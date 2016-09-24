namespace POS 
{
    partial class FrmPermissions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPermissions));
            this.txtOrderDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new DevExpress.XtraEditors.LabelControl();
            this.txtOrderNo = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new DevExpress.XtraEditors.LabelControl();
            this.Label16 = new DevExpress.XtraEditors.LabelControl();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnPost = new DevExpress.XtraEditors.SimpleButton();
            this.btnSearchByName = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnMovePrevious = new DevExpress.XtraEditors.SimpleButton();
            this.btnMoveLast = new DevExpress.XtraEditors.SimpleButton();
            this.btnMoveNext = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnMoveFirst = new DevExpress.XtraEditors.SimpleButton();
            this.Pnl_ToolBat = new System.Windows.Forms.Panel();
            this.txtRem = new DevExpress.XtraEditors.MemoEdit();
            
            this.label7 = new DevExpress.XtraEditors.LabelControl();
            this.cmbEmployees = new System.Windows.Forms.ComboBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtFromTime = new System.Windows.Forms.DateTimePicker();
            this.label10 = new DevExpress.XtraEditors.LabelControl();
            this.txtToTime = new System.Windows.Forms.DateTimePicker();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.chkWithoutSalary = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderNo.Properties)).BeginInit();
            this.Pnl_ToolBat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRem.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.CustomFormat = "dd/MM/yyyy";
            this.txtOrderDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtOrderDate.Location = new System.Drawing.Point(123, 88);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtOrderDate.Size = new System.Drawing.Size(157, 21);
            this.txtOrderDate.TabIndex = 140;
            this.txtOrderDate.Tag = "OrderDate";
            // 
            // label6
            // 
            this.label6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(468, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 117;
            this.label6.Text = "الملاحظات";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtOrderNo
            // 
            this.txtOrderNo.Location = new System.Drawing.Point(349, 90);
            this.txtOrderNo.Name = "txtOrderNo";
            this.txtOrderNo.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtOrderNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtOrderNo.Properties.Appearance.Options.UseBackColor = true;
            this.txtOrderNo.Properties.Appearance.Options.UseFont = true;
            this.txtOrderNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtOrderNo.Size = new System.Drawing.Size(100, 20);
            this.txtOrderNo.TabIndex = 11;
            this.txtOrderNo.Tag = "OrderNo";
            // 
            // label2
            // 
            this.label2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(291, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "التاريخ";
            // 
            // Label16
            // 
            this.Label16.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label16.Location = new System.Drawing.Point(463, 94);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(57, 13);
            this.Label16.TabIndex = 41;
            this.Label16.Text = "رقم الحركة";
            // 
            // btnPost
            // 
            this.btnPost.AccessibleDescription = "";
            this.btnPost.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnPost.Appearance.Options.UseFont = true;
            this.btnPost.Image = global::POS.Properties.Resources.SymbolCheck32;
            this.btnPost.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnPost.Location = new System.Drawing.Point(375, 3);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(53, 54);
            this.btnPost.TabIndex = 85;
            this.btnPost.Text = "الترحيل";
            this.ToolTip1.SetToolTip(this.btnPost, "جديد");
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // btnSearchByName
            // 
            this.btnSearchByName.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSearchByName.Appearance.Options.UseFont = true;
            this.btnSearchByName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchByName.Image = global::POS.Properties.Resources.SearchIcon;
            this.btnSearchByName.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnSearchByName.Location = new System.Drawing.Point(269, 3);
            this.btnSearchByName.Name = "btnSearchByName";
            this.btnSearchByName.Size = new System.Drawing.Size(53, 54);
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
            this.btnSave.Location = new System.Drawing.Point(428, 3);
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
            this.btnMovePrevious.Location = new System.Drawing.Point(110, 3);
            this.btnMovePrevious.Name = "btnMovePrevious";
            this.btnMovePrevious.Size = new System.Drawing.Size(53, 54);
            this.btnMovePrevious.TabIndex = 9;
            this.btnMovePrevious.Text = "السابق";
            this.ToolTip1.SetToolTip(this.btnMovePrevious, "السابق");
            this.btnMovePrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnMoveLast
            // 
            this.btnMoveLast.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnMoveLast.Appearance.Options.UseFont = true;
            this.btnMoveLast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMoveLast.Image = global::POS.Properties.Resources.LastIcon;
            this.btnMoveLast.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnMoveLast.Location = new System.Drawing.Point(57, 3);
            this.btnMoveLast.Name = "btnMoveLast";
            this.btnMoveLast.Size = new System.Drawing.Size(53, 54);
            this.btnMoveLast.TabIndex = 10;
            this.btnMoveLast.Text = "الاخير";
            this.ToolTip1.SetToolTip(this.btnMoveLast, "الاخير");
            this.btnMoveLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnMoveNext
            // 
            this.btnMoveNext.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnMoveNext.Appearance.Options.UseFont = true;
            this.btnMoveNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMoveNext.Image = global::POS.Properties.Resources.NextIcon;
            this.btnMoveNext.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnMoveNext.Location = new System.Drawing.Point(163, 3);
            this.btnMoveNext.Name = "btnMoveNext";
            this.btnMoveNext.Size = new System.Drawing.Size(53, 54);
            this.btnMoveNext.TabIndex = 8;
            this.btnMoveNext.Text = "التالى";
            this.ToolTip1.SetToolTip(this.btnMoveNext, "التالي");
            this.btnMoveNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnNew
            // 
            this.btnNew.AccessibleDescription = "";
            this.btnNew.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnNew.Appearance.Options.UseFont = true;
            this.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNew.Image = global::POS.Properties.Resources.Newicon;
            this.btnNew.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnNew.Location = new System.Drawing.Point(481, 3);
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
            this.btnExit.Image = global::POS.Properties.Resources.Exiticon;
            this.btnExit.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnExit.Location = new System.Drawing.Point(4, 3);
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
            this.btnDelete.Location = new System.Drawing.Point(322, 3);
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
            this.btnMoveFirst.Location = new System.Drawing.Point(216, 3);
            this.btnMoveFirst.Name = "btnMoveFirst";
            this.btnMoveFirst.Size = new System.Drawing.Size(53, 54);
            this.btnMoveFirst.TabIndex = 7;
            this.btnMoveFirst.Text = "الاول";
            this.ToolTip1.SetToolTip(this.btnMoveFirst, "الاول");
            this.btnMoveFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // Pnl_ToolBat
            // 
            this.Pnl_ToolBat.Controls.Add(this.btnPost);
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
            this.Pnl_ToolBat.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Pnl_ToolBat.Location = new System.Drawing.Point(0, 0);
            this.Pnl_ToolBat.Name = "Pnl_ToolBat";
            this.Pnl_ToolBat.Size = new System.Drawing.Size(542, 59);
            this.Pnl_ToolBat.TabIndex = 151;
            // 
            // txtRem
            // 
            this.txtRem.Location = new System.Drawing.Point(124, 297);
            this.txtRem.Name = "txtRem";
            this.txtRem.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtRem.Properties.Appearance.Options.UseFont = true;
            this.txtRem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtRem.Size = new System.Drawing.Size(327, 58);
            this.txtRem.TabIndex = 152;
            // 
            // resizeControls1
            // 
            
            
            
           
           
            
           
            
            
            // 
            // label7
            // 
            this.label7.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label7.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(27, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 154;
            this.label7.Text = "جديد";
            // 
            // cmbEmployees
            // 
            this.cmbEmployees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployees.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.cmbEmployees.FormattingEnabled = true;
            this.cmbEmployees.Location = new System.Drawing.Point(153, 136);
            this.cmbEmployees.Name = "cmbEmployees";
            this.cmbEmployees.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbEmployees.Size = new System.Drawing.Size(296, 21);
            this.cmbEmployees.TabIndex = 212;
            // 
            // simpleButton1
            // 
            this.simpleButton1.AccessibleDescription = "";
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            
            this.simpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton1.Location = new System.Drawing.Point(123, 134);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(28, 22);
            this.simpleButton1.TabIndex = 211;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Location = new System.Drawing.Point(478, 144);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 13);
            this.labelControl2.TabIndex = 210;
            this.labelControl2.Text = "الموظف";
            // 
            // txtFromTime
            // 
            this.txtFromTime.CustomFormat = "HH:mm:ss";
            this.txtFromTime.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtFromTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.txtFromTime.Location = new System.Drawing.Point(355, 199);
            this.txtFromTime.Name = "txtFromTime";
            this.txtFromTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFromTime.ShowUpDown = true;
            this.txtFromTime.Size = new System.Drawing.Size(96, 21);
            this.txtFromTime.TabIndex = 214;
            this.txtFromTime.Tag = "";
            // 
            // label10
            // 
            this.label10.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(504, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 13);
            this.label10.TabIndex = 213;
            this.label10.Text = "من";
            // 
            // txtToTime
            // 
            this.txtToTime.CustomFormat = "HH:mm:ss";
            this.txtToTime.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtToTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.txtToTime.Location = new System.Drawing.Point(184, 199);
            this.txtToTime.Name = "txtToTime";
            this.txtToTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtToTime.ShowUpDown = true;
            this.txtToTime.Size = new System.Drawing.Size(96, 21);
            this.txtToTime.TabIndex = 216;
            this.txtToTime.Tag = "";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(307, 203);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(21, 13);
            this.labelControl1.TabIndex = 215;
            this.labelControl1.Text = "الي";
            // 
            // chkWithoutSalary
            // 
            this.chkWithoutSalary.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkWithoutSalary.ForeColor = System.Drawing.Color.Maroon;
            this.chkWithoutSalary.Location = new System.Drawing.Point(266, 254);
            this.chkWithoutSalary.Name = "chkWithoutSalary";
            this.chkWithoutSalary.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkWithoutSalary.Size = new System.Drawing.Size(183, 24);
            this.chkWithoutSalary.TabIndex = 227;
            this.chkWithoutSalary.Text = "يخصم من الراتب";
            this.chkWithoutSalary.UseVisualStyleBackColor = true;
            // 
            // FrmPermissions
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 401);
            this.Controls.Add(this.chkWithoutSalary);
            this.Controls.Add(this.txtToTime);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtFromTime);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbEmployees);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRem);
            this.Controls.Add(this.Pnl_ToolBat);
            this.Controls.Add(this.txtOrderDate);
            
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Label16);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOrderNo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmPermissions";
            this.Text = "الاذونات";
            this.Load += new System.EventHandler(this.FrmPermissions_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPermissions_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderNo.Properties)).EndInit();
            this.Pnl_ToolBat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtRem.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolTip ToolTip1;
        internal DevExpress.XtraEditors.LabelControl Label16;
        internal DevExpress.XtraEditors.TextEdit txtOrderNo;
        private System.Windows.Forms.DateTimePicker txtOrderDate;
        internal DevExpress.XtraEditors.LabelControl label2;
        internal DevExpress.XtraEditors.LabelControl label6;
       
        internal System.Windows.Forms.Panel Pnl_ToolBat;
        private DevExpress.XtraEditors.SimpleButton btnSearchByName;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnMovePrevious;
        private DevExpress.XtraEditors.SimpleButton btnMoveLast;
        private DevExpress.XtraEditors.SimpleButton btnMoveNext;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnMoveFirst;
        private DevExpress.XtraEditors.MemoEdit txtRem;
        internal DevExpress.XtraEditors.SimpleButton btnPost;
        private DevExpress.XtraEditors.LabelControl label7;
        private System.Windows.Forms.ComboBox cmbEmployees;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        internal DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.DateTimePicker txtFromTime;
        internal DevExpress.XtraEditors.LabelControl label10;
        private System.Windows.Forms.DateTimePicker txtToTime;
        internal DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.CheckBox chkWithoutSalary;
    }
}