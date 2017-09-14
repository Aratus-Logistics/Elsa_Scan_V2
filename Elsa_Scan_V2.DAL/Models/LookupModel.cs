using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Elsa_Scan_V2.DAL.Models
{
    public class LookupModel
    {
        public string LPN { get; set; }
        public string SKU { get; set; }
        public string Location { get; set; }
        public string Storer { get; set; }
        public int Quantity { get; set; }
    }
}
