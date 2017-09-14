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
    public partial class SearchStockByLocation : BaseForm
    {
        private BLL_SearchByLocation _formVariables;
        public SearchStockByLocation()
        {
            InitializeComponent();

            this.txb_LOC.GotFocus += (sender, e) => { this.ChangeColor(SystemColors.ScrollBar, sender as TextBox); };

            this.txb_LOC.LostFocus += (sender, e) => { this.ChangeColor(SystemColors.Window, sender as TextBox); };

            this.txb_LOC.KeyPress += (sender, e) =>
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    this.EnterPressed(sender, e);
                }
            };

            this.txb_LOC.TextChanged += (sender, e) =>
            {
                this.TextChanged(sender, e, sender as TextBox);
            };

            this.ClearForm();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.ClearForm();
            this.Hide();
        }

        private void btn_Lookup_Click(object sender, EventArgs e)
        {
            _formVariables = new BLL_SearchByLocation(this.txb_LOC.Text.ToString());
            if (this.IsValidForm())
            {
                _formVariables.LookupData();
            }
            else
            {
                _formVariables.FormHelper.GenerateFailedForm("Error", "Error", "Please fill in all fields!");
            }
            this.ClearForm();
        }
    }
}