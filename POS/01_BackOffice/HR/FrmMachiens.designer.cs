namespace POS 
{
    partial class FrmMachiens
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMachiens));
            this.Label16 = new DevExpress.XtraEditors.LabelControl();
            this.Label8 = new DevExpress.XtraEditors.LabelControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.txtCode = new DevExpress.XtraEditors.TextEdit();
            this.Pnl_ToolBat = new System.Windows.Forms.Panel();
            this.btnSearchByName = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnMovePrevious = new DevExpress.XtraEditors.SimpleButton();
            this.btnMoveLast = new DevExpress.XtraEditors.SimpleButton();
            this.btnMoveNext = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnMoveFirst = new DevExpress.XtraEditors.SimpleButton();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtIP = new DevExpress.XtraEditors.TextEdit();
            this.txtPort = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            this.Pnl_ToolBat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPort.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Label16
            // 
            this.Label16.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label16.Location = new System.Drawing.Point(438, 89);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(27, 13);
            this.Label16.TabIndex = 41;
            this.Label16.Text = "الكود";
            // 
            // Label8
            // 
            this.Label8.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label8.Location = new System.Drawing.Point(438, 128);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(32, 13);
            this.Label8.TabIndex = 22;
            this.Label8.Text = "الاسم";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(109, 122);
            this.txtName.Name = "txtName";
            this.txtName.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtName.Properties.Appearance.Options.UseBackColor = true;
            this.txtName.Properties.Appearance.Options.UseFont = true;
            this.txtName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtName.Size = new System.Drawing.Size(307, 20);
            this.txtName.TabIndex = 12;
            this.txtName.Tag = "name";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(313, 85);
            this.txtCode.Name = "txtCode";
            this.txtCode.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtCode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtCode.Properties.Appearance.Options.UseBackColor = true;
            this.txtCode.Properties.Appearance.Options.UseFont = true;
            this.txtCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCode.Size = new System.Drawing.Size(103, 20);
            this.txtCode.TabIndex = 11;
            this.txtCode.Tag = "Code";
            // 
            // Pnl_ToolBat
            // 
            this.Pnl_ToolBat.Controls.Add(this.btnSearchByName);
            this.Pnl_ToolBat.Controls.Add(this.btnSave);
            this.Pnl_ToolBat.Controls.Add(this.btnMovePrevious);
            this.Pnl_ToolBat.Controls.Add(this.btnMoveLast);
            this.Pnl_ToolBat.Controls.Add(this.btnMoveNext);
            this.Pnl_ToolBat.Controls.Add(this.btnNew);
            this.Pnl_ToolBat.Controls.Add(this.btnExit);
            this.Pnl_ToolBat.Controls.Add(this.btnDelete);
            this.Pnl_ToolBat.Controls.Add(this.btnMoveFirst);
            this.Pnl_ToolBat.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_ToolBat.Location = new System.Drawing.Point(0, 0);
            this.Pnl_ToolBat.Name = "Pnl_ToolBat";
            this.Pnl_ToolBat.Size = new System.Drawing.Size(491, 59);
            this.Pnl_ToolBat.TabIndex = 29;
            // 
            // btnSearchByName
            // 
            this.btnSearchByName.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSearchByName.Appearance.Options.UseFont = true;
            this.btnSearchByName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchByName.Image = global::POS.Properties.Resources.SearchIcon;
            this.btnSearchByName.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnSearchByName.Location = new System.Drawing.Point(272, 2);
            this.btnSearchByName.Name = "btnSearchByName";
            this.btnSearchByName.Size = new System.Drawing.Size(53, 54);//(53, 54);//(53, 54);
            this.btnSearchByName.TabIndex = 6;
            this.btnSearchByName.Text = "بحث";
            this.ToolTip1.SetToolTip(this.btnSearchByName, "بحث بالاسم");
            this.btnSearchByName.Click += new System.EventHandler(this.btnSearchByName_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Image = global::POS.Properties.Resources.Saveicon;
            this.btnSave.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnSave.Location = new System.Drawing.Point(378, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(53, 54);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "حفظ";
            this.ToolTip1.SetToolTip(this.btnSave, "حفظ");
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnMovePrevious
            // 
            this.btnMovePrevious.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnMovePrevious.Appearance.Options.UseFont = true;
            this.btnMovePrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMovePrevious.Image = global::POS.Properties.Resources.PreviousIcon;
            this.btnMovePrevious.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnMovePrevious.Location = new System.Drawing.Point(113, 2);
            this.btnMovePrevious.Name = "btnMovePrevious";
            this.btnMovePrevious.Size = new System.Drawing.Size(53, 54);
            this.btnMovePrevious.TabIndex = 9;
            this.btnMovePrevious.Text = "السابق";
            this.ToolTip1.SetToolTip(this.btnMovePrevious, "السابق");
            this.btnMovePrevious.Click += new System.EventHandler(this.btnMovePrevious_Click);
            // 
            // btnMoveLast
            // 
            this.btnMoveLast.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnMoveLast.Appearance.Options.UseFont = true;
            this.btnMoveLast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMoveLast.Image = global::POS.Properties.Resources.LastIcon;
            this.btnMoveLast.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnMoveLast.Location = new System.Drawing.Point(60, 2);
            this.btnMoveLast.Name = "btnMoveLast";
            this.btnMoveLast.Size = new System.Drawing.Size(53, 54);
            this.btnMoveLast.TabIndex = 10;
            this.btnMoveLast.Text = "الاخير";
            this.ToolTip1.SetToolTip(this.btnMoveLast, "الاخير");
            this.btnMoveLast.Click += new System.EventHandler(this.btnMoveLast_Click);
            // 
            // btnMoveNext
            // 
            this.btnMoveNext.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnMoveNext.Appearance.Options.UseFont = true;
            this.btnMoveNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMoveNext.Image = global::POS.Properties.Resources.NextIcon;
            this.btnMoveNext.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnMoveNext.Location = new System.Drawing.Point(166, 2);
            this.btnMoveNext.Name = "btnMoveNext";
            this.btnMoveNext.Size = new System.Drawing.Size(53, 54);
            this.btnMoveNext.TabIndex = 8;
            this.btnMoveNext.Text = "التالى";
            this.ToolTip1.SetToolTip(this.btnMoveNext, "التالي");
            this.btnMoveNext.Click += new System.EventHandler(this.btnMoveNext_Click);
            // 
            // btnNew
            // 
            this.btnNew.AccessibleDescription = "";
            this.btnNew.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnNew.Appearance.Options.UseFont = true;
            this.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNew.Image = global::POS.Properties.Resources.Newicon;
            this.btnNew.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnNew.Location = new System.Drawing.Point(431, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(53, 54);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "جديد";
            this.ToolTip1.SetToolTip(this.btnNew, "جديد");
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnExit
            // 
            this.btnExit.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Image = global::POS.Properties.Resources.Exiticon;
            this.btnExit.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnExit.Location = new System.Drawing.Point(7, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(53, 54);
            this.btnExit.TabIndex = 79;
            this.btnExit.Text = "خروج";
            this.ToolTip1.SetToolTip(this.btnExit, "خروج");
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Image = global::POS.Properties.Resources.DeleteIcon;
            this.btnDelete.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnDelete.Location = new System.Drawing.Point(325, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(53, 54);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "حذف";
            this.ToolTip1.SetToolTip(this.btnDelete, "الحذف");
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnMoveFirst
            // 
            this.btnMoveFirst.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnMoveFirst.Appearance.Options.UseFont = true;
            this.btnMoveFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMoveFirst.Image = global::POS.Properties.Resources.FirstIcon;
            this.btnMoveFirst.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnMoveFirst.Location = new System.Drawing.Point(219, 2);
            this.btnMoveFirst.Name = "btnMoveFirst";
            this.btnMoveFirst.Size = new System.Drawing.Size(53, 54);
            this.btnMoveFirst.TabIndex = 7;
            this.btnMoveFirst.Text = "الاول";
            this.ToolTip1.SetToolTip(this.btnMoveFirst, "الاول");
            this.btnMoveFirst.Click += new System.EventHandler(this.btnMoveFirst_Click);
 
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(438, 164);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(12, 13);
            this.labelControl1.TabIndex = 92;
            this.labelControl1.Text = "IP";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(110, 158);
            this.txtIP.Name = "txtIP";
            this.txtIP.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtIP.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtIP.Properties.Appearance.Options.UseBackColor = true;
            this.txtIP.Properties.Appearance.Options.UseFont = true;
            this.txtIP.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtIP.Size = new System.Drawing.Size(307, 20);
            this.txtIP.TabIndex = 93;
            this.txtIP.Tag = "name";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(291, 203);
            this.txtPort.Name = "txtPort";
            this.txtPort.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtPort.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtPort.Properties.Appearance.Options.UseBackColor = true;
            this.txtPort.Properties.Appearance.Options.UseFont = true;
            this.txtPort.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPort.Size = new System.Drawing.Size(125, 20);
            this.txtPort.TabIndex = 94;
            this.txtPort.Tag = "name";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Location = new System.Drawing.Point(438, 209);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(25, 13);
            this.labelControl2.TabIndex = 95;
            this.labelControl2.Text = "بورت";
            // 
            // FrmMachiens
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(491, 277);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.labelControl1);
            
            this.Controls.Add(this.Pnl_ToolBat);
            this.Controls.Add(this.Label16);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmMachiens";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الماكينات البصمة";
            this.Load += new System.EventHandler(this.FrmMachiens_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMachiens_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            this.Pnl_ToolBat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtIP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPort.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        internal System.Windows.Forms.ToolTip ToolTip1;
        private DevExpress.XtraEditors.SimpleButton  btnSearchByName;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl Label16;
        private DevExpress.XtraEditors.LabelControl Label8;
        internal DevExpress.XtraEditors.TextEdit txtName;
        internal DevExpress.XtraEditors.TextEdit txtCode;
        private DevExpress.XtraEditors.SimpleButton  btnMoveLast;
        internal System.Windows.Forms.Panel Pnl_ToolBat;
        private DevExpress.XtraEditors.SimpleButton  btnMoveNext;
        private DevExpress.XtraEditors.SimpleButton  btnMovePrevious;
        private DevExpress.XtraEditors.SimpleButton  btnNew;
        private DevExpress.XtraEditors.SimpleButton  btnExit;
        private DevExpress.XtraEditors.SimpleButton  btnDelete;
        private DevExpress.XtraEditors.SimpleButton  btnMoveFirst;
       
        private DevExpress.XtraEditors.LabelControl labelControl1;
        internal DevExpress.XtraEditors.TextEdit txtIP;
        internal DevExpress.XtraEditors.TextEdit txtPort;
        private DevExpress.XtraEditors.LabelControl labelControl2;//
    }
}