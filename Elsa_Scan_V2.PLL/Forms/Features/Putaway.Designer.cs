namespace Elsa_Scan_V2.PLL.Forms.Features
{
    partial class Putaway
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
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.lbl_LOC = new System.Windows.Forms.Label();
            this.lbl_LPN = new System.Windows.Forms.Label();
            this.txb_SKU = new System.Windows.Forms.TextBox();
            this.txb_LPN = new System.Windows.Forms.TextBox();
            this.txb_LOC = new System.Windows.Forms.TextBox();
            this.txb_QTY = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_SKU
            // 
            this.lbl_SKU.Location = new System.Drawing.Point(4, 4);
            this.lbl_SKU.Name = "lbl_SKU";
            this.lbl_SKU.Size = new System.Drawing.Size(225, 20);
            this.lbl_SKU.Text = "SKU";
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.Location = new System.Drawing.Point(4, 152);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(225, 20);
            this.lbl_Quantity.Text = "Quantity";
            // 
            // lbl_LOC
            // 
            this.lbl_LOC.Location = new System.Drawing.Point(4, 103);
            this.lbl_LOC.Name = "lbl_LOC";
            this.lbl_LOC.Size = new System.Drawing.Size(225, 20);
            this.lbl_LOC.Text = "Location";
            // 
            // lbl_LPN
            // 
            this.lbl_LPN.Location = new System.Drawing.Point(4, 54);
            this.lbl_LPN.Name = "lbl_LPN";
            this.lbl_LPN.Size = new System.Drawing.Size(225, 20);
            this.lbl_LPN.Text = "LPN";
            // 
            // txb_SKU
            // 
            this.txb_SKU.Location = new System.Drawing.Point(4, 28);
            this.txb_SKU.Name = "txb_SKU";
            this.txb_SKU.Size = new System.Drawing.Size(234, 23);
            this.txb_SKU.TabIndex = 2;
            // 
            // txb_LPN
            // 
            this.txb_LPN.Location = new System.Drawing.Point(3, 77);
            this.txb_LPN.Name = "txb_LPN";
            this.txb_LPN.Size = new System.Drawing.Size(235, 23);
            this.txb_LPN.TabIndex = 5;
            // 
            // txb_LOC
            // 
            this.txb_LOC.Location = new System.Drawing.Point(3, 126);
            this.txb_LOC.Name = "txb_LOC";
            this.txb_LOC.Size = new System.Drawing.Size(235, 23);
            this.txb_LOC.TabIndex = 6;
            // 
            // txb_QTY
            // 
            this.txb_QTY.Location = new System.Drawing.Point(5, 175);
            this.txb_QTY.Name = "txb_QTY";
            this.txb_QTY.Size = new System.Drawing.Size(233, 23);
            this.txb_QTY.TabIndex = 7;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(123, 222);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(114, 40);
            this.btn_Save.TabIndex = 8;
            this.btn_Save.Text = "Save";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(3, 222);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(114, 40);
            this.btn_Exit.TabIndex = 9;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Putaway
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(241, 265);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txb_QTY);
            this.Controls.Add(this.txb_LOC);
            this.Controls.Add(this.txb_LPN);
            this.Controls.Add(this.txb_SKU);
            this.Controls.Add(this.lbl_LPN);
            this.Controls.Add(this.lbl_LOC);
            this.Controls.Add(this.lbl_Quantity);
            this.Controls.Add(this.lbl_SKU);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Putaway";
            this.Text = "Putaway";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_SKU;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.Label lbl_LOC;
        private System.Windows.Forms.Label lbl_LPN;
        private System.Windows.Forms.TextBox txb_SKU;
        private System.Windows.Forms.TextBox txb_LPN;
        private System.Windows.Forms.TextBox txb_LOC;
        private System.Windows.Forms.TextBox txb_QTY;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Exit;
    }
}