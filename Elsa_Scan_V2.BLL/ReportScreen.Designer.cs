namespace Elsa_Scan_V2.PLL
{
    partial class ReportScreen
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
            this.lbl_reportScreenTitle = new System.Windows.Forms.Label();
            this.lbl_reportScreenMessageTitle = new System.Windows.Forms.Label();
            this.txb_reportScreenMessageBody = new System.Windows.Forms.TextBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.lbl_reportScreenBorder = new System.Windows.Forms.Panel();
            this.lbl_reportScreenBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_reportScreenTitle
            // 
            this.lbl_reportScreenTitle.BackColor = System.Drawing.Color.LightGray;
            this.lbl_reportScreenTitle.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_reportScreenTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_reportScreenTitle.Location = new System.Drawing.Point(2, 2);
            this.lbl_reportScreenTitle.Name = "lbl_reportScreenTitle";
            this.lbl_reportScreenTitle.Size = new System.Drawing.Size(230, 26);
            this.lbl_reportScreenTitle.Text = "Title";
            this.lbl_reportScreenTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_reportScreenMessageTitle
            // 
            this.lbl_reportScreenMessageTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_reportScreenMessageTitle.ForeColor = System.Drawing.Color.Black;
            this.lbl_reportScreenMessageTitle.Location = new System.Drawing.Point(3, 38);
            this.lbl_reportScreenMessageTitle.Name = "lbl_reportScreenMessageTitle";
            this.lbl_reportScreenMessageTitle.Size = new System.Drawing.Size(234, 20);
            this.lbl_reportScreenMessageTitle.Text = "Message Title";
            this.lbl_reportScreenMessageTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txb_reportScreenMessageBody
            // 
            this.txb_reportScreenMessageBody.Location = new System.Drawing.Point(4, 60);
            this.txb_reportScreenMessageBody.Multiline = true;
            this.txb_reportScreenMessageBody.Name = "txb_reportScreenMessageBody";
            this.txb_reportScreenMessageBody.ReadOnly = true;
            this.txb_reportScreenMessageBody.Size = new System.Drawing.Size(233, 167);
            this.txb_reportScreenMessageBody.TabIndex = 2;
            this.txb_reportScreenMessageBody.Text = "Message Body";
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(3, 231);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(234, 32);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "Close";
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lbl_reportScreenBorder
            // 
            this.lbl_reportScreenBorder.Controls.Add(this.lbl_reportScreenTitle);
            this.lbl_reportScreenBorder.Location = new System.Drawing.Point(3, 3);
            this.lbl_reportScreenBorder.Name = "lbl_reportScreenBorder";
            this.lbl_reportScreenBorder.Size = new System.Drawing.Size(234, 30);
            // 
            // ReportScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(241, 265);
            this.Controls.Add(this.lbl_reportScreenBorder);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.txb_reportScreenMessageBody);
            this.Controls.Add(this.lbl_reportScreenMessageTitle);
            this.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReportScreen";
            this.Text = "Error";
            this.Load += new System.EventHandler(this.ReportScreen_Load);
            this.lbl_reportScreenBorder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_reportScreenMessageTitle;
        private System.Windows.Forms.TextBox txb_reportScreenMessageBody;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lbl_reportScreenTitle;
        private System.Windows.Forms.Panel lbl_reportScreenBorder;
    }
}