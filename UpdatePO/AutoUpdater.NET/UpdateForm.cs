using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

namespace AutoUpdaterDotNET
{
    internal partial class UpdateForm : Form
    {
        private bool HideReleaseNotes { get; set; }

        public UpdateForm()
        {
            InitializeComponent();
            UseLatestIE();
            
            Text = string.Format("{0} {1} доступен!", AutoUpdater.AppTitle, AutoUpdater.CurrentVersion);
            labelUpdate.Text = string.Format("Доступна новая версия {0}!", AutoUpdater.AppTitle);
            labelDescription.Text = string.Format("{0} {1} теперь доступен. У вас установлена версия {2}. Вы хотите скачать его сейчас?",
                    AutoUpdater.AppTitle, AutoUpdater.CurrentVersion, AutoUpdater.InstalledVersion);
            if (string.IsNullOrEmpty(AutoUpdater.ChangelogURL))
            {
                HideReleaseNotes = true;
                var reduceHeight = labelReleaseNotes.Height + webBrowser.Height;
                labelReleaseNotes.Hide();
                webBrowser.Hide();

                Height -= reduceHeight;

                buttonUpdate.Location = new Point(buttonUpdate.Location.X, buttonUpdate.Location.Y - reduceHeight);
            }
        }

        public sealed override string Text
        {
            get { return  base.Text; }
            set { base.Text = value; }
        }

        private void UseLatestIE()
        {
            int ieValue = 0;
            switch (webBrowser.Version.Major)
            {
                case 11:
                    ieValue = 11001;
                    break;
                case 10:
                    ieValue = 10001;
                    break;
                case 9:
                    ieValue = 9999;
                    break;
                case 8:
                    ieValue = 8888;
                    break;
                case 7:
                    ieValue = 7000;
                    break;
            }
            if (ieValue != 0)
            {
                using (RegistryKey registryKey =
                    Registry.CurrentUser.OpenSubKey(
                        @"SOFTWARE\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", true))
                {
                    registryKey?.SetValue(Path.GetFileName(Process.GetCurrentProcess().MainModule.FileName), ieValue,
                        RegistryValueKind.DWord);
                }
            }
        }

        private void UpdateFormLoad(object sender, EventArgs e)
        {
            if (!HideReleaseNotes)
            {
                webBrowser.Navigate(AutoUpdater.ChangelogURL);
            }
        }

        private void ButtonUpdateClick(object sender, EventArgs e)
        {
            if (AutoUpdater.OpenDownloadPage)
            {
                var processStartInfo = new ProcessStartInfo(AutoUpdater.DownloadURL);

                Process.Start(processStartInfo);

                DialogResult = DialogResult.OK;
            }
            else
            {
                if (AutoUpdater.DownloadUpdate())
                {
                    DialogResult = DialogResult.OK;
                }
            }
        }
                
        private void UpdateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AutoUpdater.Running = false;
        }
    }
}
