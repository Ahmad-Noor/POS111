namespace POS
{
    partial class FrmHRSetings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHRSetings));
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.Pnl_ToolBat = new System.Windows.Forms.Panel();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.txtMonthEnd = new System.Windows.Forms.DateTimePicker();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtMonthStart = new System.Windows.Forms.DateTimePicker();
            this.label2 = new DevExpress.XtraEditors.LabelControl();
            
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
        
            this.Pnl_ToolBat.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
 
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Image = global::POS.Properties.Resources.Saveicon;
            this.btnSave.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnSave.Location = new System.Drawing.Point(0, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(62, 54);
            this.btnSave.TabIndex = 82;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Image = global::POS.Properties.Resources.Exiticon;
            this.btnExit.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnExit.Location = new System.Drawing.Point(0, 427);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(62, 54);
            this.btnExit.TabIndex = 79;
            // 
            // Pnl_ToolBat
            // 
            this.Pnl_ToolBat.Controls.Add(this.btnSave);
            this.Pnl_ToolBat.Controls.Add(this.btnExit);
            this.Pnl_ToolBat.Dock = System.Windows.Forms.DockStyle.Right;
            this.Pnl_ToolBat.Location = new System.Drawing.Point(862, 0);
            this.Pnl_ToolBat.Name = "Pnl_ToolBat";
            this.Pnl_ToolBat.Size = new System.Drawing.Size(63, 467);
            this.Pnl_ToolBat.TabIndex = 107;
            // 
            // TabPage1
            // 
            this.TabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TabPage1.Controls.Add(this.txtMonthEnd);
            this.TabPage1.Controls.Add(this.labelControl1);
            this.TabPage1.Controls.Add(this.txtMonthStart);
            this.TabPage1.Controls.Add(this.label2);
           
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(853, 440);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "الافتراضات الاساسية";
            // 
            // txtMonthEnd
            // 
            this.txtMonthEnd.CustomFormat = "dd/MM/yyyy";
            this.txtMonthEnd.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonthEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtMonthEnd.Location = new System.Drawing.Point(269, 29);
            this.txtMonthEnd.Name = "txtMonthEnd";
            this.txtMonthEnd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMonthEnd.Size = new System.Drawing.Size(157, 26);
            this.txtMonthEnd.TabIndex = 144;
            this.txtMonthEnd.Tag = "OrderDate";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(437, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(105, 18);
            this.labelControl1.TabIndex = 143;
            this.labelControl1.Text = "تاريخ نهاية الشهر";
            // 
            // txtMonthStart
            // 
            this.txtMonthStart.CustomFormat = "dd/MM/yyyy";
            this.txtMonthStart.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonthStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtMonthStart.Location = new System.Drawing.Point(553, 31);
            this.txtMonthStart.Name = "txtMonthStart";
            this.txtMonthStart.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMonthStart.Size = new System.Drawing.Size(157, 26);
            this.txtMonthStart.TabIndex = 142;
            this.txtMonthStart.Tag = "OrderDate";
            // 
            // label2
            // 
            this.label2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(721, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 141;
            this.label2.Text = "تاريخ بداية الشهر";
            // 
            // resizeControls1
            // 
            
            
            
           
           
            
            
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.tabPage2);
            this.TabControl1.Location = new System.Drawing.Point(-1, 0);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TabControl1.RightToLeftLayout = true;
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(861, 466);
            this.TabControl1.TabIndex = 106;
            // 
            // tabPage2
            // 
         
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(853, 440);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "الجزاءات ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // grdSanctions
            // 
 
            // 
            // FrmHRSetings
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 467);
            this.Controls.Add(this.Pnl_ToolBat);
            this.Controls.Add(this.TabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmHRSetings";
            this.Text = "الافتراضات الاساسية";
            this.Load += new System.EventHandler(this.FrmSetings_Load);
            this.Pnl_ToolBat.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.TabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            //((System.ComponentModel.ISupportInitialize)(this.grdSanctions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal DevExpress.XtraEditors.SimpleButton btnSave;
        internal DevExpress.XtraEditors.SimpleButton btnExit;
        internal System.Windows.Forms.Panel Pnl_ToolBat;
        internal System.Windows.Forms.TabPage TabPage1;
        internal System.Windows.Forms.TabControl TabControl1;
       
        private System.Windows.Forms.DateTimePicker txtMonthEnd;
        internal DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.DateTimePicker txtMonthStart;
        internal DevExpress.XtraEditors.LabelControl label2;
        private System.Windows.Forms.TabPage tabPage2;
        
    }
}