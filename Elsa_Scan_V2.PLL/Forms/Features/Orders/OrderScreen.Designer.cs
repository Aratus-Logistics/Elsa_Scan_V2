namespace Elsa_Scan_V2.PLL.Forms.Features.Orders
{
    partial class DoOrder
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
            this.btn_next = new System.Windows.Forms.Button();
            this.pickup_lpn_label = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_gotoLocation = new System.Windows.Forms.Label();
            this.txb_location = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(122, 201);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(116, 41);
            this.btn_next.TabIndex = 0;
            this.btn_next.Text = "Next";
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // pickup_lpn_label
            // 
            this.pickup_lpn_label.Location = new System.Drawing.Point(4, 25);
            this.pickup_lpn_label.Name = "pickup_lpn_label";
            this.pickup_lpn_label.Size = new System.Drawing.Size(234, 20);
            this.pickup_lpn_label.Text = "Scan Location:";
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(4, 201);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(112, 41);
            this.btn_exit.TabIndex = 13;
            this.btn_exit.Text = "Exit";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_gotoLocation
            // 
            this.lbl_gotoLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_gotoLocation.Location = new System.Drawing.Point(4, 4);
            this.lbl_gotoLocation.Name = "lbl_gotoLocation";
            this.lbl_gotoLocation.Size = new System.Drawing.Size(234, 20);
            this.lbl_gotoLocation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txb_location
            // 
            this.txb_location.Location = new System.Drawing.Point(4, 49);
            this.txb_location.Name = "txb_location";
            this.txb_location.Size = new System.Drawing.Size(234, 23);
            this.txb_location.TabIndex = 15;
            // 
            // DoOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(241, 245);
            this.ControlBox = false;
            this.Controls.Add(this.txb_location);
            this.Controls.Add(this.lbl_gotoLocation);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.pickup_lpn_label);
            this.Controls.Add(this.btn_next);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DoOrder";
            this.Text = "Order Screen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Label pickup_lpn_label;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_gotoLocation;
        private System.Windows.Forms.TextBox txb_location;
    }
}