using System;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Transactions;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraScheduler;

namespace POS
{
    public partial class frmPOS_Items : Sky_UserControl
    {
        public frmPOS_Items()
        {
            InitializeComponent();

        }

        private DBEntities db = new DBEntities();
        private bool NewRecord = false;
        POS_Items mTable = new POS_Items();
        long ID = 0;

        DataTable tbSizes = new DataTable();

        private void FrmItems_Load(object sender, EventArgs e)
        {
            //panelControl1.Dock = DockStyle.None;
            //panelControl1.Dock = DockStyle.Fill;

            btn_AddNew_ItemClick(null, null);
            Filllookup();
            FullTree();

            var lookup2 = (from tb in db.POS_ItemsCategories
                           where tb.Branch_ID == Settings.CurrentBranch_ID
                           select new { tb.CategoryCode, tb.CategoryName, tb.ID }).ToList();
            LookupCategories.Properties.DataSource = lookup2;
            LookupCategories.Properties.ValueMember = "ID";
            LookupCategories.Properties.DisplayMember = "CategoryName";
            LookupCategories.Properties.View.Columns.AddField("ID").Visible = false;
            LookupCategories.Properties.View.Columns.AddField("CategoryCode").Visible = true; 
            LookupCategories.Properties.View.Columns.AddField("CategoryName").Visible = true;
            ;



            var lookup3 = (from tb in db.POS_Kitchens
                           where tb.Branch_ID == Settings.CurrentBranch_ID
                           select new { tb.KitchenCode, tb.KitchenName, tb.ID }).ToList();
            LookUpKitchens.Properties.DataSource = lookup3;
            LookUpKitchens.Properties.ValueMember = "ID";
            LookUpKitchens.Properties.DisplayMember = "KitchenName";
            LookUpKitchens.Properties.View.Columns.AddField("ID").Visible = false;
            LookUpKitchens.Properties.View.Columns.AddField("KitchenCode").Visible = true; 
            LookUpKitchens.Properties.View.Columns.AddField("KitchenName").Visible = true;
     
             

            var lookup3_1 = (from tb in db.POS_Attributes
                             where tb.Branch_ID == Settings.CurrentBranch_ID
                             select new { tb.AttributCode, tb.AttributName, tb.ID }).ToList();
            LookUpAttributes.Properties.DataSource = lookup3_1;
            LookUpAttributes.Properties.ValueMember = "ID";
            LookUpAttributes.Properties.DisplayMember = "AttributName";
            LookUpAttributes.Properties.View.Columns.AddField("ID").Visible = false;
            LookUpAttributes.Properties.View.Columns.AddField("AttributCode").Visible = true;
            LookUpAttributes.Properties.View.Columns.AddField("AttributName").Visible = true;



            searchLookUpEdit1.Properties.ValueMember = "ID";
            searchLookUpEdit1.Properties.DisplayMember = "ItemName";
            searchLookUpEdit1.Properties.View.Columns.AddField("ID").Visible = false;
            searchLookUpEdit1.Properties.View.Columns.AddField("ItemCode").Visible = true;
            searchLookUpEdit1.Properties.View.Columns.AddField("ItemName").Visible = true;
            searchLookUpEdit1.Properties.TextEditStyle = TextEditStyles.Standard;
            Filllookup();
            Filllookup();


            var lookup4 = (from tb in db.POS_Sizes
                           where tb.Branch_ID == Settings.CurrentBranch_ID
                           select new { tb.SizeCode, tb.SizeName, tb.ID }).ToList();
            LookUpSizes.Properties.DataSource = lookup4;
            LookUpSizes.Properties.ValueMember = "ID";
            LookUpSizes.Properties.DisplayMember = "SizeName";
            LookUpSizes.Properties.View.Columns.AddField("ID").Visible = false;
            LookUpSizes.Properties.View.Columns.AddField("SizeCode").Visible = true;
            LookUpSizes.Properties.View.Columns.AddField("SizeName").Visible = true;

            repositoryItemLookUpEdit2.Properties.DataSource = lookup4;
            repositoryItemLookUpEdit2.Properties.ValueMember = "ID";
            repositoryItemLookUpEdit2.Properties.DisplayMember = "SizeName";


            tbSizes.Columns.Add("SizeName", typeof(string));
            tbSizes.Columns.Add("Price", typeof(string));
            grdSizes.DataSource = tbSizes;
        }

