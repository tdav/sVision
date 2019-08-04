using Apteka.Interfaces;
using Apteka.Utils;
using System;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.IO;
using System.Reflection;

namespace WinServicePluginHost
{
    public class PluginManagerSI
    {
        [Import(typeof(IPluginServerRpc))]
        internal IPluginServerRpc PlgItem { get; set; }
        
        public PluginManagerSI()
        {
            try
            {
                Directory.SetCurrentDirectory(AppDomain.CurrentDomain.BaseDirectory);
                var catalog = new DirectoryCatalog(@".\", "*.plg.dll");
                var container = new CompositionContainer(catalog);
                var batch = new CompositionBatch();
                batch.AddPart(this);
                container.Compose(batch);
                PlgItem?.Initialize(null);
            }
            catch (ReflectionTypeLoadException ee)
            {
                var li = new LogItem
                {
                    App = "wsDataBaseSync",
                    Stacktrace = ee.GetStackTrace(5),
                    Message = ee.GetAllMessages(),
                    Method = "PluginManagerSI"
                };
                CLogJson.Write(li);
            }
        }        
    }
}
