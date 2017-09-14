using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Elsa_Scan_V2.PLL.Models;
using Elsa_Scan_V2.BLL.Helpers;
using Elsa_Scan_V2.BLL.Models.Controls;
using Elsa_Scan_V2.PLL.Models.Navigation;
using Elsa_Scan_V2.PLL.Forms.Features.SearchStock;

namespace Elsa_Scan_V2.PLL.Forms.Navigation
{
    public partial class SearchStockMenu : BaseForm
    {
        private List<NavigationLink> _navigationLinks = new List<NavigationLink>()
        {
            new NavigationLink("Back to main menu", null),            
            new NavigationLink("Search by LPN", new SearchStockByLPN()),
            new NavigationLink("Search by Location", new SearchStockByLocation()),
            new NavigationLink("Search by SKU", new SearchStockBySKU())
        };

        public SearchStockMenu()
        {
            InitializeComponent();

            this.PrintNavigation(_navigationLinks, this);
        }

        private void SearchStockMenu_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.Navigation_KeyPress_Event(sender, e, _navigationLinks, this);
        }
    }
}