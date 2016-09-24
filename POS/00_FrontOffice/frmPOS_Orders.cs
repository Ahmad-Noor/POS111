using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList.Nodes;
//using System.Data.Entity;
using DevExpress.CodeParser;
using DevExpress.XtraReports.UI;

namespace POS
{
    public partial class frmPOS_Orders : SkyForm
    {
        public frmPOS_Orders()
        {
            InitializeComponent();

        }

        private DBEntities db = new DBEntities();
        DataTable Itemsdt = new DataTable();
        POS_Orders mTable = new POS_Orders();



        bool NewRecord = false;
        string Refund { get; set; }

        private void frmOrders_Load(object sender, EventArgs e)
        {

            Settings.CreateShift();

            TreeItems.KeyFieldName = "ID";
            TreeItems.ParentFieldName = "PerantID";

            // Here we create a DataTable with four columns.
            DataColumn dc = new DataColumn("ID", typeof(long));
            dc.AutoIncrement = true;
            dc.AutoIncrementSeed = 1;
            dc.AutoIncrementStep = 1;
            Itemsdt.Columns.Add(dc);

            Itemsdt.Columns.Add("ItemID", typeof(long));
            Itemsdt.Columns.Add("SizeID", typeof(long));
            Itemsdt.Columns.Add("Qty", typeof(double));
            Itemsdt.Columns.Add("ItemName", typeof(string));
            Itemsdt.Columns.Add("Note", typeof(string));
            Itemsdt.Columns.Add("Price", typeof(double));
            Itemsdt.Columns.Add("PriceValue", typeof(double));
            Itemsdt.Columns.Add("Discount", typeof(double));
            Itemsdt.Columns.Add("isPrint", typeof(bool));
            Itemsdt.Columns.Add("isDelete", typeof(bool));
            Itemsdt.Columns.Add("PerantID", typeof(long));

            Itemsdt.Columns.Add("UserCreate", typeof(long));
            Itemsdt.Columns.Add("UserLastModified", typeof(long));
            Itemsdt.Columns.Add("CreationDate", typeof(DateTime));
            Itemsdt.Columns.Add("LastModified", typeof(DateTime));
            Itemsdt.Columns.Add("Deleterow", typeof(string));
            Itemsdt.Columns.Add("UserDelete", typeof(long));
            //Itemsdt.Columns.Add("Orderid", typeof(long));
            TreeItems.DataSource = Itemsdt;
            //-----------------------------------------------------------------------------

            var tabledt = db.POS_Tables.Where(c => c.Branch_ID == Settings.CurrentBranch_ID).ToList();
            lookUpTables.Properties.DataSource = tabledt;
            lookUpTables.Properties.DisplayMember = "TableName";
            lookUpTables.Properties.ValueMember = "ID";
            lookUpTables.Properties.Columns.Add(new LookUpColumnInfo("TableCode", "TableCode", 20));
            lookUpTables.Properties.Columns.Add(new LookUpColumnInfo("TableName", "TableName", 100));
            //lookUpTables.Properties.BestFitMode = BestFitMode.BestFitResizePopup; 
            //lookUpTables.Properties.SearchMode = SearchMode.AutoComplete;



            LookUpCustomers.Properties.ValueMember = "ID";
            LookUpCustomers.Properties.DisplayMember = "CustomerName";
            
            GridColumn columnc = LookUpCustomers.Properties.View.Columns.AddField("ID");
            columnc.Visible = false;
            columnc = LookUpCustomers.Properties.View.Columns.AddField("CustomerCode");
            columnc.Visible = true;
            columnc = LookUpCustomers.Properties.View.Columns.AddField("CustomerName");
            columnc.Visible = true;
           
            //searchLookUpEdit1.Properties.View.Columns.AddField("AreaName").Visible = true;
            LookUpCustomers.Properties.TextEditStyle = TextEditStyles.Standard;
            FilllookupCustomers();


            var tabledt3 = db.Employees.Where(c => c.Branch_ID == Settings.CurrentBranch_ID).ToList();
            lookUpDelivery.Properties.DataSource = tabledt3;
            lookUpDelivery.Properties.DisplayMember = "EmployeeName";
            lookUpDelivery.Properties.ValueMember = "ID";
            lookUpDelivery.Properties.Columns.Add(new LookUpColumnInfo("EmployeeCode", "EmployeeCode", 20));
            lookUpDelivery.Properties.Columns.Add(new LookUpColumnInfo("EmployeeName", "EmployeeName", 100));


            var tabledt4 = db.POS_LKUPOrderType.ToList();
            cmbOrderType.DataSource = tabledt4;
            cmbOrderType.DisplayMember = "OrderTypeName";
            cmbOrderType.ValueMember = "ID";




            LookUpOrders.Properties.ValueMember = "ID";
            LookUpOrders.Properties.DisplayMember = "OrderNo";
            GridColumn column = LookUpOrders.Properties.View.Columns.AddField("ID");
            column.Visible = false;
            column = LookUpOrders.Properties.View.Columns.AddField("OrderNo");
            column.Visible = true;
            column = LookUpOrders.Properties.View.Columns.AddField("CreationDate");
            column.Visible = true;
            LookUpOrders.Properties.TextEditStyle = TextEditStyles.Standard;

            FillLookupOrder();

            int Margin = 5;
            int left = 0;

            var catogry = db.POS_ItemsCategories.Where(c => c.Branch_ID == Settings.CurrentBranch_ID).ToList();
            foreach (var VARIABLE in catogry)
            {
                POSButton newButton = new POSButton();

                newButton.Size = new System.Drawing.Size(83, 54);
                newButton.ItemsID = VARIABLE.ID;
                newButton.Text = VARIABLE.CategoryName;
                newButton.Click += new EventHandler(Categoriesbutton_Click);

                newButton.Left = left;
                left += newButton.Width + Margin;
                pnlPOS_ItemsCategories.Controls.Add(newButton);
            }

            pnlPOS_ItemsCategories.HorizontalScroll.Maximum = left - 500;


            btnClear_Click(null, null);
        }
        void FilllookupCustomers()
        {
            var lookup = (from tb in db.POS_Customers
                          where tb.Branch_ID == Settings.CurrentBranch_ID
                          select new { tb.CustomerCode, tb.CustomerName, tb.ID }).ToList();
            LookUpCustomers.Properties.DataSource = lookup;

        }
        void FillLookupOrder()
        {
            var lookup = (from tb in db.POS_Orders
                          where tb.Branch_ID == Settings.CurrentBranch_ID && tb.ShiftsTransaction_ID == Settings.CurrentShift_ID
                          select new { tb.OrderNo, tb.CreationDate, tb.ID }).ToList();

            LookUpOrders.Properties.DataSource = lookup;
        }


