using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Elsa_Scan_V2.BLL.Helpers.Validation;
using Elsa_Scan_V2.BLL.Constants;

namespace Elsa_Scan_V2.BLL.Models.Forms.Login
{
    public class BLL_Login : BaseModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public BLL_Login(string username, string password)
        {
            this.UserName = username;
            this.Password = password;
        }

        public BLL_Login() { }

        public bool Login()
        {
            if (Extensions<BLL_Login>.Validate())
            {
                BLL.LoginManager.Login(this);
                if(ApplicationConstants.IS_LOGGED_IN)
                {                    
                    return true;
                }
                else
                {                    
                    return false;
                }
            }
            return false;
        }
    }
}
