using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Elsa_Scan_V2.DAL.Models;

namespace Elsa_Scan_V2.DAL.Interfaces
{
    public interface IWebApiClient
    {
        BaseResponse Post(string uri, string authKey);
        BaseResponse Get(string uri, string authKey, string searchParam);
    }
}