        void Retrieve(long id)
        {
            mTable = db.POS_Orders.Find(id);
            if (mTable == null)
            {
                btnClear_Click(null, null);
                return;
            }
            NewRecord = false;

            //txtOrderNo.Text = mTable.OrderNo.ToString();
            cmbOrderType.SelectedValue = mTable.LookupOrderType_ID;
            cmbOrderType.SelectedValue = mTable.OrderStatus;

            LookUpCustomers.EditValue = mTable.Customer_ID;
            txtCustomerTel.Text = mTable.CustomerTel;
            txtCustomerAddress.Text = mTable.CustomerAddress;

            txtNote.Text = mTable.Note;
            lblTotal.Text = mTable.Total.ToString();
            lblTax.Text = mTable.Tax.ToString();
            lblDiscount.Text = mTable.Discount.ToString();
            lblService.Text = mTable.Service.ToString();
            lblDeliveryFees.Text = mTable.DeliveryFees.ToString();

            lblTotalNet.Text = mTable.TotalNet.ToString();

            var lst = (from mOrderD in db.POS_Orders2
                       from oitems in db.POS_Items.Where(oitems => oitems.ID == mOrderD.Item_ID).DefaultIfEmpty()
                       from oSizes in db.POS_Sizes.Where(oSizes => oSizes.ID == mOrderD.Size_ID).DefaultIfEmpty()
                       where mOrderD.Master_ID == id && mOrderD.Branch_ID == Settings.CurrentBranch_ID
                       select new
                       {
                           mOrderD.ID,
                           mOrderD.Item_ID,
                           mOrderD.Size_ID,
                           mOrderD.Qty,
                           ItemName = mOrderD.Size_ID == null ? oitems.ItemName : oitems.ItemName + " - " + oSizes.SizeName,
                           mOrderD.Note,
                           mOrderD.Price,
                           mOrderD.value,
                           mOrderD.Discount,
                           mOrderD.isPrint,
                           mOrderD.isDelete,
                           mOrderD.Perant_ID,
                           mOrderD.UserCreate,
                           mOrderD.UserLastModified,
                           mOrderD.CreationDate,
                           mOrderD.LastModified,
                           mOrderD.Deleterow,
                           mOrderD.UserDelete
                       }).ToList();
            Itemsdt.Rows.Clear();
            foreach (var itm in lst)
            {
                Itemsdt.Rows.Add(
                    itm.ID,
                    itm.Item_ID,
                    itm.Size_ID,
                    itm.Qty,
                    itm.ItemName,
                    itm.Note,
                    itm.Price,
                    itm.value,
                    itm.Discount,
                    itm.isPrint,
                    itm.isDelete,
                    itm.Perant_ID,
                    itm.UserCreate,
                    itm.UserLastModified,
                    itm.CreationDate,
                    itm.LastModified,
                    itm.Deleterow,
                    itm.UserDelete
                    );
            }


            TreeItems.Refresh();
        }


