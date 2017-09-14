using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Elsa_Scan_V2.BLL.Models.Controls;
using System.Drawing;
using Elsa_Scan_V2.PLL;

namespace Elsa_Scan_V2.BLL.Helpers
{
    public class FormHelper
    {
        #region Private constants()

        private Size _defaultButtonSize = new Size(175, 40);
        private Size _defaultFormSize = new Size(243, 270);

        #endregion

        public FormHelper()
        {

        }

        #region Public Methods

        #region Success Form Generation()
        public void GenerateSuccessForm(string title, string subTitle, string body)
        {
            ReportScreen _errorScreen = new ReportScreen(title, subTitle, body, ReportSceenType.Success);
            _errorScreen.ShowDialog();
        }

        #endregion

        #region Failed Form Generation

        public void GenerateFailedForm(string title, string subTitle, string body)
        {
            ReportScreen _errorScreen = new ReportScreen(title, subTitle, body, ReportSceenType.Erorr);
            _errorScreen.ShowDialog();
        }

        #endregion

        #region Control Generation()

        public Button GenerateButton(ButtonOptions options)
        {
            //new System.Drawing.Point(25, 175)
            //new System.Drawing.Size(175, 40)
            var _btn = new Button()
            {
                Name = options.Name,
                Text = options.Text,
                Location = options.Location,
                Size = options.Size,
                TabIndex = 1
            };

            _btn.Click += options.Event;

            /*_exitButton.Click += new System.EventHandler((sender, e) =>
            {
                ((sender as Button).Parent as Form).Close();
            });*/

            return _btn;
        }

        public Label GenerateLabel(LabelOptions options, bool specialLabel)
        {
            if (!specialLabel)
            {
                //new System.Drawing.Point(25, 25)
                //new System.Drawing.Size(175, 150)
                return new Label()
                {
                    Name = options.Name,
                    Text = options.Text,
                    Location = options.Location,
                    Size = options.Size
                };
            }
            else
            {
                return new Label()
                {
                    Name = options.Name,
                    Text = options.Text,
                    Location = options.Location,
                    Size = options.Size,

                    TextAlign = ContentAlignment.TopCenter
                };
            }
        }

        public TextBox GenerateTextbox(TextBoxOptions options)
        {
            //new System.Drawing.Point(15, 40)
            //new System.Drawing.Size(209, 165)
            var _txtBox = new TextBox()
            {
                Location = options.Location,
                Size = options.Size,
                Name = options.Name,
                Text = options.Text,
                ScrollBars = ScrollBars.Vertical
            };

            if (options.MultiLine)
            {
                _txtBox.ReadOnly = true;
                _txtBox.Multiline = true;
                _txtBox.WordWrap = true;
            }

            return _txtBox;
        }

        #endregion

        #endregion

        #region ShowForm()

        private void _showForm(string title, List<Control> _controls)
        {
            using (Form _form = new Form())
            {
                _form.SuspendLayout();

                _form.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
                _form.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
                _form.ControlBox = false;
                _form.ClientSize = _defaultFormSize;
                _form.AutoScroll = true;

                _form.MinimizeBox = false;

                foreach (var control in _controls)
                {
                    _form.Controls.Add(control);
                }

                _form.Name = title;
                _form.Text = title;

                _form.ResumeLayout(false);

                _form.ShowDialog();
            }
        }

        #endregion
    }
}
