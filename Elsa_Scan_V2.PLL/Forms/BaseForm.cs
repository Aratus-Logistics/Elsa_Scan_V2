using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Elsa_Scan_V2.PLL.Models;
using Elsa_Scan_V2.PLL.Models.Navigation;

using Elsa_Scan_V2.BLL.Models.Controls;
using Elsa_Scan_V2.BLL.Helpers;
using Elsa_Scan_V2.PLL.Forms.Navigation;
using System.Reflection;

namespace Elsa_Scan_V2.PLL.Forms
{
    public partial class BaseForm : Form
    {
        protected FormHelper formHelper = new FormHelper();

        public BLL.BLL BusinessLogic = new BLL.BLL();

        public BaseForm()
        {
            InitializeComponent();
        }

        #region Base Logic()

        public virtual void OnShown()
        {
            ClearForm();
        }

        public void ClearForm()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
            }

            if (!(this is MainWindow || this is SearchStockMenu))
            {
                var _control = _findFirstTextbox();

                if (_control != null)
                {
                    _control.Focus();
                }
            }
        }

        private Control _findFirstTextbox()
        {
            foreach (Control control in this.Controls)
            {
                if (control.TabIndex == 2) //Normally the first textbox in the form
                {
                    return control;
                }
            }
            return null;
        }

        public bool IsValidForm()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox && control.Text == "")
                {
                    return false;
                }
            }
            return true;
        }

        public void ChangeColor(Color color, Control control)
        {
            control.BackColor = color;
        }

        public void TextChanged(object sender, EventArgs e, Control control)
        {
            if (control is TextBox)
            {
                control.Text = removeLeadingZeros(control.Text);
            }
        }

        public void EnterPressed(object sender, KeyPressEventArgs e)
        {
            this.SelectNextControl(sender as Control, true, false, false, false);

            var control = _findFocusedControl(this);
            if (control != null && (control.Name == "btn_Save" || control.Name == "btn_Lookup" || control.Name == "btn_next" || control.Name == "btn_Login"))
            {
                var _methodInfo = (control as Button).GetType().GetMethod("OnClick", BindingFlags.NonPublic | BindingFlags.Instance);
                _methodInfo.Invoke(control as Button, new object[] { EventArgs.Empty });
            }
        }

        private Control _findFocusedControl(Form form)
        {
            foreach (Control control in form.Controls)
            {
                if (control.Focused)
                {
                    return control;
                }
            }
            return null;
        }

        #endregion

        #region Navigation Logic()

        public void PrintNavigation(List<NavigationLink> _navigationLinks, BaseForm _form)
        {
            int _startPosition = 10;
            int _positionIncrease = 25;

            foreach (NavigationLink link in _navigationLinks)
            {
                int _index = _navigationLinks.IndexOf(link);

                string _text = string.Format("{0} - {1}", _index, link.Name);
                string _name = string.Format("lbl_link_{0}", _index);

                int _currentPosition = _startPosition + (_positionIncrease * _index);

                this.Controls.Add(formHelper.GenerateLabel(new LabelOptions(_name, _text, new Point(25, _currentPosition), new Size(200, 25)), false));
            }
        }

        public void Navigation_KeyPress_Event(object sender, KeyPressEventArgs e, List<NavigationLink> _navigationLinks, BaseForm _currentForm)
        {
            if (e.KeyChar < (char)Keys.NumPad0 || e.KeyChar > (char)Keys.NumPad9)
            {
                int _currentOption = 0;
                try
                {
                    _currentOption = Convert.ToInt32(e.KeyChar.ToString());
                }
                catch (Exception)
                {
                    _currentOption = 0;
                }

                if (_currentOption < _navigationLinks.Count)
                {
                    var form = _navigationLinks[_currentOption].Form;

                    if (form != null) // --> if form is null --> back to previous menu
                    {
                        form.OnShown();
                        form.Show();
                    }

                    if (!(_currentForm is MainWindow || _currentForm is SearchStockMenu) ||
                        (form == null && _currentForm is SearchStockMenu))
                    {
                        _currentForm.Hide();
                    }
                }
            }
        }

        #endregion

        #region Protected Methods()

        protected string removeLeadingZeros(string text)
        {
            return text.TrimStart(new char[] { '0' });
        }

        #endregion

        private void BaseForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}