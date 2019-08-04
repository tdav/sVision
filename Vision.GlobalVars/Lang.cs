using System;

namespace App.Utils
{
    public class LangKeyboardLayout
    {
        public void SetLatin()
        {
            

            Vars.webView.Dispatcher.BeginInvoke((Action)(() =>
            {
                Vars.langKeyboardLayout.LoadEnglishKeyboardLayout();
            }));
        }

        public void SetUzbek()
        {
            Vars.webView.Dispatcher.BeginInvoke((Action)(() =>
            {
                Vars.langKeyboardLayout.LoadUzbekKeyboardLayout();
            }));
        }
    }
}
