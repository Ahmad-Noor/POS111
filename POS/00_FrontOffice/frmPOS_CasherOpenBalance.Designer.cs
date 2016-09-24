namespace POS 
{
    partial class frmPOS_CasherOpenBalance
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
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblShiftNo = new DevExpress.XtraEditors.LabelControl();
            this.lblShiftType = new DevExpress.XtraEditors.LabelControl();
            this.lblCasherName = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.nuStartBalance = new System.Windows.Forms.NumericUpDown();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.nuStartBalance)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(206, 209);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(173, 43);
            this.simpleButton1.TabIndex = 171;
            this.simpleButton1.Text = "Close";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Location = new System.Drawing.Point(27, 209);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(173, 43);
            this.btnSave.TabIndex = 172;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl9.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl9.Location = new System.Drawing.Point(31, 88);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(42, 13);
            this.labelControl9.TabIndex = 173;
            this.labelControl9.Text = "Shift No.";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Location = new System.Drawing.Point(31, 114);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(49, 13);
            this.labelControl1.TabIndex = 173;
            this.labelControl1.Text = "Shift Type";
            // 
            // lblShiftNo
            // 
            this.lblShiftNo.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.lblShiftNo.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.lblShiftNo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblShiftNo.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.lblShiftNo.Location = new System.Drawing.Point(118, 85);
            this.lblShiftNo.Name = "lblShiftNo";
            this.lblShiftNo.Size = new System.Drawing.Size(82, 17);
            this.lblShiftNo.TabIndex = 174;
            // 
            // lblShiftType
            // 
            this.lblShiftType.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.lblShiftType.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.lblShiftType.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblShiftType.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.lblShiftType.Location = new System.Drawing.Point(118, 111);
            this.lblShiftType.Name = "lblShiftType";
            this.lblShiftType.Size = new System.Drawing.Size(183, 17);
            this.lblShiftType.TabIndex = 175;
            // 
            // lblCasherName
            // 
            this.lblCasherName.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.lblCasherName.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.lblCasherName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblCasherName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.lblCasherName.Location = new System.Drawing.Point(118, 137);
            this.lblCasherName.Name = "lblCasherName";
            this.lblCasherName.Size = new System.Drawing.Size(183, 17);
            this.lblCasherName.TabIndex = 177;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl5.Location = new System.Drawing.Point(31, 139);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(64, 13);
            this.labelControl5.TabIndex = 176;
            this.labelControl5.Text = "Casher Name";
            // 
            // nuStartBalance
            // 
            this.nuStartBalance.DecimalPlaces = 2;
            this.nuStartBalance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.nuStartBalance.Location = new System.Drawing.Point(118, 163);
            this.nuStartBalance.Name = "nuStartBalance";
            this.nuStartBalance.Size = new System.Drawing.Size(94, 21);
            this.nuStartBalance.TabIndex = 1159;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl6.Location = new System.Drawing.Point(31, 165);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(76, 16);
            this.labelControl6.TabIndex = 1158;
            this.labelControl6.Text = "Start Balance";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.labelControl7.Location = new System.Drawing.Point(0, 12);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(409, 57);
            this.labelControl7.TabIndex = 1160;
            this.labelControl7.Text = "Casher Open Balance";
            // 
            // frmPOS_CasherOpenBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(405, 291);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.nuStartBalance);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.lblCasherName);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.lblShiftType);
            this.Controls.Add(this.lblShiftNo);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.simpleButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPOS_CasherOpenBalance";
            this.Text = "CasherOpenBalance";
            this.Load += new System.EventHandler(this.frmPOS_CasherOpenBalance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nuStartBalance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblShiftNo;
        private DevExpress.XtraEditors.LabelControl lblShiftType;
        private DevExpress.XtraEditors.LabelControl lblCasherName;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.NumericUpDown nuStartBalance;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
    }
}