        void Filllookup()
        {
            var lookup = (from tb in db.POS_Items
                          where tb.Branch_ID == Settings.CurrentBranch_ID
                          select new { tb.ItemCode, tb.ItemName, tb.ID }).ToList();
            searchLookUpEdit1.Properties.DataSource = lookup;
        }

        void LoadItemSizes()
        {

            tbSizes.Rows.Clear();
            var lst = (from mis in db.POS_ItemsSizes
                       where mis.Branch_ID == Settings.CurrentBranch_ID && mis.Item_ID == ID
                       select new { SizeName = mis.Size_ID, mis.Price }).ToList();
            foreach (var item in lst)
            {
                DataRow dr = tbSizes.NewRow();
                dr["SizeName"] = item.SizeName;
                dr["Price"] = item.Price;
                tbSizes.Rows.Add(dr);
            }


        }

        private void Retrieve(long id)
        {
            mTable = db.POS_Items.Find(id);
            if (mTable == null)
            {
                btn_AddNew_ItemClick(null, null);
                return;
            }
            ID = mTable.ID;
            NewRecord = false;
            txtCode.Text = mTable.ItemCode;
            txtName.Text = mTable.ItemName;
            txtPrice.Text = mTable.Price.ToString();
            LookupCategories.EditValue = mTable.Category_ID;
            LookUpKitchens.EditValue = mTable.Kitchen_ID;

            if (mTable.KitchenPrint != null) chkKitchenPrint.Checked = (bool)mTable.KitchenPrint;
            if (mTable.ItemService != null) chkItemService.Checked = (bool)mTable.ItemService;
            if (mTable.ContainSizes != null) chkContainSizes.Checked = (bool)mTable.ContainSizes;

            img.Image = null;
            if (mTable.Image != null)
            {
                byte[] ap1 = (byte[])mTable.Image;
                var ms = new MemoryStream(ap1);
                img.Image = Image.FromStream(ms);
                ms.Close();
            }

            LoadItemSizes();


            var user = db.Users.FirstOrDefault(c => c.ID == mTable.UserCreate && c.Branch_ID == Settings.CurrentBranch_ID);
            lblUserCreate.Text = user.UserName;
            lblUserCreateDate.Text = mTable.CreationDate.ToString();
            user = db.Users.FirstOrDefault(c => c.ID == mTable.UserLastModified && c.Branch_ID == Settings.CurrentBranch_ID);
            if (user != null) lblUserLastModified.Text = user.UserName; else lblUserLastModified.Text = "";
            lbllblUserLastModifiedDate.Text = mTable.LastModified.ToString();


        }


        void FullTree()
        {
            //var query = (from x in db.POS_ItemsCategories select new { A = x.ID.ToString(), B = x.CategoryName }).Concat(from y in db.Items select new { A = y.CategoryID, B = y.ItemName });

            //var dataSource = db.getAllItems();
            //TreeList1.DataSource = dataSource;

            //TreeList1.KeyFieldName = "ID";
            //TreeList1.ParentFieldName = "ID";

        }
 


        private void chkContainSizes_CheckedChanged(object sender, EventArgs e)
        {
            if (chkContainSizes.Checked)
            {
                gSizes.Enabled = true;
                txtPrice.Enabled = false;
                txtPrice.Value = 0;
            }
            else
            {
                gSizes.Enabled = false;
                txtPrice.Enabled = true;
                tbSizes.Rows.Clear();


            }
            LookUpSizes.EditValue = null;
            numericUpDown1.Value = 0;
        }


        void grdRemoveRow(GridView view)
        {
            if (view == null) return;
            DataRow[] rows = new DataRow[view.RowCount];

            for (int i = 0; i < view.RowCount; i++)
                rows[i] = view.GetDataRow(view.GetSelectedRows()[i]);
            view.BeginSort();
            try
            {
                foreach (DataRow row in rows)
                    row.Delete();
            }
            finally
            {
                view.EndSort();

            }

        }

  
 

        private void searchLookUpEdit1_EditValueChanged_1(object sender, EventArgs e)
        {
 

            if (searchLookUpEdit1.EditValue != null)
            {
                Retrieve((long)searchLookUpEdit1.EditValue);
                searchLookUpEdit1.EditValue = null;
            }
        }


        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmPOS_Sizes().Show();
        }

