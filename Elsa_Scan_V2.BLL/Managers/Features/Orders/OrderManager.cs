using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Elsa_Scan_V2.BLL.Models.Forms.Orders;

namespace Elsa_Scan_V2.BLL.Managers.Features.Orders
{
    public class OrderManager : BaseManager
    {
        public void MoveLPN(string lpn, string newLocation)
        {
            BLL_Order _order = new BLL_Order(lpn, newLocation);
            _order.Move();
            if (_order.IsProcesCompleted)
            {
                this.FormHelper.GenerateSuccessForm("Success", "Order Processed", "");
            }
            else
            {
                this.FormHelper.GenerateFailedForm("Error", "Processing order failed", "Please try again");
            }
        }
    }
}
