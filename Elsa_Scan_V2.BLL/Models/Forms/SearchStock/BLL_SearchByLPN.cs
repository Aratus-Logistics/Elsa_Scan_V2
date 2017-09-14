using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Elsa_Scan_V2.BLL.Helpers.Validation;
using Elsa_Scan_V2.BLL.Constants;

namespace Elsa_Scan_V2.BLL.Models.Forms.SearchStock
{
    public class BLL_SearchByLPN : BaseModel
    {
        public string LPN { get; set; }

        public BLL_SearchByLPN(string lpn)
        {
            this.LPN = lpn;
        }
        public BLL_SearchByLPN() { }

        public override void LookupData()
        {
            if (Extensions<BLL_SearchByLPN>.Validate())
            {
                var _response = BLL.SearchByLPNManager.Lookup(ApiConstants.API_GET_SEARCHSTOCK_LPN, this);

                if (_response != null) this.HandleApiResponse(_response); 
            }
        }
    }
}
