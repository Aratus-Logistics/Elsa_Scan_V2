using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Elsa_Scan_V2.PLL.Forms.Features.Orders
{
    public partial class MoveOrder : BaseForm
    {
        public MoveOrder(string lpn_to_move, string future_lpn_location)
        {
            InitializeComponent();

            this.txb_location.GotFocus += (sender, e) => { this.ChangeColor(SystemColors.ScrollBar, sender as TextBox); };
            this.txb_lpn.GotFocus += (sender, e) => { this.ChangeColor(SystemColors.ScrollBar, sender as TextBox); };

            this.txb_location.LostFocus += (sender, e) => { this.ChangeColor(SystemColors.Window, sender as TextBox); };
            this.txb_lpn.LostFocus += (sender, e) => { this.ChangeColor(SystemColors.Window, sender as TextBox); };

            this.txb_location.KeyPress += (sender , e) =>
            {
                if(e.KeyChar == (char)Keys.Enter)
                {
                    this.EnterPressed(sender, e);
                }
            };
            this.txb_lpn.KeyPress += (sender, e) =>
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    this.EnterPressed(sender, e);
                }
            };


            this.current_lpn.Text = string.Format("[ {0} ]", lpn_to_move);
            this.lbl_gotoLocation.Text = string.Format("Go To Location: {0}", future_lpn_location);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

        }
    }
}