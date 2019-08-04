using System.ComponentModel.Composition;

namespace Apteka.Interfaces
{
    [InheritedExport("IPluginServerRpc", typeof(IPluginServerRpc))]
    public interface IPluginServerRpc : IBasePlugin
    {
        void Run();
    }
}
