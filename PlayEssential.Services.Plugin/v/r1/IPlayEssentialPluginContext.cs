using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asyvix.PlayEssential.Services.PlugIn.v.r1
{
    public interface IPlayEssentialPluginContext
    {

        string PlayEssentialContextName { get; }

        string PluginId { get; }
        
        string PlayEssentialPluginLoaderVersion { get; }

        IPlayEssentialServiceBridge Bridge { get; set; }

    }

}
