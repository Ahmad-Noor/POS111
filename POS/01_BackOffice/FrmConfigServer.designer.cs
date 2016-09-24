using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using Microsoft.VisualBasic;
using System.Linq;
using System;
using System.Collections;
using System.Windows.Forms;

namespace POS
{
    public partial class FrmConfigServer : SkyForm
    {

        //Form overrides dispose to clean up the component list.
        [System.Diagnostics.DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components != null)
                {
                    components.Dispose();}
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        //Required by the Windows Form Designer
        private System.ComponentModel.Container components = null;

        //NOTE: The following procedure is required by the Windows Form Designer
        //It can be modified using the Windows Form Designer.
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfigServer));
            this.txtUser = new DevExpress.XtraEditors.TextEdit();
            this.Label1 = new DevExpress.XtraEditors.LabelControl();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.Label3 = new DevExpress.XtraEditors.LabelControl();
            this.Label4 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.btnConnection = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.lblConnection = new DevExpress.XtraEditors.LabelControl();
            this.button3 = new System.Windows.Forms.Button();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn2 = new DevExpress.XtraEditors.SimpleButton();
            this.txtLogFile = new System.Windows.Forms.TextBox();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtFolderPath = new System.Windows.Forms.TextBox();
            this.txtMDFFile = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btn1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new DevExpress.XtraEditors.SimpleButton();
            this.DatabaseCombo = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.Label2 = new DevExpress.XtraEditors.LabelControl();
            this.btn3 = new DevExpress.XtraEditors.SimpleButton();
            this.cmbSVR = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::POS.Properties.Settings.Default, "UserName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtUser.EditValue = "sa";
            this.txtUser.Location = new System.Drawing.Point(126, 60);
            this.txtUser.Name = "txtUser";
            this.txtUser.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Properties.Appearance.Options.UseFont = true;
            this.txtUser.Size = new System.Drawing.Size(175, 20);
            this.txtUser.TabIndex = 1;
            this.txtUser.Tag = "3";
            // 
            // Label1
            // 
            this.Label1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Appearance.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(23, 33);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(73, 13);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Server Name";
            // 
            // txtPassword
            // 
            this.txtPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::POS.Properties.Settings.Default, "UserPassword", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtPassword.EditValue = "P@$$w0rd";
            this.txtPassword.Location = new System.Drawing.Point(126, 90);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Properties.Appearance.Options.UseFont = true;
            this.txtPassword.Properties.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(175, 20);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Tag = "4";
            // 
            // Label3
            // 
            this.Label3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Appearance.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(23, 63);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(61, 13);
            this.Label3.TabIndex = 7;
            this.Label3.Text = "User Name";
            // 
            // Label4
            // 
            this.Label4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Appearance.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(23, 93);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(54, 13);
            this.Label4.TabIndex = 8;
            this.Label4.Text = "Password";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.labelControl9);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.labelControl11);
            this.groupBox1.Controls.Add(this.btnConnection);
            this.groupBox1.Controls.Add(this.labelControl10);
            this.groupBox1.Controls.Add(this.lblConnection);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.labelControl8);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.btn2);
            this.groupBox1.Controls.Add(this.txtLogFile);
            this.groupBox1.Controls.Add(this.simpleButton4);
            this.groupBox1.Controls.Add(this.labelControl7);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.labelControl6);
            this.groupBox1.Controls.Add(this.txtFolderPath);
            this.groupBox1.Controls.Add(this.txtMDFFile);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.simpleButton2);
            this.groupBox1.Controls.Add(this.btn1);
            this.groupBox1.Controls.Add(this.simpleButton1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txtUser);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.Label3);
            this.groupBox1.Controls.Add(this.DatabaseCombo);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.Label4);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.Label2);
            this.groupBox1.Controls.Add(this.btn3);
            this.groupBox1.Controls.Add(this.Label1);
            this.groupBox1.Controls.Add(this.cmbSVR);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(8, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(595, 564);
            this.groupBox1.TabIndex = 97;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connect to Server";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(7, 144);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(121, 13);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Create New Datebase";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl9.Location = new System.Drawing.Point(235, 252);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(159, 13);
            this.labelControl9.TabIndex = 118;
            this.labelControl9.Text = "Database has been Created.";
            this.labelControl9.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 366);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 21);
            this.textBox1.TabIndex = 117;
            this.textBox1.Text = "SkySysDB";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl11.Location = new System.Drawing.Point(17, 369);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(50, 13);
            this.labelControl11.TabIndex = 116;
            this.labelControl11.Text = "DB Name";
            // 
            // btnConnection
            // 
            this.btnConnection.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnection.Appearance.Options.UseFont = true;
            this.btnConnection.Location = new System.Drawing.Point(94, 116);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(127, 29);
            this.btnConnection.TabIndex = 115;
            this.btnConnection.Tag = "5";
            this.btnConnection.Text = "Connect";
            this.btnConnection.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl10.Location = new System.Drawing.Point(214, 401);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(166, 13);
            this.labelControl10.TabIndex = 8;
            this.labelControl10.Text = "Database has been Attached.";
            this.labelControl10.Visible = false;
            // 
            // lblConnection
            // 
            this.lblConnection.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnection.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblConnection.Location = new System.Drawing.Point(240, 124);
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.Size = new System.Drawing.Size(60, 13);
            this.lblConnection.TabIndex = 8;
            this.lblConnection.Text = "Connected";
            this.lblConnection.Visible = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(302, 29);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 22);
            this.button3.TabIndex = 114;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Location = new System.Drawing.Point(7, 441);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(98, 13);
            this.labelControl8.TabIndex = 112;
            this.labelControl8.Text = "Choose Datebase";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(6, 440);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(582, 10);
            this.groupBox4.TabIndex = 113;
            this.groupBox4.TabStop = false;
            // 
            // btn2
            // 
            this.btn2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Appearance.Options.UseFont = true;
            this.btn2.Enabled = false;
            this.btn2.Location = new System.Drawing.Point(73, 393);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(127, 29);
            this.btn2.TabIndex = 111;
            this.btn2.Tag = "5";
            this.btn2.Text = "Attach Database";
            this.btn2.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // txtLogFile
            // 
            this.txtLogFile.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogFile.Location = new System.Drawing.Point(73, 337);
            this.txtLogFile.Name = "txtLogFile";
            this.txtLogFile.Size = new System.Drawing.Size(487, 21);
            this.txtLogFile.TabIndex = 110;
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.Location = new System.Drawing.Point(561, 335);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(24, 23);
            this.simpleButton4.TabIndex = 109;
            this.simpleButton4.Tag = "5";
            this.simpleButton4.Text = "...";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl7.Location = new System.Drawing.Point(21, 341);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(42, 13);
            this.labelControl7.TabIndex = 108;
            this.labelControl7.Text = "Log File";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(86, 213);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(135, 21);
            this.textBox3.TabIndex = 107;
            this.textBox3.Text = "SkySysDB";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl6.Location = new System.Drawing.Point(12, 216);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(50, 13);
            this.labelControl6.TabIndex = 106;
            this.labelControl6.Text = "DB Name";
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFolderPath.Location = new System.Drawing.Point(102, 186);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.Size = new System.Drawing.Size(455, 21);
            this.txtFolderPath.TabIndex = 105;
            // 
            // txtMDFFile
            // 
            this.txtMDFFile.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMDFFile.Location = new System.Drawing.Point(73, 308);
            this.txtMDFFile.Name = "txtMDFFile";
            this.txtMDFFile.Size = new System.Drawing.Size(487, 21);
            this.txtMDFFile.TabIndex = 104;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(7, 276);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(84, 13);
            this.labelControl3.TabIndex = 102;
            this.labelControl3.Text = "Exist Datebase";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(6, 275);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(582, 10);
            this.groupBox3.TabIndex = 103;
            this.groupBox3.TabStop = false;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Location = new System.Drawing.Point(561, 307);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(24, 23);
            this.simpleButton2.TabIndex = 101;
            this.simpleButton2.Tag = "5";
            this.simpleButton2.Text = "...";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btn1
            // 
            this.btn1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Appearance.Options.UseFont = true;
            this.btn1.Enabled = false;
            this.btn1.Location = new System.Drawing.Point(70, 243);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(153, 27);
            this.btn1.TabIndex = 101;
            this.btn1.Tag = "5";
            this.btn1.Text = "Create New Datebase";
            this.btn1.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(559, 185);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(24, 23);
            this.simpleButton1.TabIndex = 101;
            this.simpleButton1.Tag = "5";
            this.simpleButton1.Text = "...";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(315, 474);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 22);
            this.button2.TabIndex = 99;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Appearance.Options.UseFont = true;
            this.button1.Location = new System.Drawing.Point(194, 520);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 31);
            this.button1.TabIndex = 9;
            this.button1.Tag = "6";
            this.button1.Text = "Cancel";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DatabaseCombo
            // 
            this.DatabaseCombo.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::POS.Properties.Settings.Default, "DataBase", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DatabaseCombo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatabaseCombo.FormattingEnabled = true;
            this.DatabaseCombo.Location = new System.Drawing.Point(102, 475);
            this.DatabaseCombo.Name = "DatabaseCombo";
            this.DatabaseCombo.Size = new System.Drawing.Size(212, 21);
            this.DatabaseCombo.TabIndex = 3;
            this.DatabaseCombo.Tag = "2";
            this.DatabaseCombo.DropDown += new System.EventHandler(this.DatabaseCombo_DropDown);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Location = new System.Drawing.Point(30, 167);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(270, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Please Select Location to Store your New Database Files";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl5.Location = new System.Drawing.Point(6, 189);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(92, 13);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "Folder DataBase";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Location = new System.Drawing.Point(21, 312);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "MDF File";
            // 
            // Label2
            // 
            this.Label2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Appearance.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(27, 478);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(50, 13);
            this.Label2.TabIndex = 6;
            this.Label2.Text = "DB Name";
            // 
            // btn3
            // 
            this.btn3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Appearance.Options.UseFont = true;
            this.btn3.Enabled = false;
            this.btn3.Location = new System.Drawing.Point(70, 520);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(110, 31);
            this.btn3.TabIndex = 4;
            this.btn3.Tag = "5";
            this.btn3.Text = "Connect";
            this.btn3.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // cmbSVR
            // 
            this.cmbSVR.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::POS.Properties.Settings.Default, "ServerName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbSVR.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSVR.FormattingEnabled = true;
            this.cmbSVR.Location = new System.Drawing.Point(126, 30);
            this.cmbSVR.Name = "cmbSVR";
            this.cmbSVR.Size = new System.Drawing.Size(175, 21);
            this.cmbSVR.TabIndex = 0;
            this.cmbSVR.Tag = "1";
            this.cmbSVR.DropDown += new System.EventHandler(this.ServerCombo_DropDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(6, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(582, 10);
            this.groupBox2.TabIndex = 100;
            this.groupBox2.TabStop = false;
            // 
            // FrmConfigServer
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 619);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmConfigServer";
            this.Text = "Configuration Server";
            this.Load += new System.EventHandler(this.FrmConfigServer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }
        internal DevExpress.XtraEditors.TextEdit txtUser;
        private DevExpress.XtraEditors.LabelControl Label1;
        internal DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.LabelControl Label3;
        private DevExpress.XtraEditors.LabelControl Label4;
        internal System.Windows.Forms.ComboBox cmbSVR;
        private GroupBox groupBox1;
        private Button button2;
        private DevExpress.XtraEditors.SimpleButton button1;
        internal ComboBox DatabaseCombo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl Label2;
        private DevExpress.XtraEditors.SimpleButton btn3;
        private GroupBox groupBox2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private GroupBox groupBox3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btn1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private TextBox txtMDFFile;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private TextBox txtFolderPath;
        private TextBox textBox3;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private GroupBox groupBox4;
        private DevExpress.XtraEditors.SimpleButton btn2;
        private TextBox txtLogFile;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private Button button3;
        private DevExpress.XtraEditors.SimpleButton btnConnection;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl lblConnection;
        private TextBox textBox1;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl9;

    }

}
