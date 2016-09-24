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
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraScheduler;

namespace POS
{
    public partial class frmPOS_ShifTypes : Sky_UserControl
    {
        public frmPOS_ShifTypes()
        {
            
            InitializeComponent();
 
        }

        private DBEntities db = new DBEntities();
        private bool NewRecord = false;
        POS_ShifTypes mTable = new POS_ShifTypes();
        long ID;



        private void frmPOS_ShifTypes_Load(object sender, EventArgs e)
        {
            panelControl1.Dock = DockStyle.None;
            panelControl1.Dock = DockStyle.Fill;
        
            btn_AddNew_ItemClick(null, null);


            searchLookUpEdit1.Properties.ValueMember = "ID";
            searchLookUpEdit1.Properties.DisplayMember = "ShifTypeName";
            searchLookUpEdit1.Properties.View.Columns.AddField("ID").Visible = false;
            searchLookUpEdit1.Properties.View.Columns.AddField("ShifTypeCode").Visible = true;
            searchLookUpEdit1.Properties.View.Columns.AddField("ShifTypeName").Visible = true;
            searchLookUpEdit1.Properties.TextEditStyle = TextEditStyles.Standard;
            Filllookup();

      

        }

        void Filllookup()
        {var lookup = (from tb in db.POS_ShifTypes
                          where tb.Branch_ID == Settings.CurrentBranch_ID
                          select new { tb.ShifTypeCode, tb.ShifTypeName, tb.ID }).ToList();

            searchLookUpEdit1.Properties.DataSource = lookup;
     
        }



        private void Retrieve(long id)
        {
            mTable = db.POS_ShifTypes.Find(id);
            if (mTable == null)
            {
                btn_AddNew_ItemClick(null, null);
                return;
            }
            NewRecord = false;
            txtCode.Text = mTable.ShifTypeCode;
            txtName.Text = mTable.ShifTypeName;
            dtpFromTime.Value = mTable.FromTime == null ? DateTime.Now : (DateTime)mTable.FromTime;
            dtpToTime.Value = mTable.ToTime == null ? DateTime.Now : (DateTime)mTable.ToTime;

            var user = db.Users.FirstOrDefault(c => c.ID == mTable.UserCreate && c.Branch_ID == Settings.CurrentBranch_ID);
            lblUserCreate.Text = user.UserName;
            lblUserCreateDate.Text = mTable.CreationDate.ToString();
            user = db.Users.FirstOrDefault(c => c.ID == mTable.UserLastModified && c.Branch_ID == Settings.CurrentBranch_ID);
            if (user != null) lblUserLastModified.Text = user.UserName; else lblUserLastModified.Text = "";
            lbllblUserLastModifiedDate.Text = mTable.LastModified.ToString();


        }
         
        private void searchLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            if (searchLookUpEdit1.EditValue != null)
            {
                Retrieve((long)searchLookUpEdit1.EditValue);
                searchLookUpEdit1.EditValue = null;
            }
        }
         
        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCode.Text))
            {
                MessageBox.Show("Enter Name", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    mTable.ShifTypeCode = txtCode.Text;
                    mTable.ShifTypeName = txtName.Text;
                    mTable.FromTime = dtpFromTime.Value;
                    mTable.ToTime = dtpToTime.Value;

                    if (NewRecord)
                    {
                        mTable.Branch_ID = Settings.CurrentBranch_ID;
                        mTable.CreationDate = DateTime.Now;
                        mTable.UserCreate = Settings.CurrentUser_ID;

                        db.POS_ShifTypes.Add(mTable);

                    }
                    else
                    {
                        mTable.UserLastModified = Settings.CurrentUser_ID;
                        mTable.LastModified = DateTime.Now;
                        db.Entry(mTable).State = EntityState.Modified;
                    }
                    db.SaveChanges();

                   
                    transaction.Commit();
                    MessageBox.Show("Save Complete", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_AddNew_ItemClick(null, null);
                }
                catch (Exception exception)
                {
                    transaction.Rollback();
                    MessageBox.Show("Transaction Roll backed due to some exception");
                }
            }
            Filllookup();
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (NewRecord) return;

            if (MessageBox.Show("Are you sure you want to delete these item?", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                db.Entry(mTable).State = EntityState.Deleted;
                db.SaveChanges();
                btn_AddNew_ItemClick(null, null);
                Filllookup();
            }
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Hide();
        }

        private void btnCopy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mTable = new POS_ShifTypes();
            txtCode.Focus();
            txtCode.SelectAll();
            NewRecord = true;
            ID = 0;
            

            var user = db.Users.FirstOrDefault(c => c.ID == Settings.CurrentUser_ID && c.Branch_ID == Settings.CurrentBranch_ID);
            lblUserCreate.Text = user.UserName;
            lblUserCreateDate.Text = DateTime.Now.ToString();
            lblUserLastModified.Text = string.Empty;
            lbllblUserLastModifiedDate.Text = string.Empty;

        }

        private void btn_AddNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mTable = new POS_ShifTypes();
            NewRecord = true;
            txtCode.Focus();
            txtCode.Text = string.Empty;
            txtName.Text = string.Empty;
            txtRem.Text = string.Empty;
            searchLookUpEdit1.EditValue = null;
            ID = 0;

            dtpFromTime.Value = DateTime.Now;
            dtpToTime.Value = DateTime.Now; 

            var user = db.Users.FirstOrDefault(c => c.ID == Settings.CurrentUser_ID && c.Branch_ID == Settings.CurrentBranch_ID);
            lblUserCreate.Text = user.UserName;
            lblUserCreateDate.Text = DateTime.Now.ToString();
            lblUserLastModified.Text = string.Empty;
            lbllblUserLastModifiedDate.Text = string.Empty;

        }

        private void btnFirst_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var nav = db.POS_ShifTypes.Where(c => c.Branch_ID == Settings.CurrentBranch_ID).FirstOrDefault();
            if (nav == null) return;
            Retrieve(nav.ID);
        }

        private void btnNext_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!NewRecord)
            {
                var nav = db.POS_ShifTypes.Where(c => c.ID > mTable.ID && c.Branch_ID == Settings.CurrentBranch_ID).FirstOrDefault();
                if (nav == null) return;
                Retrieve(nav.ID);
            }
        }

        private void btnPrevious_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!NewRecord)
            {
                var nav = db.POS_ShifTypes.Where(c => c.ID < mTable.ID && c.Branch_ID == Settings.CurrentBranch_ID).OrderByDescending(c => c.ID).FirstOrDefault();
                if (nav == null) return;
                Retrieve(nav.ID);
            }
        }

        private void btnLast_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var nav = db.POS_ShifTypes.Where(c => c.Branch_ID == Settings.CurrentBranch_ID).OrderByDescending(c => c.ID).FirstOrDefault();
            if (nav == null) return;
            Retrieve(nav.ID); 
        }

        private void txtCode_Validated(object sender, EventArgs e)
        {
            var validated = db.POS_ShifTypes.FirstOrDefault(c => c.ShifTypeCode == txtCode.Text && c.Branch_ID == Settings.CurrentBranch_ID);
            if (validated != null)
            {
                Retrieve(validated.ID);
            }
        }

    





    }
}
