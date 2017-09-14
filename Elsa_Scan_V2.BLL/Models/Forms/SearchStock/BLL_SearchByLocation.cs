using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Elsa_Scan_V2.BLL.Helpers.Validation;
using Elsa_Scan_V2.BLL.Constants;

namespace Elsa_Scan_V2.BLL.Models.Forms.SearchStock
{
    public class BLL_SearchByLocation : BaseModel
    {
        public string Location { get; set; }

        public BLL_SearchByLocation(string location)
        {
            this.Location = location;
        }

        public BLL_SearchByLocation() { }

        public override void LookupData()
        {
            if (Extensions<BLL_SearchByLocation>.Validate())
            {
                var _response = BLL.SearchByLocationManager.Lookup(ApiConstants.API_GET_SEARCHSTOCK_LOC, this);

                if (_response != null) this.HandleApiResponse(_response);
            }
        }
    }
}
