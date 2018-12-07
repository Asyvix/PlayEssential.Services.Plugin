using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asyvix.PlayEssential.Services.Plugin.Attributes
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class CallIdAttribute : Attribute
    {
        private string _id;

        public string Id
        {
            get => _id;
            set => _id = value;
        }

        public CallIdAttribute(string callid)
        {
            _id = callid;
        }
       
    }
}
