namespace POS 
{
    partial class FrmAdditions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdditions));
            this.txtOrderDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.txtAmount = new DevExpress.XtraEditors.TextEdit();
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
            this.cmbAdditionsType = new System.Windows.Forms.ComboBox();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.cmbEmployees = new System.Windows.Forms.ComboBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderNo.Properties)).BeginInit();
            this.Pnl_ToolBat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRem.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.CustomFormat = "dd/MM/yyyy";
            this.txtOrderDate.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtOrderDate.Location = new System.Drawing.Point(110, 88);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtOrderDate.Size = new System.Drawing.Size(157, 26);
            this.txtOrderDate.TabIndex = 140;
            this.txtOrderDate.Tag = "OrderDate";
            // 
            // label6
            // 
            this.label6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(494, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 117;
            this.label6.Text = "الملاحظات";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label1
            // 
            this.label1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(518, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 117;
            this.label1.Text = "المبلغ";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(336, 231);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtAmount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Properties.Appearance.Options.UseBackColor = true;
            this.txtAmount.Properties.Appearance.Options.UseFont = true;
            this.txtAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAmount.Size = new System.Drawing.Size(100, 24);
            this.txtAmount.TabIndex = 116;
            this.txtAmount.Tag = "";
            // 
            // txtOrderNo
            // 
            this.txtOrderNo.Location = new System.Drawing.Point(336, 90);
            this.txtOrderNo.Name = "txtOrderNo";
            this.txtOrderNo.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtOrderNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderNo.Properties.Appearance.Options.UseBackColor = true;
            this.txtOrderNo.Properties.Appearance.Options.UseFont = true;
            this.txtOrderNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtOrderNo.Size = new System.Drawing.Size(100, 24);
            this.txtOrderNo.TabIndex = 11;
            this.txtOrderNo.Tag = "OrderNo";
            // 
            // label2
            // 
            this.label2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(278, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 18);
            this.label2.TabIndex = 41;
            this.label2.Text = "التاريخ";
            // 
            // Label16
            // 
            this.Label16.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label16.Location = new System.Drawing.Point(491, 94);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(57, 13);
            this.Label16.TabIndex = 41;
            this.Label16.Text = "رقم الحركة";
            // 
            // btnPost
            // 
            this.btnPost.AccessibleDescription = "";
            this.btnPost.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnSearchByName.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnMovePrevious.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnMoveLast.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnMoveNext.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnNew.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnExit.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnMoveFirst.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.Pnl_ToolBat.Size = new System.Drawing.Size(566, 59);
            this.Pnl_ToolBat.TabIndex = 151;
            // 
            // txtRem
            // 
            this.txtRem.Location = new System.Drawing.Point(118, 290);
            this.txtRem.Name = "txtRem";
            this.txtRem.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRem.Properties.Appearance.Options.UseFont = true;
            this.txtRem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtRem.Size = new System.Drawing.Size(319, 68);
            this.txtRem.TabIndex = 152;
            // 
            // resizeControls1
            // 
            
            
            
           
           
            
           
            
            
            // 
            // label7
            // 
            this.label7.Appearance.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(28, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 23);
            this.label7.TabIndex = 154;
            this.label7.Text = "جديد";
            // 
            // label3
            // 
            this.label3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(440, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 153;
            this.label3.Text = "نوع الاضافة/المكافأة";
            // 
            // cmbAdditionsType
            // 
            this.cmbAdditionsType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAdditionsType.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAdditionsType.FormattingEnabled = true;
            this.cmbAdditionsType.Location = new System.Drawing.Point(140, 186);
            this.cmbAdditionsType.Name = "cmbAdditionsType";
            this.cmbAdditionsType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbAdditionsType.Size = new System.Drawing.Size(296, 21);
            this.cmbAdditionsType.TabIndex = 208;
            // 
            // simpleButton5
            // 
            this.simpleButton5.AccessibleDescription = "";
            this.simpleButton5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton5.Appearance.ForeColor = System.Drawing.Color.Black;
            this.simpleButton5.Appearance.Options.UseFont = true;
            this.simpleButton5.Appearance.Options.UseForeColor = true;
            this.simpleButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            
            this.simpleButton5.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton5.Location = new System.Drawing.Point(110, 185);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(28, 22);
            this.simpleButton5.TabIndex = 207;
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // cmbEmployees
            // 
            this.cmbEmployees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployees.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmployees.FormattingEnabled = true;
            this.cmbEmployees.Location = new System.Drawing.Point(140, 136);
            this.cmbEmployees.Name = "cmbEmployees";
            this.cmbEmployees.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbEmployees.Size = new System.Drawing.Size(296, 21);
            this.cmbEmployees.TabIndex = 212;
            // 
            // simpleButton1
            // 
            this.simpleButton1.AccessibleDescription = "";
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            
            this.simpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton1.Location = new System.Drawing.Point(110, 134);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(28, 22);
            this.simpleButton1.TabIndex = 211;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Location = new System.Drawing.Point(503, 139);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(45, 13);
            this.labelControl2.TabIndex = 210;
            this.labelControl2.Text = "الموظف ";
            // 
            // FrmAdditions
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 422);
            this.Controls.Add(this.cmbEmployees);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.cmbAdditionsType);
            this.Controls.Add(this.simpleButton5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pnl_ToolBat);
            this.Controls.Add(this.txtOrderDate);
            
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.Label16);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOrderNo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmAdditions";
            this.Text = "الاضافات والمكافأت";
            this.Load += new System.EventHandler(this.FrmAdditions_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmAdditions_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).EndInit();
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
        internal DevExpress.XtraEditors.LabelControl label1;
        internal DevExpress.XtraEditors.TextEdit txtAmount;
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
        private System.Windows.Forms.ComboBox cmbAdditionsType;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private System.Windows.Forms.ComboBox cmbEmployees;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        internal DevExpress.XtraEditors.LabelControl labelControl2;
    }
}