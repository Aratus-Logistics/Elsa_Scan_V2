using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Elsa_Scan_V2.BLL.Models.Controls
{
    public class BaseOptions
    {
        public string Name { get; set; }
        public string Text { get; set; }
        public Point Location { get; set; }
        public Size Size { get; set; }

        public BaseOptions(string name, string text, Point location, Size size)
        {
            this.Name = name;
            this.Text = text;
            this.Size = size;
            this.Location = location;
        }
    }
}
