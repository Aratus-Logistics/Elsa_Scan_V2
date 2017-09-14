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
    public partial class GetOrder : BaseForm
    {
        public GetOrder()
        {
            InitializeComponent();
            this.lbl_IntroText.Text = "When clicking get order you're going to get the first created order in the system.";
        }

        private void btn_getOrder_Click(object sender, EventArgs e)
        {
            BaseForm do_order = new DoOrder("E10", "lpn", "E20");
            
            do_order.Show();
            
            //this.Hide();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void GetOrder_Load(object sender, EventArgs e)
        {
            this.btn_getOrder.Focus();
        }
    }
}