        private void Categoriesbutton_Click(object sender, EventArgs e)
        {
            var msender = sender as POSButton;
            var gi = msender.ItemsID;
            pnlItems.Controls.Clear();
            var items = db.POS_Items.Where(w => w.Category_ID == gi && w.Branch_ID == Settings.CurrentBranch_ID).ToList();
            foreach (var item in items)
            {
                POSButton newButton = new POSButton();
                newButton.Size = new System.Drawing.Size(83, 54);
                newButton.ItemsID = item.ID;
                newButton.Text = item.ItemName + ((bool)item.ContainSizes ? "" : " (" + item.Price + ")");
                newButton.ItemsName = item.ItemName;
                newButton.Price = item.Price;
                newButton.Click += new EventHandler(Itemsbutton_Click);
                newButton.ContainSizes = item.ContainSizes;
                newButton.ItemService = item.ItemService;
                pnlItems.Controls.Add(newButton);
            }

        }
        private void Itemsbutton_Click(object sender, EventArgs e)
        {
            pnlSizes.Controls.Clear();

            var msender = sender as POSButton;
            if ((bool)msender.ContainSizes)
            {
                var ItemsID = msender.ItemsID;

                var mSizes = (from mis in db.POS_ItemsSizes
                              join ms in db.POS_Sizes on mis.Size_ID equals ms.ID
                              where mis.Branch_ID == Settings.CurrentBranch_ID
                              select new { mis.Size_ID, ms.SizeName, mis.Price, mis.Item_ID }).Where(w => w.Item_ID == ItemsID).ToList();

                foreach (var mSize in mSizes)
                {
                    POSButton newButton = new POSButton();
                    newButton.Size = new System.Drawing.Size(83, 54);
                    newButton.ItemsID = (long)mSize.Item_ID;
                    newButton.SizeID = mSize.Size_ID;
                    newButton.Text = mSize.SizeName + " (" + mSize.Price + ")";
                    newButton.ItemsName = msender.ItemsName;
                    newButton.SizeName = mSize.SizeName;
                    newButton.Price = mSize.Price;

                    newButton.Click += new EventHandler(Sizebutton_Click);

                    pnlSizes.Controls.Add(newButton);
                }
            }
            else
            {
                AddRow(msender, false);
            }

        }

        private void Sizebutton_Click(object sender, EventArgs e)
        {
            var msender = sender as POSButton;
            AddRow(msender, true);
        }

