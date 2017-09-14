using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Elsa_Scan_V2.BLL.Models.Controls
{
    public class TextBoxOptions : BaseOptions
    {
        public bool MultiLine { get; set; }

        public TextBoxOptions(string name, string text, Point location, Size size, bool multiLine)
            :base(name, text, location, size)
        {
            this.MultiLine = multiLine;
        }
    }
}
