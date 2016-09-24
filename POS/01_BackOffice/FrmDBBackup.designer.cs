namespace POS 
{
    partial class FrmDBBackup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDBBackup));
            
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.Pnl_ToolBat = new System.Windows.Forms.Panel();
            this.Pnl_ToolBat.SuspendLayout();
            this.SuspendLayout();
            // 
            // resizeControls1
            // 
            
            
            
            
           
            
            
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Image = global::POS.Properties.Resources.Exiticon;
            this.btnExit.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnExit.Location = new System.Drawing.Point(23, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(62, 54);
            this.btnExit.TabIndex = 79;
            this.btnExit.Text = "خروج";
            this.ToolTip1.SetToolTip(this.btnExit, "خروج");
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Image = global::POS.Properties.Resources.database_process_icon;
            this.btnDelete.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnDelete.Location = new System.Drawing.Point(118, 61);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 76);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Backup";
            this.ToolTip1.SetToolTip(this.btnDelete, "الالغأ");
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.simpleButton1.Image = global::POS.Properties.Resources.database_process_icon;
            this.simpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButton1.Location = new System.Drawing.Point(220, 61);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(87, 76);
            this.simpleButton1.TabIndex = 92;
            this.simpleButton1.Text = "Restore";
            this.ToolTip1.SetToolTip(this.simpleButton1, "الالغأ");
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Pnl_ToolBat
            // 
            this.Pnl_ToolBat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Pnl_ToolBat.Controls.Add(this.btnExit);
            this.Pnl_ToolBat.Location = new System.Drawing.Point(14, -4);
            this.Pnl_ToolBat.Name = "Pnl_ToolBat";
            this.Pnl_ToolBat.Size = new System.Drawing.Size(412, 59);
            this.Pnl_ToolBat.TabIndex = 30;
            // 
            // FrmDBBackup
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 149);
            this.Controls.Add(this.simpleButton1);
            
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.Pnl_ToolBat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmDBBackup";
            this.Text = "Backup";
            this.Pnl_ToolBat.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ToolTip ToolTip1;
       
        internal System.Windows.Forms.Panel Pnl_ToolBat;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}