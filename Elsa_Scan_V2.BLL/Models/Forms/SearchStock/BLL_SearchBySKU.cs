using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Elsa_Scan_V2.BLL.Helpers.Validation;
using Elsa_Scan_V2.BLL.Constants;

namespace Elsa_Scan_V2.BLL.Models.Forms.SearchStock
{
    public class BLL_SearchBySKU : BaseModel
    {
        public string SKU { get; set; }

        public BLL_SearchBySKU(string sku)
        {
            this.SKU = sku;
        }

        public BLL_SearchBySKU() { }

        public override void LookupData()
        {
            if (Extensions<BLL_SearchBySKU>.Validate())
            {
                var _response = BLL.SearchBySKUManager.Lookup(ApiConstants.API_GET_SEARCHSTOCK_LPN, this);

                if (_response != null) this.HandleApiResponse(_response);
            }
        }
    }
}