        void AddRow(POSButton sender, bool isSize)
        {

            int par = 0;
            if (sender.ItemService != null && TreeItems.FocusedNode != null)
            {
                if ((bool)sender.ItemService && TreeItems.FocusedNode.Level == 0)
                {
                    var dd = TreeItems.FocusedNode.GetValue("ID");
                    //par = (int)dd;
                    int.TryParse(dd.ToString(), out par);
                    if ((bool)TreeItems.FocusedNode["isPrint"])
                    {
                        return;
                    }
                }
            }
            var sName = isSize ? " - " + sender.SizeName : "";
            DataRow dr = null;
            if (Itemsdt.Rows.Count > 0)
            {
                try
                {
                    var drr = Itemsdt.AsEnumerable().Where(r => !((bool)r["isPrint"] && ((long)r["ItemID"]) == sender.ItemsID)).First();
                    //////
                    if (drr != null)
                    {
                        if (sender.ItemService != null && !(bool)sender.ItemService)
                        {
                            if (sender.SizeID != null)
                            {
                                dr = Itemsdt.AsEnumerable()
                                    .First(
                                        r =>
                                            (r["ItemID"]).Equals(sender.ItemsID) &&
                                            (r["SizeID"]).Equals(sender.SizeID) &&
                                            ((bool)r["isPrint"]).Equals(false));
                            }
                            else
                            {
                                dr = Itemsdt.AsEnumerable()
                                    .First(
                                        r =>
                                            (r["ItemID"]).Equals(sender.ItemsID) &&
                                            ((bool)r["isPrint"]).Equals(false));
                            }
                        }
                        else
                        {
                            //par
                            if (sender.SizeID != null)
                            {
                                if (par != null)
                                {
                                    dr = Itemsdt.AsEnumerable()
                                        .First(
                                            r =>
                                                (r["ItemID"]).Equals(sender.ItemsID) &&
                                                (r["SizeID"]).Equals(sender.SizeID) &&
                                                ((bool)r["isPrint"]).Equals(false) &&
                                                (r["PerantID"]).Equals(par)
                                        );
                                }
                                else
                                {
                                    dr = Itemsdt.AsEnumerable()
                                        .First(
                                            r =>
                                                (r["ItemID"]).Equals(sender.ItemsID) &&
                                                (r["SizeID"]).Equals(sender.SizeID) &&
                                                ((bool)r["isPrint"]).Equals(false)
                                        );
                                }
                            }
                            else
                            {
                                if (par != null)
                                {
                                    dr = Itemsdt.AsEnumerable()
                                        .First(
                                            r =>
                                                (r["ItemID"]).Equals(sender.ItemsID) &&
                                                ((bool)r["isPrint"]).Equals(false) &&
                                                (r["PerantID"]).Equals(par));
                                }
                                else
                                {
                                    dr = Itemsdt.AsEnumerable()
                                        .First(
                                            r =>
                                                (r["ItemID"]).Equals(sender.ItemsID) &&
                                                ((bool)r["isPrint"]).Equals(false));
                                }
                            }
                        }
                    }
                }
                catch (Exception)
                {
                }

            }

            if (dr == null)
            {
                Itemsdt.Rows.Add(
                    null, //"ID" 
                    sender.ItemsID, //"ItemID" 
                    sender.SizeID, //"SizeID" 
                    1, //"Qty" 
                    sender.ItemsName + sName, //"ItemName" 
                    string.Empty, // Note 
                    sender.Price, //"Price" 
                    sender.Price * 1, //"Value" 
                    0.0, // Discount  ,
                    false, //"isPrint" 
                    false, //"isDelete"
                    par, //"PerantID" 
                    Settings.CurrentUser_ID, //"UserCreate" 
                    Settings.CurrentUser_ID, //"UserLastModified" 
                    DateTime.Now, //"CreationDate"
                    DateTime.Now, //"LastModified"  
                    null // UserDelete
                    //,Orderid
                    );
            }
            else
            {
                dr["Qty"] = (double)dr["Qty"] + 1;
                dr["PriceValue"] = (double)dr["Qty"] * (double)dr["Price"];
                dr["LastModified"] = DateTime.Now;
                dr["UserLastModified"] = Settings.CurrentUser_ID;


            }
            grdSummary();
            TreeItems.FocusedNode = null;
        }

        void grdSummary()
        {
            lblItemsCount.Text = Itemsdt.Rows.Count.ToString();
            //object sumObject;
            lblTotal.Text = Itemsdt.Compute("Sum(PriceValue)", "").ToString();
            lblDiscount.Text = Itemsdt.Compute("Sum(Discount)", "").ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            try
            {
                mY -= 83;
                if (mY < 0) mY = 0;
                pnlPOS_ItemsCategories.HorizontalScroll.Value = mY;
            }
            catch (Exception)
            {

            }


        }
        int mY = 0;
        int yy = 0;
        private void buttonRight_Click(object sender, EventArgs e)
        {
            try
            {
                mY += 83;
                if (mY > pnlPOS_ItemsCategories.HorizontalScroll.Maximum) mY = pnlPOS_ItemsCategories.HorizontalScroll.Maximum;
                pnlPOS_ItemsCategories.HorizontalScroll.Value = mY;
            }
            catch (Exception)
            {
            }


        }

