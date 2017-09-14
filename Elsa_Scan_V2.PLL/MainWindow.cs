using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Elsa_Scan_V2.BLL.Helpers;
using Elsa_Scan_V2.BLL.Models.Controls;
using Elsa_Scan_V2.PLL.Models;
using Elsa_Scan_V2.PLL.Forms;
using Elsa_Scan_V2.PLL.Forms.Navigation;
using Elsa_Scan_V2.PLL.Models.Navigation;
using Elsa_Scan_V2.PLL.Forms.Features;
using Elsa_Scan_V2.PLL.Forms.Features.Orders;
using Elsa_Scan_V2.BLL.Constants;
using Elsa_Scan_V2.PLL.Forms.Loign;

namespace Elsa_Scan_V2.PLL
{
    public partial class MainWindow : BaseForm
    {
        private List<NavigationLink> _navigationLinks = new List<NavigationLink>()
        {
            new NavigationLink("Putaway", new Putaway()),
            new NavigationLink("Move Stock", new MoveStock()),
            new NavigationLink("Search Stock", new SearchStockMenu()),
            new NavigationLink("Orders", new GetOrder())
        };

        public MainWindow()
        {
            InitializeComponent();
            this.PrintNavigation(_navigationLinks, this);
            if (!ApplicationConstants.IS_LOGGED_IN)
            {
                var _loginScreen = new LoginScreen();
                _loginScreen.ShowDialog();
            }
        }

        private void ScannerMenu_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.Navigation_KeyPress_Event(sender, e, _navigationLinks, this);
        }
    }
}