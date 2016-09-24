using System;
using System.Windows.Forms;

namespace POS
{
    public partial class FrmMachiens : SkyForm
    {
        public FrmMachiens()
        {
            InitializeComponent();
        }
        public FrmMachiens(MATRIX table, string FormName)
        {
            InitializeComponent();

            mTable = table;
            Text = FormName;
        }
        private MATRIX Setings = new MATRIX("Setings");
        public MATRIX mTable = new MATRIX("Machiens");

        private Boolean SaveMsgDontShow = false;
        private Boolean BasicDataNo = false;
        private Boolean NewRecord = false;
        private Boolean InProcess = false;
        public void btnNew_Click(System.Object sender, System.EventArgs e)
        {
            txtCode.Text = BasicDataNo ? mTable.Get_New("Code") : "";
            if (BasicDataNo)
                txtName.Focus();

            NewRecord = true;
            txtName.Text = ""; 
            txtIP.Text = "";
            txtPort.Text = ""; 

        }

        public void btnSave_Click(System.Object sender, System.EventArgs e)
        {
            if (txtCode.Text.Trim() == "")
            {
                MessageBox.Show("من فضلك ادخل الكود", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("من فضلك ادخل الاسم", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtIP.Text.Trim() == "")
            {
                MessageBox.Show("من فضلك ادخل ip", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtPort.Text.Trim() == "")
            {
                MessageBox.Show("من فضلك ادخل Port", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (NewRecord && mTable.find("Code=N\'" + txtCode.Text.Trim() + "\'"))
            {
                MessageBox.Show("الكود موجود من قبل...ولا يمكن اضافة جديد بهذا الكود", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCode.Text = "";
                return;
            }


            try
            {
                string TransACTIONID = Name + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Millisecond;
                mTable.ExecuteNonQuery("BEGIN TransACTION " + TransACTIONID);
                InProcess = true;
                mTable.Add_New();
                mTable.SetFiled("Code", (BasicDataNo ? Convert.ToInt64(txtCode.Text).ToString() : txtCode.Text));
                mTable.SetFiled("Name", txtName.Text);

                mTable.SetFiled("ip", txtIP.Text);
                mTable.SetFiled("port", txtPort.Text);





                mTable.Update("Code=N\'" + txtCode.Text.Trim() + "\'");
                mTable.ExecuteNonQuery("COMMIT TransACTION " + TransACTIONID);
                NewRecord = false;
                InProcess = false;
                if (SaveMsgDontShow)
                    btnNew_Click(null, null);
                else
                    if (MessageBox.Show("تم حفظ البيانات...هل تريد مستند جديد؟", "حفظ", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        btnNew_Click(null, null);
                    else
                        Retrieve();
              

            }
            catch (Exception Ex)
            {
                if (InProcess)
                {
                    ////mTable.ExecuteNonQuery("Rollback TransACTION " + TransACTIONID);
                    InProcess = false;
                }
                MessageBox.Show(Ex.Message);

            }




        }

        private void Retrieve()
        {
            NewRecord = false;


            mTable.View("Code=N\'" + txtCode.Text.Trim() + "\'");

            if (!mTable.DR.HasRows)
            {
                btnNew_Click(null, null);
                return;
            }

            txtCode.Text = mTable.GetFiled("Code");
            txtName.Text = mTable.GetFiled("Name");
            txtIP.Text = mTable.GetFiled("ip");
            txtPort.Text = mTable.GetFiled("Port");
             
        }

        public void btnCopyToNew_Click( Object sender, System.EventArgs e)
        {
            txtCode.Text = BasicDataNo ? mTable.Get_New("Code") : "";
            NewRecord = true;
            txtName.Text = "نسخة من " + txtName.Text;
            txtCode.Focus();

        }



  

        public void btnDelete_Click(System.Object sender, System.EventArgs e)
        { 

            if (MessageBox.Show("سوف يتم حذف...هل هل انت متاكد؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                mTable.Delete("Code=N\'" + txtCode.Text.Trim() + "\'");
                btnNew_Click(null, null);
            
            }
        }

        public void btnMoveFirst_Click(System.Object sender, System.EventArgs e)
        {
            mTable.MoveFrist(txtCode, BasicDataNo);
            Retrieve();
        }

        public void btnMoveNext_Click(System.Object sender, System.EventArgs e)
        {
            mTable.MoveNext(txtCode, BasicDataNo);
            Retrieve();
        }

        public void btnMovePrevious_Click(System.Object sender, System.EventArgs e)
        {
            mTable.MovePrevious(txtCode, BasicDataNo);
            Retrieve();
        }

        public void btnMoveLast_Click(System.Object sender, System.EventArgs e)
        {
            mTable.MoveLast(txtCode, BasicDataNo);
            Retrieve();
        }

        public void btnExit_Click(System.Object sender, System.EventArgs e)
        {
            this.Close();
        }

        public void btnSearchByName_Click(System.Object sender, System.EventArgs e)
        {
            mTable.Search(txtCode, "Code الكـــود,Name الاســــم", " 1=1 order by " + (BasicDataNo ? "CONVERT(INT,code)" : "Code"));
            Retrieve();
        }

    
        private void FrmMachiens_Load(object sender, EventArgs e)
        {
            Setings.View();
            SaveMsgDontShow = Convert.ToBoolean(Setings.GetFiled("SaveMsgDontShow"));
            BasicDataNo = Convert.ToBoolean(Setings.GetFiled("BasicDataNo"));

            btnNew_Click(null, null);
        }

        private void FrmMachiens_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N)
            {
                btnNew_Click(null, null);
            }
            else if (e.Control && e.KeyCode == Keys.S)
            {
                btnSave_Click(null, null);
            }
            else if (e.Control && e.KeyCode == Keys.R)
            {
                Retrieve();
            }
            else if (e.Control && e.KeyCode == Keys.F)
            {
                btnSearchByName_Click(null, null);
            }
            else if (e.Control && e.KeyCode == Keys.Q)
            {
                btnCopyToNew_Click(null, null);
            }
            else if (e.Control && e.KeyCode == Keys.D)
            {
                ButSearchByCode_Click(null, null);
            }
            else if (e.Control && e.KeyCode == Keys.T)
            {
            }
        }

        private void ButSearchByCode_Click(object sender, EventArgs e)
        {
            try
            {
                txtCode.Text = mTable.SearchByCode("Code");
                Retrieve();
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message, "بحث بالكود", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
