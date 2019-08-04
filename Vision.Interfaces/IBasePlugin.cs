using System.Collections.Generic;

namespace Apteka.Interfaces
{
    public interface IBasePlugin
    {
        string Version { get; }
        string Description { get; }
        object Initialize(Dictionary<string, object> param);
        void Dispose();
    }
}
