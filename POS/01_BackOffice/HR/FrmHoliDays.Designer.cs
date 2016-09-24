namespace POS 
{
    partial class FrmHoliDays
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHoliDays));
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
            this.label3 = new DevExpress.XtraEditors.LabelControl();
            this.cmbHoliDaysType = new System.Windows.Forms.ComboBox();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.cmbEmployees = new System.Windows.Forms.ComboBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtEndDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkWithoutSalary = new System.Windows.Forms.CheckBox();
            this.txtDaysCount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
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
            this.txtOrderDate.Location = new System.Drawing.Point(100, 88);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtOrderDate.Size = new System.Drawing.Size(157, 21);
            this.txtOrderDate.TabIndex = 140;
            this.txtOrderDate.Tag = "OrderDate";
            // 
            // label6
            // 
            this.label6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(487, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 117;
            this.label6.Text = "الملاحظات";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtOrderNo
            // 
            this.txtOrderNo.Location = new System.Drawing.Point(326, 90);
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
            this.label2.Location = new System.Drawing.Point(268, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "التاريخ";
            // 
            // Label16
            // 
            this.Label16.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label16.Location = new System.Drawing.Point(484, 94);
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
            this.btnPost.Location = new System.Drawing.Point(383, 2);
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
            this.btnSearchByName.Location = new System.Drawing.Point(277, 2);
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
            this.btnSave.Location = new System.Drawing.Point(436, 2);
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
            this.btnMovePrevious.Location = new System.Drawing.Point(118, 2);
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
            this.btnMoveLast.Location = new System.Drawing.Point(65, 2);
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
            this.btnMoveNext.Location = new System.Drawing.Point(171, 2);
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
            this.btnNew.Location = new System.Drawing.Point(489, 2);
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
            this.btnExit.Location = new System.Drawing.Point(12, 2);
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
            this.btnDelete.Location = new System.Drawing.Point(330, 2);
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
            this.btnMoveFirst.Location = new System.Drawing.Point(224, 2);
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
            this.Pnl_ToolBat.Location = new System.Drawing.Point(0, 0);
            this.Pnl_ToolBat.Name = "Pnl_ToolBat";
            this.Pnl_ToolBat.Size = new System.Drawing.Size(554, 59);
            this.Pnl_ToolBat.TabIndex = 151;
            // 
            // txtRem
            // 
            this.txtRem.Location = new System.Drawing.Point(100, 370);
            this.txtRem.Name = "txtRem";
            this.txtRem.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtRem.Properties.Appearance.Options.UseFont = true;
            this.txtRem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtRem.Size = new System.Drawing.Size(326, 68);
            this.txtRem.TabIndex = 152;
            // 
            // resizeControls1
            // 
            
            
            
           
           
            
           
            
            
            // 
            // label7
            // 
            this.label7.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label7.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(27, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 154;
            this.label7.Text = "جديد";
            // 
            // label3
            // 
            this.label3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(485, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 153;
            this.label3.Text = "نوع الاجازة";
            // 
            // cmbHoliDaysType
            // 
            this.cmbHoliDaysType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHoliDaysType.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.cmbHoliDaysType.FormattingEnabled = true;
            this.cmbHoliDaysType.Location = new System.Drawing.Point(130, 186);
            this.cmbHoliDaysType.Name = "cmbHoliDaysType";
            this.cmbHoliDaysType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbHoliDaysType.Size = new System.Drawing.Size(296, 21);
            this.cmbHoliDaysType.TabIndex = 208;
            // 
            // simpleButton5
            // 
            this.simpleButton5.AccessibleDescription = "";
            this.simpleButton5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.simpleButton5.Appearance.ForeColor = System.Drawing.Color.Black;
            this.simpleButton5.Appearance.Options.UseFont = true;
            this.simpleButton5.Appearance.Options.UseForeColor = true;
            this.simpleButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            
            this.simpleButton5.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton5.Location = new System.Drawing.Point(100, 185);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(28, 22);
            this.simpleButton5.TabIndex = 207;
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // cmbEmployees
            // 
            this.cmbEmployees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployees.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.cmbEmployees.FormattingEnabled = true;
            this.cmbEmployees.Location = new System.Drawing.Point(130, 136);
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
            this.simpleButton1.Location = new System.Drawing.Point(100, 134);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(28, 22);
            this.simpleButton1.TabIndex = 211;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Location = new System.Drawing.Point(496, 139);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(45, 13);
            this.labelControl2.TabIndex = 210;
            this.labelControl2.Text = "الموظف ";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(118, 310);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(86, 21);
            this.textBox1.TabIndex = 214;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(214, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 213;
            this.label4.Text = "رصيد ";
            // 
            // txtStartDate
            // 
            this.txtStartDate.CustomFormat = "yyyy/MM/dd";
            this.txtStartDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtStartDate.Location = new System.Drawing.Point(294, 227);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(132, 21);
            this.txtStartDate.TabIndex = 215;
            this.txtStartDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtEndDate
            // 
            this.txtEndDate.CustomFormat = "yyyy/MM/dd";
            this.txtEndDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtEndDate.Location = new System.Drawing.Point(294, 271);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(132, 21);
            this.txtEndDate.TabIndex = 216;
            this.txtEndDate.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(440, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 217;
            this.label5.Text = "تاريخ انتهاء الاجازة";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(442, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 218;
            this.label1.Text = "تاريخ بداية الاجازة";
            // 
            // chkWithoutSalary
            // 
            this.chkWithoutSalary.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkWithoutSalary.ForeColor = System.Drawing.Color.Maroon;
            this.chkWithoutSalary.Location = new System.Drawing.Point(268, 323);
            this.chkWithoutSalary.Name = "chkWithoutSalary";
            this.chkWithoutSalary.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkWithoutSalary.Size = new System.Drawing.Size(158, 24);
            this.chkWithoutSalary.TabIndex = 219;
            this.chkWithoutSalary.Text = "بدون راتب";
            this.chkWithoutSalary.UseVisualStyleBackColor = true;
            // 
            // txtDaysCount
            // 
            this.txtDaysCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDaysCount.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtDaysCount.Location = new System.Drawing.Point(110, 248);
            this.txtDaysCount.Name = "txtDaysCount";
            this.txtDaysCount.ReadOnly = true;
            this.txtDaysCount.Size = new System.Drawing.Size(75, 21);
            this.txtDaysCount.TabIndex = 221;
            this.txtDaysCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(193, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 220;
            this.label8.Text = "المدة بالايام";
            // 
            // FrmHoliDays
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 467);
            this.Controls.Add(this.txtDaysCount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chkWithoutSalary);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.txtEndDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbEmployees);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.cmbHoliDaysType);
            this.Controls.Add(this.simpleButton5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRem);
            this.Controls.Add(this.Pnl_ToolBat);
            this.Controls.Add(this.txtOrderDate);
            
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Label16);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOrderNo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmHoliDays";
            this.Text = "الاجازات";
            this.Load += new System.EventHandler(this.FrmHoliDays_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmHoliDays_KeyDown);
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
        internal DevExpress.XtraEditors.LabelControl label3;
        private System.Windows.Forms.ComboBox cmbHoliDaysType;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private System.Windows.Forms.ComboBox cmbEmployees;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        internal DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker txtStartDate;
        private System.Windows.Forms.DateTimePicker txtEndDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkWithoutSalary;
        private System.Windows.Forms.TextBox txtDaysCount;
        private System.Windows.Forms.Label label8;
    }
}