        private void btnDeleteRow_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            var id = TreeItems.FocusedNode.GetValue("ID");

            for (int i = 0; i < Itemsdt.Rows.Count; i++)
            {


                if (Itemsdt.Rows[i]["ID"] == id || (Itemsdt.Rows[i]["PerantID"].ToString() != string.Empty && Itemsdt.Rows[i]["PerantID"] == id))
                {
                    if ((bool)Itemsdt.Rows[i]["isPrint"])
                    {
                        Itemsdt.Rows[i]["isDelete"] = true;
                        //TreeItems.FocusedNode.SetValue("isDelete",true);
                        //TreeItems.Appearance.OddRow.BackColor = Color.Red;
                        //TreeItems.Appearance.OddRow.Font = new Font(TreeItems.Appearance.OddRow.Font, FontStyle.Strikeout);
                    }
                    else { Itemsdt.Rows[i].Delete(); }
                    return;
                }


            }






        }

        private void TreeItems_NodeCellStyle(object sender, GetCustomNodeCellStyleEventArgs e)
        {
            //if (e.Node.Checked)
            //    e.Appearance.BackColor = Color.Green;
            if (Convert.ToString(e.Node["isDelete"]) == "True")
            {
                e.Appearance.BackColor = Color.Red;
                e.Appearance.Font = new Font(TreeItems.Appearance.OddRow.Font, FontStyle.Strikeout);
            }
            //else if (Convert.ToString(e.Node["IsAmber"]) == "True")
            //{ e.Appearance.BackColor = Color.Orange; }
            //else if (Convert.ToString(e.Node["IsRed"]) == "True")
            //{ e.Appearance.BackColor = Color.Red; }

        }



