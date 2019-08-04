using Apteka.Utils;
using System;
using System.IO;

namespace Apteka
{
    public static class Vars
    {
        public static bool IsServer = false;
        public static string Version
        {
            get
            {
                return "0.1.29";
            }
        }

        public static string Skin
        {
            get
            {
                return Apteka.Utils.CAppSettings.Get("Skin");
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    Apteka.Utils.CAppSettings.Set("Skin", value);
                }
            }
        }
        public static string Palette
        {
            get
            {

                return Apteka.Utils.CAppSettings.Get("Palette");
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    Apteka.Utils.CAppSettings.Set("Palette", value);
                }
            }
        }

        public static string BacodeScannerComPort
        {
            get
            {
                return Apteka.Utils.CAppSettings.Get("COMPORT");
            }
        }

        public static string DevBacodeScanner = @"\\?\HID#VID_1EAB&PID_8003";
        public static string DevPrinterName;
        public static string SizePaper = "58 мм";


        public static bool IsDebug { get; set; }
        public static bool IsOnline { get; set; }

        public static Guid UserId { get; set; }
        public static string UserFullName { get; set; }
        public static Guid DrugStoreId { get; set; }
        public static object ExtraCharge { get; set; }


        public static string ImagesPath { get => $"{ AppDomain.CurrentDomain.BaseDirectory}Images\\"; }
        public static string RepConfigPath { get => $"{ AppDomain.CurrentDomain.BaseDirectory}RepConfig\\"; }
        public static string DockManagerPath { get => $"{ AppDomain.CurrentDomain.BaseDirectory}DockConfig\\"; }


        public static string BarcodeEmpty { get => "0000000000000"; }
        public static System.Windows.Forms.Form FrmMain { get; set; }
        public static string InputKeybord { get; set; } = "Standard PS/2 Keyboard";

        public static void SaveParameters()
        {
            // Apteka.Utils.CAppSettings.Set("devBacodeScanner", devBacodeScanner);
            Apteka.Utils.CAppSettings.Set("devPrinterName", DevPrinterName);
            Apteka.Utils.CAppSettings.Set("SizePaper", SizePaper);
        }

        public static void InitGlobalVars()
        {
            try
            {
                if (Vars.IsServer)
                {

                }
                else
                {
                    if (!Directory.Exists(ImagesPath))
                        Directory.CreateDirectory(ImagesPath);

                    if (!Directory.Exists(DockManagerPath))
                        Directory.CreateDirectory(DockManagerPath);

                    if (!Directory.Exists(RepConfigPath))
                        Directory.CreateDirectory(RepConfigPath);
                }

                //  devBacodeScanner = Apteka.Utils.CAppSettings.Get("devBacodeScanner");
                DevPrinterName = Apteka.Utils.CAppSettings.Get("devPrinterName");
                SizePaper = Apteka.Utils.CAppSettings.Get("SizePaper");
            }
            catch (Exception ee)
            {
                var li = new LogItem
                {
                    App = "Apteka.GlobalVars",
                    Stacktrace = ee.GetStackTrace(5),
                    Message = ee.GetAllMessages(),
                    Method = "Vars.InitGlobalVars"
                };
                CLogJson.Write(li);
                throw;
            }
        }
    }
}
