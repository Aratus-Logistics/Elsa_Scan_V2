using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Elsa_Scan_V2.BLL.Models.Controls
{
    public class ButtonOptions : BaseOptions
    {
        public EventHandler Event { get; set; }

        public ButtonOptions(string name, string text, Point location, Size size, EventHandler eventHandler)
            : base(name, text, location, size) 
        {
            this.Event = eventHandler;
        }
    }
}
