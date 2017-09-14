using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Elsa_Scan_V2.BLL.Managers.Features;
using Elsa_Scan_V2.BLL.Managers.Features.SearchStock;

namespace Elsa_Scan_V2.BLL
{
    public class BLL
    {
        #region Login()

        public static LoginManager LoginManager = new LoginManager();

        #endregion

        #region Putaway()

        public static PutawayManager PutawayManager = new PutawayManager();

        #endregion

        #region MoveStock()

        public static MoveStockManager MoveStockManager = new MoveStockManager();

        #endregion

        #region SearchStock()

        public static SearchByLPNManager SearchByLPNManager = new SearchByLPNManager();
        public static SearchByLocationManager SearchByLocationManager = new SearchByLocationManager();
        public static SearchBySKUManager SearchBySKUManager = new SearchBySKUManager();

        #endregion
    }
}
