using System;
using System.Windows.Forms;

namespace POS
{
    public partial class FrmPullMovements : SkyForm
    {
        public FrmPullMovements()
        {
            InitializeComponent();
        }

        private Boolean connected = false;


        //zkemkeeper.CZKEMClass axCZKEM1 = new zkemkeeper.CZKEMClass();
        private void btnConnect_Click(object sender, EventArgs e)
        {
            //if (!connected)
            //{
            //    if (cmbMachines.SelectedIndex <= 0)
            //    {
            //        MessageBox.Show("من فضلك اختار الماكينة");
            //        return;
            //    }
            //    Cursor = Cursors.WaitCursor;
            //    label1.Text = "جاري الاتصال";
            //    timer1.Enabled = true;
            //    connected = axCZKEM1.Connect_Net(txtIP.Text, int.Parse(txtPort.Text));
            //    if (connected)
            //    {
            //        axCZKEM1.RegEvent(1, 65535);
            //        timer1.Enabled = false;
            //        label1.Text = "تم الاتصال بنجاح!!";
            //        btnConnect.Image = Properties.Resources.SymbolCheck32;
            //        btnConnect.Text = "قطع الاتصال";

            //    }
            //    else
            //    {
            //        axCZKEM1.Disconnect();
            //        btnConnect.Text = " اتصال";
            //        connected = false;
            //    }
            //}
            //else
            //{
            //    axCZKEM1.Disconnect();
            //    label1.Text = "تم قطع الاتصال";
            //    btnConnect.Text = " اتصال";
            //    connected = false;
            //}
            //Cursor = Cursors.Default;
            //enable();
        }


        void enable()
        {
            btnPullMovements.Enabled = connected;
            btnPullMovementsandDelete.Enabled = connected;
            btnBackup.Enabled = connected;
            btnRestor.Enabled = connected;



        }
        int iMachineNumber = 1;
        private void btnPullMovements_Click(object sender, EventArgs e)
        {
            Drag_Move();
        }

        void Drag_Move()
        {
            //grd.Rows.Count = 1;
            //if (connected)
            //{
            //    var attendanceMovements = new MATRIX("AttendanceMovements");

            //    Cursor = Cursors.WaitCursor;

            //    axCZKEM1.EnableDevice(iMachineNumber, false);//disable the device
            //    if (axCZKEM1.ReadGeneralLogData(iMachineNumber))//read all the attendance records to the memory
            //    {
            //        int idwErrorCode = 0;
            //        int idwTMachineNumber = 0;
            //        int idwEnrollNumber = 0;
            //        int idwEMachineNumber = 0;
            //        string sdwEnrollNumber = "";
            //        int idwVerifyMode = 0;
            //        int idwInOutMode = 0;
            //        int idwYear = 0;
            //        int idwMonth = 0;
            //        int idwDay = 0;
            //        int idwHour = 0;
            //        int idwMinute = 0;
            //        int idwSecond = 0;
            //        int idwWorkcode = 0;

            //        int iGLCount = 0;
            //        int iIndex = 0;

            //        while (axCZKEM1.GetGeneralLogData(iMachineNumber, ref idwTMachineNumber, ref idwEnrollNumber, ref idwEMachineNumber, ref idwVerifyMode, ref idwInOutMode, ref idwYear, ref idwMonth, ref idwDay, ref idwHour, ref idwMinute))//get records from the memory
            //        {
            //            attendanceMovements.Add_New();
            //            attendanceMovements["Year"] = Pub.CurrentYear;
            //            attendanceMovements["Branch_ID"] = Pub.CurrentBranch;

            //            var mEmployees = new MATRIX("Employees");
            //            if (mEmployees.find(" FingerPrintCode=" + idwWorkcode + sdwEnrollNumber + idwVerifyMode))
            //            {
            //                attendanceMovements["EmployeeCode"] = mEmployees["Code"];

            //                var mEmployeesShifts = new MATRIX("EmployeesShifts");
            //                mEmployeesShifts.View("EmployeeCode = N'" + mEmployees["Code"] + "'");
            //                attendanceMovements["ShiftOrderNo"] = mEmployeesShifts["ShiftCode"];
            //            }
            //            else
            //            {//attendanceMovements["EmployeeCode"] = a2;
            //                attendanceMovements["ShiftOrderNo"] = "";
            //            }

            //            attendanceMovements["TransType"] = idwInOutMode;
            //            attendanceMovements["TransDate"] = string.Format("{0}/{1}/{2} {3}:{4}", idwYear, idwMonth, idwDay, idwHour, idwMinute);
            //            attendanceMovements["dwYear"] = idwYear;
            //            attendanceMovements["dwMonth"] = idwMonth;
            //            attendanceMovements["dwDay"] = idwDay;
            //            attendanceMovements["dwHour"] = idwHour;
            //            attendanceMovements["dwMinute"] = idwMinute;
            //            attendanceMovements["dwSecond"] = idwSecond;



            //            attendanceMovements.Update();




            //            var s1 = (string.Format("{0}:{1}", idwHour, idwMinute));
            //            var s2 = string.Format("{0}/{1}/{2}", idwYear, idwMonth, idwDay);
            //            FillGrid(mEmployees["Code"].ToString(), mEmployees["name"].ToString(), idwInOutMode, s1, s2);


            //        }


            //        MessageBox.Show("تم سحب الحركات بنجاح");
            //    }
            //    axCZKEM1.EnableDevice(iMachineNumber, true);//enable the device
            //}
            //else
            //{
            //    MessageBox.Show("يجب الاتصال بالماكينة اولا!!");
            //}
        }

