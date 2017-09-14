namespace Elsa_Scan_V2.PLL.Forms.Features
{
    partial class MoveStock
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
            this.lbl_LPN = new System.Windows.Forms.Label();
            this.lbl_NewLOC = new System.Windows.Forms.Label();
            this.txb_LPN = new System.Windows.Forms.TextBox();
            this.txb_NewLOC = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_LPN
            // 
            this.lbl_LPN.Location = new System.Drawing.Point(4, 4);
            this.lbl_LPN.Name = "lbl_LPN";
            this.lbl_LPN.Size = new System.Drawing.Size(225, 20);
            this.lbl_LPN.Text = "LPN";
            // 
            // lbl_NewLOC
            // 
            this.lbl_NewLOC.Location = new System.Drawing.Point(3, 54);
            this.lbl_NewLOC.Name = "lbl_NewLOC";
            this.lbl_NewLOC.Size = new System.Drawing.Size(226, 20);
            this.lbl_NewLOC.Text = "New Location";
            // 
            // txb_LPN
            // 
            this.txb_LPN.Location = new System.Drawing.Point(4, 28);
            this.txb_LPN.Name = "txb_LPN";
            this.txb_LPN.Size = new System.Drawing.Size(234, 23);
            this.txb_LPN.TabIndex = 2;
            // 
            // txb_NewLOC
            // 
            this.txb_NewLOC.Location = new System.Drawing.Point(4, 78);
            this.txb_NewLOC.Name = "txb_NewLOC";
            this.txb_NewLOC.Size = new System.Drawing.Size(234, 23);
            this.txb_NewLOC.TabIndex = 4;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(124, 222);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(114, 40);
            this.btn_Save.TabIndex = 5;
            this.btn_Save.Text = "Save";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(3, 222);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(114, 40);
            this.btn_Exit.TabIndex = 6;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // MoveStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(241, 265);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txb_NewLOC);
            this.Controls.Add(this.txb_LPN);
            this.Controls.Add(this.lbl_NewLOC);
            this.Controls.Add(this.lbl_LPN);
            this.Name = "MoveStock";
            this.Text = "Move Stock";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_LPN;
        private System.Windows.Forms.Label lbl_NewLOC;
        private System.Windows.Forms.TextBox txb_LPN;
        private System.Windows.Forms.TextBox txb_NewLOC;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Exit;
    }
}