using System.Configuration;

namespace WinServicePluginHost
{
    partial class ProjectInstaller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.winServInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.spWinService = new System.ServiceProcess.ServiceInstaller();
            // 
            // winServInstaller
            // 
            this.winServInstaller.Account = System.ServiceProcess.ServiceAccount.NetworkService;
            this.winServInstaller.Password = null;
            this.winServInstaller.Username = null;
            // 
            // spWinService
            // 
            this.spWinService.DelayedAutoStart = true;
            this.spWinService.Description = "Apteka DataBase Sync";
            this.spWinService.DisplayName = "Apteka DataBase Sync";
            this.spWinService.ServiceName = "AptekaService";
            this.spWinService.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.winServInstaller,
            this.spWinService});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller winServInstaller;
        public System.ServiceProcess.ServiceInstaller spWinService;
    }
}