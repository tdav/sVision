using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Apteka.Utils;
using AutoUpdaterDotNET;

namespace UpdaterApp
{
    public partial class FormDownloader : Form
    {
        private string UpdatePath = "";
        private bool IsCloseCommand = false;

        public FormDownloader()
        {
            InitializeComponent();
            InitParams();

            Hide();
            notifyIcon1.Visible = true;
            WindowState = FormWindowState.Minimized;
        }

        private void InitParams()
        {
            UpdatePath = AppDomain.CurrentDomain.BaseDirectory + "\\Update";
            if (!Directory.Exists(UpdatePath))
                Directory.CreateDirectory(UpdatePath);
        }
        
        private void AutoUpdater_ApplicationExitEvent()
        {
            Text = "Closing application...";
            Kill();
            RunSql();
            Thread.Sleep(3000);
            IsCloseCommand = true;
            Application.Exit();
        }

        private void AutoUpdaterOnCheckForUpdateEvent(UpdateInfoEventArgs args)
        {
            if (args != null)
            {
                if (args.IsUpdateAvailable)
                {
                    DialogResult dialogResult;
                    if (args.Mandatory)
                    {
                        dialogResult =
                            MessageBox.Show(
                                $@"There is new version {args.CurrentVersion} available. You are using version {args.InstalledVersion}. This is required update. Press Ok to begin updating the application.", @"Update Available",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                    }
                    else
                    {
                        dialogResult =
                            MessageBox.Show(
                                $@"There is new version {args.CurrentVersion} available. You are using version {
                                        args.InstalledVersion
                                    }. Do you want to update the application now?", @"Update Available",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information);
                    }


                    if (dialogResult.Equals(DialogResult.Yes) || dialogResult.Equals(DialogResult.OK))
                    {
                        try
                        {
                            //You can use Download Update dialog used by AutoUpdater.NET to download the update.

                            if (AutoUpdater.DownloadUpdate())
                            {
                                Application.Exit();
                            }
                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show(exception.Message, exception.GetType().ToString(), MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show(@"There is no update available. Please try again later.", @"Update Unavailable",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show(
                       @"There is a problem reaching update server. Please check your internet connection and try again later.",
                       @"Update Check Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MnuCheckUpdate_Click(object sender, EventArgs e)
        {
            AutoUpdater.Start("http://80.211.213.82:9595/AutoUpdaterTest.xml");
        }

        private void MnuOpen_Click(object sender, EventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void FormDownloader_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsCloseCommand) return;

            e.Cancel = true;
            Hide();
            notifyIcon1.Visible = true;
            WindowState = FormWindowState.Minimized;
        }

        private void MnuClose_Click(object sender, EventArgs e)
        {
            IsCloseCommand = true;
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            AutoUpdater.Start("http://80.211.213.82:9595/AutoUpdaterTest.xml");
        }

        private void FormDownloader_Load(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;
            AutoUpdater.AppTitle = "AptekaN3";
            AutoUpdater.ReportErrors = false;
            AutoUpdater.RunUpdateAsAdmin = true;
            AutoUpdater.Mandatory = true;
            AutoUpdater.DownloadPath = UpdatePath;
            AutoUpdater.ApplicationExitEvent += AutoUpdater_ApplicationExitEvent;
            // AutoUpdater.CheckForUpdateEvent += AutoUpdaterOnCheckForUpdateEvent;


            //System.Timers.Timer timer = new System.Timers.Timer
            //{
            //    Interval = 2 * 60 * 1000,
            //    SynchronizingObject = this
            //};

            //timer.Elapsed += delegate
            //{
            //    AutoUpdater.Mandatory = true;
            //    AutoUpdater.Start("https://rbsoft.org/updates/AutoUpdaterTest.xml");
            //};
            //timer.Start();
        }


        private void Kill()
        {
            foreach (var process in Process.GetProcesses().Where(pr => pr.ProcessName == "Admin"))
            {
                process.Kill();
            }

            foreach (var process in Process.GetProcesses().Where(pr => pr.ProcessName == "Kassa"))
            {
                process.Kill();
            }

            foreach (var process in Process.GetProcesses().Where(pr => pr.ProcessName == "Orders"))
            {
                process.Kill();
            }

            foreach (var process in Process.GetProcesses().Where(pr => pr.ProcessName == "PriceLoader"))
            {
                process.Kill();
            }

            foreach (var process in Process.GetProcesses().Where(pr => pr.ProcessName == "SyncDbTest"))
            {
                process.Kill();
            }

            foreach (var process in Process.GetProcesses().Where(pr => pr.ProcessName == "UpdateFileRename"))
            {
                process.Kill();
            }

            foreach (var process in Process.GetProcesses().Where(pr => pr.ProcessName == "WinServiceSync"))
            {
                process.Kill();
            }
        }

        private void RunSql()
        {
            var sqlpath = AppDomain.CurrentDomain.BaseDirectory + "dbChange.sql";
            if (!File.Exists(sqlpath)) return;

            var connstr = ConfigurationManager.ConnectionStrings["AptekaDBConnectionString"].ConnectionString;
            var con = new SqlConnection(connstr);

            string query = File.ReadAllText(sqlpath);
            var cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();

                var li = new LogItem
                {
                    App = "UpdaterApp",
                    Stacktrace = "",
                    Mestype= "Success",
                    Message = "Column Created Successfully",
                    Method = "RunSql"
                };
                CLogJson.Write(li);                
            }
            catch (SqlException ee)
            {
                var li = new LogItem
                {
                    App = "UpdaterApp",
                    Stacktrace = ee.StackTrace,
                    Message = ee.Message,
                    Method = "RunSql"
                };
                CLogJson.Write(li);
            }
            finally
            {
                con.Close();
            }
        }
    }
}