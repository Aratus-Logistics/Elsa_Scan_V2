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
    public partial class SearchStockBySKU : BaseForm
    {
        private BLL_SearchBySKU _formVariables;
        public SearchStockBySKU()
        {
            InitializeComponent();

            this.txb_SKU.GotFocus += (sender, e) => { this.ChangeColor(SystemColors.ScrollBar, sender as TextBox); };

            this.txb_SKU.LostFocus += (sender, e) => { this.ChangeColor(SystemColors.Window, sender as TextBox); };

            this.txb_SKU.KeyPress += (sender, e) =>
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    this.EnterPressed(sender, e);
                }
            };

            this.txb_SKU.TextChanged += (sender, e) =>
            {
                this.TextChanged(sender, e, sender as TextBox);
            };

            this.ClearForm();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_Lookup_Click(object sender, EventArgs e)
        {
            _formVariables = new BLL_SearchBySKU(this.txb_SKU.Text.Trim());
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
    }
}