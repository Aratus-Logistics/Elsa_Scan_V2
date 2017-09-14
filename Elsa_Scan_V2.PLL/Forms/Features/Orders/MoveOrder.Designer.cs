namespace Elsa_Scan_V2.PLL.Forms.Features.Orders
{
    partial class MoveOrder
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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.lbl_currentLPNOnthislocation = new System.Windows.Forms.Label();
            this.current_lpn = new System.Windows.Forms.Label();
            this.txb_lpn = new System.Windows.Forms.TextBox();
            this.lbl_gotoLocation = new System.Windows.Forms.Label();
            this.lbl_location = new System.Windows.Forms.Label();
            this.txb_location = new System.Windows.Forms.TextBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_currentLPNOnthislocation
            // 
            this.lbl_currentLPNOnthislocation.BackColor = System.Drawing.Color.Silver;
            this.lbl_currentLPNOnthislocation.Location = new System.Drawing.Point(4, 4);
            this.lbl_currentLPNOnthislocation.Name = "lbl_currentLPNOnthislocation";
            this.lbl_currentLPNOnthislocation.Size = new System.Drawing.Size(234, 20);
            this.lbl_currentLPNOnthislocation.Text = "Scan Lpn on this location: ";
            this.lbl_currentLPNOnthislocation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // current_lpn
            // 
            this.current_lpn.BackColor = System.Drawing.Color.Silver;
            this.current_lpn.Location = new System.Drawing.Point(4, 24);
            this.current_lpn.Name = "current_lpn";
            this.current_lpn.Size = new System.Drawing.Size(234, 20);
            this.current_lpn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txb_lpn
            // 
            this.txb_lpn.Location = new System.Drawing.Point(4, 47);
            this.txb_lpn.Name = "txb_lpn";
            this.txb_lpn.Size = new System.Drawing.Size(234, 23);
            this.txb_lpn.TabIndex = 2;
            // 
            // lbl_gotoLocation
            // 
            this.lbl_gotoLocation.BackColor = System.Drawing.Color.Silver;
            this.lbl_gotoLocation.Location = new System.Drawing.Point(4, 73);
            this.lbl_gotoLocation.Name = "lbl_gotoLocation";
            this.lbl_gotoLocation.Size = new System.Drawing.Size(234, 20);
            this.lbl_gotoLocation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_location
            // 
            this.lbl_location.BackColor = System.Drawing.Color.Silver;
            this.lbl_location.Location = new System.Drawing.Point(4, 93);
            this.lbl_location.Name = "lbl_location";
            this.lbl_location.Size = new System.Drawing.Size(234, 20);
            this.lbl_location.Text = "Scan Location:";
            this.lbl_location.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txb_location
            // 
            this.txb_location.Location = new System.Drawing.Point(4, 116);
            this.txb_location.Name = "txb_location";
            this.txb_location.Size = new System.Drawing.Size(234, 23);
            this.txb_location.TabIndex = 5;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(4, 221);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(114, 40);
            this.btn_exit.TabIndex = 15;
            this.btn_exit.Text = "Exit";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(123, 221);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(114, 40);
            this.btn_save.TabIndex = 14;
            this.btn_save.Text = "Move";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // MoveOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(241, 265);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txb_location);
            this.Controls.Add(this.lbl_location);
            this.Controls.Add(this.lbl_gotoLocation);
            this.Controls.Add(this.txb_lpn);
            this.Controls.Add(this.current_lpn);
            this.Controls.Add(this.lbl_currentLPNOnthislocation);
            this.Name = "MoveOrder";
            this.Text = "Move Order";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_currentLPNOnthislocation;
        private System.Windows.Forms.Label current_lpn;
        private System.Windows.Forms.TextBox txb_lpn;
        private System.Windows.Forms.Label lbl_gotoLocation;
        private System.Windows.Forms.Label lbl_location;
        private System.Windows.Forms.TextBox txb_location;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_save;
    }
}