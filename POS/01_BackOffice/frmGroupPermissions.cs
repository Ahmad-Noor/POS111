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
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraScheduler;

namespace POS
{
    public partial class frmGroupPermissions : SkyForm
    {
        public frmGroupPermissions()
        {
            InitializeComponent();
            this.ActiveControl = txtCode;
        }

        private DBEntities db = new DBEntities();
        private bool NewRecord = false;
        GroupPermission mTable = new GroupPermission();
        long ID;



        private void frmGroupPermissions_Load(object sender, EventArgs e)
        {
            btn_AddNew_Click(null, null);



            searchLookUpEdit1.Properties.ValueMember = "ID";
            searchLookUpEdit1.Properties.DisplayMember = "GroupName";
            searchLookUpEdit1.Properties.View.Columns.AddField("ID").Visible = false;
            searchLookUpEdit1.Properties.View.Columns.AddField("GroupCode").Visible = true;
            searchLookUpEdit1.Properties.View.Columns.AddField("GroupName").Visible = true;
            searchLookUpEdit1.Properties.TextEditStyle = TextEditStyles.Standard;
            Filllookup();

        }

        void Filllookup()
        {
            var lookup = (from tb in db.GroupPermissions
                          where tb.Branch_ID == Settings.CurrentBranch_ID
                          select new { tb.GroupCode, tb.GroupName, tb.ID }).ToList();

            searchLookUpEdit1.Properties.DataSource = lookup;

        }



        private void Retrieve(long id)
        {
            mTable = db.GroupPermissions.Find(id);
            if (mTable == null)
            {
                btn_AddNew_Click(null, null);
                return;
            }
            NewRecord = false;
            txtCode.Text = mTable.GroupCode;
            txtName.Text = mTable.GroupName;
        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            mTable = new GroupPermission();
            NewRecord = true;
            txtCode.Focus();
            txtCode.Text = string.Empty;
            txtName.Text = string.Empty;
            txtRem.Text = string.Empty;
            searchLookUpEdit1.EditValue = null;
        }

        private void btnSave_Click(object sender, EventArgs e)
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
                    mTable.GroupCode = txtCode.Text;
                    mTable.GroupName = txtName.Text;

                    if (NewRecord)
                    {
                        mTable.Branch_ID = Settings.CurrentBranch_ID;
                        mTable.CreationDate = DateTime.Now;
                        mTable.UserCreate = Settings.CurrentUser_ID;

                        db.GroupPermissions.Add(mTable);

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
                    btn_AddNew_Click(null, null);
                }
                catch (Exception exception)
                {
                    transaction.Rollback();
                    MessageBox.Show("Transaction Roll backed due to some exception");
                }
            }
            Filllookup();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnCopy_Click(object sender, EventArgs e)
        {
            mTable = new GroupPermission();
            txtCode.Focus();
            txtCode.SelectAll();
            NewRecord = true;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (NewRecord) return;

            if (MessageBox.Show("Are you sure you want to delete these item?", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                db.Entry(mTable).State = EntityState.Deleted;
                db.SaveChanges();
                btn_AddNew_Click(null, null);
                Filllookup();
            }
        }

        private void searchLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            if (searchLookUpEdit1.EditValue != null)
            {
                btn_AddNew_Click(null, null);
                Retrieve((long)searchLookUpEdit1.EditValue);
                searchLookUpEdit1.EditValue = null;
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            var nav = db.GroupPermissions.Where(c => c.Branch_ID == Settings.CurrentBranch_ID).FirstOrDefault();
            if (nav == null) return;
            Retrieve(nav.ID);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            var nav = db.GroupPermissions.Where(c => c.Branch_ID == Settings.CurrentBranch_ID).OrderByDescending(c => c.ID).FirstOrDefault();
            if (nav == null) return;
            Retrieve(nav.ID);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!NewRecord)
            {
                var nav = db.GroupPermissions.Where(c => c.ID > mTable.ID).Where(c => c.Branch_ID == Settings.CurrentBranch_ID).FirstOrDefault();
                if (nav == null) return;
                Retrieve(nav.ID);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (!NewRecord)
            {
                var nav = db.GroupPermissions.Where(c => c.ID < mTable.ID).OrderByDescending(c => c.ID).Where(c => c.Branch_ID == Settings.CurrentBranch_ID).FirstOrDefault();
                if (nav == null) return;
                Retrieve(nav.ID);
            }
        }
    }
}