        private void LookupCategories_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            LookupCategories.EditValue = null;
        }

        private void LookUpKitchens_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            LookUpKitchens.EditValue = null;
        }

        private void LookUpAttributes_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            LookUpAttributes.EditValue = null;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {

            Settings.LoadControl(new frmPOS_ItemsCategories());
        }

        private void hyperlinkLabelControl2_Click(object sender, EventArgs e)
        {
            Settings.LoadControl(new frmPOS_Kitchens());
        }

        private void hyperlinkLabelControl3_Click(object sender, EventArgs e)
        {
            Settings.LoadControl(new frmPOS_Attributes());
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            img.LoadImage();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            img.Image = null;
        }
  
        private void hyperlinkLabelControl4_Click(object sender, EventArgs e)
        {
            Settings.LoadControl(new frmPOS_Sizes());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (LookUpSizes.EditValue != null)
            {


                for (int i = 0; i < tbSizes.Rows.Count; i++)
                {
                    if (tbSizes.Rows[i]["SizeName"] == LookUpSizes.EditValue)
                    {
                        tbSizes.Rows.Remove(tbSizes.Rows[i]);
                    }
                }

                DataRow dr = tbSizes.NewRow();
                dr["SizeName"] = LookUpSizes.EditValue;
                dr["Price"] = numericUpDown1.Value;
                tbSizes.Rows.Add(dr);
            }
            LookUpSizes.EditValue = null;
            numericUpDown1.Value = 0;


        }

        private void grdSizes_DoubleClick(object sender, EventArgs e)
        {
            LookUpSizes.EditValue = gridView6.GetRowCellValue(gridView6.GetSelectedRows()[0], SizeName);
            numericUpDown1.Text = gridView6.GetRowCellValue(gridView6.GetSelectedRows()[0], Price).ToString();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (LookUpSizes.EditValue != null)
            {
                for (int i = 0; i < tbSizes.Rows.Count; i++)
                {
                    if (tbSizes.Rows[i]["SizeName"] == LookUpSizes.EditValue)
                    {
                        tbSizes.Rows.Remove(tbSizes.Rows[i]);
                    }
                }
            }
            LookUpSizes.EditValue = null;
            numericUpDown1.Value = 0;
        }

        private void LookUpSizes_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            LookUpSizes.EditValue = null;
        }

        private void btn_AddNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mTable = new POS_Items();
            NewRecord = true;
            ID = 0;
            txtCode.Text = string.Empty;
            txtName.Text = string.Empty;
            txtRem.Text = string.Empty;
            txtPrice.Value = 0;
            txtBarcode.Text = string.Empty;
            LookupCategories.EditValue = null;
            LookUpKitchens.EditValue = null;
            chkItemService.Checked = false;
            chkContainSizes.Checked = false;
            chkKitchenPrint.Checked = true;
            img.Image = null;

            chkContainSizes_CheckedChanged(null, null);
            txtPrice.Value = 0;
            searchLookUpEdit1.EditValue = null;

            tbSizes.Rows.Clear();



            var user = db.Users.FirstOrDefault(c => c.ID == Settings.CurrentUser_ID && c.Branch_ID == Settings.CurrentBranch_ID);
            lblUserCreate.Text = user.UserName;
            lblUserCreateDate.Text = DateTime.Now.ToString();
            lblUserLastModified.Text = string.Empty;
            lbllblUserLastModifiedDate.Text = string.Empty;
        }

        private void btnCopy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ID = 0;
            mTable = new POS_Items();
            txtCode.Focus();
            txtCode.SelectAll();
            NewRecord = true;



            var user = db.Users.FirstOrDefault(c => c.ID == Settings.CurrentUser_ID && c.Branch_ID == Settings.CurrentBranch_ID);
            lblUserCreate.Text = user.UserName;
            lblUserCreateDate.Text = DateTime.Now.ToString();
            lblUserLastModified.Text = string.Empty;
            lbllblUserLastModifiedDate.Text = string.Empty;
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Enter Name", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    mTable.ItemCode = txtCode.Text;
                    mTable.ItemName = txtName.Text;
                    mTable.Price = Convert.ToDouble(string.IsNullOrEmpty(txtPrice.Text) ? "0" : txtPrice.Text);
                    if (LookupCategories.EditValue != null) mTable.Category_ID = (long)LookupCategories.EditValue;
                    if (LookUpKitchens.EditValue != null) mTable.Kitchen_ID = (long)LookUpKitchens.EditValue;
                    mTable.KitchenPrint = chkKitchenPrint.Checked;
                    mTable.ItemService = chkItemService.Checked;
                    mTable.ContainSizes = chkContainSizes.Checked;


                    if (img.Image != null)
                    {
                        Bitmap newBitmap1 = new Bitmap(img.Image);
                        var ms1 = new MemoryStream();
                        newBitmap1.Save(ms1, ImageFormat.Jpeg);
                        byte[] photoAray1 = new byte[ms1.Length];
                        ms1.Position = 0;
                        ms1.Read(photoAray1, 0, photoAray1.Length);
                        ms1.Close();
                        mTable.Image = photoAray1;
                    }
                    else
                    {
                        mTable.Image = null;
                    }
                    if (NewRecord)
                    {
                        mTable.Branch_ID = Settings.CurrentBranch_ID;
                        mTable.CreationDate = DateTime.Now;
                        mTable.UserCreate = Settings.CurrentUser_ID;
                        db.POS_Items.Add(mTable);

                    }
                    else
                    {
                        mTable.UserLastModified = Settings.CurrentUser_ID;
                        mTable.LastModified = DateTime.Now;
                        db.Entry(mTable).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                    #region Size

                    db.POS_ItemsSizes.RemoveRange(db.POS_ItemsSizes.Where(c => c.Item_ID == mTable.ID && c.Branch_ID == Settings.CurrentBranch_ID)
                            .ToList());
                    for (int i = 0; i < tbSizes.Rows.Count; i++)
                    {
                        if (tbSizes.Rows[i]["SizeName"] + "" != "")
                        {
                            var iz = new POS_ItemsSizes();

                            iz.Item_ID = mTable.ID;
                            iz.Size_ID = long.Parse(tbSizes.Rows[i]["SizeName"].ToString());
                            iz.Price = Convert.ToDouble(tbSizes.Rows[i]["Price"] + "" == "" ? "0" : tbSizes.Rows[i]["Price"]);
                            iz.Branch_ID = Settings.CurrentBranch_ID;
                            iz.CreationDate = DateTime.Now;
                            iz.UserCreate = Settings.CurrentUser_ID;
                            iz.UserLastModified = Settings.CurrentUser_ID;
                            iz.LastModified = DateTime.Now;
                            db.POS_ItemsSizes.Add(iz);

                        }
                    }


                    #endregion

                    db.SaveChanges();

                    transaction.Commit();
                    MessageBox.Show("Save Complete", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_AddNew_ItemClick(null, null);
                    Filllookup();
                }
                catch (Exception exception)
                {
                    transaction.Rollback();
                    MessageBox.Show("Transaction Roll backed due to some exception");
                }
            }

        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (NewRecord) return;
            if (
                MessageBox.Show("Are you sure you want to delete these item?", "Delete Item", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                db.Entry(mTable).State = EntityState.Deleted;
                db.POS_ItemsSizes.RemoveRange(db.POS_ItemsSizes.Where(c => c.Item_ID == mTable.ID && c.Branch_ID == Settings.CurrentBranch_ID)
                            .ToList());

                db.SaveChanges();
                btn_AddNew_ItemClick(null, null);
                Filllookup();
            }
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Hide();
        }




        private void btnFirst_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var nav = db.POS_Items.Where(c => c.Branch_ID == Settings.CurrentBranch_ID).FirstOrDefault();
            if (nav == null) return;
            Retrieve(nav.ID);
        }

        private void btnNext_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!NewRecord)
            {
                var nav = db.POS_Items.Where(c => c.ID > mTable.ID && c.Branch_ID == Settings.CurrentBranch_ID).FirstOrDefault();
                if (nav == null) return;
                Retrieve(nav.ID);
            }
        }

        private void btnPrevious_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!NewRecord)
            {
                var nav = db.POS_Items.Where(c => c.ID < mTable.ID && c.Branch_ID == Settings.CurrentBranch_ID).OrderByDescending(c => c.ID).FirstOrDefault();
                if (nav == null) return;
                Retrieve(nav.ID);
            }
        }

        private void btnLast_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var nav = db.POS_Items.Where(c => c.Branch_ID == Settings.CurrentBranch_ID).OrderByDescending(c => c.ID).FirstOrDefault();
            if (nav == null) return;
            Retrieve(nav.ID);
        }

        private void txtCode_Validated(object sender, EventArgs e)
        {
            var validated = db.POS_Items.FirstOrDefault(c => c.ItemCode == txtCode.Text && c.Branch_ID == Settings.CurrentBranch_ID);
            if (validated != null)
            {
                Retrieve(validated.ID);
            }
        }

        private void LookUpAttributes_EditValueChanged(object sender, EventArgs e)
        {

        }

    

    }

}
