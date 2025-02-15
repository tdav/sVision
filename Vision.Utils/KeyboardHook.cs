﻿using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Apteka.Utils
{
    public class KeyboardHook : IDisposable
    {

        public enum Parameters
        {
            None,
            AllowAltTab,
            AllowWindowsKey,
            AllowAltTabAndWindows,
            PassAllKeysToNextApp
        }

        //Internal parameters
        private bool PassAllKeysToNextApp = false;
        private bool AllowAltTab = false;
        private bool AllowWindowsKey = false;

        //Keyboard API constants
        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYUP = 0x0101;
        private const int WM_SYSKEYUP = 0x0105;

        //Modifier key constants
        private const int VK_SHIFT = 0x10;
        private const int VK_CONTROL = 0x11;
        private const int VK_MENU = 0x12;
        private const int VK_CAPITAL = 0x14;

        //Variables used in the call to SetWindowsHookEx
        private HookHandlerDelegate proc;
        private IntPtr hookID = IntPtr.Zero;
        internal delegate IntPtr HookHandlerDelegate(
          int nCode, IntPtr wParam, ref KBDLLHOOKSTRUCT lParam);


        public event KeyboardHookEventHandler KeyIntercepted;

        // Structure returned by the hook whenever a key is pressed
        internal struct KBDLLHOOKSTRUCT
        {
            public int vkCode;
            int scanCode;
            public int flags;
            int time;
            int dwExtraInfo;
        }

        #region Constructors

        public KeyboardHook()
        {
            proc = new HookHandlerDelegate(HookCallback);
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                hookID = NativeMethods.SetWindowsHookEx(WH_KEYBOARD_LL, proc,
                  NativeMethods.GetModuleHandle(curModule.ModuleName), 0);
            }
        }


        public KeyboardHook(string param)
            : this()
        {
            if (!String.IsNullOrEmpty(param) && Enum.IsDefined(typeof(Parameters), param))
            {
                SetParameters((Parameters)Enum.Parse(typeof(Parameters), param));
            }
        }


        public KeyboardHook(Parameters param)
            : this()
        {
            SetParameters(param);
        }

        private void SetParameters(Parameters param)
        {
            switch (param)
            {
                case Parameters.None:
                    break;
                case Parameters.AllowAltTab:
                    AllowAltTab = true;
                    break;
                case Parameters.AllowWindowsKey:
                    AllowWindowsKey = true;
                    break;
                case Parameters.AllowAltTabAndWindows:
                    AllowAltTab = true;
                    AllowWindowsKey = true;
                    break;
                case Parameters.PassAllKeysToNextApp:
                    PassAllKeysToNextApp = true;
                    break;
            }
        }
        #endregion


        public static void PressKeyboardButton(Keys keyCode)
        {
            const int KEYEVENTF_EXTENDEDKEY = 0x1;
            const int KEYEVENTF_KEYUP = 0x2;

            NativeMethods.Keybd_event((byte)keyCode, 0x45, KEYEVENTF_EXTENDEDKEY, 0);
            NativeMethods.Keybd_event((byte)keyCode, 0x45, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, 0);
        }

        #region Check Modifier keys

        private void CheckModifiers()
        {
            StringBuilder sb = new StringBuilder();

            if ((NativeMethods.GetKeyState(VK_CAPITAL) & 0x0001) != 0)
            {
                //CAPSLOCK is ON
                sb.AppendLine("Capslock is enabled.");
            }

            if ((NativeMethods.GetKeyState(VK_SHIFT) & 0x8000) != 0)
            {
                //SHIFT is pressed
                sb.AppendLine("Shift is pressed.");
            }
            if ((NativeMethods.GetKeyState(VK_CONTROL) & 0x8000) != 0)
            {
                //CONTROL is pressed
                sb.AppendLine("Control is pressed.");
            }
            if ((NativeMethods.GetKeyState(VK_MENU) & 0x8000) != 0)
            {
                //ALT is pressed
                sb.AppendLine("Alt is pressed.");
            }
            Console.WriteLine(sb.ToString());
        }
        #endregion Check Modifier keys

        #region Hook Callback Method

        private IntPtr HookCallback(
          int nCode, IntPtr wParam, ref KBDLLHOOKSTRUCT lParam)
        {
            bool AllowKey = PassAllKeysToNextApp;

            //Filter wParam for KeyUp events only
            if (nCode >= 0)
            {
                if (wParam == (IntPtr)WM_KEYUP || wParam == (IntPtr)WM_SYSKEYUP)
                {


                    if (!(lParam.vkCode >= 160 && lParam.vkCode <= 164))
                    {
                        CheckModifiers();
                    }


                    if (AllowWindowsKey)
                    {
                        switch (lParam.flags)
                        {
                            //Ctrl+Esc
                            case 0:
                                if (lParam.vkCode == 27)
                                    AllowKey = true;
                                break;

                            //Windows keys
                            case 1:
                                if ((lParam.vkCode == 91) || (lParam.vkCode == 92))
                                    AllowKey = true;
                                break;
                        }
                    }
                    // Alt+Tab
                    if (AllowAltTab)
                    {
                        if ((lParam.flags == 32) && (lParam.vkCode == 9))
                            AllowKey = true;
                    }

                    OnKeyIntercepted(new KeyboardHookEventArgs(lParam.vkCode, AllowKey));
                }

                //If this key is being suppressed, return a dummy value
                if (AllowKey == false)
                    return (System.IntPtr)1;
            }
            //Pass key to next application
            return NativeMethods.CallNextHookEx(hookID, nCode, wParam, ref lParam);

        }
        #endregion

        #region Event Handling

        public void OnKeyIntercepted(KeyboardHookEventArgs e)
        {
            KeyIntercepted?.Invoke(e);
        }


        public delegate void KeyboardHookEventHandler(KeyboardHookEventArgs e);


        public class KeyboardHookEventArgs : System.EventArgs
        {

            private string keyName;
            private int keyCode;
            private bool passThrough;


            public string KeyName
            {
                get { return keyName; }
            }


            public int KeyCode
            {
                get { return keyCode; }
            }


            public bool PassThrough
            {
                get { return passThrough; }
            }

            public KeyboardHookEventArgs(int evtKeyCode, bool evtPassThrough)
            {
                keyName = (evtKeyCode).ToString();
                keyCode = evtKeyCode;
                passThrough = evtPassThrough;
            }

        }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            NativeMethods.UnhookWindowsHookEx(hookID);
        }
        #endregion

        #region Native methods

        [ComVisibleAttribute(false),
         System.Security.SuppressUnmanagedCodeSecurity()]
        internal class NativeMethods
        {
            [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            public static extern IntPtr GetModuleHandle(string lpModuleName);

            [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            public static extern IntPtr SetWindowsHookEx(int idHook,
              HookHandlerDelegate lpfn, IntPtr hMod, uint dwThreadId);

            [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool UnhookWindowsHookEx(IntPtr hhk);

            [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            public static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode,
              IntPtr wParam, ref KBDLLHOOKSTRUCT lParam);

            [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            public static extern short GetKeyState(int keyCode);

            [DllImport("user32.dll")]
            public static extern void Keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);
        }


        #endregion
    }
}