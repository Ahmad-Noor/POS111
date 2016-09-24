using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class frmPOS_CasherOpenBalance : Form
    {
        public frmPOS_CasherOpenBalance()
        {
            InitializeComponent();
        }
        DBEntities db = new DBEntities();
       public bool Status { get; set; }
        private void frmPOS_CasherOpenBalance_Load(object sender, EventArgs e)
        {
            var ss = db.POS_ShiftsTransaction.Where(c => c.Branch_ID == Settings.CurrentBranch_ID && c.ID == Settings.CurrentShift_ID).FirstOrDefault();
            lblShiftNo.Text = ss.OrderNo.ToString();
            var us = db.Users.Where(c => c.Branch_ID == Settings.CurrentBranch_ID && c.ID == Settings.CurrentUser_ID).FirstOrDefault();

            lblCasherName.Text = us.UserName;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            POS_ShiftsTransaction2 st = new POS_ShiftsTransaction2();
            st.CreationDate = DateTime.Now;
            st.UserCreate = Settings.CurrentUser_ID;
            st.Branch_ID = Settings.CurrentBranch_ID;

            st.Master_ID = Settings.CurrentShift_ID;
            st.User_ID = Settings.CurrentUser_ID;
            st.Casher_StartBalance = (double)nuStartBalance.Value;
            st.Casher_Status = 1;
            db.POS_ShiftsTransaction2.Add(st);
            db.SaveChanges();
            Status = true;
            Close();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Status = false;
            Close();
        }
    }
}
