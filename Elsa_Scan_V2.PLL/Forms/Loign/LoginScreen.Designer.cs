namespace Elsa_Scan_V2.PLL.Forms.Loign
{
    partial class LoginScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.txb_Username = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txb_Password = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.pic_damco = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(4, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 37);
            this.label1.Text = "Please fill in your login details, to use the application.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(4, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 5);
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_Username
            // 
            this.lbl_Username.Location = new System.Drawing.Point(4, 125);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(234, 20);
            this.lbl_Username.Text = "Username:";
            // 
            // txb_Username
            // 
            this.txb_Username.Location = new System.Drawing.Point(4, 147);
            this.txb_Username.Name = "txb_Username";
            this.txb_Username.Size = new System.Drawing.Size(234, 23);
            this.txb_Username.TabIndex = 4;
            // 
            // lbl_Password
            // 
            this.lbl_Password.Location = new System.Drawing.Point(4, 176);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(234, 20);
            this.lbl_Password.Text = "Password:";
            // 
            // txb_Password
            // 
            this.txb_Password.Location = new System.Drawing.Point(4, 195);
            this.txb_Password.Name = "txb_Password";
            this.txb_Password.PasswordChar = '*';
            this.txb_Password.Size = new System.Drawing.Size(234, 23);
            this.txb_Password.TabIndex = 6;
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(3, 222);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(235, 40);
            this.btn_Login.TabIndex = 9;
            this.btn_Login.Text = "Login";
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // pic_damco
            // 
            this.pic_damco.BackColor = System.Drawing.Color.White;
            this.pic_damco.Image = ((System.Drawing.Image)(resources.GetObject("pic_damco.Image")));
            this.pic_damco.Location = new System.Drawing.Point(4, 4);
            this.pic_damco.Name = "pic_damco";
            this.pic_damco.Size = new System.Drawing.Size(234, 73);
            this.pic_damco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(241, 265);
            this.Controls.Add(this.pic_damco);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txb_Password);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.txb_Username);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginScreen";
            this.Text = "Login";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.TextBox txb_Username;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txb_Password;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.PictureBox pic_damco;
    }
}