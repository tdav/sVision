using System;
using System.Drawing;
using Apteka.UtilsUI.Properties;
using DevExpress.XtraBars.Alerter;
using DevExpress.XtraSplashScreen;

namespace Apteka.UtilsUI
{
    public class WaitFormManager
    {
        public static void Show()
        {
            try
            {
                SplashScreenManager.ShowForm(typeof (WaitForm1));
            }
            catch (Exception)
            {
            }
        }

        public static void Close()
        {
            try
            {
                SplashScreenManager.CloseForm();
            }
            catch (Exception)
            {
            }
        }
    }

    public class AlertMessage
    {
        public static void ShowError(string mes)
        {
            using (var box = new AlertControl())
            {
                var ai = new AlertInfo("Ошибка", mes, Resources.error);
                box.AutoFormDelay = 3000;
                box.AllowHotTrack = false;
                box.FormDisplaySpeed = AlertFormDisplaySpeed.Slow;
                box.FormLocation = AlertFormLocation.BottomRight;
                box.AutoHeight = true;
                box.Show(UtilsUI.CurMainForm, ai);
            }
        }

        public static void Show(string mes, string caption= "Информация")
        {
            try
            {
                using (var box = new AlertControl())
                {
                    var ai = new AlertInfo(caption, mes, Resources.Save);
                    box.AutoFormDelay = 3000;
                    box.AllowHotTrack = false;
                    box.FormDisplaySpeed = AlertFormDisplaySpeed.Moderate;
                    box.FormLocation = AlertFormLocation.BottomRight;
                    box.AutoHeight = true;
                    box.Show(UtilsUI.CurMainForm, ai);
                }
            }
            catch (Exception)
            {
            }
        }

        public static void HabarnomaShow(string mes, Image img, Action<int> res)
        {
            using (var box = new AlertControl())
            {
                box.AutoFormDelay = 9000;
                box.AllowHotTrack = false;
                box.FormDisplaySpeed = AlertFormDisplaySpeed.Slow;
                box.FormLocation = AlertFormLocation.BottomRight;
                box.AutoHeight = true;
                box.AllowHotTrack = true;
                box.ShowCloseButton = false;

                box.AlertClick += (s, ex) => { res.Invoke(0); };

                box.Show(UtilsUI.CurMainForm, "Информация", mes, img);
            }
        }
    }
}