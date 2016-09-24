using System;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
//using System.Data.Entity;
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
    public partial class frmPOS_Expenses : Sky_UserControl
    {
        public frmPOS_Expenses()
        {
            InitializeComponent();
        }

        private DBEntities db = new DBEntities();
        private bool NewRecord = false;
        POS_Expenses mTable = new POS_Expenses();
        long ID;



        private void frmPOS_Expenses_Load(object sender, EventArgs e)
        {
            panelControl1.Dock = DockStyle.None;
            panelControl1.Dock = DockStyle.Fill;
            btn_AddNew_ItemClick(null, null);



            var lookup = (from tb in db.POS_ExpensesTypes
                          where tb.Branch_ID == Settings.CurrentBranch_ID
                          select new { tb.ExpensCode, tb.ExpensName, tb.ID }).ToList();
            LookUpxpensType.Properties.DataSource = lookup;
            LookUpxpensType.Properties.ValueMember = "ID";
            LookUpxpensType.Properties.DisplayMember = "ExpensName";
            LookUpxpensType.Properties.View.Columns.AddField("ID").Visible = false;
            LookUpxpensType.Properties.View.Columns.AddField("ExpensCode").Visible = true;
            LookUpxpensType.Properties.View.Columns.AddField("ExpensName").Visible = true;

            LookUpxpensType.Properties.TextEditStyle = TextEditStyles.Standard;




            LookUp.Properties.ValueMember = "ID";
            LookUp.Properties.DisplayMember = "OrderNo";

            LookUp.Properties.View.Columns.AddField("ID").Visible = false;
            LookUp.Properties.View.Columns.AddField("OrderNo").Visible = true;
            LookUp.Properties.View.Columns.AddField("ExpensesType_ID").Visible = true;
            LookUp.Properties.View.Columns.AddField("Amount").Visible = true;
            LookUp.Properties.View.Columns.AddField("Note").Visible = true;
            LookUp.Properties.TextEditStyle = TextEditStyles.Standard;

            Filllookup();

        }

        void Filllookup()
        {
            var lookup1 = (from tb in db.POS_Expenses
                           where tb.Branch_ID == Settings.CurrentBranch_ID && tb.ShiftsTransaction_ID == Settings.CurrentShift_ID
                           select new { tb.OrderNo, tb.ExpensesType_ID, tb.Note, tb.Amount, tb.ID }).ToList();
            LookUp.Properties.DataSource = lookup1;
        }



        private void Retrieve(long id)
        {
            mTable = db.POS_Expenses.Find(id);
            if (mTable == null)
            {
                btn_AddNew_ItemClick(null, null);
                return;
            }
            NewRecord = false;

            ID = mTable.ID;
            txtOrderNo.Text = mTable.OrderNo.ToString();
            txtExpensTypeCode.Focus();
            txtExpensTypeCode.Tag = mTable.ExpensesType_ID;

            var ExpensesType = db.POS_ExpensesTypes.FirstOrDefault(c => c.ID == mTable.ExpensesType_ID && c.Branch_ID==Settings.CurrentBranch_ID);
            txtExpensTypeCode.Text = ExpensesType.ExpensCode;
            lblExpensTypeName.Text = ExpensesType.ExpensName;

            txtAmount.Value = (decimal)mTable.Amount;
            txtNote.Text = mTable.Note;

            var user = db.Users.FirstOrDefault(c => c.ID == mTable.UserCreate && c.Branch_ID == Settings.CurrentBranch_ID);
            lblUserCreate.Text = user.UserName;
            lblUserCreateDate.Text = mTable.CreationDate.ToString();
            user = db.Users.FirstOrDefault(c => c.ID == mTable.UserLastModified && c.Branch_ID == Settings.CurrentBranch_ID);
            if (user != null) lblUserLastModified.Text = user.UserName; else lblUserLastModified.Text = "";
            lbllblUserLastModifiedDate.Text = mTable.LastModified.ToString();




        }

  

        private void searchLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            if (LookUpxpensType.EditValue != null)
            {
                var ExpensesType = db.POS_ExpensesTypes.FirstOrDefault(c => c.ID == ((long)LookUpxpensType.EditValue) && c.Branch_ID == Settings.CurrentBranch_ID);
                txtExpensTypeCode.Tag = ExpensesType.ID;
                txtExpensTypeCode.Text = ExpensesType.ExpensCode;
                lblExpensTypeName.Text = ExpensesType.ExpensName;
                LookUpxpensType.EditValue = null;
            }
        }




        private void txtExpensTypeCode_Validated(object sender, EventArgs e)
        {
            var ExpensesType = db.POS_ExpensesTypes.FirstOrDefault(c => c.ExpensCode == txtExpensTypeCode.Text && c.Branch_ID==Settings.CurrentBranch_ID);
            if (ExpensesType == null) return;
            txtExpensTypeCode.Tag = ExpensesType.ID;
            lblExpensTypeName.Text = ExpensesType.ExpensName;
        }

        private void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {
            Settings.LoadControl(new frmPOS_ExpensesTypes());
        }

        private void LookUp_EditValueChanged(object sender, EventArgs e)
        {
            if (LookUp.EditValue != null)
            {  btn_AddNew_ItemClick(null, null);
                Retrieve((long)LookUp.EditValue); 
              LookUp.EditValue = null;
            }


 

            
        }
 
        private void btn_AddNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mTable = new POS_Expenses();

            NewRecord = true;
            txtOrderNo.Text = string.Empty;
            txtOrderNo.Tag = string.Empty;
            txtExpensTypeCode.Focus();

            txtExpensTypeCode.Text = string.Empty;
            txtExpensTypeCode.Tag = string.Empty;
            lblExpensTypeName.Text = string.Empty;
            txtAmount.Value = 0;
            txtNote.Text = string.Empty;
            LookUpxpensType.EditValue = null;
            LookUp.EditValue = null;

            var user = db.Users.FirstOrDefault(c => c.ID == Settings.CurrentUser_ID && c.Branch_ID == Settings.CurrentBranch_ID);
            lblUserCreate.Text = user.UserName;
            lblUserCreateDate.Text = DateTime.Now.ToString();
            lblUserLastModified.Text = string.Empty;
            lbllblUserLastModifiedDate.Text = string.Empty;

        }

        private void btnCopy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mTable = new POS_Expenses();
            txtOrderNo.Text = string.Empty;
            txtOrderNo.Tag = string.Empty;
            txtExpensTypeCode.Focus();
            txtExpensTypeCode.SelectAll();
            NewRecord = true;


            var user = db.Users.FirstOrDefault(c => c.ID == Settings.CurrentUser_ID && c.Branch_ID == Settings.CurrentBranch_ID);
            lblUserCreate.Text = user.UserName;
            lblUserCreateDate.Text = DateTime.Now.ToString();
            lblUserLastModified.Text = string.Empty;
            lbllblUserLastModifiedDate.Text = string.Empty;



        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (string.IsNullOrEmpty(txtExpensTypeCode.Text))
            {
                MessageBox.Show("Enter Expens Type", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {

                    mTable.ExpensesType_ID = (long?)txtExpensTypeCode.Tag;
                    mTable.Amount = (double?)txtAmount.Value;
                    txtNote.Text = mTable.Note;

                    if (NewRecord)
                    {

                        var ss = db.POS_Expenses.Where(c => c.Branch_ID == Settings.CurrentBranch_ID).Max(c => c.OrderNo);
                        mTable.OrderNo = ss == null ? 1 : ss + 1;
                        mTable.Branch_ID = Settings.CurrentBranch_ID;
                        mTable.CreationDate = DateTime.Now;
                        mTable.UserCreate = Settings.CurrentUser_ID;
                        mTable.ShiftsTransaction_ID = Settings.CurrentShift_ID;
                        mTable.User_ID = Settings.CurrentUser_ID;
                        db.POS_Expenses.Add(mTable);

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
                    btn_AddNew_ItemClick(null, null); Filllookup();
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

        private void btnFirst_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
  var nav = db.POS_Expenses.Where(c => c.Branch_ID == Settings.CurrentBranch_ID).FirstOrDefault();
            if (nav == null) return;
            Retrieve(nav.ID);
       
        }

        private void btnLast_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var nav = db.POS_Expenses.Where(c => c.Branch_ID == Settings.CurrentBranch_ID).OrderByDescending(c => c.ID).FirstOrDefault();
            if (nav == null) return;
            Retrieve(nav.ID);

        }

        private void btnNext_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!NewRecord)
            {
                var nav = db.POS_Expenses.Where(c => c.ID > mTable.ID && c.Branch_ID == Settings.CurrentBranch_ID).FirstOrDefault();
                if (nav == null) return;
                Retrieve(nav.ID);
            }

        }

        private void btnPrevious_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!NewRecord)
            {
                var nav = db.POS_Expenses.Where(c => c.ID < mTable.ID && c.Branch_ID == Settings.CurrentBranch_ID).OrderByDescending(c => c.ID).FirstOrDefault();
                if (nav == null) return;
                Retrieve(nav.ID);
            }

        }
    }
}
