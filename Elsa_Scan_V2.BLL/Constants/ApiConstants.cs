using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Elsa_Scan_V2.BLL.Constants
{
    public static class ApiConstants
    {
        #region Debug()

        private const string _baseUrl = "";

        public const string API_GET_SEARCHSTOCK_SKU = _baseUrl + "";
        public const string API_GET_SEARCHSTOCK_LOC = _baseUrl + "";
        public const string API_GET_SEARCHSTOCK_LPN = _baseUrl + "";

        public const string API_POST_PÜTAWAY = _baseUrl + "";
        public const string API_POST_MOVE = _baseUrl + "";

        public const string API_AUTHKEY = "";

        #endregion

        #region Production()
        /*
        private const string _baseUrl = "";
        
        public const string API_GET_SEARCHSTOCK_SKU = _baseUrl + "";
        public const string API_GET_SEARCHSTOCK_LOC = _baseUrl + "";
        public const string API_GET_SEARCHSTOCK_LPN = _baseUrl + "";

        public const string API_POST_PÜTAWAY = "";
        public const string API_POST_MOVE = "";
        */
        #endregion

    }
}
