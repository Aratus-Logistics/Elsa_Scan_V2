using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Elsa_Scan_V2.PLL
{
    public enum ReportSceenType { Erorr, Success }
    public partial class ReportScreen : Form
    {
        public ReportScreen(string screenTitle, string messageTitle, string messageBody, ReportSceenType type)
        {
            InitializeComponent();

            switch (type)
            {
                case ReportSceenType.Erorr:
                    this.lbl_reportScreenTitle.BackColor = Color.LightCoral;
                    this.lbl_reportScreenTitle.ForeColor = Color.Red;
                    this.lbl_reportScreenBorder.BackColor = Color.Red;
                    this.txb_reportScreenMessageBody.Text = messageBody;
                    break;
                case ReportSceenType.Success:
                    this.lbl_reportScreenTitle.BackColor = Color.LightGreen;
                    this.lbl_reportScreenTitle.ForeColor = Color.Green;
                    this.lbl_reportScreenBorder.BackColor = Color.Green;
                    this.txb_reportScreenMessageBody.Visible = false;
                    break;
            }

            this.lbl_reportScreenTitle.Text = screenTitle;
            this.lbl_reportScreenMessageTitle.Text = messageTitle;

            this.btn_close.Focus();            
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReportScreen_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}