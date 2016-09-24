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
    public partial class frmBranches : Sky_UserControl
    {
        public frmBranches()
        {
            InitializeComponent();
            this.ActiveControl = txtCode;
        }

        private DBEntities db = new DBEntities();
        private bool NewRecord = false;
        Branch mTable = new Branch();
        long ID = 0;
        public void PictureBox1_MouseClick(System.Object sender, System.Windows.Forms.MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                fill_pic();
            }
            else if (e.Button == MouseButtons.Right)
            {
                Logo.Image = null;
            }
        }
        public void fill_pic(bool Clear_Pic = true)
        {
            if (Clear_Pic == true)
            {
                OpenFileDialog filedialog = new OpenFileDialog();
                ImageList imagelst = new ImageList();
                filedialog.Filter = "Images|*.BMP;*.GIF;*.JPG;*.png";
                if (filedialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imagelst.ColorDepth = ColorDepth.Depth32Bit;
                    imagelst.ImageSize = new System.Drawing.Size(160, 160);
                    imagelst.Images.Add(Image.FromFile(filedialog.FileName));
                    Logo.Image = imagelst.Images[0];
                }
            }
            else
            {
                Logo.Image = null;
            }

        }


        private void FrmBranches_Load(object sender, EventArgs e)
        {
            panelControl1.Dock = DockStyle.None;
            panelControl1.Dock = DockStyle.Fill;
            btn_AddNew_ItemClick(null, null);


            searchLookUpEdit1.Properties.ValueMember = "ID";
            searchLookUpEdit1.Properties.DisplayMember = "BranchName";
            searchLookUpEdit1.Properties.View.Columns.AddField("ID").Visible = false;
            searchLookUpEdit1.Properties.View.Columns.AddField("BranchCode").Visible = true;
            searchLookUpEdit1.Properties.View.Columns.AddField("BranchName").Visible = true;
            searchLookUpEdit1.Properties.TextEditStyle = TextEditStyles.Standard;
            Filllookup();


        }
        void Filllookup()
        {
            var lookup = (from tb in db.Branches
                          select new { tb.BranchCode, tb.BranchName, tb.ID }).ToList();

            searchLookUpEdit1.Properties.DataSource = lookup;

        }
        private void Retrieve(long id)
        {
            mTable = db.Branches.Find(id);
            if (mTable == null)
            {
                btn_AddNew_ItemClick(null, null);
                return;
            }
            NewRecord = false;

            ID = mTable.ID;
            txtCode.Text = mTable.BranchCode;
            txtName.Text = mTable.BranchName;
            txtAddress.Text = mTable.Address;
            txtTel1.Text = mTable.Tel1;
            txtTel2.Text = mTable.Tel2;
            txtMobile1.Text = mTable.Mobile1;
            txtMobile2.Text = mTable.Mobile2;
            txtFax.Text = mTable.Fax;
            txtCommercialNo.Text = mTable.CommercialNo;
            txtEmail.Text = mTable.Email;
            txtSiteURL.Text = mTable.SiteURL;
            txtRem.Text = mTable.Rem;

            if (mTable.Logo != null)
            {
                byte[] ap1 = (byte[])mTable.Logo;
                var ms = new MemoryStream(ap1);
                Logo.Image = Image.FromStream(ms);
                ms.Close();
            }
            else
            {
                Logo.Image = null;
            }

            var user = db.Users.FirstOrDefault(c => c.ID == mTable.UserCreate && c.Branch_ID == Settings.CurrentBranch_ID);
            lblUserCreate.Text = user.UserName;
            lblUserCreateDate.Text = mTable.CreationDate.ToString();
            user = db.Users.FirstOrDefault(c => c.ID == mTable.UserLastModified && c.Branch_ID == Settings.CurrentBranch_ID);
            if (user != null) lblUserLastModified.Text = user.UserName; else lblUserLastModified.Text = "";
            lbllblUserLastModifiedDate.Text = mTable.LastModified.ToString();
        }
         
        private void btn_AddNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mTable = new Branch();
            NewRecord = true;
            ID = 0;
            txtCode.Text = string.Empty;
            txtName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtTel1.Text = string.Empty;
            txtTel2.Text = string.Empty;
            txtMobile1.Text = string.Empty;
            txtMobile2.Text = string.Empty;
            txtFax.Text = string.Empty;
            txtCommercialNo.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtSiteURL.Text = string.Empty;
            txtRem.Text = string.Empty;
            Logo.Image = null;

            var user = db.Users.FirstOrDefault(c => c.ID == Settings.CurrentUser_ID && c.Branch_ID == Settings.CurrentBranch_ID);
            lblUserCreate.Text = user.UserName;
            lblUserCreateDate.Text = DateTime.Now.ToString();
            lblUserLastModified.Text = string.Empty;
            lbllblUserLastModifiedDate.Text = string.Empty;
        }

        private void btnCopy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mTable = new Branch();
            NewRecord = true;
            ID = 0;



            var user = db.Users.FirstOrDefault(c => c.ID == Settings.CurrentUser_ID && c.Branch_ID == Settings.CurrentBranch_ID);
            lblUserCreate.Text = user.UserName;
            lblUserCreateDate.Text = DateTime.Now.ToString();
            lblUserLastModified.Text = string.Empty;
            lbllblUserLastModifiedDate.Text = string.Empty;
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
                    mTable.BranchCode = txtCode.Text;
                    mTable.BranchName = txtName.Text;
                    mTable.Address = txtAddress.Text;
                    mTable.Tel1 = txtTel1.Text;
                    mTable.Tel2 = txtTel2.Text;
                    mTable.Mobile1 = txtMobile1.Text;
                    mTable.Mobile2 = txtMobile2.Text;
                    mTable.Fax = txtFax.Text;
                    mTable.CommercialNo = txtCommercialNo.Text;
                    mTable.Email = txtEmail.Text;
                    mTable.SiteURL = txtSiteURL.Text;
                    mTable.Rem = txtRem.Text;

                    if (Logo.Image != null)
                    {
                        Bitmap newBitmap1 = new Bitmap(Logo.Image);
                        var ms1 = new MemoryStream();
                        newBitmap1.Save(ms1, ImageFormat.Jpeg);
                        byte[] photoAray1 = new byte[ms1.Length];
                        ms1.Position = 0;
                        ms1.Read(photoAray1, 0, photoAray1.Length);
                        ms1.Close();
                        mTable.Logo = photoAray1;
                    }
                    else
                    {
                        mTable.Logo = null;
                    }
                    if (NewRecord)
                    {
                        mTable.CreationDate = DateTime.Now;
                        mTable.UserCreate = Settings.CurrentUser_ID;
                        db.Branches.Add(mTable);
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
                    Filllookup();

                    btn_AddNew_ItemClick(null, null);
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
                MessageBox.Show("Are you sure you want to delete these item?", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
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
            var nav = db.Branches.FirstOrDefault();
            if (nav == null) return;
            Retrieve(nav.ID);
        }

        private void btnNext_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!NewRecord)
            {
                var nav = db.Branches.Where(c => c.ID > mTable.ID  ).FirstOrDefault();
                if (nav == null) return;
                Retrieve(nav.ID);
            }
        }

        private void btnPrevious_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!NewRecord)
            {
                var nav = db.Branches.Where(c => c.ID < mTable.ID ).OrderByDescending(c => c.ID).FirstOrDefault();
                if (nav == null) return;
                Retrieve(nav.ID);
            }
        }

        private void btnLast_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var nav = db.Branches.OrderByDescending(c => c.ID).FirstOrDefault();
            if (nav == null) return;
            Retrieve(nav.ID);
        }

        private void txtCode_Validated(object sender, EventArgs e)
        {
            var validated = db.Branches.FirstOrDefault(c => c.BranchCode == txtCode.Text);
            if (validated != null)
            {
                Retrieve(validated.ID);
            }

        }
     



    }
}