        private void FillGrid(string empcode, string empName, int Type, string mTime, string mDate)
        {
            //grd.Rows.Add();
            //grd[grd.Rows.Count - 1, "EmployeeCode"] = empcode;
            //grd[grd.Rows.Count - 1, "EmployeeName"] = empName;
            //grd[grd.Rows.Count - 1, "TypeName"] = (Type == 0 ? "خضور" : "انصراف");
            //grd[grd.Rows.Count - 1, "Time"] = mTime;
            //grd[grd.Rows.Count - 1, "Date"] = mDate;


        }
        private void btnPullMovementsandDelete_Click(object sender, EventArgs e)
        {
            //if (cmbMachines.SelectedIndex <= 0)
            //{
            //    MessageBox.Show("من اختار الماكينة");
            //    return;
            //}

            //Drag_Move();
            //if (axCZKEM1.Connect_Net(cmbMachines.SelectedValue.ToString(), int.Parse(txtPort.Text)))
            //    if (MessageBox.Show("سوف يتم مسح جميع الحركات الموجودة علي الماكينة...هل انت متاكد؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //        axCZKEM1.ClearGLog(1);
        }


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var frm = new FrmMachiens();
            frm.ShowDialog();
            FillMachiens();

        }

        void FillMachiens()
        {
            var m = new MATRIX("Machiens");
            m.FillComboBox(cmbMachines);
        }

        private void FrmPullMovements_Load(object sender, EventArgs e)
        {
            FillMachiens();
            enable();
        }

        private void cmbMachines_SelectedIndexChanged(object sender, EventArgs e)
        {
            var m = new MATRIX("Machiens");
            m.View("Code='" + cmbMachines.SelectedValue + "'");
            if (m.DR.HasRows)
            {
                txtIP.Text = (string)m["ip"];
                txtPort.Text = (string)m["Port"];
            }
            else
            {
                txtIP.Text = "";
                txtPort.Text = "";
            }
        }

        private bool micon = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text += ".";

            if (micon)
            {
                btnConnect.Image = Properties.Resources.SymbolCheck32;
                micon = false;
            }
            else
            {
                btnConnect.Image = null;
                micon = true;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBackup_Click(object sender, EventArgs e)
        {

        }

    }
}