        private void btnClear_Click(object sender, EventArgs e)
        {

            mTable = new POS_Orders();
            NewRecord = true;
            Refund = string.Empty;
            txtOrderNo.Text = string.Empty;
            cmbOrderType.SelectedIndex = 0;
            lookUpTables.EditValue = null;
            LookUpCustomers.EditValue = null;

            txtCustomerAddress.Text = string.Empty;
            lookUpDelivery.EditValue = null;
            txtNote.Text = string.Empty;
            Itemsdt.Rows.Clear();
            grdSummary();
            LookUpOrders.EditValue = null;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            // OrderStatus =1 ==>order is close
            // OrderStatus =2 ==>order is open---Delivery || Resturant
            //--------
            // OrderStatus =3 ==>Check is Printed
            //------------CheckisPrint
            //--------
            // OrderStatus =4 ==>order is refund
            // OrderStatus =5 ==>order is Deleted

            var Shift_isOpen = Settings.Shift_isOpen();
            if (Shift_isOpen != "")
            {
                MessageBox.Show(Shift_isOpen, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var CasherisOpen = db.POS_ShiftsTransaction2.Where(c => c.Branch_ID == Settings.CurrentBranch_ID && c.User_ID == Settings.CurrentUser_ID).FirstOrDefault();
            if (CasherisOpen == null)
            {
                frmPOS_CasherOpenBalance frm = new frmPOS_CasherOpenBalance();
                frm.ShowDialog();
                if (!frm.Status) return;

            }


            var type = (int)cmbOrderType.SelectedValue;
            switch (type)
            {
                case 2:// delivery
                    if (txtCustomerTel.Text.Trim() == string.Empty)
                    {
                        MessageBox.Show("Enter Customer", "Sky sys", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                case 3:// resturant

                    if (lookUpTables.EditValue == null)
                    {
                        MessageBox.Show("Enter the Table", "Sky sys", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
            }

            DataSet ds = new DataSet();
            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {

                    var OrderStatus = 0;

                    //var ss = db.POS_Orders.Where(c => c.Branch_ID == CurrentBranch_ID).Max(c => c.OrderNo);
                    //st.OrderNo = ss == null ? 1 : ss + 1;

                    mTable.OrderNo += db.POS_Orders.Max(c => c.OrderNo);
                    mTable.Branch_ID = Settings.CurrentBranch_ID;
                    //mTable.PeriodID = Pub.PeriodID;
                    mTable.LookupOrderType_ID = cmbOrderType.SelectedValue as int?;
                    mTable.OrderStatus = (int)cmbOrderType.SelectedValue == 1 ? 1 : 2;

                    if (txtCustomerTel.Tag!=null) mTable.Customer_ID = (long)txtCustomerTel.Tag;
                    mTable.CustomerTel = txtCustomerTel.Text;
                    mTable.CustomerAddress = txtCustomerAddress.Text;
                    mTable.Branch_ID = Settings.CurrentBranch_ID;
                    mTable.Note = txtNote.Text;
                    mTable.Total = Settings.ConvertToDouble(lblTotal.Text);
                    mTable.Tax = Settings.ConvertToDouble(lblTax.Text);
                    mTable.Discount = Settings.ConvertToDouble(lblDiscount.Text);
                    mTable.Service = Settings.ConvertToDouble(lblService.Text);
                    mTable.DeliveryFees = Settings.ConvertToDouble(lblDeliveryFees.Text);

                    mTable.TotalNet = Settings.ConvertToDouble(lblTotalNet.Text);



                    if (NewRecord)
                    {

                        mTable.CreationDate = DateTime.Now;
                        mTable.UserCreate = Settings.CurrentUser_ID;
                        db.POS_Orders.Add(mTable);

                    }
                    else
                    {
                        mTable.UserLastModified = Settings.CurrentUser_ID;
                        mTable.LastModified = DateTime.Now;
                        db.Entry(mTable).State = EntityState.Modified;
                    }


                    ds.Tables.Add(Itemsdt);
                    db.SaveChanges();
                    //db.Database.ExecuteSqlCommand(string.Format("exec dbo.POS_OrdersDeltails_save @XML ='{0}',@Branch_ID = N'{1}', @Orderid ={2}", ds.GetXml(), Settings.CurrentBranch, "'{" + mTable.id + "}'"));
                    var ss = db.POS_OrdersDeltails_save(ds.GetXml(), mTable.ID, Settings.CurrentBranch_ID);

                    db.SaveChanges();
                    transaction.Commit();
                    
                }
                catch (Exception exception)
                {
                    transaction.Rollback();
                    MessageBox.Show("Transaction Roll backed due to some exception");
                }

                //MessageBox.Show("تم الحفظ", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (NewRecord)
                {
                    FillLookupOrder();
                }

                rptPon report = new rptPon();
                foreach (var para in report.Parameters)
                {
                    switch (para.Name)
                    {
                        case "ParamID":
                            para.Value = mTable.ID;
                            break;
                        default:
                            break;
                    }
                }

                ReportPrintTool tool = new ReportPrintTool(report);
                tool.Print();
                //tool.ShowPreview();

                //ReportDesignTool tool = new ReportDesignTool(report);
                //tool.ShowDesignerDialog(); 

                btnClear_Click(null, null);



                if (ds.Tables.Count > 0)
                {
                    ds.Tables.RemoveAt(0);
                }

            }

        }
        private void lookUpTables_Properties_Click(object sender, EventArgs e)
        {
            lookUpTables.EditValue = null;
        }
        private void lookUpDelivery_Properties_Click(object sender, EventArgs e)
        {
            lookUpDelivery.EditValue = null;

        }


        private void TreeItems_BeforeFocusNode(object sender, BeforeFocusNodeEventArgs e)
        {

        }

        private void TreeItems_ShowingEditor(object sender, CancelEventArgs e)
        {

            if ((bool)((TreeList)sender).FocusedNode["isPrint"])
            {
                //((TreeList)sender).ActiveEditor.Properties.ReadOnly = true;
                e.Cancel = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtCode_Validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtOrderNo.Text.ToString()))
            {
                var id = long.Parse(txtOrderNo.Text);
                Retrieve(id);
            }

        }
        private void txtCustomerTel_Validated(object sender, EventArgs e)
        {
            var foundcust = db.POS_CustomersTel.FirstOrDefault(c => c.Tel == txtCustomerTel.Text);

            frmPOS_Customers frm = new frmPOS_Customers();
            if (foundcust != null) frm.id = foundcust.ID;
            frm.Tel = txtCustomerTel.Text;
            frm.CloseAfterSave = true;
         

            txtCustomerTel.Tag = frm.id;
            lblCustomerName.Text = frm.CustName;
            frm.Hide();
            FilllookupCustomers();
        }

        private void btnExpenses_Click(object sender, EventArgs e)
        {
            new frmPOS_Expenses().Show();

        }



    }
}

