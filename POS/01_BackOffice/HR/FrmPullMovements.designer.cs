namespace POS 
{
    partial class FrmPullMovements
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPullMovements));
            this.btnConnect = new DevExpress.XtraEditors.SimpleButton();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            
            this.cmbMachines = new System.Windows.Forms.ComboBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnBackup = new DevExpress.XtraEditors.SimpleButton();
            this.btnRestor = new DevExpress.XtraEditors.SimpleButton();
            this.btnPullMovements = new DevExpress.XtraEditors.SimpleButton();
            this.btnPullMovementsandDelete = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtIP = new DevExpress.XtraEditors.LabelControl();
            this.txtPort = new DevExpress.XtraEditors.LabelControl(); 
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnConnect.Appearance.Options.UseFont = true;
            this.btnConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConnect.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnConnect.Location = new System.Drawing.Point(385, 23);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(105, 74);
            this.btnConnect.TabIndex = 168;
            this.btnConnect.Text = "اتصال";
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // resizeControls1
            // 
            
            
            
            
           
           
            
            
            // 
            // cmbMachines
            // 
            this.cmbMachines.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMachines.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.cmbMachines.FormattingEnabled = true;
            this.cmbMachines.Location = new System.Drawing.Point(527, 32);
            this.cmbMachines.Name = "cmbMachines";
            this.cmbMachines.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbMachines.Size = new System.Drawing.Size(296, 21);
            this.cmbMachines.TabIndex = 215;
            this.cmbMachines.SelectedIndexChanged += new System.EventHandler(this.cmbMachines_SelectedIndexChanged);
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
            this.simpleButton1.Location = new System.Drawing.Point(496, 31);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(28, 22);
            this.simpleButton1.TabIndex = 214;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Location = new System.Drawing.Point(835, 37);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(40, 13);
            this.labelControl4.TabIndex = 213;
            this.labelControl4.Text = "الماكينة";
            // 
            // btnBackup
            // 
            this.btnBackup.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnBackup.Appearance.Options.UseFont = true;
            this.btnBackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBackup.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnBackup.Location = new System.Drawing.Point(8, 24);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(180, 35);
            this.btnBackup.TabIndex = 216;
            this.btnBackup.Text = "النسخ الاحتياتي للماكينة";
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnRestor
            // 
            this.btnRestor.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnRestor.Appearance.Options.UseFont = true;
            this.btnRestor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRestor.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnRestor.Location = new System.Drawing.Point(8, 62);
            this.btnRestor.Name = "btnRestor";
            this.btnRestor.Size = new System.Drawing.Size(180, 35);
            this.btnRestor.TabIndex = 217;
            this.btnRestor.Text = "استرجاع النسخه الاحتياطيه";
            // 
            // btnPullMovements
            // 
            this.btnPullMovements.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnPullMovements.Appearance.Options.UseFont = true;
            this.btnPullMovements.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPullMovements.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnPullMovements.Location = new System.Drawing.Point(192, 22);
            this.btnPullMovements.Name = "btnPullMovements";
            this.btnPullMovements.Size = new System.Drawing.Size(180, 35);
            this.btnPullMovements.TabIndex = 222;
            this.btnPullMovements.Text = "سحب الحركات";
            this.btnPullMovements.Click += new System.EventHandler(this.btnPullMovements_Click);
            // 
            // btnPullMovementsandDelete
            // 
            this.btnPullMovementsandDelete.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnPullMovementsandDelete.Appearance.Options.UseFont = true;
            this.btnPullMovementsandDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPullMovementsandDelete.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnPullMovementsandDelete.Location = new System.Drawing.Point(192, 62);
            this.btnPullMovementsandDelete.Name = "btnPullMovementsandDelete";
            this.btnPullMovementsandDelete.Size = new System.Drawing.Size(180, 35);
            this.btnPullMovementsandDelete.TabIndex = 223;
            this.btnPullMovementsandDelete.Text = "سحب الحركات && مسح";
            this.btnPullMovementsandDelete.Click += new System.EventHandler(this.btnPullMovementsandDelete_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(629, 74);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 13);
            this.labelControl1.TabIndex = 213;
            this.labelControl1.Text = "Port";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Location = new System.Drawing.Point(848, 74);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(12, 13);
            this.labelControl2.TabIndex = 225;
            this.labelControl2.Text = "IP";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(894, 20);
            this.label1.TabIndex = 227;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtIP
            // 
            this.txtIP.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtIP.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtIP.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.txtIP.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtIP.Location = new System.Drawing.Point(675, 72);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(148, 17);
            this.txtIP.TabIndex = 228;
            // 
            // txtPort
            // 
            this.txtPort.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPort.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtPort.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.txtPort.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtPort.Location = new System.Drawing.Point(534, 72);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(83, 17);
            this.txtPort.TabIndex = 229;
            // 
            // grd
            // 
     
            // 
            // FrmPullMovements
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 613);
 
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.btnPullMovementsandDelete);
            this.Controls.Add(this.btnPullMovements);
            this.Controls.Add(this.btnRestor);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.cmbMachines);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.btnConnect);
            
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmPullMovements";
            this.Text = "سحب الحركات";
            this.Load += new System.EventHandler(this.FrmPullMovements_Load);
            //((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolTip ToolTip1;
       
        private DevExpress.XtraEditors.SimpleButton btnConnect;
        private System.Windows.Forms.ComboBox cmbMachines;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        internal DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btnBackup;
        private DevExpress.XtraEditors.SimpleButton btnRestor;
        private DevExpress.XtraEditors.SimpleButton btnPullMovements;
        private DevExpress.XtraEditors.SimpleButton btnPullMovementsandDelete;
        internal DevExpress.XtraEditors.LabelControl labelControl1;
        internal DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        internal DevExpress.XtraEditors.LabelControl txtIP;
        internal DevExpress.XtraEditors.LabelControl txtPort;
 

    



    }
}