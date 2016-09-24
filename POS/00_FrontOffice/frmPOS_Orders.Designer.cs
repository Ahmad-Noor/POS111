using System.Drawing;
using POS.Forms;

namespace POS
{
    partial class frmPOS_Orders
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.pnlItems = new System.Windows.Forms.FlowLayoutPanel();
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.pnlPOS_ItemsCategories = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TreeItems = new DevExpress.XtraTreeList.TreeList();
            this.colID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colItemID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colSizeID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colQty = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colItemName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colNote = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.colPrice = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.Discount = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.PriceValue = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colisPrint = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colisDelete = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colDeleterow = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.btnDeleteRow = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colServicePerantID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.btnRefund = new DevExpress.XtraEditors.SimpleButton();
            this.btnVoid = new DevExpress.XtraEditors.SimpleButton();
            this.btnDiscount = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.cmbOrderType = new System.Windows.Forms.ComboBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpDelivery = new DevExpress.XtraEditors.LookUpEdit();
            this.txtNote = new DevExpress.XtraEditors.MemoEdit();
            this.btnSplitCheck = new DevExpress.XtraEditors.SimpleButton();
            this.pnlSizes = new System.Windows.Forms.FlowLayoutPanel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.lblDeliveryFees = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblItemsCount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCustomerTel = new System.Windows.Forms.TextBox();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.simpleButton8 = new DevExpress.XtraEditors.SimpleButton();
            this.lookUpTables = new DevExpress.XtraEditors.LookUpEdit();
            this.lblTotalNet = new System.Windows.Forms.Label();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.LookUpOrders = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtOrderNo = new DevExpress.XtraEditors.TextEdit();
            this.LookUpCustomers = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lblCustomerName = new DevExpress.XtraEditors.LabelControl();
            this.btnExpenses = new DevExpress.XtraEditors.SimpleButton();
            this.panelNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TreeItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpDelivery.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpTables.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpOrders.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpCustomers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlItems
            // 
            this.pnlItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlItems.BackColor = System.Drawing.Color.Transparent;
            this.pnlItems.Location = new System.Drawing.Point(639, 65);
            this.pnlItems.Name = "pnlItems";
            this.pnlItems.Size = new System.Drawing.Size(556, 727);
            this.pnlItems.TabIndex = 0;
            // 
            // panelNavigation
            // 
            this.panelNavigation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelNavigation.BackColor = System.Drawing.Color.White;
            this.panelNavigation.Controls.Add(this.buttonLeft);
            this.panelNavigation.Controls.Add(this.buttonRight);
            this.panelNavigation.Controls.Add(this.pnlPOS_ItemsCategories);
            this.panelNavigation.Location = new System.Drawing.Point(555, 0);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(640, 64);
            this.panelNavigation.TabIndex = 4;
            this.panelNavigation.TabStop = true;
            // 
            // buttonLeft
            // 
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLeft.Location = new System.Drawing.Point(2, 1);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(36, 61);
            this.buttonLeft.TabIndex = 0;
            this.buttonLeft.Text = "<";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRight.Location = new System.Drawing.Point(604, 1);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(36, 61);
            this.buttonRight.TabIndex = 2;
            this.buttonRight.Text = ">";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // pnlPOS_ItemsCategories
            // 
            this.pnlPOS_ItemsCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPOS_ItemsCategories.Location = new System.Drawing.Point(39, 2);
            this.pnlPOS_ItemsCategories.Margin = new System.Windows.Forms.Padding(0);
            this.pnlPOS_ItemsCategories.Name = "pnlPOS_ItemsCategories";
            this.pnlPOS_ItemsCategories.Size = new System.Drawing.Size(564, 59);
            this.pnlPOS_ItemsCategories.TabIndex = 1;
            this.pnlPOS_ItemsCategories.TabStop = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(-1, 683);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Net Total :";
            // 
            // TreeItems
            // 
            this.TreeItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TreeItems.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colID,
            this.colItemID,
            this.colSizeID,
            this.colQty,
            this.colItemName,
            this.colNote,
            this.colPrice,
            this.Discount,
            this.PriceValue,
            this.colisPrint,
            this.colisDelete,
            this.colDeleterow,
            this.colServicePerantID});
            this.TreeItems.Location = new System.Drawing.Point(2, 127);
            this.TreeItems.Name = "TreeItems";
            this.TreeItems.OptionsView.EnableAppearanceOddRow = true;
            this.TreeItems.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnDeleteRow,
            this.repositoryItemSpinEdit1,
            this.repositoryItemMemoEdit1});
            this.TreeItems.RowHeight = 50;
            this.TreeItems.Size = new System.Drawing.Size(552, 365);
            this.TreeItems.TabIndex = 183;
            this.TreeItems.NodeCellStyle += new DevExpress.XtraTreeList.GetCustomNodeCellStyleEventHandler(this.TreeItems_NodeCellStyle);
            this.TreeItems.BeforeFocusNode += new DevExpress.XtraTreeList.BeforeFocusNodeEventHandler(this.TreeItems_BeforeFocusNode);
            this.TreeItems.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.TreeItems_ShowingEditor);
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Width = 20;
            // 
            // colItemID
            // 
            this.colItemID.Caption = "ItemID";
            this.colItemID.FieldName = "ItemID";
            this.colItemID.Name = "colItemID";
            // 
            // colSizeID
            // 
            this.colSizeID.Caption = "Size ID";
            this.colSizeID.FieldName = "SizeID";
            this.colSizeID.Name = "colSizeID";
            this.colSizeID.Width = 68;
            // 
            // colQty
            // 
            this.colQty.Caption = "Qty";
            this.colQty.ColumnEdit = this.repositoryItemSpinEdit1;
            this.colQty.FieldName = "Qty";
            this.colQty.MinWidth = 33;
            this.colQty.Name = "colQty";
            this.colQty.Visible = true;
            this.colQty.VisibleIndex = 0;
            this.colQty.Width = 44;
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // colItemName
            // 
            this.colItemName.Caption = "Item Name";
            this.colItemName.FieldName = "ItemName";
            this.colItemName.Name = "colItemName";
            this.colItemName.OptionsColumn.AllowEdit = false;
            this.colItemName.Visible = true;
            this.colItemName.VisibleIndex = 1;
            this.colItemName.Width = 175;
            // 
            // colNote
            // 
            this.colNote.Caption = "Note";
            this.colNote.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colNote.FieldName = "Note";
            this.colNote.Name = "colNote";
            this.colNote.Visible = true;
            this.colNote.VisibleIndex = 2;
            this.colNote.Width = 97;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // colPrice
            // 
            this.colPrice.Caption = "Price";
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.OptionsColumn.AllowEdit = false;
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 3;
            this.colPrice.Width = 47;
            // 
            // Discount
            // 
            this.Discount.Caption = "Discount";
            this.Discount.FieldName = "Discount";
            this.Discount.Name = "Discount";
            this.Discount.Visible = true;
            this.Discount.VisibleIndex = 4;
            this.Discount.Width = 51;
            // 
            // PriceValue
            // 
            this.PriceValue.Caption = "Value";
            this.PriceValue.FieldName = "PriceValue";
            this.PriceValue.Name = "PriceValue";
            this.PriceValue.Visible = true;
            this.PriceValue.VisibleIndex = 5;
            this.PriceValue.Width = 69;
            // 
            // colisPrint
            // 
            this.colisPrint.Caption = "isPrint";
            this.colisPrint.FieldName = "isPrint";
            this.colisPrint.Name = "colisPrint";
            this.colisPrint.Width = 77;
            // 
            // colisDelete
            // 
            this.colisDelete.Caption = "isDelete";
            this.colisDelete.FieldName = "isDelete";
            this.colisDelete.Name = "colisDelete";
            this.colisDelete.Width = 25;
            // 
            // colDeleterow
            // 
            this.colDeleterow.Caption = "Delete Item";
            this.colDeleterow.ColumnEdit = this.btnDeleteRow;
            this.colDeleterow.FieldName = "Deleterow";
            this.colDeleterow.ImageIndex = 3;
            this.colDeleterow.Name = "colDeleterow";
            this.colDeleterow.Visible = true;
            this.colDeleterow.VisibleIndex = 6;
            this.colDeleterow.Width = 49;
            // 
            // btnDeleteRow
            // 
            this.btnDeleteRow.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::POS.Properties.Resources.DeleteRed, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.btnDeleteRow.Name = "btnDeleteRow";
            this.btnDeleteRow.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnDeleteRow.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnDeleteRow_ButtonClick);
            // 
            // colServicePerantID
            // 
            this.colServicePerantID.Caption = "ServicePerantID";
            this.colServicePerantID.FieldName = "ServicePerantID";
            this.colServicePerantID.Name = "colServicePerantID";
            this.colServicePerantID.Width = 77;
            // 
            // btnRefund
            // 
            this.btnRefund.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefund.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefund.Appearance.Options.UseFont = true;
            this.btnRefund.Appearance.Options.UseTextOptions = true;
            this.btnRefund.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnRefund.Location = new System.Drawing.Point(208, 492);
            this.btnRefund.Name = "btnRefund";
            this.btnRefund.Size = new System.Drawing.Size(69, 62);
            this.btnRefund.TabIndex = 154;
            this.btnRefund.Text = "Refund";
            // 
            // btnVoid
            // 
            this.btnVoid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVoid.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoid.Appearance.Options.UseFont = true;
            this.btnVoid.Appearance.Options.UseTextOptions = true;
            this.btnVoid.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnVoid.Location = new System.Drawing.Point(415, 492);
            this.btnVoid.Name = "btnVoid";
            this.btnVoid.Size = new System.Drawing.Size(69, 62);
            this.btnVoid.TabIndex = 155;
            this.btnVoid.Text = "Void";
            // 
            // btnDiscount
            // 
            this.btnDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDiscount.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscount.Appearance.Options.UseFont = true;
            this.btnDiscount.Appearance.Options.UseTextOptions = true;
            this.btnDiscount.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnDiscount.Location = new System.Drawing.Point(138, 492);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(70, 62);
            this.btnDiscount.TabIndex = 157;
            this.btnDiscount.Text = "Discount";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.Appearance.Options.UseTextOptions = true;
            this.simpleButton3.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.simpleButton3.Location = new System.Drawing.Point(208, 718);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(69, 74);
            this.simpleButton3.TabIndex = 156;
            this.simpleButton3.Text = "Open Drawer";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClear.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Appearance.Options.UseFont = true;
            this.btnClear.Appearance.Options.UseTextOptions = true;
            this.btnClear.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnClear.Location = new System.Drawing.Point(1, 492);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(68, 62);
            this.btnClear.TabIndex = 159;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrint.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Appearance.Options.UseFont = true;
            this.btnPrint.Appearance.Options.UseTextOptions = true;
            this.btnPrint.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnPrint.Location = new System.Drawing.Point(69, 492);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(69, 62);
            this.btnPrint.TabIndex = 158;
            this.btnPrint.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 576);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Total:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 596);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tax:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 616);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Discount:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 637);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Service:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(-1, 657);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Delivery Fees:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Location = new System.Drawing.Point(6, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 12);
            this.labelControl1.TabIndex = 160;
            this.labelControl1.Text = "Order No.:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl3.Location = new System.Drawing.Point(265, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(43, 12);
            this.labelControl3.TabIndex = 160;
            this.labelControl3.Text = "Time do:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl4.Location = new System.Drawing.Point(6, 25);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(61, 12);
            this.labelControl4.TabIndex = 160;
            this.labelControl4.Text = "Order Type:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl5.Location = new System.Drawing.Point(6, 48);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(54, 12);
            this.labelControl5.TabIndex = 160;
            this.labelControl5.Text = "Customer :";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl6.Location = new System.Drawing.Point(276, 27);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(31, 12);
            this.labelControl6.TabIndex = 160;
            this.labelControl6.Text = "Table:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl7.Location = new System.Drawing.Point(6, 88);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(49, 12);
            this.labelControl7.TabIndex = 160;
            this.labelControl7.Text = "Delivery :";
            // 
            // dtpTime
            // 
            this.dtpTime.Checked = false;
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(314, 2);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowCheckBox = true;
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(112, 21);
            this.dtpTime.TabIndex = 163;
            // 
            // cmbOrderType
            // 
            this.cmbOrderType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrderType.FormattingEnabled = true;
            this.cmbOrderType.Location = new System.Drawing.Point(73, 21);
            this.cmbOrderType.Name = "cmbOrderType";
            this.cmbOrderType.Size = new System.Drawing.Size(199, 21);
            this.cmbOrderType.TabIndex = 164;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl8.Location = new System.Drawing.Point(6, 110);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(29, 12);
            this.labelControl8.TabIndex = 160;
            this.labelControl8.Text = "Note :";
            // 
            // lookUpDelivery
            // 
            this.lookUpDelivery.Location = new System.Drawing.Point(73, 84);
            this.lookUpDelivery.Name = "lookUpDelivery";
            this.lookUpDelivery.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.lookUpDelivery.Properties.NullText = "";
            this.lookUpDelivery.Properties.Click += new System.EventHandler(this.lookUpDelivery_Properties_Click);
            this.lookUpDelivery.Size = new System.Drawing.Size(198, 20);
            this.lookUpDelivery.TabIndex = 167;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(73, 104);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(480, 21);
            this.txtNote.TabIndex = 168;
            // 
            // btnSplitCheck
            // 
            this.btnSplitCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSplitCheck.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSplitCheck.Appearance.Options.UseFont = true;
            this.btnSplitCheck.Appearance.Options.UseTextOptions = true;
            this.btnSplitCheck.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnSplitCheck.Location = new System.Drawing.Point(277, 492);
            this.btnSplitCheck.Name = "btnSplitCheck";
            this.btnSplitCheck.Size = new System.Drawing.Size(69, 62);
            this.btnSplitCheck.TabIndex = 171;
            this.btnSplitCheck.Text = "Split Check";
            // 
            // pnlSizes
            // 
            this.pnlSizes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlSizes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlSizes.Location = new System.Drawing.Point(554, 64);
            this.pnlSizes.Name = "pnlSizes";
            this.pnlSizes.Size = new System.Drawing.Size(85, 728);
            this.pnlSizes.TabIndex = 172;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseTextOptions = true;
            this.simpleButton1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.simpleButton1.Location = new System.Drawing.Point(346, 492);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(69, 62);
            this.simpleButton1.TabIndex = 173;
            this.simpleButton1.Text = "Transfer";
            // 
            // lblDeliveryFees
            // 
            this.lblDeliveryFees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDeliveryFees.BackColor = System.Drawing.Color.Transparent;
            this.lblDeliveryFees.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveryFees.ForeColor = System.Drawing.Color.White;
            this.lblDeliveryFees.Location = new System.Drawing.Point(110, 658);
            this.lblDeliveryFees.Name = "lblDeliveryFees";
            this.lblDeliveryFees.Size = new System.Drawing.Size(198, 21);
            this.lblDeliveryFees.TabIndex = 176;
            this.lblDeliveryFees.Text = "0.0";
            // 
            // lblService
            // 
            this.lblService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblService.BackColor = System.Drawing.Color.Transparent;
            this.lblService.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblService.ForeColor = System.Drawing.Color.White;
            this.lblService.Location = new System.Drawing.Point(110, 638);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(198, 20);
            this.lblService.TabIndex = 177;
            this.lblService.Text = "0.0";
            // 
            // lblDiscount
            // 
            this.lblDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDiscount.BackColor = System.Drawing.Color.Transparent;
            this.lblDiscount.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblDiscount.ForeColor = System.Drawing.Color.White;
            this.lblDiscount.Location = new System.Drawing.Point(110, 617);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(198, 21);
            this.lblDiscount.TabIndex = 178;
            this.lblDiscount.Text = "0.0";
            // 
            // lblTax
            // 
            this.lblTax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTax.BackColor = System.Drawing.Color.Transparent;
            this.lblTax.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblTax.ForeColor = System.Drawing.Color.White;
            this.lblTax.Location = new System.Drawing.Point(110, 597);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(198, 20);
            this.lblTax.TabIndex = 179;
            this.lblTax.Text = "0.0";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(110, 577);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(198, 20);
            this.lblTotal.TabIndex = 180;
            this.lblTotal.Text = "0.0";
            // 
            // lblItemsCount
            // 
            this.lblItemsCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblItemsCount.BackColor = System.Drawing.Color.Transparent;
            this.lblItemsCount.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblItemsCount.ForeColor = System.Drawing.Color.White;
            this.lblItemsCount.Location = new System.Drawing.Point(110, 557);
            this.lblItemsCount.Name = "lblItemsCount";
            this.lblItemsCount.Size = new System.Drawing.Size(198, 20);
            this.lblItemsCount.TabIndex = 182;
            this.lblItemsCount.Text = "0.0";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(0, 557);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 16);
            this.label8.TabIndex = 181;
            this.label8.Text = "Items Count:";
            // 
            // txtCustomerTel
            // 
            this.txtCustomerTel.BackColor = System.Drawing.Color.White;
            this.txtCustomerTel.Location = new System.Drawing.Point(73, 42);
            this.txtCustomerTel.Name = "txtCustomerTel";
            this.txtCustomerTel.Size = new System.Drawing.Size(181, 21);
            this.txtCustomerTel.TabIndex = 186;
            this.txtCustomerTel.Validated += new System.EventHandler(this.txtCustomerTel_Validated);
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl11.Location = new System.Drawing.Point(6, 65);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(47, 12);
            this.labelControl11.TabIndex = 160;
            this.labelControl11.Text = "Address :";
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.BackColor = System.Drawing.Color.White;
            this.txtCustomerAddress.Location = new System.Drawing.Point(73, 63);
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(480, 21);
            this.txtCustomerAddress.TabIndex = 189;
            // 
            // simpleButton8
            // 
            this.simpleButton8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton8.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton8.Appearance.Options.UseFont = true;
            this.simpleButton8.Appearance.Options.UseTextOptions = true;
            this.simpleButton8.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.simpleButton8.Location = new System.Drawing.Point(484, 492);
            this.simpleButton8.Name = "simpleButton8";
            this.simpleButton8.Size = new System.Drawing.Size(69, 62);
            this.simpleButton8.TabIndex = 192;
            this.simpleButton8.Text = "Reciept Delivery";
            // 
            // lookUpTables
            // 
            this.lookUpTables.Location = new System.Drawing.Point(314, 24);
            this.lookUpTables.Margin = new System.Windows.Forms.Padding(2);
            this.lookUpTables.Name = "lookUpTables";
            this.lookUpTables.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.lookUpTables.Properties.NullText = "";
            this.lookUpTables.Properties.Click += new System.EventHandler(this.lookUpTables_Properties_Click);
            this.lookUpTables.Size = new System.Drawing.Size(239, 20);
            this.lookUpTables.TabIndex = 195;
            // 
            // lblTotalNet
            // 
            this.lblTotalNet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalNet.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotalNet.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalNet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTotalNet.Location = new System.Drawing.Point(121, 683);
            this.lblTotalNet.Name = "lblTotalNet";
            this.lblTotalNet.Size = new System.Drawing.Size(187, 32);
            this.lblTotalNet.TabIndex = 9;
            this.lblTotalNet.Text = "0.0";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.Appearance.Options.UseTextOptions = true;
            this.simpleButton4.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.simpleButton4.Location = new System.Drawing.Point(139, 718);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(69, 74);
            this.simpleButton4.TabIndex = 199;
            this.simpleButton4.Text = "Deleviry Orders";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Appearance.Options.UseTextOptions = true;
            this.simpleButton2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.simpleButton2.Location = new System.Drawing.Point(70, 718);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(69, 74);
            this.simpleButton2.TabIndex = 200;
            this.simpleButton2.Text = "Kichine Orders";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExit.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.Appearance.Options.UseTextOptions = true;
            this.btnExit.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnExit.Location = new System.Drawing.Point(1, 718);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(69, 74);
            this.btnExit.TabIndex = 202;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // LookUpOrders
            // 
            this.LookUpOrders.EditValue = "";
            this.LookUpOrders.Location = new System.Drawing.Point(176, 0);
            this.LookUpOrders.Name = "LookUpOrders";
            this.LookUpOrders.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpOrders.Properties.NullText = "";
            this.LookUpOrders.Properties.View = this.gridView1;
            this.LookUpOrders.Size = new System.Drawing.Size(19, 20);
            this.LookUpOrders.TabIndex = 204;
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
            this.txtOrderNo.Location = new System.Drawing.Point(73, 0);
            this.txtOrderNo.Name = "txtOrderNo";
            this.txtOrderNo.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtOrderNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtOrderNo.Properties.Appearance.Options.UseBackColor = true;
            this.txtOrderNo.Properties.Appearance.Options.UseFont = true;
            this.txtOrderNo.Size = new System.Drawing.Size(103, 20);
            this.txtOrderNo.TabIndex = 203;
            this.txtOrderNo.Tag = "";
            this.txtOrderNo.Validated += new System.EventHandler(this.txtCode_Validated);
            // 
            // LookUpCustomers
            // 
            this.LookUpCustomers.EditValue = "";
            this.LookUpCustomers.Location = new System.Drawing.Point(253, 42);
            this.LookUpCustomers.Name = "LookUpCustomers";
            this.LookUpCustomers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpCustomers.Properties.NullText = "";
            this.LookUpCustomers.Properties.View = this.gridView2;
            this.LookUpCustomers.Size = new System.Drawing.Size(19, 20);
            this.LookUpCustomers.TabIndex = 205;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.lblCustomerName.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.lblCustomerName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblCustomerName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.lblCustomerName.Location = new System.Drawing.Point(273, 45);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(280, 17);
            this.lblCustomerName.TabIndex = 206;
            // 
            // btnExpenses
            // 
            this.btnExpenses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExpenses.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpenses.Appearance.Options.UseFont = true;
            this.btnExpenses.Appearance.Options.UseTextOptions = true;
            this.btnExpenses.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnExpenses.Location = new System.Drawing.Point(277, 718);
            this.btnExpenses.Name = "btnExpenses";
            this.btnExpenses.Size = new System.Drawing.Size(69, 74);
            this.btnExpenses.TabIndex = 207;
            this.btnExpenses.Text = "Expenses";
            this.btnExpenses.Click += new System.EventHandler(this.btnExpenses_Click);
            // 
            // frmPOS_Orders
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 793);
            this.Controls.Add(this.btnExpenses);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.LookUpCustomers);
            this.Controls.Add(this.LookUpOrders);
            this.Controls.Add(this.txtOrderNo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.lookUpTables);
            this.Controls.Add(this.simpleButton8);
            this.Controls.Add(this.txtCustomerAddress);
            this.Controls.Add(this.txtCustomerTel);
            this.Controls.Add(this.lblItemsCount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblDeliveryFees);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.pnlSizes);
            this.Controls.Add(this.btnSplitCheck);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.lookUpDelivery);
            this.Controls.Add(this.cmbOrderType);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnDiscount);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.btnVoid);
            this.Controls.Add(this.btnRefund);
            this.Controls.Add(this.TreeItems);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotalNet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelNavigation);
            this.Controls.Add(this.pnlItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPOS_Orders";
            this.Text = "Del";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmOrders_Load);
            this.panelNavigation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TreeItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpDelivery.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpTables.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpOrders.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpCustomers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlItems;
        private System.Windows.Forms.Panel panelNavigation;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Panel pnlPOS_ItemsCategories;
        private System.Windows.Forms.Label label1;
        internal DevExpress.XtraTreeList.TreeList TreeItems;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colItemID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colSizeID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colItemName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colQty;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colisPrint;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colisDelete;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colServicePerantID;
        private DevExpress.XtraEditors.SimpleButton btnRefund;
        private DevExpress.XtraEditors.SimpleButton btnVoid;
        private DevExpress.XtraEditors.SimpleButton btnDiscount;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.ComboBox cmbOrderType;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LookUpEdit lookUpDelivery;
        private DevExpress.XtraEditors.MemoEdit txtNote;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPrice;
        private DevExpress.XtraEditors.SimpleButton btnSplitCheck;
        private System.Windows.Forms.FlowLayoutPanel pnlSizes;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label lblDeliveryFees;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTotal;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDeleterow;
        private System.Windows.Forms.Label lblItemsCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCustomerTel;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDeleteRow;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colNote;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton8;
        private DevExpress.XtraEditors.LookUpEdit lookUpTables;
        private System.Windows.Forms.Label lblTotalNet;
        private DevExpress.XtraTreeList.Columns.TreeListColumn Discount;
        private DevExpress.XtraTreeList.Columns.TreeListColumn PriceValue;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SearchLookUpEdit LookUpOrders;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        internal DevExpress.XtraEditors.TextEdit txtOrderNo;
        private DevExpress.XtraEditors.SearchLookUpEdit LookUpCustomers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.LabelControl lblCustomerName;
        private DevExpress.XtraEditors.SimpleButton btnExpenses;
    }
}