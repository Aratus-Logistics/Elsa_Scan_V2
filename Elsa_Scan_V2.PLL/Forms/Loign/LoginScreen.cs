using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Elsa_Scan_V2.BLL.Models.Forms.Login;
using System.IO;
using System.Reflection;

namespace Elsa_Scan_V2.PLL.Forms.Loign
{
    public partial class LoginScreen : BaseForm
    {
        public LoginScreen()
        {
            InitializeComponent();

            this.txb_Username.GotFocus += (sender, e) => { this.ChangeColor(SystemColors.ScrollBar, sender as TextBox); };
            this.txb_Password.GotFocus += (sender, e) => { this.ChangeColor(SystemColors.ScrollBar, sender as TextBox); };

            this.txb_Username.GotFocus += (sender, e) => { this.ChangeColor(SystemColors.Window, sender as TextBox); };
            this.txb_Password.GotFocus += (sender, e) => { this.ChangeColor(SystemColors.Window, sender as TextBox); };

            this.txb_Username.KeyPress += (sender, e) =>
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    this.EnterPressed(sender, e);
                }
            };
            this.txb_Password.KeyPress += (sender, e) =>
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    this.EnterPressed(sender, e);
                }
            };
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            this.btn_Login.Enabled = false;
            if (this.IsValidForm())
            {
                BLL_Login _login = new BLL_Login(this.txb_Username.Text, this.txb_Password.Text);
                if (_login.Login())
                {
                    this.formHelper.GenerateSuccessForm("Success", "Logged in", "");
                    this.Close();
                }
                else
                {
                    this.btn_Login.Enabled = true;
                    this.formHelper.GenerateFailedForm("Error", "Invalid Username or password", "Please provide the right credentials.");
                }
            }
            else
            {
                this.btn_Login.Enabled = true;
                this.formHelper.GenerateFailedForm("Error", "Valation", "Please fill in all required fields");
            }
        }
    }
}