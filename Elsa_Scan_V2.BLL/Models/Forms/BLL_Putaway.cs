using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Elsa_Scan_V2.DAL.Models;
using System.Reflection;
using Elsa_Scan_V2.BLL.Helpers.Validation;
using Elsa_Scan_V2.BLL.Constants;

namespace Elsa_Scan_V2.BLL.Models.Forms
{
    public class BLL_Putaway : BaseModel
    {
        public string SKU { get; set; }
        public string LOC { get; set; }
        public string LPN { get; set; }
        public string QTY { get; set; }

        public BLL_Putaway(string sku, string loc, string lpn, string qty)
        {
            this.SKU = sku;
            this.LOC = loc;
            this.LPN = lpn;
            this.QTY = qty;
        }

        public BLL_Putaway() { }

        public override void SaveData()
        {
            if (Extensions<BLL_Putaway>.Validate()) 
            {
                var _response = BLL.PutawayManager.Post(ApiConstants.API_POST_PÜTAWAY, this);

                if(_response != null) this.HandleApiResponse(_response);
            }
        }
    }
}
