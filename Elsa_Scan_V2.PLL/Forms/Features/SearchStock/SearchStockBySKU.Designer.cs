namespace Elsa_Scan_V2.PLL.Forms.Features.SearchStock
{
    partial class SearchStockBySKU
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
            this.lbl_SKU = new System.Windows.Forms.Label();
            this.txb_SKU = new System.Windows.Forms.TextBox();
            this.btn_Lookup = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_SKU
            // 
            this.lbl_SKU.Location = new System.Drawing.Point(4, 4);
            this.lbl_SKU.Name = "lbl_SKU";
            this.lbl_SKU.Size = new System.Drawing.Size(234, 20);
            this.lbl_SKU.Text = "SKU";
            // 
            // txb_SKU
            // 
            this.txb_SKU.Location = new System.Drawing.Point(4, 28);
            this.txb_SKU.Name = "txb_SKU";
            this.txb_SKU.Size = new System.Drawing.Size(234, 23);
            this.txb_SKU.TabIndex = 2;
            // 
            // btn_Lookup
            // 
            this.btn_Lookup.Location = new System.Drawing.Point(124, 222);
            this.btn_Lookup.Name = "btn_Lookup";
            this.btn_Lookup.Size = new System.Drawing.Size(114, 40);
            this.btn_Lookup.TabIndex = 3;
            this.btn_Lookup.Text = "Lookup";
            this.btn_Lookup.Click += new System.EventHandler(this.btn_Lookup_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(4, 222);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(114, 40);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // SearchStockBySKU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(241, 265);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Lookup);
            this.Controls.Add(this.txb_SKU);
            this.Controls.Add(this.lbl_SKU);
            this.Name = "SearchStockBySKU";
            this.Text = "Search Stock By SKU";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_SKU;
        private System.Windows.Forms.TextBox txb_SKU;
        private System.Windows.Forms.Button btn_Lookup;
        private System.Windows.Forms.Button btn_Exit;
    }
}