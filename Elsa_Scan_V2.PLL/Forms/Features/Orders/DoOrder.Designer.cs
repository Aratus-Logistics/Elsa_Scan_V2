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
            this.lbl_gotoLocation = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_location = new System.Windows.Forms.TextBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_gotoLocation
            // 
            this.lbl_gotoLocation.BackColor = System.Drawing.Color.Silver;
            this.lbl_gotoLocation.Location = new System.Drawing.Point(4, 4);
            this.lbl_gotoLocation.Name = "lbl_gotoLocation";
            this.lbl_gotoLocation.Size = new System.Drawing.Size(234, 20);
            this.lbl_gotoLocation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 20);
            this.label1.Text = "Scan Location:";
            // 
            // txb_location
            // 
            this.txb_location.Location = new System.Drawing.Point(4, 52);
            this.txb_location.Name = "txb_location";
            this.txb_location.Size = new System.Drawing.Size(234, 23);
            this.txb_location.TabIndex = 2;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_exit.Location = new System.Drawing.Point(4, 222);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(114, 40);
            this.btn_exit.TabIndex = 17;
            this.btn_exit.Text = "Exit";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_next.Location = new System.Drawing.Point(124, 222);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(114, 40);
            this.btn_next.TabIndex = 16;
            this.btn_next.Text = "Next";
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // DoOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(241, 265);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.txb_location);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_gotoLocation);
            this.Name = "DoOrder";
            this.Text = "DoOrder";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_gotoLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_location;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_next;
    }
}