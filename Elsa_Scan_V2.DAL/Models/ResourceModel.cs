using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Elsa_Scan_V2.DAL.Models
{
    public class ResourceModel
    {
        public string Name { get; set; }
        public string Value { get; set; }

        public ResourceModel(string name, string value)
        {
            this.Name = name;
            this.Value = value;
        }
    }
}
