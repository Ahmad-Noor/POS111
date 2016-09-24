namespace POS 
{
    partial class FrmAtt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAtt));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.Pnl_ToolBat = new System.Windows.Forms.Panel();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnView = new DevExpress.XtraEditors.SimpleButton();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            
            this.label10 = new DevExpress.XtraEditors.LabelControl();
            this.label3 = new DevExpress.XtraEditors.LabelControl();
            this.txtEmployeeName = new DevExpress.XtraEditors.TextEdit();
            this.txtEmployeeCode = new DevExpress.XtraEditors.ButtonEdit();
            this.dtpAttTime = new System.Windows.Forms.DateTimePicker();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.grd = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShiftOrderNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Timein = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtTransDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonEdit4 = new DevExpress.XtraEditors.ButtonEdit();
            this.buttonEdit3 = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.buttonEdit1 = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtShiftOrderNo = new DevExpress.XtraEditors.ButtonEdit();
            this.Pnl_ToolBat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmployeeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmployeeCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShiftOrderNo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_ToolBat
            // 
            this.Pnl_ToolBat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Pnl_ToolBat.Controls.Add(this.btnSave);
            this.Pnl_ToolBat.Controls.Add(this.btnNew);
            this.Pnl_ToolBat.Controls.Add(this.btnExit);
            this.Pnl_ToolBat.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Pnl_ToolBat.Location = new System.Drawing.Point(373, 2);
            this.Pnl_ToolBat.Name = "Pnl_ToolBat";
            this.Pnl_ToolBat.Size = new System.Drawing.Size(307, 59);
            this.Pnl_ToolBat.TabIndex = 29;
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Image = global::POS.Properties.Resources.Saveicon;
            this.btnSave.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnSave.Location = new System.Drawing.Point(168, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(53, 54);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "حفظ";
            this.ToolTip1.SetToolTip(this.btnSave, "حفظ");
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.AccessibleDescription = "";
            this.btnNew.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnNew.Appearance.Options.UseFont = true;
            this.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNew.Image = global::POS.Properties.Resources.Newicon;
            this.btnNew.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnNew.Location = new System.Drawing.Point(221, 2);
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
            this.btnExit.Location = new System.Drawing.Point(115, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(53, 54);
            this.btnExit.TabIndex = 79;
            this.btnExit.Text = "خروج";
            this.ToolTip1.SetToolTip(this.btnExit, "خروج");
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnView
            // 
            this.btnView.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnView.Appearance.Options.UseFont = true;
            this.btnView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnView.Image = global::POS.Properties.Resources.SearchIcon;
            this.btnView.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnView.Location = new System.Drawing.Point(27, 12);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(101, 28);
            this.btnView.TabIndex = 168;
            this.btnView.Text = "عرض";
            this.ToolTip1.SetToolTip(this.btnView, "عرض");
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
    
            // 
            // label10
            // 
            this.label10.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(414, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 155;
            this.label10.Text = "الوقت";
            // 
            // label3
            // 
            this.label3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(668, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 152;
            this.label3.Text = "الموظف";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(334, 121);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmployeeName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtEmployeeName.Properties.Appearance.Options.UseBackColor = true;
            this.txtEmployeeName.Properties.Appearance.Options.UseFont = true;
            this.txtEmployeeName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEmployeeName.Size = new System.Drawing.Size(224, 20);
            this.txtEmployeeName.TabIndex = 154;
            this.txtEmployeeName.TabStop = false;
            this.txtEmployeeName.Tag = "";
            // 
            // txtEmployeeCode
            // 
            this.txtEmployeeCode.Location = new System.Drawing.Point(559, 121);
            this.txtEmployeeCode.Name = "txtEmployeeCode";
            this.txtEmployeeCode.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtEmployeeCode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtEmployeeCode.Properties.Appearance.Options.UseBackColor = true;
            this.txtEmployeeCode.Properties.Appearance.Options.UseFont = true;
            this.txtEmployeeCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, true, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject6, "", null, null, true)});
            this.txtEmployeeCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEmployeeCode.Size = new System.Drawing.Size(78, 20);
            this.txtEmployeeCode.TabIndex = 153;
            this.txtEmployeeCode.Tag = "";
            this.txtEmployeeCode.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtEmployeeCode_ButtonClick);
            this.txtEmployeeCode.Validated += new System.EventHandler(this.txtEmployeeCode_Validated);
            // 
            // dtpAttTime
            // 
            this.dtpAttTime.CustomFormat = "HH:mm:ss";
            this.dtpAttTime.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.dtpAttTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpAttTime.Location = new System.Drawing.Point(288, 213);
            this.dtpAttTime.Name = "dtpAttTime";
            this.dtpAttTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpAttTime.ShowUpDown = true;
            this.dtpAttTime.Size = new System.Drawing.Size(96, 21);
            this.dtpAttTime.TabIndex = 163;
            this.dtpAttTime.Tag = "";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(673, 190);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(35, 13);
            this.labelControl1.TabIndex = 155;
            this.labelControl1.Text = "الحركة";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.radioButton1.Location = new System.Drawing.Point(568, 186);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton1.Size = new System.Drawing.Size(55, 17);
            this.radioButton1.TabIndex = 164;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "حضور";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.radioButton2.Location = new System.Drawing.Point(470, 186);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton2.Size = new System.Drawing.Size(65, 17);
            this.radioButton2.TabIndex = 165;
            this.radioButton2.Text = "انصراف";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // grd
            // 
            this.grd.AllowUserToAddRows = false;
            this.grd.AllowUserToDeleteRows = false;
            this.grd.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.EmployeeCode,
            this.EmployeeName,
            this.colShiftOrderNo,
            this.TransDate,
            this.TransName,
            this.Timein});
            this.grd.Location = new System.Drawing.Point(8, 248);
            this.grd.Name = "grd";
            this.grd.ReadOnly = true;
            this.grd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grd.RowHeadersVisible = false;
            this.grd.RowTemplate.ReadOnly = true;
            this.grd.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd.Size = new System.Drawing.Size(784, 271);
            this.grd.TabIndex = 166;
            this.grd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_CellContentClick);
            this.grd.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // EmployeeCode
            // 
            this.EmployeeCode.DataPropertyName = "EmployeeCode";
            this.EmployeeCode.HeaderText = "كود الموظف";
            this.EmployeeCode.Name = "EmployeeCode";
            this.EmployeeCode.ReadOnly = true;
            // 
            // EmployeeName
            // 
            this.EmployeeName.DataPropertyName = "EmployeeName";
            this.EmployeeName.HeaderText = "اسم الموظف";
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.ReadOnly = true;
            this.EmployeeName.Width = 150;
            // 
            // colShiftOrderNo
            // 
            this.colShiftOrderNo.DataPropertyName = "ShiftOrderNo";
            this.colShiftOrderNo.HeaderText = "الوردية";
            this.colShiftOrderNo.Name = "colShiftOrderNo";
            this.colShiftOrderNo.ReadOnly = true;
            // 
            // TransDate
            // 
            this.TransDate.DataPropertyName = "TransDate";
            this.TransDate.HeaderText = "التاريخ";
            this.TransDate.Name = "TransDate";
            this.TransDate.ReadOnly = true;
            // 
            // TransName
            // 
            this.TransName.DataPropertyName = "TransName";
            this.TransName.HeaderText = "نوع الحركة";
            this.TransName.Name = "TransName";
            this.TransName.ReadOnly = true;
            // 
            // Timein
            // 
            this.Timein.DataPropertyName = "Timein";
            this.Timein.HeaderText = "وقت";
            this.Timein.Name = "Timein";
            this.Timein.ReadOnly = true;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Location = new System.Drawing.Point(671, 162);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 13);
            this.labelControl2.TabIndex = 155;
            this.labelControl2.Text = "الوردية";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Location = new System.Drawing.Point(672, 219);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(34, 13);
            this.labelControl3.TabIndex = 155;
            this.labelControl3.Text = "التاريخ";
            // 
            // txtTransDate
            // 
            this.txtTransDate.CustomFormat = "dd/MM/yyyy";
            this.txtTransDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtTransDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtTransDate.Location = new System.Drawing.Point(482, 216);
            this.txtTransDate.Name = "txtTransDate";
            this.txtTransDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTransDate.Size = new System.Drawing.Size(157, 21);
            this.txtTransDate.TabIndex = 169;
            this.txtTransDate.Tag = "";
            // 
            // label7
            // 
            this.label7.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(205, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 22);
            this.label7.TabIndex = 171;
            this.label7.Text = "جديد";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonEdit4);
            this.groupBox1.Controls.Add(this.buttonEdit3);
            this.groupBox1.Controls.Add(this.labelControl6);
            this.groupBox1.Controls.Add(this.textEdit1);
            this.groupBox1.Controls.Add(this.buttonEdit1);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.btnView);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(7, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(778, 48);
            this.groupBox1.TabIndex = 172;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "عرض";
            // 
            // buttonEdit4
            // 
            this.buttonEdit4.Location = new System.Drawing.Point(147, 15);
            this.buttonEdit4.Name = "buttonEdit4";
            this.buttonEdit4.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.buttonEdit4.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonEdit4.Properties.Appearance.Options.UseBackColor = true;
            this.buttonEdit4.Properties.Appearance.Options.UseFont = true;
            this.buttonEdit4.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, true, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.buttonEdit4.Size = new System.Drawing.Size(78, 20);
            this.buttonEdit4.TabIndex = 178;
            this.buttonEdit4.Tag = "LocationCode";
            this.buttonEdit4.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.buttonEdit4_ButtonClick);
            // 
            // buttonEdit3
            // 
            this.buttonEdit3.Location = new System.Drawing.Point(293, 15);
            this.buttonEdit3.Name = "buttonEdit3";
            this.buttonEdit3.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.buttonEdit3.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.buttonEdit3.Properties.Appearance.Options.UseFont = true;
            this.buttonEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, true, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.buttonEdit3.Size = new System.Drawing.Size(78, 20);
            this.buttonEdit3.TabIndex = 177;
            this.buttonEdit3.Tag = "LocationCode";
            this.buttonEdit3.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.buttonEdit3_ButtonClick);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Location = new System.Drawing.Point(712, 18);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(42, 13);
            this.labelControl6.TabIndex = 174;
            this.labelControl6.Text = "الموظف";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(451, 15);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.textEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textEdit1.Size = new System.Drawing.Size(173, 20);
            this.textEdit1.TabIndex = 176;
            this.textEdit1.TabStop = false;
            this.textEdit1.Tag = "";
            // 
            // buttonEdit1
            // 
            this.buttonEdit1.Location = new System.Drawing.Point(626, 15);
            this.buttonEdit1.Name = "buttonEdit1";
            this.buttonEdit1.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.buttonEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.buttonEdit1.Properties.Appearance.Options.UseFont = true;
            this.buttonEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, true, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true)});
            this.buttonEdit1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonEdit1.Size = new System.Drawing.Size(78, 20);
            this.buttonEdit1.TabIndex = 175;
            this.buttonEdit1.Tag = "";
            this.buttonEdit1.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.buttonEdit1_ButtonClick);
            this.buttonEdit1.Validated += new System.EventHandler(this.buttonEdit1_Validated);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Location = new System.Drawing.Point(233, 18);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(51, 13);
            this.labelControl5.TabIndex = 172;
            this.labelControl5.Text = "الى وردية";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Location = new System.Drawing.Point(381, 18);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(47, 13);
            this.labelControl4.TabIndex = 170;
            this.labelControl4.Text = "من وردية";
            // 
            // txtShiftOrderNo
            // 
            this.txtShiftOrderNo.Location = new System.Drawing.Point(559, 155);
            this.txtShiftOrderNo.Name = "txtShiftOrderNo";
            this.txtShiftOrderNo.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtShiftOrderNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtShiftOrderNo.Properties.Appearance.Options.UseBackColor = true;
            this.txtShiftOrderNo.Properties.Appearance.Options.UseFont = true;
            this.txtShiftOrderNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, true, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "", null, null, true)});
            this.txtShiftOrderNo.Size = new System.Drawing.Size(78, 20);
            this.txtShiftOrderNo.TabIndex = 173;
            this.txtShiftOrderNo.Tag = "LocationCode";
            this.txtShiftOrderNo.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.buttonEdit2_ButtonClick);
            // 
            // FrmAtt
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 521);
            this.Controls.Add(this.txtShiftOrderNo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTransDate);
            this.Controls.Add(this.grd);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.dtpAttTime);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.txtEmployeeCode);
            
            this.Controls.Add(this.Pnl_ToolBat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmAtt";
            this.Text = "تسجيل الحضور والانصراف";
            this.Load += new System.EventHandler(this.FrmAtt_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmAtt_KeyDown);
            this.Pnl_ToolBat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtEmployeeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmployeeCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShiftOrderNo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolTip ToolTip1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        internal System.Windows.Forms.Panel Pnl_ToolBat;
        private DevExpress.XtraEditors.SimpleButton  btnNew;
        private DevExpress.XtraEditors.SimpleButton btnExit;
       
        internal DevExpress.XtraEditors.LabelControl label10;
        internal DevExpress.XtraEditors.LabelControl label3;
        internal DevExpress.XtraEditors.TextEdit txtEmployeeName;
        internal DevExpress.XtraEditors.ButtonEdit txtEmployeeCode;
        private System.Windows.Forms.DateTimePicker dtpAttTime;
        internal DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.DataGridView grd;
        internal DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnView;
        internal DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.DateTimePicker txtTransDate;
        private DevExpress.XtraEditors.LabelControl label7;
        private System.Windows.Forms.GroupBox groupBox1;
        internal DevExpress.XtraEditors.LabelControl labelControl5;
        internal DevExpress.XtraEditors.LabelControl labelControl4;
        internal DevExpress.XtraEditors.ButtonEdit txtShiftOrderNo;
        internal DevExpress.XtraEditors.LabelControl labelControl6;
        internal DevExpress.XtraEditors.TextEdit textEdit1;
        internal DevExpress.XtraEditors.ButtonEdit buttonEdit1;
        internal DevExpress.XtraEditors.ButtonEdit buttonEdit3;
        internal DevExpress.XtraEditors.ButtonEdit buttonEdit4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShiftOrderNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Timein;//


    



    }
}