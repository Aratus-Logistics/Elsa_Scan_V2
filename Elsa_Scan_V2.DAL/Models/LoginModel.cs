using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Elsa_Scan_V2.DAL.Models
{
    public class LoginModel
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
    }
}
