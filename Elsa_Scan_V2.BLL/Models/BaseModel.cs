using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Elsa_Scan_V2.BLL.Helpers;
using Elsa_Scan_V2.BLL.Helpers.Validation;
using Elsa_Scan_V2.BLL.Models.Forms;
using Elsa_Scan_V2.DAL.Models;

namespace Elsa_Scan_V2.BLL.Models
{
    public class BaseModel
    {
        public FormHelper FormHelper = new FormHelper();

        public void HandleApiResponse(BaseResponse _response)
        {
            switch (_response.Status)
            {
                case ResponseCode.Error:
                    this.FormHelper.GenerateFailedForm(_response.Status.ToString(), "Error", _response.Message);
                    break;
                case ResponseCode.Alert:
                    this.FormHelper.GenerateFailedForm(_response.Status.ToString(), "Error", _response.Message);
                    break;
                case ResponseCode.Ok:
                    this.FormHelper.GenerateSuccessForm(_response.Status.ToString(), _response.SubTitle, _response.Message.Replace("\n", Environment.NewLine));
                    break;
            }
        }

        public virtual void LookupData() { }
        public virtual void SaveData() { }
    }
}
