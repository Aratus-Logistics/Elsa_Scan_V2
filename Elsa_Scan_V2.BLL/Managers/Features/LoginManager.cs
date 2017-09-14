using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Elsa_Scan_V2.BLL.Constants;
using Elsa_Scan_V2.BLL.Models.Forms.Login;

namespace Elsa_Scan_V2.BLL.Managers.Features
{
    public class LoginManager : BaseManager
    {
        public void Login(BLL_Login _loginInformation)
        {
            //TODO: Login logic
            if (ApplicationConstants.TEST_MODE)
            {
                ApplicationConstants.IS_LOGGED_IN = true;
            }
            else 
            { 

                //real login logic
            }
        }
    }
}
