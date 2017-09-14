using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Elsa_Scan_V2.DAL.Models
{
    public class BaseResponse
    {
        public ResponseCode Status { get; set; }
        public string Message { get; set; }
        public string SubTitle { get; set; }
    }
}
