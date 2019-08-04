using System.ComponentModel;

namespace WinServicePluginHost
{
    [RunInstaller(true)]
    public partial class ProjectInstaller : System.Configuration.Install.Installer
    {
        public ProjectInstaller()
        {
           
            InitializeComponent();
           
        }
    }
}
