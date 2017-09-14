namespace Elsa_Scan_V2.PLL.Forms.Features.Orders
{
    partial class GetOrder
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
            this.btn_getOrder = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_IntroText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_getOrder
            // 
            this.btn_getOrder.Location = new System.Drawing.Point(4, 67);
            this.btn_getOrder.Name = "btn_getOrder";
            this.btn_getOrder.Size = new System.Drawing.Size(234, 40);
            this.btn_getOrder.TabIndex = 0;
            this.btn_getOrder.Text = "Get Order";
            this.btn_getOrder.Click += new System.EventHandler(this.btn_getOrder_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(4, 222);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(234, 40);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.Text = "Exit";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_IntroText
            // 
            this.lbl_IntroText.BackColor = System.Drawing.Color.Silver;
            this.lbl_IntroText.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.lbl_IntroText.Location = new System.Drawing.Point(4, 20);
            this.lbl_IntroText.Name = "lbl_IntroText";
            this.lbl_IntroText.Size = new System.Drawing.Size(234, 30);
            this.lbl_IntroText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 16);
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.label2.Location = new System.Drawing.Point(4, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 16);
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // GetOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(241, 265);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_IntroText);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_getOrder);
            this.Name = "GetOrder";
            this.Text = "Get Order";
            this.Load += new System.EventHandler(this.GetOrder_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_getOrder;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_IntroText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

    }
}