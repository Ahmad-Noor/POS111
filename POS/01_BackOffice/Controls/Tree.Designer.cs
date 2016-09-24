namespace POS 
{
    partial class Tree
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tree));
            this.TreeList1 = new DevExpress.XtraTreeList.TreeList();
            this.ColCode = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.ColName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.chkMain = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.LblActive = new DevExpress.XtraEditors.LabelControl();
            this.CheckEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TreeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // TreeList1
            // 
            this.TreeList1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TreeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.ColCode,
            this.ColName,
            this.chkMain});
            this.TreeList1.Location = new System.Drawing.Point(0, 0);
            this.TreeList1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TreeList1.Name = "TreeList1";
            this.TreeList1.OptionsView.ShowIndicator = false;
            this.TreeList1.Size = new System.Drawing.Size(232, 257);
            this.TreeList1.TabIndex = 6;
            this.TreeList1.TabStop = false;
            this.TreeList1.GetSelectImage += new DevExpress.XtraTreeList.GetSelectImageEventHandler(this.TreeList1_GetSelectImage);
            this.TreeList1.AfterExpand += new DevExpress.XtraTreeList.NodeEventHandler(this.TreeList1_AfterExpand);
            this.TreeList1.AfterCollapse += new DevExpress.XtraTreeList.NodeEventHandler(this.TreeList1_AfterCollapse);
            this.TreeList1.DoubleClick += new System.EventHandler(this.TreeList1_DoubleClick);
            // 
            // ColCode
            // 
            this.ColCode.AppearanceHeader.Options.UseTextOptions = true;
            this.ColCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColCode.Caption = "الكود";
            this.ColCode.FieldName = "T_Code";
            this.ColCode.Name = "ColCode";
            this.ColCode.OptionsColumn.AllowEdit = false;
            this.ColCode.OptionsColumn.ReadOnly = true;
            this.ColCode.Visible = true;
            this.ColCode.VisibleIndex = 0;
            this.ColCode.Width = 20;
            // 
            // ColName
            // 
            this.ColName.AppearanceHeader.Options.UseTextOptions = true;
            this.ColName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColName.Caption = "الاسم";
            this.ColName.FieldName = "Name";
            this.ColName.Name = "ColName";
            this.ColName.OptionsColumn.AllowEdit = false;
            this.ColName.OptionsColumn.AllowFocus = false;
            this.ColName.OptionsColumn.ReadOnly = true;
            this.ColName.Visible = true;
            this.ColName.VisibleIndex = 1;
            this.ColName.Width = 70;
            // 
            // chkMain
            // 
            this.chkMain.Caption = "TreeListColumn1";
            this.chkMain.FieldName = "Main";
            this.chkMain.Name = "chkMain";
            // 
            // LblActive
            // 
            this.LblActive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LblActive.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.LblActive.Location = new System.Drawing.Point(167, 261);
            this.LblActive.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LblActive.Name = "LblActive";
            this.LblActive.Size = new System.Drawing.Size(37, 17);
            this.LblActive.TabIndex = 5;
            this.LblActive.Text = "تفعيل";
            this.LblActive.Click += new System.EventHandler(this.LblActive_Click);
            // 
            // CheckEdit1
            // 
            this.CheckEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckEdit1.Location = new System.Drawing.Point(202, 258);
            this.CheckEdit1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheckEdit1.Name = "CheckEdit1";
            this.CheckEdit1.Properties.Caption = "";
            this.CheckEdit1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CheckEdit1.Size = new System.Drawing.Size(26, 19);
            this.CheckEdit1.TabIndex = 4;
            this.CheckEdit1.TabStop = false;
            this.CheckEdit1.CheckedChanged += new System.EventHandler(this.CheckEdit1_CheckedChanged);
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "Close.png");
            this.ImageList1.Images.SetKeyName(1, "open.png");
            this.ImageList1.Images.SetKeyName(2, "1327177722_notebook.png");
            // 
            // Tree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LblActive);
            this.Controls.Add(this.TreeList1);
            this.Controls.Add(this.CheckEdit1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Tree";
            this.Size = new System.Drawing.Size(232, 279);
            ((System.ComponentModel.ISupportInitialize)(this.TreeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal DevExpress.XtraTreeList.TreeList TreeList1;
        internal DevExpress.XtraTreeList.Columns.TreeListColumn ColCode;
        internal DevExpress.XtraTreeList.Columns.TreeListColumn ColName;
        internal DevExpress.XtraTreeList.Columns.TreeListColumn chkMain;
        internal DevExpress.XtraEditors.LabelControl LblActive;
        internal DevExpress.XtraEditors.CheckEdit CheckEdit1;
        internal System.Windows.Forms.ImageList ImageList1;

    }
}
