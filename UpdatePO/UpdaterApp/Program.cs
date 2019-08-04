using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace UpdaterApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            bool onlyInstance;
            var mtx = new Mutex(true, "UpdaterApp", out onlyInstance);

            if (!(onlyInstance)) return;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var cl = new CultureInfo("ru-RU");
            Thread.CurrentThread.CurrentCulture = cl;
            Thread.CurrentThread.CurrentUICulture = cl;

            Application.Run(new FormDownloader());
        }
    }
}
