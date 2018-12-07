using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asyvix.PlayEssential.Services.Plugin.v.r1
{
    public interface IPlayEssentialPluginInformationProvider
    {
        IEnumerable<string> LoadedPlugin { get; set; }
    }
}
