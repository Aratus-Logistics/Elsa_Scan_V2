using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Elsa_Scan_V2.BLL.Helpers.Validation;

namespace Elsa_Scan_V2.BLL.Models.Forms.Orders
{
    public class BLL_Order
    {
        public string LPN { get; set; }
        public string NewLocation { get; set; }

        public bool IsProcesCompleted { get; set; }

        public BLL_Order(string lpn, string newLocation)
        {
            this.LPN = lpn;
            this.NewLocation = newLocation;
        }

        public void Move()
        {            
            if (Extensions<BLL_Order>.Validate())
            {
                //Logic
                this.IsProcesCompleted = true;
            }
            else
            {
                this.IsProcesCompleted = false;
            }


        }
    }
}
