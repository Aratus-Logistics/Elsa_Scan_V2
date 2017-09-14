using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Elsa_Scan_V2.BLL.Models.ApplicationModels;

namespace Elsa_Scan_V2.BLL.Constants
{
    public class ApplicationConstants
    {
        public const bool TEST_MODE = true;

        public static bool IS_LOGGED_IN { get; set; }

        public User CurrentUser { get; set; }
    }
}
