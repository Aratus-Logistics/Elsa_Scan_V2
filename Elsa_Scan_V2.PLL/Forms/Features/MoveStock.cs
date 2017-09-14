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
    public partial class MoveStock : BaseForm
    {
        private BLL_MoveStock _formVariables;

        public MoveStock()
        {
            InitializeComponent();

            this.txb_LPN.GotFocus += (sender, e) => { ChangeColor(SystemColors.ScrollBar, sender as TextBox); };
            this.txb_NewLOC.GotFocus += (sender, e) => { ChangeColor(SystemColors.ScrollBar, sender as TextBox); };

            this.txb_LPN.LostFocus += (sender, e) => { ChangeColor(SystemColors.Window, sender as TextBox); };
            this.txb_NewLOC.LostFocus += (sender, e) => { ChangeColor(SystemColors.Window, sender as TextBox); };

            this.txb_LPN.KeyPress += (sender, e) =>
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    this.EnterPressed(sender, e);
                }
            };
            this.txb_NewLOC.KeyPress += (sender, e) =>
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
            this.txb_NewLOC.TextChanged += (sender, e) =>
            {
                this.TextChanged(sender, e, sender as TextBox);
            };

            this.ClearForm();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            _formVariables = new BLL_MoveStock(this.txb_LPN.Text.Trim(), this.txb_NewLOC.Text.Trim());
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