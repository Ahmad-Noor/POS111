using System;
using System.Windows.Forms;

namespace POS
{
    public partial class FrmAtt : SkyForm
    {
        public FrmAtt(){
                    InitializeComponent();
        }

        private MATRIX Setings = new MATRIX("Setings");
        private MATRIX mTable = new MATRIX("AttendanceMovements");
        private MATRIX mTable2 = new MATRIX("AttendanceMovements2");
        private MATRIX Employees = new MATRIX("Employees");

        private bool SaveMsgDontShow = false;
        private bool BasicDataNo = false;
        private bool NewRecord = false;
        private bool InProcess = false;

        int mID = 0;
        public void btnNew_Click(System.Object sender, System.EventArgs e)
        {
            NewRecord = true;
            label7.Text = "جديد";
            txtShiftOrderNo.Text = "";
            txtTransDate.Value = DateTime.Now;
            txtEmployeeCode.Text = "";
            txtEmployeeName.Text = "";
            radioButton1.Checked = true;
            dtpAttTime.Value = DateTime.Now;
            txtEmployeeCode.Enabled = true;
            mID = 0;
        }

        public void btnSave_Click(System.Object sender, System.EventArgs e)
        {

            if (txtEmployeeName.Text.Trim() == "")
            {
                MessageBox.Show("من فضلك ادخل الموظف", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtShiftOrderNo.Text.Trim() == "")
            {
                MessageBox.Show("من فضلك ادخل الوردية", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            //try
            //{
            string TransACTIONID = Name + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Millisecond;
            mTable.ExecuteNonQuery("BEGIN TransACTION " + TransACTIONID);



            if (mTable.find("ID=" + mID))
            {
                mTable.Add_New();
                mTable.SetFiled("Year", Settings.CurrentYear);
                mTable.SetFiled("Branch_ID", Settings.CurrentBranch_ID);
                mTable.SetFiled("TransDate", Convert.ToDateTime(txtTransDate.Text + " " + dtpAttTime.Text));
                mTable.SetFiled("ShiftOrderNo", txtShiftOrderNo.Text);
                mTable.SetFiled("EmployeeCode", txtEmployeeCode.Text);
                mTable.SetFiled("TransType", radioButton1.Checked ? 1 : 0);

                mTable["dwYear"] = txtTransDate.Value.Year;
                mTable["dwMonth"] = txtTransDate.Value.Month;
                mTable["dwDay"] = txtTransDate.Value.Day;
                mTable["dwHour"] = dtpAttTime.Value.Hour;
                mTable["dwMinute"] = dtpAttTime.Value.Minute;
                mTable["dwSecond"] = dtpAttTime.Value.Second;

                mTable.Update("ID=" + mID);
                //---------------------------------------

                mTable2.Add_New();
                mTable2.SetFiled("ID", mID);
                mTable2.SetFiled("Year", Settings.CurrentYear);
                mTable2.SetFiled("Branch_ID", Settings.CurrentBranch_ID);
                mTable2.SetFiled("TransDate", Convert.ToDateTime(txtTransDate.Text + " " + dtpAttTime.Text));
                mTable2.SetFiled("ShiftOrderNo", txtShiftOrderNo.Text);
                mTable2.SetFiled("EmployeeCode", txtEmployeeCode.Text);
                mTable2.SetFiled("UserCode", Settings.CurrentUser_ID);
                mTable2.SetFiled("TransType", radioButton1.Checked ? 1 : 0);

                mTable2.SetFiled("TransTypeOld", radioButton1.Tag + "" == "true" ? 1 : 0);
                mTable2.SetFiled("TransDateOld", txtTransDate.Tag); 
                mTable2.Update();
            }
            else
            {
                mTable.Add_New();
                mTable.SetFiled("Year", Settings.CurrentYear);
                mTable.SetFiled("Branch_ID", Settings.CurrentBranch_ID);
                mTable.SetFiled("TransDate", Convert.ToDateTime(txtTransDate.Text + " " + dtpAttTime.Text));
                mTable.SetFiled("ShiftOrderNo", txtShiftOrderNo.Text);
                mTable.SetFiled("EmployeeCode", txtEmployeeCode.Text);
                mTable.SetFiled("TransType", radioButton1.Checked ? 1 : 0);
                mTable.Update();
            }


            mTable.ExecuteNonQuery("COMMIT TransACTION " + TransACTIONID);
            NewRecord = false;
            InProcess = false;


            if (SaveMsgDontShow)
                btnNew_Click(null, null);
            else
                if (MessageBox.Show("تم حفظ البيانات. ", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    btnNew_Click(null, null);

            //}
            //catch (Exception Ex)
            //{ 
            //    MessageBox.Show(Ex.Message); 
            //}




        }

        private void Retrieve()
        {
            NewRecord = false;

            mTable.View("Code=N\'" + txtEmployeeCode.Text.Trim() + "\'");

            if (!mTable.DR.HasRows)
            {
                btnNew_Click(null, null);
                return;
            }
            txtEmployeeName.Text = mTable.GetFiled("Name");
            //Convert.ToBoolean(mTable.GetFiled("Type"))     
        }

        public void btnCopyToNew_Click(System.Object sender, System.EventArgs e)
        {
            txtEmployeeCode.Text = BasicDataNo ? mTable.Get_New("Code") : "";
            NewRecord = true;
            txtEmployeeName.Text = "نسخة من " + txtEmployeeName.Text;
            txtEmployeeCode.Focus();

        }

        public void btnMoveFirst_Click(System.Object sender, System.EventArgs e)
        {
            mTable.MoveFrist(txtEmployeeCode, BasicDataNo);
            Retrieve();
        }

        public void btnMoveNext_Click(System.Object sender, System.EventArgs e)
        {
            mTable.MoveNext(txtEmployeeCode, BasicDataNo);
            Retrieve();
        }

        public void btnMovePrevious_Click(System.Object sender, System.EventArgs e)
        {
            mTable.MovePrevious(txtEmployeeCode, BasicDataNo);
            Retrieve();
        }

        public void btnMoveLast_Click(System.Object sender, System.EventArgs e)
        {
            mTable.MoveLast(txtEmployeeCode, BasicDataNo);
            Retrieve();
        }

        public void btnExit_Click(System.Object sender, System.EventArgs e)
        {
            this.Close();
        }

        public void btnSearchByName_Click(System.Object sender, System.EventArgs e)
        {
            mTable.Search(txtEmployeeCode, "Code الكـــود,Name الاســــم", " 1=1 order by " + (BasicDataNo ? "CONVERT(INT,code)" : "Code"));
            Retrieve();
        }

        private void FrmAtt_Load(object sender, EventArgs e)
        {
            Setings.View();
            SaveMsgDontShow = Convert.ToBoolean(Setings.GetFiled("SaveMsgDontShow"));
            BasicDataNo = Convert.ToBoolean(Setings.GetFiled("BasicDataNo"));



            btnNew_Click(null, null);
        }

        private void FrmAtt_KeyDown(object sender, KeyEventArgs e)
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

        }

        private void ButSearchByCode_Click(object sender, EventArgs e)
        {
            try
            {
                txtEmployeeCode.Text = mTable.SearchByCode("Code");
                Retrieve();
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message, "بحث بالكود", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtEmployeeCode_Validated(object sender, EventArgs e)
        {
            txtEmployeeName.Text = Employees.Get_Value("Name", "Code=N\'" + txtEmployeeCode.Text.Trim() + "\' ");

        }

        private void txtEmployeeCode_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Employees.Search(txtEmployeeCode, "Code الكـــود,Name الاســــم", " 1=1 order by " + (BasicDataNo ? "CONVERT(INT,code)" : "Code"));
            txtEmployeeCode_Validated(null, null);
        }
        string s = "";
        private void buttonEdit2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            s = " SELECT  dbo.ShiftsOpening.OrderNo رقم_الوردية, ";
            s += "        dbo.ShiftsOpening.OrderDate التاريخ , ";
            s += "        dbo.ShiftsOpening.ShiftCode كود_الوردية, ";
            s += "        dbo.Shifts.Name اسم_الوردية, ";
            s += "        dbo.ShiftsOpening.Rem ملاحظات ";
            s += " FROM    dbo.ShiftsOpening ";
            s += "        LEFT OUTER JOIN dbo.Shifts ON dbo.ShiftsOpening.ShiftCode = dbo.Shifts.Code ";
            s += " WHERE   ( dbo.ShiftsOpening.Branch_ID = N'" + Settings.CurrentBranch_ID + "' ) ";
            s += "        AND ( dbo.ShiftsOpening.Year = " + Settings.CurrentYear + " ) order by dbo.ShiftsOpening.OrderNo desc ";

            Settings.Search(txtShiftOrderNo, s);
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string s = "";
            s = "SELECT dbo.AttendanceMovements.ID, \n";
            s += "       dbo.AttendanceMovements.ShiftOrderNo, \n";
            s += "       TransName=(CASE WHEN dbo.AttendanceMovements.TransType=1 THEN 'حضور' ELSE 'انصراف' END ) , \n";
            s += "       dbo.AttendanceMovements.EmployeeCode, \n";
            s += "       CONVERT(NVARCHAR(10), dbo.AttendanceMovements.TransDate, 126) AS TransDate, \n";
            s += "       RIGHT(CONVERT(CHAR(20), TransDate, 22), 11) AS Timein, \n";
            s += "       dbo.Employees.Name EmployeeName \n";
            s += " FROM   dbo.AttendanceMovements \n";
            s += "       LEFT OUTER JOIN dbo.Employees \n";
            s += "         ON dbo.AttendanceMovements.EmployeeCode = dbo.Employees.Code   \n";
            s += " where   ( dbo.AttendanceMovements.Branch_ID = N'" + Settings.CurrentBranch_ID + "' ) AND ( dbo.AttendanceMovements.Year = " + Settings.CurrentYear + " ) \n";
            if (buttonEdit4.Text != "") s += " AND AttendanceMovements.ShiftOrderNo <=" + buttonEdit4.Text + "  \n";
            if (buttonEdit3.Text != "") s += " AND AttendanceMovements.ShiftOrderNo>=" + buttonEdit3.Text + "   ";
            if (buttonEdit1.Text != "") s += " AND AttendanceMovements.EmployeeCode='" + buttonEdit1.Text + "' \n";
            s += "     order by dbo.AttendanceMovements.TransDate ";

            Settings.Fill_Grid(grd, s);

        }

        private void buttonEdit1_Validated(object sender, EventArgs e)
        {
            textEdit1.Text = Employees.Get_Value("Name", "Code=N\'" + buttonEdit1.Text.Trim() + "\' ");
        }

        private void buttonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Employees.Search(buttonEdit1, "Code الكـــود,Name الاســــم", " 1=1 order by " + (BasicDataNo ? "CONVERT(INT,code)" : "Code"));
            buttonEdit1_Validated(null, null);
        }

        private void buttonEdit3_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            s = " SELECT  dbo.ShiftsOpening.OrderNo رقم_الوردية, ";
            s += "        dbo.ShiftsOpening.OrderDate التاريخ , ";
            s += "        dbo.ShiftsOpening.ShiftCode كود_الوردية, ";
            s += "        dbo.Shifts.Name اسم_الوردية, ";
            s += "        dbo.ShiftsOpening.Rem ملاحظات ";
            s += " FROM    dbo.ShiftsOpening ";
            s += "        LEFT OUTER JOIN dbo.Shifts ON dbo.ShiftsOpening.ShiftCode = dbo.Shifts.Code ";
            s += " WHERE   ( dbo.ShiftsOpening.Branch_ID = N'" + Settings.CurrentBranch_ID + "' ) ";
            s += "        AND ( dbo.ShiftsOpening.Year = " + Settings.CurrentYear + " ) order by dbo.ShiftsOpening.OrderNo desc ";

            Settings.Search(buttonEdit3, s);
        }

        private void buttonEdit4_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            s = " SELECT  dbo.ShiftsOpening.OrderNo رقم_الوردية, ";
            s += "        dbo.ShiftsOpening.OrderDate التاريخ , ";
            s += "        dbo.ShiftsOpening.ShiftCode كود_الوردية, ";
            s += "        dbo.Shifts.Name اسم_الوردية, ";
            s += "        dbo.ShiftsOpening.Rem ملاحظات ";
            s += " FROM    dbo.ShiftsOpening ";
            s += "        LEFT OUTER JOIN dbo.Shifts ON dbo.ShiftsOpening.ShiftCode = dbo.Shifts.Code ";
            s += " WHERE   ( dbo.ShiftsOpening.Branch_ID = N'" + Settings.CurrentBranch_ID + "' ) ";
            s += "        AND ( dbo.ShiftsOpening.Year = " + Settings.CurrentYear + " ) order by dbo.ShiftsOpening.OrderNo desc ";

            Settings.Search(buttonEdit4, s);
        }

        private void grd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            mID = (int)grd.CurrentRow.Cells["ID"].Value;
            txtEmployeeCode.Text = grd.CurrentRow.Cells["EmployeeCode"].Value.ToString();
            txtEmployeeCode_Validated(null, null);

            txtShiftOrderNo.Text = grd.CurrentRow.Cells["colShiftOrderNo"].Value.ToString();
            txtTransDate.Text = grd.CurrentRow.Cells["TransDate"].Value.ToString();
            txtTransDate.Tag = grd.CurrentRow.Cells["TransDate"].Value.ToString();
            radioButton1.Checked = grd.CurrentRow.Cells["TransName"].Value.ToString() == "حضور";
            radioButton1.Tag = grd.CurrentRow.Cells["TransName"].Value.ToString() == "حضور";
            radioButton2.Checked = !radioButton1.Checked;

            dtpAttTime.Text = grd.CurrentRow.Cells["Timein"].Value.ToString();
            dtpAttTime.Tag = grd.CurrentRow.Cells["Timein"].Value.ToString();


            txtEmployeeCode.Enabled = false;
        }

        private void grd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



    }
}
