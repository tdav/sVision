using System.ComponentModel.Composition;

namespace Apteka.Interfaces
{
    [InheritedExport("PluginMenu", typeof(IPluginMenu))]
    public interface IPluginMenu : IBasePlugin { }
}
