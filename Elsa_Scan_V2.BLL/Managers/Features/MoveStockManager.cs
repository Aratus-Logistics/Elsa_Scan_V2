using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Elsa_Scan_V2.BLL.Models.Forms;
using Elsa_Scan_V2.DAL.Models;
using Elsa_Scan_V2.DAL.Clients;
using Elsa_Scan_V2.BLL.Helpers;

namespace Elsa_Scan_V2.BLL.Managers.Features
{
    public class MoveStockManager : BaseManager
    {
        public BaseResponse Post(string url, BLL_MoveStock data)
        {
            try
            {
                string _fullApiUri = string.Format("{0}?lpn={1}&loc={2}", url, data.LPN, data.NewLocation);

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
