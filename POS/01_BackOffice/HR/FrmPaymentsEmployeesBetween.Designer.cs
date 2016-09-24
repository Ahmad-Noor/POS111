namespace POS 
{
    partial class FrmPaymentsEmployeesBetween
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPaymentsEmployeesBetween));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.txtCode = new DevExpress.XtraEditors.ButtonEdit();
            this.textBox2 = new DevExpress.XtraEditors.TextEdit();
            this.textBox1 = new DevExpress.XtraEditors.TextEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new DevExpress.XtraEditors.LabelControl();
            this.txtOrderNo = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new DevExpress.XtraEditors.LabelControl();
            this.label2 = new DevExpress.XtraEditors.LabelControl();
            this.label4 = new DevExpress.XtraEditors.LabelControl();
            this.Label16 = new DevExpress.XtraEditors.LabelControl();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnSearchByName = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnMovePrevious = new DevExpress.XtraEditors.SimpleButton();
            this.btnMoveLast = new DevExpress.XtraEditors.SimpleButton();
            this.btnMoveNext = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnMoveFirst = new DevExpress.XtraEditors.SimpleButton();
            this.btnView = new DevExpress.XtraEditors.SimpleButton();
            
            this.Pnl_ToolBat = new System.Windows.Forms.Panel();
            this.label7 = new DevExpress.XtraEditors.LabelControl();
            this.buttonEdit4 = new DevExpress.XtraEditors.ButtonEdit();
            this.buttonEdit3 = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.grd = new System.Windows.Forms.DataGridView();
            this.OrderNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeInm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIMEOUT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActulMinute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIMEOUTm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActulMinutem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTotal = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderNo.Properties)).BeginInit();
            this.Pnl_ToolBat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.CustomFormat = "dd/MM/yyyy";
            this.dtpOrderDate.Enabled = false;
            this.dtpOrderDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrderDate.Location = new System.Drawing.Point(314, 113);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpOrderDate.Size = new System.Drawing.Size(157, 21);
            this.dtpOrderDate.TabIndex = 140;
            this.dtpOrderDate.Tag = "OrderDate";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(540, 155);
            this.txtCode.Name = "txtCode";
            this.txtCode.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtCode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Properties.Appearance.Options.UseBackColor = true;
            this.txtCode.Properties.Appearance.Options.UseFont = true;
            this.txtCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, true, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.txtCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCode.Size = new System.Drawing.Size(101, 20);
            this.txtCode.TabIndex = 113;
            this.txtCode.Tag = "";
            this.txtCode.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtCode_ButtonClick);
            this.txtCode.Validated += new System.EventHandler(this.txtCode_Validated);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(294, 71);
            this.textBox2.Name = "textBox2";
            this.textBox2.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Properties.Appearance.Options.UseBackColor = true;
            this.textBox2.Properties.Appearance.Options.UseFont = true;
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox2.Size = new System.Drawing.Size(96, 20);
            this.textBox2.TabIndex = 114;
            this.textBox2.TabStop = false;
            this.textBox2.Tag = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(471, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Properties.Appearance.Options.UseBackColor = true;
            this.textBox1.Properties.Appearance.Options.UseFont = true;
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(170, 20);
            this.textBox1.TabIndex = 114;
            this.textBox1.TabStop = false;
            this.textBox1.Tag = "";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(314, 155);
            this.txtName.Name = "txtName";
            this.txtName.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Properties.Appearance.Options.UseBackColor = true;
            this.txtName.Properties.Appearance.Options.UseFont = true;
            this.txtName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtName.Size = new System.Drawing.Size(224, 20);
            this.txtName.TabIndex = 114;
            this.txtName.TabStop = false;
            this.txtName.Tag = "";
            // 
            // label3
            // 
            this.label3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(678, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 107;
            this.label3.Text = "الموظف";
            // 
            // txtOrderNo
            // 
            this.txtOrderNo.Location = new System.Drawing.Point(544, 113);
            this.txtOrderNo.Name = "txtOrderNo";
            this.txtOrderNo.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtOrderNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderNo.Properties.Appearance.Options.UseBackColor = true;
            this.txtOrderNo.Properties.Appearance.Options.UseFont = true;
            this.txtOrderNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtOrderNo.Size = new System.Drawing.Size(100, 20);
            this.txtOrderNo.TabIndex = 11;
            this.txtOrderNo.Tag = "OrderNo";
            // 
            // label5
            // 
            this.label5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(402, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "الوردية";
            // 
            // label2
            // 
            this.label2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(488, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "التاريخ";
            // 
            // label4
            // 
            this.label4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(645, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "الخزينة/الكاشير";
            // 
            // Label16
            // 
            this.Label16.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label16.Location = new System.Drawing.Point(660, 117);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(57, 13);
            this.Label16.TabIndex = 41;
            this.Label16.Text = "رقم الحركة";
            // 
            // btnSearchByName
            // 
            this.btnSearchByName.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchByName.Appearance.Options.UseFont = true;
            this.btnSearchByName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchByName.Image = global::POS.Properties.Resources.SearchIcon;
            this.btnSearchByName.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnSearchByName.Location = new System.Drawing.Point(356, 2);
            this.btnSearchByName.Name = "btnSearchByName";
            this.btnSearchByName.Size = new System.Drawing.Size(53, 54);
            this.btnSearchByName.TabIndex = 6;
            this.btnSearchByName.Text = "بحث";
            this.ToolTip1.SetToolTip(this.btnSearchByName, "بحث بالاسم");
            this.btnSearchByName.Click += new System.EventHandler(this.btnSearchByName_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Image = global::POS.Properties.Resources.Saveicon;
            this.btnSave.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnSave.Location = new System.Drawing.Point(490, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(53, 54);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "حفظ";
            this.ToolTip1.SetToolTip(this.btnSave, "حفظ");
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnMovePrevious
            // 
            this.btnMovePrevious.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovePrevious.Appearance.Options.UseFont = true;
            this.btnMovePrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMovePrevious.Image = global::POS.Properties.Resources.PreviousIcon;
            this.btnMovePrevious.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnMovePrevious.Location = new System.Drawing.Point(155, 2);
            this.btnMovePrevious.Name = "btnMovePrevious";
            this.btnMovePrevious.Size = new System.Drawing.Size(53, 54);
            this.btnMovePrevious.TabIndex = 9;
            this.btnMovePrevious.Text = "السابق";
            this.ToolTip1.SetToolTip(this.btnMovePrevious, "السابق");
            this.btnMovePrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnMoveLast
            // 
            this.btnMoveLast.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveLast.Appearance.Options.UseFont = true;
            this.btnMoveLast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMoveLast.Image = global::POS.Properties.Resources.LastIcon;
            this.btnMoveLast.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnMoveLast.Location = new System.Drawing.Point(88, 2);
            this.btnMoveLast.Name = "btnMoveLast";
            this.btnMoveLast.Size = new System.Drawing.Size(53, 54);
            this.btnMoveLast.TabIndex = 10;
            this.btnMoveLast.Text = "الاخير";
            this.ToolTip1.SetToolTip(this.btnMoveLast, "الاخير");
            this.btnMoveLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnMoveNext
            // 
            this.btnMoveNext.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveNext.Appearance.Options.UseFont = true;
            this.btnMoveNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMoveNext.Image = global::POS.Properties.Resources.NextIcon;
            this.btnMoveNext.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnMoveNext.Location = new System.Drawing.Point(222, 2);
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
            this.btnNew.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Appearance.Options.UseFont = true;
            this.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNew.Image = global::POS.Properties.Resources.Newicon;
            this.btnNew.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnNew.Location = new System.Drawing.Point(557, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(53, 54);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "جديد";
            this.ToolTip1.SetToolTip(this.btnNew, "جديد");
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnExit
            // 
            this.btnExit.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Image = global::POS.Properties.Resources.Exiticon;
            this.btnExit.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnExit.Location = new System.Drawing.Point(21, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(53, 54);
            this.btnExit.TabIndex = 79;
            this.btnExit.Text = "خروج";
            this.ToolTip1.SetToolTip(this.btnExit, "خروج");
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Image = global::POS.Properties.Resources.DeleteIcon;
            this.btnDelete.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnDelete.Location = new System.Drawing.Point(423, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(53, 54);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "حذف";
            this.ToolTip1.SetToolTip(this.btnDelete, "الحذف");
            this.btnDelete.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnMoveFirst
            // 
            this.btnMoveFirst.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveFirst.Appearance.Options.UseFont = true;
            this.btnMoveFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMoveFirst.Image = global::POS.Properties.Resources.FirstIcon;
            this.btnMoveFirst.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnMoveFirst.Location = new System.Drawing.Point(289, 2);
            this.btnMoveFirst.Name = "btnMoveFirst";
            this.btnMoveFirst.Size = new System.Drawing.Size(53, 54);
            this.btnMoveFirst.TabIndex = 7;
            this.btnMoveFirst.Text = "الاول";
            this.ToolTip1.SetToolTip(this.btnMoveFirst, "الاول");
            this.btnMoveFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnView
            // 
            this.btnView.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Appearance.Options.UseFont = true;
            this.btnView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnView.Image = global::POS.Properties.Resources.SearchIcon;
            this.btnView.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnView.Location = new System.Drawing.Point(183, 131);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(101, 47);
            this.btnView.TabIndex = 179;
            this.btnView.Text = "عرض";
            this.ToolTip1.SetToolTip(this.btnView, "عرض");
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
 
            // 
            // Pnl_ToolBat
            // 
            this.Pnl_ToolBat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Pnl_ToolBat.Controls.Add(this.btnSearchByName);
            this.Pnl_ToolBat.Controls.Add(this.btnSave);
            this.Pnl_ToolBat.Controls.Add(this.btnMovePrevious);
            this.Pnl_ToolBat.Controls.Add(this.btnMoveLast);
            this.Pnl_ToolBat.Controls.Add(this.btnMoveNext);
            this.Pnl_ToolBat.Controls.Add(this.btnNew);
            this.Pnl_ToolBat.Controls.Add(this.btnExit);
            this.Pnl_ToolBat.Controls.Add(this.btnDelete);
            this.Pnl_ToolBat.Controls.Add(this.btnMoveFirst);
            this.Pnl_ToolBat.Location = new System.Drawing.Point(104, 1);
            this.Pnl_ToolBat.Name = "Pnl_ToolBat";
            this.Pnl_ToolBat.Size = new System.Drawing.Size(632, 59);
            this.Pnl_ToolBat.TabIndex = 167;
            // 
            // label7
            // 
            this.label7.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(104, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 22);
            this.label7.TabIndex = 172;
            this.label7.Text = "جديد";
            // 
            // buttonEdit4
            // 
            this.buttonEdit4.Location = new System.Drawing.Point(344, 196);
            this.buttonEdit4.Name = "buttonEdit4";
            this.buttonEdit4.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.buttonEdit4.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit4.Properties.Appearance.Options.UseBackColor = true;
            this.buttonEdit4.Properties.Appearance.Options.UseFont = true;
            this.buttonEdit4.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, true, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.buttonEdit4.Size = new System.Drawing.Size(78, 20);
            this.buttonEdit4.TabIndex = 183;
            this.buttonEdit4.Tag = "LocationCode";
            this.buttonEdit4.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.buttonEdit4_ButtonClick);
            // 
            // buttonEdit3
            // 
            this.buttonEdit3.Location = new System.Drawing.Point(563, 196);
            this.buttonEdit3.Name = "buttonEdit3";
            this.buttonEdit3.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.buttonEdit3.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.buttonEdit3.Properties.Appearance.Options.UseFont = true;
            this.buttonEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, true, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true)});
            this.buttonEdit3.Size = new System.Drawing.Size(78, 20);
            this.buttonEdit3.TabIndex = 182;
            this.buttonEdit3.Tag = "LocationCode";
            this.buttonEdit3.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.buttonEdit3_ButtonClick);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(430, 199);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(51, 13);
            this.labelControl5.TabIndex = 181;
            this.labelControl5.Text = "الى وردية";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Location = new System.Drawing.Point(672, 490);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(42, 18);
            this.labelControl4.TabIndex = 180;
            this.labelControl4.Text = "الاجمالي";
            // 
            // grd
            // 
            this.grd.AllowUserToAddRows = false;
            this.grd.AllowUserToDeleteRows = false;
            this.grd.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderNo,
            this.OrderDate,
            this.TimeInm,
            this.TimeIn,
            this.TIMEOUT,
            this.ActulMinute,
            this.TIMEOUTm,
            this.ActulMinutem,
            this.Salary});
            this.grd.Location = new System.Drawing.Point(15, 238);
            this.grd.Name = "grd";
            this.grd.ReadOnly = true;
            this.grd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grd.RowHeadersVisible = false;
            this.grd.RowTemplate.Height = 27;
            this.grd.RowTemplate.ReadOnly = true;
            this.grd.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd.Size = new System.Drawing.Size(721, 237);
            this.grd.TabIndex = 184;
            // 
            // OrderNo
            // 
            this.OrderNo.DataPropertyName = "OrderNo";
            this.OrderNo.HeaderText = "الوردية";
            this.OrderNo.Name = "OrderNo";
            this.OrderNo.ReadOnly = true;
            // 
            // OrderDate
            // 
            this.OrderDate.DataPropertyName = "OrderDate";
            this.OrderDate.HeaderText = "التاريخ";
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.ReadOnly = true;
            // 
            // TimeInm
            // 
            this.TimeInm.HeaderText = "وقت الحضور";
            this.TimeInm.Name = "TimeInm";
            this.TimeInm.ReadOnly = true;
            // 
            // TimeIn
            // 
            this.TimeIn.DataPropertyName = "TimeIn";
            this.TimeIn.HeaderText = "TimeIn";
            this.TimeIn.Name = "TimeIn";
            this.TimeIn.ReadOnly = true;
            this.TimeIn.Visible = false;
            // 
            // TIMEOUT
            // 
            this.TIMEOUT.DataPropertyName = "TIMEOUT";
            this.TIMEOUT.HeaderText = "TIMEOUT";
            this.TIMEOUT.Name = "TIMEOUT";
            this.TIMEOUT.ReadOnly = true;
            this.TIMEOUT.Visible = false;
            // 
            // ActulMinute
            // 
            this.ActulMinute.HeaderText = "ActulMinute";
            this.ActulMinute.Name = "ActulMinute";
            this.ActulMinute.ReadOnly = true;
            this.ActulMinute.Visible = false;
            // 
            // TIMEOUTm
            // 
            this.TIMEOUTm.DataPropertyName = "TIMEOUTm";
            this.TIMEOUTm.HeaderText = "وقت الانصراف";
            this.TIMEOUTm.Name = "TIMEOUTm";
            this.TIMEOUTm.ReadOnly = true;
            // 
            // ActulMinutem
            // 
            this.ActulMinutem.DataPropertyName = "ActulMinutem";
            this.ActulMinutem.HeaderText = "ساعات العمل";
            this.ActulMinutem.Name = "ActulMinutem";
            this.ActulMinutem.ReadOnly = true;
            // 
            // Salary
            // 
            this.Salary.DataPropertyName = "Salary";
            this.Salary.HeaderText = "الراتب";
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(500, 487);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTotal.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Properties.Appearance.Options.UseBackColor = true;
            this.txtTotal.Properties.Appearance.Options.UseFont = true;
            this.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotal.Size = new System.Drawing.Size(152, 24);
            this.txtTotal.TabIndex = 185;
            this.txtTotal.TabStop = false;
            this.txtTotal.Tag = "";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(671, 199);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(47, 13);
            this.labelControl1.TabIndex = 181;
            this.labelControl1.Text = "من وردية";
            // 
            // FrmPaymentsEmployeesBetween
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 522);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.grd);
            this.Controls.Add(this.buttonEdit4);
            this.Controls.Add(this.buttonEdit3);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Pnl_ToolBat);
            
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Label16);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtOrderNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.dtpOrderDate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmPaymentsEmployeesBetween";
            this.Text = "اجور عاملين خلال فترة";
            this.Load += new System.EventHandler(this.FrmPaymentsEmployeesBetween_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPaymentsEmployeesBetween_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderNo.Properties)).EndInit();
            this.Pnl_ToolBat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolTip ToolTip1;
        internal DevExpress.XtraEditors.LabelControl Label16;
        internal DevExpress.XtraEditors.TextEdit txtOrderNo;
        internal DevExpress.XtraEditors.ButtonEdit txtCode;
        internal DevExpress.XtraEditors.TextEdit txtName;
        internal DevExpress.XtraEditors.LabelControl label3;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        internal DevExpress.XtraEditors.LabelControl label2;
        internal DevExpress.XtraEditors.TextEdit textBox2;
        internal DevExpress.XtraEditors.TextEdit textBox1;
        internal DevExpress.XtraEditors.LabelControl label5;
        internal DevExpress.XtraEditors.LabelControl label4;
       
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
        private DevExpress.XtraEditors.LabelControl label7;
        internal DevExpress.XtraEditors.ButtonEdit buttonEdit4;
        internal DevExpress.XtraEditors.ButtonEdit buttonEdit3;
        internal DevExpress.XtraEditors.LabelControl labelControl5;
        internal DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btnView;
        private System.Windows.Forms.DataGridView grd;
        internal DevExpress.XtraEditors.TextEdit txtTotal;
        internal DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeInm;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIMEOUT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActulMinute;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIMEOUTm;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActulMinutem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
    }
}