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
using DevExpress.DXperience.Demos;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraScheduler;

namespace POS
{
    public partial class frmUsers : Sky_UserControl{
        public frmUsers()
        {
            InitializeComponent();
          
        }

        private DBEntities db = new DBEntities();
        private bool NewRecord = false;
        User mTable = new User();
        long ID;



        private void FrmUsers_Load(object sender, EventArgs e)
        {
            btnNew_Click(null, null);

            var list = db.ScreensPermissions.ToList();
            grd.DataSource = list;

            gridView2.Columns[0].Visible = false;
            gridView2.Columns[1].Visible = false;
            searchLookUpEdit1.Properties.ValueMember = "ID";
            searchLookUpEdit1.Properties.DisplayMember = "UserName";
            searchLookUpEdit1.Properties.View.Columns.AddField("ID").Visible = false;
            searchLookUpEdit1.Properties.View.Columns.AddField("UserCode").Visible = true;
            searchLookUpEdit1.Properties.View.Columns.AddField("UserName").Visible = true;
            searchLookUpEdit1.Properties.TextEditStyle = TextEditStyles.Standard;
            Filllookup();

        }

        void Filllookup()
        {
            var lookup = (from tb in db.Users
                          where tb.Branch_ID == Settings.CurrentBranch_ID
                          select new { tb.UserCode, tb.UserName, tb.ID }).ToList();

            searchLookUpEdit1.Properties.DataSource = lookup;

        }



        private void btnNew_Click(object sender, EventArgs e)
        {


        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void Retrieve(long id)
        {
            mTable = db.Users.Find(id);
            if (mTable == null)
            {
                btnNew_Click(null, null);
                return;
            }
            NewRecord = false;
            txtCode.Text = mTable.UserCode;
            txtName.Text = mTable.UserName;

            txtPassword.Text = mTable.UserPassword;


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }


        private void searchLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            //if (searchLookUpEdit1.EditValue != null)
            //{
            //     Retrieve( (long)searchLookUpEdit1.EditValue );
            //}
        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            mTable = new User();
            NewRecord = true;

            txtCode.Text = string.Empty;
            txtName.Text = string.Empty;
            txtRem.Text = string.Empty;
            txtPassword.Text = string.Empty;
            ID = 0;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCode.Text))
            {
                MessageBox.Show("ادخل الاسم", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    mTable.UserCode = txtCode.Text;
                    mTable.UserName = txtName.Text;
                    mTable.UserPassword = txtPassword.Text;
                    if (NewRecord)
                    {

                        mTable.CreationDate = DateTime.Now;
                        mTable.UserCreate = Settings.CurrentUser_ID;
                        db.Users.Add(mTable);

                    }
                    else
                    {
                        mTable.UserLastModified = Settings.CurrentUser_ID;
                        mTable.LastModified = DateTime.Now;
                        db.Entry(mTable).State = EntityState.Modified;
                    }
                    db.SaveChanges();

                    transaction.Commit();
                    MessageBox.Show("تم الحفظ", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew_Click(null, null); Filllookup();
                }
                catch (Exception exception)
                {
                    transaction.Rollback();
                    MessageBox.Show("Transaction Roll backed due to some exception");
                }
            }

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (NewRecord) return;
            if (
                MessageBox.Show("Are you sure you want to delete these item?", "Delete Item", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                db.Entry(mTable).State = EntityState.Deleted;
                db.SaveChanges();
                btnNew_Click(null, null);
                Filllookup();
            }
        }

        private void searchLookUpEdit1_EditValueChanged_1(object sender, EventArgs e)
        {
            if (searchLookUpEdit1.EditValue != null)
            {
                btn_AddNew_Click(null, null);
                Retrieve((long)searchLookUpEdit1.EditValue);
                searchLookUpEdit1.EditValue = null;
            }

            searchLookUpEdit1.EditValue = null;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {

            ID = 0;
            mTable = new User();
            txtCode.Focus();
            txtCode.SelectAll();
            NewRecord = true;
        }
    }
}
