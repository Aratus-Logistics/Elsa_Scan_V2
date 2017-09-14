using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Elsa_Scan_V2.BLL;
using Elsa_Scan_V2.PLL.Forms;

namespace Elsa_Scan_V2.PLL.Models.Navigation
{
    public class NavigationLink
    {
        public string Name { get; set; }
        public BaseForm Form { get; set; }

        public NavigationLink(string name, BaseForm form)
        {
            this.Name = name;
            this.Form = form;
        }
    }
}
