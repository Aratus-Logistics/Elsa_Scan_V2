using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Elsa_Scan_V2.BLL.Helpers.Validation;
using Elsa_Scan_V2.BLL.Constants;
using Elsa_Scan_V2.DAL.Models;

namespace Elsa_Scan_V2.BLL.Models.Forms
{
    public class BLL_MoveStock : BaseModel
    {
        public string LPN { get; set; }
        public string NewLocation { get; set; }

        public BLL_MoveStock(string lpn, string newLocation)
        {
            this.LPN = lpn;
            this.NewLocation = NewLocation;
        }

        public BLL_MoveStock() { }

        public override void SaveData()
        {
            if (Extensions<BLL_MoveStock>.Validate())
            {
                var _response = BLL.MoveStockManager.Post(ApiConstants.API_POST_MOVE, this);

                if (_response != null) this.HandleApiResponse(_response);
            }
        }
    }
}
