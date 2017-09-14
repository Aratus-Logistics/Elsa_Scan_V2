using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Elsa_Scan_V2.DAL.Interfaces;
using Elsa_Scan_V2.DAL.Models;
using System.Net;
using System.IO;

namespace Elsa_Scan_V2.DAL.Clients
{
    public class WebApiClient : IDisposable, IWebApiClient
    {
        #region IDisposable Members

        public void Dispose()
        {
            //Dispose
        }

        #endregion

        #region IWebApiClient Members

        public BaseResponse Post(string uri, string authKey)
        {
            BaseResponse _apiResponse = new WebApiResponse();

            WebRequest _request = _generateWebRequest("POST", uri, authKey);

            using (WebResponse _response = _request.GetResponse())
            {
                using (StreamReader _reader = new StreamReader(_response.GetResponseStream()))
                {
                    string objText = _reader.ReadToEnd().ToString().Trim();
                    if (objText.ToLower().Contains("error"))
                    {
                        //Error
                        _apiResponse.Status = ResponseCode.Error;
                        _apiResponse.Message = objText.ToString().Replace("Error: ", "").Trim();
                    }
                    else if (objText.ToLower().Contains("alert"))
                    {
                        //Alert
                        _apiResponse.Status = ResponseCode.Alert;
                        _apiResponse.Message = objText.ToString().Replace("Alert: ", "").Trim();
                    }
                    else
                    {
                        //OK
                        _apiResponse.Status = ResponseCode.Ok;
                        _apiResponse.Message = "Ok";
                    }
                }
            }

            return _apiResponse;
        }

        public BaseResponse Get(string uri, string authKey, string subTitle)
        {
            BaseResponse _apiResponse = new WebApiResponse();

            WebRequest _request = _generateWebRequest("GET", uri, authKey);

            using (WebResponse _response = _request.GetResponse())
            {
                using (StreamReader _reader = new StreamReader(_response.GetResponseStream()))
                {
                    string objText = _reader.ReadToEnd().ToString().Trim();
                    if (objText.ToLower().Contains("error"))
                    {
                        //Error
                        _apiResponse.Status = ResponseCode.Error;
                        _apiResponse.Message = objText.ToString().Replace("Error: ", "").Trim();
                    }
                    else if (objText.ToLower().Contains("alert"))
                    {
                        //Alert
                        _apiResponse.Status = ResponseCode.Alert;
                        _apiResponse.Message = objText.ToString().Replace("Alert: ", "").Trim();
                    }
                    else
                    {
                        //OK
                        _apiResponse.Status = ResponseCode.Ok;
                        _apiResponse.SubTitle = subTitle;
                        _apiResponse.Message = objText.ToString();
                    }
                }
            }

            return _apiResponse;
        }

        #endregion

        private WebRequest _generateWebRequest(string requestType, string uri, string authKey)
        {
            WebRequest _request = WebRequest.Create(uri);
            _request.Method = requestType;
            _request.ContentType = "application/json; charset=utf-8";
            _request.Headers.Add("Authorization", "Basic " + authKey);

            return _request;
        }
    }
}
