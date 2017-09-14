using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Elsa_Scan_V2.BLL.Models.Forms.SearchStock;

namespace Elsa_Scan_V2.PLL.Forms.Features.SearchStock
{
    public partial class SearchStockByLPN : BaseForm
    {
        private BLL_SearchByLPN _formVariables;

        public SearchStockByLPN()
        {
            InitializeComponent();

            this.txb_LPN.GotFocus += (sender, e) => { this.ChangeColor(SystemColors.ScrollBar, sender as TextBox); };

            this.txb_LPN.LostFocus += (sender, e) => { this.ChangeColor(SystemColors.Window, sender as TextBox); };

            this.txb_LPN.KeyPress += (sender, e) => 
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    this.EnterPressed(sender, e);
                }
            };

            this.txb_LPN.TextChanged += (sender, e) =>
            {
                this.TextChanged(sender, e, sender as TextBox);
            };

            this.ClearForm();
        }

        private void btn_Lookup_Click(object sender, EventArgs e)
        {
            _formVariables = new BLL_SearchByLPN(this.txb_LPN.Text.Trim());
            if (this.IsValidForm())
            {
                _formVariables.LookupData();
            }
            else
            {
                _formVariables.FormHelper.GenerateFailedForm("Error", "Error", "Please fill in all required fields!");
            }
            this.ClearForm();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}