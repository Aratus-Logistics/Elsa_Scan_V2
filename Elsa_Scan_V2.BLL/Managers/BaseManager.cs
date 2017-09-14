using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Elsa_Scan_V2.DAL.Models;
using Elsa_Scan_V2.DAL.Clients;
using Elsa_Scan_V2.BLL.Helpers;
using Elsa_Scan_V2.BLL.Constants;
using Elsa_Scan_V2.BLL.Models;

namespace Elsa_Scan_V2.BLL.Managers
{
    public class BaseManager
    {
        public FormHelper FormHelper = new FormHelper();

        #region WebApi()

        public BaseResponse GenerateGetWebRequest(string fullApiUrl, string subTitle)
        {
            try
            {
                BaseResponse _apiResponse;

                using (WebApiClient _client = new WebApiClient())
                {
                    _apiResponse = _client.Get(fullApiUrl, ApiConstants.API_AUTHKEY, subTitle);
                }

                /*_apiResponse = new WebApiResponse();
                _apiResponse.Status = ResponseCode.Ok;
                _apiResponse.SubTitle = subTitle;
                _apiResponse.Message = "Location: Unknown \nSku: 236 \nStorer: Nickedon \nQuantity: 37";*/

                return _apiResponse;
            }
            catch (Exception ex)
            {
                FormHelper.GenerateFailedForm("Error", "Error", ex.Message);
                return null;
            }
        }
        public BaseResponse GeneratePostWebRequest(string fullApiUrl)
        {
            try
            {
                using (WebApiClient _client = new WebApiClient())
                {
                    return _client.Post(fullApiUrl, ApiConstants.API_AUTHKEY);
                }
            }
            catch (Exception ex)
            {
                FormHelper.GenerateFailedForm("Error", "Error", ex.Message);
                return null;
            }
        }

        #endregion

        #region Sql()

        public BaseResponse Sql_SearchStock(string queryString, ResourceModel resource)
        {
            try
            {
                return SqlDbClient.GetResourceData(queryString, resource);
            }
            catch (Exception ex)
            {
                FormHelper.GenerateFailedForm("Error", "Error", ex.Message);
                return null;
            }
        }

        public BaseResponse Sql_CreateStock(string queryString)
        {
            throw new NotImplementedException();
        }

        public BaseResponse Sql_MoveStock(string queryString)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
