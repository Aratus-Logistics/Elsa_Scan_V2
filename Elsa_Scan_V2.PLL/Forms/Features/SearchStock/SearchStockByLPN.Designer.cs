﻿namespace Elsa_Scan_V2.PLL.Forms.Features.SearchStock
{
    partial class SearchStockByLPN
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
            this.btn_Lookup = new System.Windows.Forms.Button();
            this.lbl_LPN = new System.Windows.Forms.Label();
            this.txb_LPN = new System.Windows.Forms.TextBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            // lbl_LPN
            // 
            this.lbl_LPN.Location = new System.Drawing.Point(4, 4);
            this.lbl_LPN.Name = "lbl_LPN";
            this.lbl_LPN.Size = new System.Drawing.Size(234, 20);
            this.lbl_LPN.Text = "LPN";
            // 
            // txb_LPN
            // 
            this.txb_LPN.Location = new System.Drawing.Point(4, 28);
            this.txb_LPN.Name = "txb_LPN";
            this.txb_LPN.Size = new System.Drawing.Size(234, 23);
            this.txb_LPN.TabIndex = 2;
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
            // SearchStockByLPN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(241, 265);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.txb_LPN);
            this.Controls.Add(this.lbl_LPN);
            this.Controls.Add(this.btn_Lookup);
            this.Name = "SearchStockByLPN";
            this.Text = "Search Stock By LPN";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Lookup;
        private System.Windows.Forms.Label lbl_LPN;
        private System.Windows.Forms.TextBox txb_LPN;
        private System.Windows.Forms.Button btn_Exit;
    }
}