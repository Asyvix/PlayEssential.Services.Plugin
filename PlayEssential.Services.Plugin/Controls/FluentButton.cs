using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asyvix.PlayEssential.Services.PlugIn.Controls
{
    public interface IFluentButton
    {
        void OnClick();

        FluentPoint Size { get; set; }

        string ButtonText { get; set; }
    }

    public class FluentPoint
    {
        public double Left { get; set; }
        public double Top { get; set; }

        public double Width { get; set; }
        public double Height { get; set; }
    }
}
