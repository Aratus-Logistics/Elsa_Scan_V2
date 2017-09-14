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
    public class SearchByLocationManager : BaseManager
    {
        public BaseResponse Lookup(string url, BLL_SearchByLocation data)
        {
            try
            {
                return base.Sql_SearchStock("Select * from SalesLT.Product2", new ResourceModel("Global", "Test"));

                /*string _fullApiUri = string.Format("{0}?loc={1}", url, data.Location);

                return base.GenerateGetWebRequest(_fullApiUri, "Location: " + data.Location);*/
            }
            catch (Exception ex)
            {
                this.FormHelper.GenerateFailedForm("Error", "Error", ex.Message);
                return null;
            }
        }
    }
}
