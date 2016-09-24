namespace POS
{
    partial class frmPOS_ShiftsTransaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPOS_ShiftsTransaction));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.btnFirst = new DevExpress.XtraBars.BarButtonItem();
            this.btnNext = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrevious = new DevExpress.XtraBars.BarButtonItem();
            this.btnLast = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem13 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem14 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem15 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem16 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem17 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem18 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem19 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem20 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.barButtonItem21 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem22 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem23 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem24 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_AddNew = new DevExpress.XtraBars.BarButtonItem();
            this.btnCopy = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "نوع الوردية";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(4, 180);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(839, 313);
            this.gridControl1.TabIndex = 143;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl3.Location = new System.Drawing.Point(10, 159);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(27, 13);
            this.labelControl3.TabIndex = 161;
            this.labelControl3.Text = "Date:";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "dd-MM-yyyy";
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(41, 154);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 0);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(91, 20);
            this.dtpFromDate.TabIndex = 162;
            // 
            // btnFirst
            // 
            this.btnFirst.Glyph = ((System.Drawing.Image)(resources.GetObject("btnFirst.Glyph")));
            this.btnFirst.Id = 1;
            this.btnFirst.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnFirst.LargeGlyph")));
            this.btnFirst.Name = "btnFirst";
            // 
            // btnNext
            // 
            this.btnNext.Glyph = ((System.Drawing.Image)(resources.GetObject("btnNext.Glyph")));
            this.btnNext.Id = 2;
            this.btnNext.Name = "btnNext";
            // 
            // btnPrevious
            // 
            this.btnPrevious.Glyph = ((System.Drawing.Image)(resources.GetObject("btnPrevious.Glyph")));
            this.btnPrevious.Id = 3;
            this.btnPrevious.Name = "btnPrevious";
            // 
            // btnLast
            // 
            this.btnLast.Glyph = ((System.Drawing.Image)(resources.GetObject("btnLast.Glyph")));
            this.btnLast.Id = 4;
            this.btnLast.Name = "btnLast";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.LargeGlyph")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.Glyph")));
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.Glyph")));
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.Glyph")));
            this.barButtonItem4.Id = 4;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.Glyph")));
            this.barButtonItem5.Id = 1;
            this.barButtonItem5.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.LargeGlyph")));
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.Glyph")));
            this.barButtonItem6.Id = 2;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.Glyph")));
            this.barButtonItem7.Id = 3;
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.Glyph")));
            this.barButtonItem8.Id = 4;
            this.barButtonItem8.Name = "barButtonItem8";
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem9.Glyph")));
            this.barButtonItem9.Id = 1;
            this.barButtonItem9.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem9.LargeGlyph")));
            this.barButtonItem9.Name = "barButtonItem9";
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem10.Glyph")));
            this.barButtonItem10.Id = 2;
            this.barButtonItem10.Name = "barButtonItem10";
            // 
            // barButtonItem11
            // 
            this.barButtonItem11.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem11.Glyph")));
            this.barButtonItem11.Id = 3;
            this.barButtonItem11.Name = "barButtonItem11";
            // 
            // barButtonItem12
            // 
            this.barButtonItem12.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem12.Glyph")));
            this.barButtonItem12.Id = 4;
            this.barButtonItem12.Name = "barButtonItem12";
            // 
            // barButtonItem13
            // 
            this.barButtonItem13.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem13.Glyph")));
            this.barButtonItem13.Id = 1;
            this.barButtonItem13.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem13.LargeGlyph")));
            this.barButtonItem13.Name = "barButtonItem13";
            // 
            // barButtonItem14
            // 
            this.barButtonItem14.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem14.Glyph")));
            this.barButtonItem14.Id = 2;
            this.barButtonItem14.Name = "barButtonItem14";
            // 
            // barButtonItem15
            // 
            this.barButtonItem15.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem15.Glyph")));
            this.barButtonItem15.Id = 3;
            this.barButtonItem15.Name = "barButtonItem15";
            // 
            // barButtonItem16
            // 
            this.barButtonItem16.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem16.Glyph")));
            this.barButtonItem16.Id = 4;
            this.barButtonItem16.Name = "barButtonItem16";
            // 
            // barButtonItem17
            // 
            this.barButtonItem17.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem17.Glyph")));
            this.barButtonItem17.Id = 1;
            this.barButtonItem17.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem17.LargeGlyph")));
            this.barButtonItem17.Name = "barButtonItem17";
            // 
            // barButtonItem18
            // 
            this.barButtonItem18.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem18.Glyph")));
            this.barButtonItem18.Id = 2;
            this.barButtonItem18.Name = "barButtonItem18";
            // 
            // barButtonItem19
            // 
            this.barButtonItem19.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem19.Glyph")));
            this.barButtonItem19.Id = 3;
            this.barButtonItem19.Name = "barButtonItem19";
            // 
            // barButtonItem20
            // 
            this.barButtonItem20.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem20.Glyph")));
            this.barButtonItem20.Id = 4;
            this.barButtonItem20.Name = "barButtonItem20";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.barButtonItem21);
            this.ribbonStatusBar1.ItemLinks.Add(this.barButtonItem22);
            this.ribbonStatusBar1.ItemLinks.Add(this.barButtonItem23);
            this.ribbonStatusBar1.ItemLinks.Add(this.barButtonItem24);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 507);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(844, 27);
            // 
            // barButtonItem21
            // 
            this.barButtonItem21.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem21.Glyph")));
            this.barButtonItem21.Id = 1;
            this.barButtonItem21.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem21.LargeGlyph")));
            this.barButtonItem21.Name = "barButtonItem21";
            // 
            // barButtonItem22
            // 
            this.barButtonItem22.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem22.Glyph")));
            this.barButtonItem22.Id = 2;
            this.barButtonItem22.Name = "barButtonItem22";
            // 
            // barButtonItem23
            // 
            this.barButtonItem23.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem23.Glyph")));
            this.barButtonItem23.Id = 3;
            this.barButtonItem23.Name = "barButtonItem23";
            // 
            // barButtonItem24
            // 
            this.barButtonItem24.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem24.Glyph")));
            this.barButtonItem24.Id = 4;
            this.barButtonItem24.Name = "barButtonItem24";
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
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 1;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(844, 141);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Above;
            // 
            // btn_AddNew
            // 
            this.btn_AddNew.Caption = "Clear";
            this.btn_AddNew.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_AddNew.Glyph")));
            this.btn_AddNew.GlyphDisabled = ((System.Drawing.Image)(resources.GetObject("btn_AddNew.GlyphDisabled")));
            this.btn_AddNew.Id = 1;
            this.btn_AddNew.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btn_AddNew.LargeGlyph")));
            this.btn_AddNew.LargeGlyphDisabled = ((System.Drawing.Image)(resources.GetObject("btn_AddNew.LargeGlyphDisabled")));
            this.btn_AddNew.Name = "btn_AddNew";
            // 
            // btnCopy
            // 
            this.btnCopy.Caption = "Copy";
            this.btnCopy.Glyph = ((System.Drawing.Image)(resources.GetObject("btnCopy.Glyph")));
            this.btnCopy.Id = 2;
            this.btnCopy.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnCopy.LargeGlyph")));
            this.btnCopy.Name = "btnCopy";
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Save";
            this.btnSave.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSave.Glyph")));
            this.btnSave.Id = 3;
            this.btnSave.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnSave.LargeGlyph")));
            this.btnSave.Name = "btnSave";
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Delete";
            this.btnDelete.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDelete.Glyph")));
            this.btnDelete.Id = 4;
            this.btnDelete.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDelete.LargeGlyph")));
            this.btnDelete.Name = "btnDelete";
            // 
            // btnClose
            // 
            this.btnClose.Caption = "Close";
            this.btnClose.Glyph = ((System.Drawing.Image)(resources.GetObject("btnClose.Glyph")));
            this.btnClose.Id = 5;
            this.btnClose.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnClose.LargeGlyph")));
            this.btnClose.Name = "btnClose";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Main";
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
            // frmPOS_ShiftsTransaction
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmPOS_ShiftsTransaction";
            this.Size = new System.Drawing.Size(844, 534);
            this.Load += new System.EventHandler(this.frmShifts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private DevExpress.XtraBars.BarButtonItem btnFirst;
        private DevExpress.XtraBars.BarButtonItem btnNext;
        private DevExpress.XtraBars.BarButtonItem btnPrevious;
        private DevExpress.XtraBars.BarButtonItem btnLast;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.BarButtonItem barButtonItem11;
        private DevExpress.XtraBars.BarButtonItem barButtonItem12;
        private DevExpress.XtraBars.BarButtonItem barButtonItem13;
        private DevExpress.XtraBars.BarButtonItem barButtonItem14;
        private DevExpress.XtraBars.BarButtonItem barButtonItem15;
        private DevExpress.XtraBars.BarButtonItem barButtonItem16;
        private DevExpress.XtraBars.BarButtonItem barButtonItem17;
        private DevExpress.XtraBars.BarButtonItem barButtonItem18;
        private DevExpress.XtraBars.BarButtonItem barButtonItem19;
        private DevExpress.XtraBars.BarButtonItem barButtonItem20;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem21;
        private DevExpress.XtraBars.BarButtonItem barButtonItem22;
        private DevExpress.XtraBars.BarButtonItem barButtonItem23;
        private DevExpress.XtraBars.BarButtonItem barButtonItem24;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btn_AddNew;
        private DevExpress.XtraBars.BarButtonItem btnCopy;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
    }
}