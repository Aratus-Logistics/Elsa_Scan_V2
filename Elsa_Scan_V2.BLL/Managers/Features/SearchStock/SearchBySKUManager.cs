using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Elsa_Scan_V2.DAL.Models;
using Elsa_Scan_V2.BLL.Models.Forms.SearchStock;
using Elsa_Scan_V2.DAL.Clients;
using Elsa_Scan_V2.BLL.Constants;

namespace Elsa_Scan_V2.BLL.Managers.Features.SearchStock
{
    public class SearchBySKUManager : BaseManager
    {
        public BaseResponse Lookup(string url, BLL_SearchBySKU data)
        {
            try
            {
                string _fullWebApiUrl = string.Format("{0}?sku={1}", url, data.SKU);

                return base.GenerateGetWebRequest(_fullWebApiUrl, data.SKU);
            }
            catch (Exception ex)
            {
                base.FormHelper.GenerateFailedForm("Error", "Error", ex.Message);
                return null;
            }
        }
    }
}
