using Apteka.Utils;
using System.Configuration;
using System.ServiceProcess;
using System.Timers;

namespace WinServicePluginHost
{
    partial class ServicePluginHost : ServiceBase
    {        
        private static System.Timers.Timer aTimer;
        private bool IsRuning = false;
        private readonly int timeOut = 0;
        private PluginManagerSI plugin;

        public ServicePluginHost()
        {
            InitializeComponent();
            timeOut = ConfigurationManager.AppSettings["TimeOut"].ToInt();
            plugin = new PluginManagerSI();            
        }
                
        protected override void OnStart(string[] args)
        {
            aTimer = new System.Timers.Timer(timeOut);
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.Interval = timeOut;
            aTimer.Enabled = true;                  
        }

        private void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            if (IsRuning) return;

            aTimer.Enabled = false;
            aTimer.Stop();

            IsRuning = true;

            plugin.PlgItem?.Run();

            IsRuning = false;

            aTimer.Enabled = true;
            aTimer.Start();
        }

        protected override void OnStop()
        {
            aTimer.Enabled = false;
            plugin.PlgItem?.Dispose();
        }

        public void OnStartX(string[] args)
        {
            OnStart(args);
        }

        public void xStop()
        {
            OnStop();
        }
    }
}
