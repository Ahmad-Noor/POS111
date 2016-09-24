using System;
using System.Windows.Forms;

namespace POS
{
    public partial class FrmPermissions : SkyForm
    {
        public FrmPermissions()
        {
            InitializeComponent();
        }

        private MATRIX mTable = new MATRIX("Permission");
        private MATRIX Setings = new MATRIX("Setings");
        private string ShiftOrderNo = "";
        private string s = "";
        //int x = 0; 


        private Boolean SaveMsgDontShow = false;
        private Boolean BasicDataNo = false;
        private Boolean NewRecord = false;

        public void btnNew_Click(System.Object sender, System.EventArgs e)
        {
            s = " Year=" + Settings.CurrentYear + "   ";
            txtOrderNo.Text = mTable.Get_New("orderNo", s);
            NewRecord = true;


            //txtAmount.Text = "";

            txtRem.Text = "";

            label7.Text = "";
            btnSave.Enabled = true;
            btnDelete.Enabled = true;

            cmbEmployees.SelectedIndex = 0;

            chkWithoutSalary.Checked = false;
        }

        public void btnSave_Click(System.Object sender, System.EventArgs e)
        {
            if (txtOrderDate.Value.Year != Settings.CurrentYear)
            {
                MessageBox.Show("هذه الحركة لا تخص السنة الحالية", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }





            try
            {

                if (NewRecord)
                {
                    s = " Year=" + Settings.CurrentYear + "   and OrderNo=" + txtOrderNo.Text;
                    Settings.ExecuteReader("select OrderNo from Permission where " + s);

                    if (Settings.DR.HasRows)
                    {
                        s = " Year=" + Settings.CurrentYear + "  ";
                        txtOrderNo.Text = mTable.Get_New("orderNo", s);
                    }
                }

                mTable.Add_New();
                mTable.SetFiled("Year", Settings.CurrentYear);
                mTable.SetFiled("Branch_ID", Settings.CurrentBranch_ID);
                mTable.SetFiled("OrderNo", txtOrderNo.Text);

                mTable["OrderDate"] = txtOrderDate.Value.Date;
                mTable["FromTime"] = txtFromTime.Text;
                mTable["ToTime"] = txtToTime.Text;
                mTable["EmployeeCode"] = cmbEmployees.SelectedValue;
                mTable["WithoutSalary"] = chkWithoutSalary.Checked;

                //mTable.SetFiled("Amount", txtAmount.Text);

                mTable.SetFiled("Rem", txtRem.Text);

                mTable.SetFiled("Posted", 0);
                mTable.SetFiled("UserCode", Settings.CurrentUser_ID);

                s = " Year=" + Settings.CurrentYear + "   and OrderNo=" + txtOrderNo.Text;
                mTable.Update(s);
                //mTable.ExecuteNonQuery("COMMIT TransACTION " + TransACTIONID);


                NewRecord = false;

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

                MessageBox.Show(Ex.Message);
                return;
            }

        }

        public void Retrieve()
        {
            NewRecord = false;

            s = " Year=" + Settings.CurrentYear + "    and OrderNo=" + txtOrderNo.Text;

            mTable.View(s);
            if (!mTable.DR.HasRows)
            {
                btnNew_Click(null, null);
                return;
            }
            btnSave.Enabled = true;
            btnDelete.Enabled = true;
            btnPost.Enabled = true;
            label7.Text = "تحت الاعتماد";


            if (mTable.GetFiled("Posted") == "1")
            {
                btnSave.Enabled = false;
                btnDelete.Enabled = false;
                btnPost.Enabled = false;
                label7.Text = "تم الترحيل";
            }
            if (mTable.GetFiled("Posted") == "2")
            {
                btnSave.Enabled = false; btnDelete.Enabled = false;
                btnPost.Enabled = false;
                label7.Text = "الغاء";
            }
            txtRem.Text = mTable.GetFiled("Rem");
            //txtAmount.Text = mTable.GetFiled("Amount");
            txtOrderDate.Text = mTable.GetFiled("OrderDate");

            cmbEmployees.SelectedValue = mTable["EmployeeCode"];

            txtFromTime.Text = (string)mTable["FromTime"];
            txtToTime.Text = (string)mTable["ToTime"];
            chkWithoutSalary.Checked = (bool)mTable["WithoutSalary"];

        }

        public void btnDelete_Click(System.Object sender, System.EventArgs e)
        {

            if (NewRecord) return;
            if (MessageBox.Show("سوف يتم الغأ الحركة....هل انت منأكد؟", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {

                mTable.Add_New();
                mTable.SetFiled("Posted", 2);
                s = " Year=" + Settings.CurrentYear + "   and OrderNo=" + txtOrderNo.Text;
                mTable.Update(s);

                Retrieve();
            }

        }



        public void btnFirst_Click(System.Object sender, System.EventArgs e)
        {
            s = "Year=" + Settings.CurrentYear + "  ";
            mTable.MoveFrist(txtOrderNo, s);
            Retrieve();
        }

        public void btnNext_Click(System.Object sender, System.EventArgs e)
        {
            s = "Year=" + Settings.CurrentYear + "  ";
            mTable.MoveNext(txtOrderNo, s);
            Retrieve();
        }

        public void btnPrevious_Click(System.Object sender, System.EventArgs e)
        {
            s = "Year=" + Settings.CurrentYear + "  ";
            mTable.MovePrevious(txtOrderNo, s);
            Retrieve();
        }

        public void btnLast_Click(System.Object sender, System.EventArgs e)
        {
            s = "Year=" + Settings.CurrentYear + "  ";
            mTable.MoveLast(txtOrderNo, s);
            Retrieve();
        }

        public void btnExit_Click(System.Object sender, System.EventArgs e)
        {
            this.Close();
        }

        public void btnSearchByName_Click(System.Object sender, System.EventArgs e)
        {

            var s1 = "SELECT OrderNo رقم, OrderDate التاريخ,Amount المبلغ FROM dbo.Permission where Year=" + Settings.CurrentYear;
            Settings.Search(txtOrderNo, s1);
            Retrieve();
        }


        private void FrmPermissions_Load(object sender, EventArgs e)
        {
            //Settings.OpenShift();
            Setings.View();
            SaveMsgDontShow = Convert.ToBoolean(Setings.GetFiled("SaveMsgDontShow"));
            BasicDataNo = Convert.ToBoolean(Setings.GetFiled("BasicDataNo"));

            FillEmployees();
            btnNew_Click(null, null);

        }

        private void FillEmployees()
        {
            var v = new MATRIX("Employees");
            v.FillComboBox(cmbEmployees);
        }
        private void FrmPermissions_KeyDown(object sender, KeyEventArgs e)
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

            }
            else if (e.Control && e.KeyCode == Keys.D)
            {
                ButSearchByCode_Click(null, null);
            }
        }

        private void ButSearchByCode_Click(object sender, EventArgs e)
        {
            try
            {
                txtOrderNo.Text = mTable.SearchByCode("Code");
                Retrieve();
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message, "بحث بالكود", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void btnPost_Click(object sender, EventArgs e)
        {
            if (NewRecord) return;
            if (MessageBox.Show("سوف يتم ترحيل الحركة....هل انت منأكد؟", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
            {

                mTable.Add_New();
                mTable.SetFiled("Posted", 1);
                mTable["UserCode2"] = Settings.CurrentUser_ID;
                s = " Year=" + Settings.CurrentYear + "   and OrderNo=" + txtOrderNo.Text;
                mTable.Update(s);

                Retrieve();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FrmEmployees frm = new FrmEmployees();
            frm.ShowDialog();
            FillEmployees();
        }



    }
}
