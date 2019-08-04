using System;
using System.ServiceProcess;

namespace WinServicePluginHost
{
    static class Program
    {
        static void Main(string[] args)
        {
            var srv = new WinServicePluginHost.ServicePluginHost();

            var sb = new ServiceBase[] { srv };
            if (Environment.UserInteractive)
            {
                srv.OnStartX(args);

                Console.ReadKey();
                srv.xStop();
            }
            else
            {
                ServiceBase.Run(srv);
            }
        }
    }
}
