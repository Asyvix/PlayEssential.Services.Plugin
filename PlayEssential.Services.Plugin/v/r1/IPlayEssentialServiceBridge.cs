using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExNet.Bridge;

namespace asyvix.PlayEssential.Services.PlugIn.v.r1
{
    public interface IPlayEssentialServiceBridge
    {
        void Publish(string data);

        IDemandBasedEventBridgeClient<string, string> Bridge { get; }
    }
}
