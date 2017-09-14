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
    public partial class DoOrder : BaseForm
    {
        private string _lpn;
        private string _futureLocation;
        private string _palletLocation;
        private string _errorMessage;

        public DoOrder(string palletLocation, string lpn, string futureLocation)
        {
            InitializeComponent();

            this.txb_location.GotFocus += (sender, e) => { this.ChangeColor(SystemColors.ScrollBar, sender as TextBox); };
            this.txb_location.LostFocus += (sender, e) => { this.ChangeColor(SystemColors.Window, sender as TextBox); };
            this.txb_location.KeyPress += (sender, e) =>
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    this.EnterPressed(sender, e);
                }
            };

            _lpn = lpn;
            _futureLocation = futureLocation;
            _palletLocation = palletLocation;

            _errorMessage = string.Format("The location you entered is not the location you need to be in. Please go to location: {0}.", _palletLocation);

            this.lbl_gotoLocation.Text = string.Format("Go To Location: {0}", palletLocation);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.ClearForm();
            this.Hide();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (this.IsValidForm())
            {
                if (_checkLocation(this.txb_location.Text, this._palletLocation))
                {
                    BaseForm _moveOrder = new MoveOrder(_lpn, _futureLocation);
                    _moveOrder.Show();

                    this.Hide();
                }
                else
                {
                    this.ClearForm();
                    this.formHelper.GenerateFailedForm("Error", "Location", _errorMessage);
                }
            }
            else
            {
                this.ClearForm();
                this.formHelper.GenerateFailedForm("Error", "Validation", "Please fill in all required fields");
            }
        }

        private bool _checkLocation(string currentLocation, string gotoLocaiton)
        {
            if (currentLocation.Equals(gotoLocaiton)) 
            { 
                return true; 
            } 
            else 
            { 
                return false; 
            }            
        }
    }
}