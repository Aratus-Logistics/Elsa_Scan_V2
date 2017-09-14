using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Elsa_Scan_V2.BLL.Helpers;
using Elsa_Scan_V2.DAL.Models;
using Elsa_Scan_V2.BLL.Models.Forms.SearchStock;
using Elsa_Scan_V2.DAL.Clients;

namespace Elsa_Scan_V2.BLL.Managers.Features.SearchStock
{
    public class SearchByLPNManager : BaseManager
    {
        public BaseResponse Lookup(string url, BLL_SearchByLPN data)
        {
            try
            {
                string _fullApiUri = string.Format("{0}?lpn={1}", url, data.LPN);

                return base.GenerateGetWebRequest(_fullApiUri, "LPN: " + data.LPN);
            }
            catch (Exception ex)
            {
                this.FormHelper.GenerateFailedForm("Error", "Error", ex.Message);
                return null;
            }
        }
    }
}
