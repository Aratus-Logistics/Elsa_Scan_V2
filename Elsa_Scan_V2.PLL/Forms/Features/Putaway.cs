using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Elsa_Scan_V2.BLL.Models.Forms;

namespace Elsa_Scan_V2.PLL.Forms.Features
{
    public partial class Putaway : BaseForm
    {
        private BLL_Putaway _formVariables;

        public Putaway()
        {
            InitializeComponent();

            this.txb_SKU.GotFocus += (sender, e) => { this.ChangeColor(SystemColors.ScrollBar, sender as TextBox); };
            this.txb_LPN.GotFocus += (sender, e) => { this.ChangeColor(SystemColors.ScrollBar, sender as TextBox); };
            this.txb_LOC.GotFocus += (sender, e) => { this.ChangeColor(SystemColors.ScrollBar, sender as TextBox); };
            this.txb_QTY.GotFocus += (sender, e) => { this.ChangeColor(SystemColors.ScrollBar, sender as TextBox); };

            this.txb_SKU.LostFocus += (sender, e) => { this.ChangeColor(SystemColors.Window, sender as TextBox); };
            this.txb_LPN.LostFocus += (sender, e) => { this.ChangeColor(SystemColors.Window, sender as TextBox); };
            this.txb_LOC.LostFocus += (sender, e) => { this.ChangeColor(SystemColors.Window, sender as TextBox); };
            this.txb_QTY.LostFocus += (sender, e) => { this.ChangeColor(SystemColors.Window, sender as TextBox); };

            this.txb_SKU.KeyPress += (sender, e) =>
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    this.EnterPressed(sender, e);
                }
            };
            this.txb_LPN.KeyPress += (sender, e) =>
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    this.EnterPressed(sender, e);
                }
            };
            this.txb_LOC.KeyPress += (sender, e) =>
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    this.EnterPressed(sender, e);
                }
            };
            this.txb_QTY.KeyPress += (sender, e) =>
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
            this.txb_LPN.TextChanged += (sender, e) =>
            {
                this.TextChanged(sender, e, sender as TextBox);
            };
            this.txb_LOC.TextChanged += (sender, e) =>
            {
                this.TextChanged(sender, e, sender as TextBox);
            };

            this.ClearForm();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            _formVariables = new BLL_Putaway(this.txb_SKU.Text.Trim(), this.txb_LOC.Text.Trim(), this.txb_LPN.Text.Trim(), this.txb_QTY.Text.Trim());
            if (this.IsValidForm())
            {
                _formVariables.SaveData();                
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