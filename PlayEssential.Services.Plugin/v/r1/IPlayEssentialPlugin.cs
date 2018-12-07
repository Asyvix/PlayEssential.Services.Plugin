using System.Collections.Generic;
using asyvix.PlayEssential.Services.PlugIn.Controls;

namespace asyvix.PlayEssential.Services.PlugIn.v.r1
{
    public interface IPlayEssentialPlugin
    {

        void StartUp(IPlayEssentialPluginContext context);

        string ServiceName { get; }

        string ServiceDescription { get; }

        string CreatedBy { get; }

        string CompanyName { get; }

        string EulaLink { get; }
        
        string Copyright { get; }
    }
}
