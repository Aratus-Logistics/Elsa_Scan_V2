using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Elsa_Scan_V2.DAL.Clients;
using Elsa_Scan_V2.BLL.Models;
using Elsa_Scan_V2.DAL.Models;
using Elsa_Scan_V2.BLL.Models.Forms;
using Elsa_Scan_V2.BLL.Helpers;

namespace Elsa_Scan_V2.BLL.Managers.Features
{
    public class PutawayManager : BaseManager
    {
        public BaseResponse Post(string url, BLL_Putaway data)
        {
            try
            {
                string _fullApiUri = string.Format("{0}?sku={1}&lpn={2}&qty={3}&loc={4}", url, data.SKU, data.LPN, data.QTY, data.LOC);

                return base.GeneratePostWebRequest(_fullApiUri);
            }
            catch (Exception ex)
            {
                this.FormHelper.GenerateFailedForm("Error", "Error", ex.Message);
                return null;
            }

        }
    }
}
