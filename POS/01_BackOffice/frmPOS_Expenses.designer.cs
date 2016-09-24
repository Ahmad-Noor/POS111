namespace POS
{
    partial class frmPOS_Expenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPOS_Expenses));
            this.lblNote = new DevExpress.XtraEditors.LabelControl();
            this.txtNote = new DevExpress.XtraEditors.MemoEdit();
            this.txtExpensTypeCode = new DevExpress.XtraEditors.TextEdit();
            this.LookUpxpensType = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblExpensTypeName = new DevExpress.XtraEditors.LabelControl();
            this.lblUserCreate = new DevExpress.XtraEditors.LabelControl();
            this.lblUserLastModified = new DevExpress.XtraEditors.LabelControl();
            this.lbllblUserLastModifiedDate = new DevExpress.XtraEditors.LabelControl();
            this.lblUserCreateDate = new DevExpress.XtraEditors.LabelControl();
            this.txtAmount = new System.Windows.Forms.NumericUpDown();
            this.lblAmount = new DevExpress.XtraEditors.LabelControl();
            this.lblOrderNo = new DevExpress.XtraEditors.LabelControl();
            this.LookUp = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtOrderNo = new DevExpress.XtraEditors.LabelControl();
            this.hyperlinkLabelControl1 = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_AddNew = new DevExpress.XtraBars.BarButtonItem();
            this.btnCopy = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.btnFirst = new DevExpress.XtraBars.BarButtonItem();
            this.btnNext = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrevious = new DevExpress.XtraBars.BarButtonItem();
            this.btnLast = new DevExpress.XtraBars.BarButtonItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExpensTypeCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpxpensType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNote
            // 
            this.lblNote.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("lblNote.Appearance.BackColor")));
            this.lblNote.Appearance.ForeColor = ((System.Drawing.Color)(resources.GetObject("lblNote.Appearance.ForeColor")));
            resources.ApplyResources(this.lblNote, "lblNote");
            this.lblNote.Name = "lblNote";
            // 
            // txtNote
            // 
            resources.ApplyResources(this.txtNote, "txtNote");
            this.txtNote.Name = "txtNote";
            this.txtNote.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("txtNote.Properties.Appearance.Font")));
            this.txtNote.Properties.Appearance.Options.UseFont = true;
            this.txtNote.Tag = "";
            // 
            // txtExpensTypeCode
            // 
            resources.ApplyResources(this.txtExpensTypeCode, "txtExpensTypeCode");
            this.txtExpensTypeCode.Name = "txtExpensTypeCode";
            this.txtExpensTypeCode.Properties.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("txtExpensTypeCode.Properties.Appearance.BackColor")));
            this.txtExpensTypeCode.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("txtExpensTypeCode.Properties.Appearance.Font")));
            this.txtExpensTypeCode.Properties.Appearance.Options.UseBackColor = true;
            this.txtExpensTypeCode.Properties.Appearance.Options.UseFont = true;
            this.txtExpensTypeCode.Tag = "";
            this.txtExpensTypeCode.Validated += new System.EventHandler(this.txtExpensTypeCode_Validated);
            // 
            // LookUpxpensType
            // 
            resources.ApplyResources(this.LookUpxpensType, "LookUpxpensType");
            this.LookUpxpensType.Name = "LookUpxpensType";
            this.LookUpxpensType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("LookUpxpensType.Properties.Buttons"))))});
            this.LookUpxpensType.Properties.NullText = resources.GetString("LookUpxpensType.Properties.NullText");
            this.LookUpxpensType.Properties.View = this.searchLookUpEdit1View;
            this.LookUpxpensType.EditValueChanged += new System.EventHandler(this.searchLookUpEdit1_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("labelControl1.Appearance.BackColor")));
            this.labelControl1.Appearance.ForeColor = ((System.Drawing.Color)(resources.GetObject("labelControl1.Appearance.ForeColor")));
            resources.ApplyResources(this.labelControl1, "labelControl1");
            this.labelControl1.Name = "labelControl1";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("labelControl2.Appearance.BackColor")));
            this.labelControl2.Appearance.ForeColor = ((System.Drawing.Color)(resources.GetObject("labelControl2.Appearance.ForeColor")));
            resources.ApplyResources(this.labelControl2, "labelControl2");
            this.labelControl2.Name = "labelControl2";
            // 
            // lblExpensTypeName
            // 
            this.lblExpensTypeName.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("lblExpensTypeName.Appearance.BackColor")));
            this.lblExpensTypeName.Appearance.ForeColor = ((System.Drawing.Color)(resources.GetObject("lblExpensTypeName.Appearance.ForeColor")));
            resources.ApplyResources(this.lblExpensTypeName, "lblExpensTypeName");
            this.lblExpensTypeName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.lblExpensTypeName.Name = "lblExpensTypeName";
            // 
            // lblUserCreate
            // 
            this.lblUserCreate.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("lblUserCreate.Appearance.BackColor")));
            this.lblUserCreate.Appearance.ForeColor = ((System.Drawing.Color)(resources.GetObject("lblUserCreate.Appearance.ForeColor")));
            resources.ApplyResources(this.lblUserCreate, "lblUserCreate");
            this.lblUserCreate.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.lblUserCreate.Name = "lblUserCreate";
            // 
            // lblUserLastModified
            // 
            this.lblUserLastModified.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("lblUserLastModified.Appearance.BackColor")));
            this.lblUserLastModified.Appearance.ForeColor = ((System.Drawing.Color)(resources.GetObject("lblUserLastModified.Appearance.ForeColor")));
            resources.ApplyResources(this.lblUserLastModified, "lblUserLastModified");
            this.lblUserLastModified.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.lblUserLastModified.Name = "lblUserLastModified";
            // 
            // lbllblUserLastModifiedDate
            // 
            this.lbllblUserLastModifiedDate.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("lbllblUserLastModifiedDate.Appearance.BackColor")));
            this.lbllblUserLastModifiedDate.Appearance.ForeColor = ((System.Drawing.Color)(resources.GetObject("lbllblUserLastModifiedDate.Appearance.ForeColor")));
            resources.ApplyResources(this.lbllblUserLastModifiedDate, "lbllblUserLastModifiedDate");
            this.lbllblUserLastModifiedDate.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.lbllblUserLastModifiedDate.Name = "lbllblUserLastModifiedDate";
            // 
            // lblUserCreateDate
            // 
            this.lblUserCreateDate.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("lblUserCreateDate.Appearance.BackColor")));
            this.lblUserCreateDate.Appearance.ForeColor = ((System.Drawing.Color)(resources.GetObject("lblUserCreateDate.Appearance.ForeColor")));
            resources.ApplyResources(this.lblUserCreateDate, "lblUserCreateDate");
            this.lblUserCreateDate.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.lblUserCreateDate.Name = "lblUserCreateDate";
            // 
            // txtAmount
            // 
            this.txtAmount.DecimalPlaces = 2;
            resources.ApplyResources(this.txtAmount, "txtAmount");
            this.txtAmount.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.txtAmount.Name = "txtAmount";
            // 
            // lblAmount
            // 
            this.lblAmount.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("lblAmount.Appearance.BackColor")));
            this.lblAmount.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("lblAmount.Appearance.Font")));
            this.lblAmount.Appearance.ForeColor = ((System.Drawing.Color)(resources.GetObject("lblAmount.Appearance.ForeColor")));
            resources.ApplyResources(this.lblAmount, "lblAmount");
            this.lblAmount.Name = "lblAmount";
            // 
            // lblOrderNo
            // 
            this.lblOrderNo.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("lblOrderNo.Appearance.BackColor")));
            this.lblOrderNo.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("lblOrderNo.Appearance.Font")));
            this.lblOrderNo.Appearance.ForeColor = ((System.Drawing.Color)(resources.GetObject("lblOrderNo.Appearance.ForeColor")));
            resources.ApplyResources(this.lblOrderNo, "lblOrderNo");
            this.lblOrderNo.Name = "lblOrderNo";
            // 
            // LookUp
            // 
            resources.ApplyResources(this.LookUp, "LookUp");
            this.LookUp.Name = "LookUp";
            this.LookUp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("LookUp.Properties.Buttons"))))});
            this.LookUp.Properties.NullText = resources.GetString("LookUp.Properties.NullText");
            this.LookUp.Properties.View = this.gridView1;
            this.LookUp.EditValueChanged += new System.EventHandler(this.LookUp_EditValueChanged);
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // txtOrderNo
            // 
            this.txtOrderNo.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("txtOrderNo.Appearance.BackColor")));
            this.txtOrderNo.Appearance.ForeColor = ((System.Drawing.Color)(resources.GetObject("txtOrderNo.Appearance.ForeColor")));
            resources.ApplyResources(this.txtOrderNo, "txtOrderNo");
            this.txtOrderNo.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.txtOrderNo.Name = "txtOrderNo";
            // 
            // hyperlinkLabelControl1
            // 
            this.hyperlinkLabelControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.hyperlinkLabelControl1, "hyperlinkLabelControl1");
            this.hyperlinkLabelControl1.Name = "hyperlinkLabelControl1";
            this.hyperlinkLabelControl1.Click += new System.EventHandler(this.hyperlinkLabelControl1_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lblUserLastModified);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.lblUserCreate);
            this.groupControl1.Controls.Add(this.lblUserCreateDate);
            this.groupControl1.Controls.Add(this.lbllblUserLastModifiedDate);
            resources.ApplyResources(this.groupControl1, "groupControl1");
            this.groupControl1.Name = "groupControl1";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btn_AddNew,
            this.btnCopy,
            this.btnSave,
            this.btnDelete,
            this.btnClose});
            resources.ApplyResources(this.ribbonControl1, "ribbonControl1");
            this.ribbonControl1.MaxItemId = 1;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Above;
            // 
            // btn_AddNew
            // 
            resources.ApplyResources(this.btn_AddNew, "btn_AddNew");
            this.btn_AddNew.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_AddNew.Glyph")));
            this.btn_AddNew.GlyphDisabled = ((System.Drawing.Image)(resources.GetObject("btn_AddNew.GlyphDisabled")));
            this.btn_AddNew.Id = 1;
            this.btn_AddNew.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btn_AddNew.LargeGlyph")));
            this.btn_AddNew.LargeGlyphDisabled = ((System.Drawing.Image)(resources.GetObject("btn_AddNew.LargeGlyphDisabled")));
            this.btn_AddNew.Name = "btn_AddNew";
            this.btn_AddNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_AddNew_ItemClick);
            // 
            // btnCopy
            // 
            resources.ApplyResources(this.btnCopy, "btnCopy");
            this.btnCopy.Glyph = ((System.Drawing.Image)(resources.GetObject("btnCopy.Glyph")));
            this.btnCopy.Id = 2;
            this.btnCopy.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnCopy.LargeGlyph")));
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCopy_ItemClick);
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSave.Glyph")));
            this.btnSave.Id = 3;
            this.btnSave.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnSave.LargeGlyph")));
            this.btnSave.Name = "btnSave";
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDelete.Glyph")));
            this.btnDelete.Id = 4;
            this.btnDelete.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDelete.LargeGlyph")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.Glyph = ((System.Drawing.Image)(resources.GetObject("btnClose.Glyph")));
            this.btnClose.Id = 5;
            this.btnClose.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnClose.LargeGlyph")));
            this.btnClose.Name = "btnClose";
            this.btnClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClose_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            resources.ApplyResources(this.ribbonPage1, "ribbonPage1");
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_AddNew);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCopy);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSave);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDelete);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnClose);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.btnFirst);
            this.ribbonStatusBar1.ItemLinks.Add(this.btnNext);
            this.ribbonStatusBar1.ItemLinks.Add(this.btnPrevious);
            this.ribbonStatusBar1.ItemLinks.Add(this.btnLast);
            resources.ApplyResources(this.ribbonStatusBar1, "ribbonStatusBar1");
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            // 
            // btnFirst
            // 
            this.btnFirst.Glyph = ((System.Drawing.Image)(resources.GetObject("btnFirst.Glyph")));
            this.btnFirst.Id = 1;
            this.btnFirst.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnFirst.LargeGlyph")));
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFirst_ItemClick);
            // 
            // btnNext
            // 
            this.btnNext.Glyph = ((System.Drawing.Image)(resources.GetObject("btnNext.Glyph")));
            this.btnNext.Id = 2;
            this.btnNext.Name = "btnNext";
            this.btnNext.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNext_ItemClick);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Glyph = ((System.Drawing.Image)(resources.GetObject("btnPrevious.Glyph")));
            this.btnPrevious.Id = 3;
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrevious_ItemClick);
            // 
            // btnLast
            // 
            this.btnLast.Glyph = ((System.Drawing.Image)(resources.GetObject("btnLast.Glyph")));
            this.btnLast.Id = 4;
            this.btnLast.Name = "btnLast";
            this.btnLast.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLast_ItemClick);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.ribbonStatusBar1);
            this.panelControl1.Controls.Add(this.lblOrderNo);
            this.panelControl1.Controls.Add(this.txtNote);
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Controls.Add(this.lblNote);
            this.panelControl1.Controls.Add(this.hyperlinkLabelControl1);
            this.panelControl1.Controls.Add(this.txtExpensTypeCode);
            this.panelControl1.Controls.Add(this.txtOrderNo);
            this.panelControl1.Controls.Add(this.LookUpxpensType);
            this.panelControl1.Controls.Add(this.LookUp);
            this.panelControl1.Controls.Add(this.lblExpensTypeName);
            this.panelControl1.Controls.Add(this.lblAmount);
            this.panelControl1.Controls.Add(this.txtAmount);
            resources.ApplyResources(this.panelControl1, "panelControl1");
            this.panelControl1.Name = "panelControl1";
            // 
            // frmPOS_Expenses
            // 
            this.Appearance.Options.UseBackColor = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "frmPOS_Expenses";
            this.Load += new System.EventHandler(this.frmPOS_Expenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExpensTypeCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpxpensType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblNote;
        private DevExpress.XtraEditors.MemoEdit txtNote;
        internal DevExpress.XtraEditors.TextEdit txtExpensTypeCode;
        private DevExpress.XtraEditors.SearchLookUpEdit LookUpxpensType;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblExpensTypeName;
        private DevExpress.XtraEditors.LabelControl lblUserCreate;
        private DevExpress.XtraEditors.LabelControl lblUserLastModified;
        private DevExpress.XtraEditors.LabelControl lbllblUserLastModifiedDate;
        private DevExpress.XtraEditors.LabelControl lblUserCreateDate;
        private System.Windows.Forms.NumericUpDown txtAmount;
        private DevExpress.XtraEditors.LabelControl lblAmount;
        private DevExpress.XtraEditors.LabelControl lblOrderNo;
        private DevExpress.XtraEditors.SearchLookUpEdit LookUp;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl txtOrderNo;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkLabelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btn_AddNew;
        private DevExpress.XtraBars.BarButtonItem btnCopy;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.BarButtonItem btnFirst;
        private DevExpress.XtraBars.BarButtonItem btnNext;
        private DevExpress.XtraBars.BarButtonItem btnPrevious;
        private DevExpress.XtraBars.BarButtonItem btnLast;
    }
}