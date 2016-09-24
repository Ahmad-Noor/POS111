using System;
using System.Globalization;
using System.Windows.Forms;

namespace POS
{
    public partial class FrmPaymentsEmployeesBetween : SkyForm
    {
        public FrmPaymentsEmployeesBetween()
        {
            InitializeComponent();
        }

        private MATRIX mTable = new MATRIX("PaymentsEmployeesBetween");
        private MATRIX mTable2 = new MATRIX("PaymentsEmployeesBetween2");

        private MATRIX Setings = new MATRIX("Setings");
        private string ShiftOrderNo = "";
        private int EmployeesTimeLate = 0;

        private string s = "";
        //int x = 0;

        private MATRIX Employees = new MATRIX("Employees");

        private Boolean SaveMsgDontShow = false;
        private Boolean BasicDataNo = false;
        private Boolean NewRecord = false;

        public void btnNew_Click(System.Object sender, System.EventArgs e)
        {

            s = " Year=" + Settings.CurrentYear + "  and Branch_ID=N'" + Settings.CurrentBranch_ID + "' and ShiftOrderNo= " + ShiftOrderNo + "  and BoxCode=N'" + Settings.CurrentBox + "'";
            txtOrderNo.Text = mTable.Get_New("orderNo", s);
            NewRecord = true;

            txtCode.Text = "";
            txtName.Text = "";

            label7.Text = "جديد";
            btnSave.Enabled = true;
            btnDelete.Enabled = true;
            dtpOrderDate.Value = DateTime.Now;
            grd.Rows.Clear();
            txtTotal.Text = "";


        }

        public void btnSave_Click(System.Object sender, System.EventArgs e)
        {

            //-----------------------------------------------


            if (Settings.CurrentBox == "")
            {
                MessageBox.Show("لا يوجد كاشير علي المستخدم الحالي....من فضلك حاول مرة اخري", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            //if (!Pub.ShiftIsOpen(ShiftOrderNo))
            //{
            //    MessageBox.Show("تم قفل الوردية الحالية ولا يمكن الاستمرار من فضل اغلاق البرنامج ثم حاول مرة اخرى", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return;
            //}


        exx: ;
            Settings.ExecuteReader("select * from ShiftsOpening2 where OrderNo=" + ShiftOrderNo + " and Year=" + Settings.CurrentYear + "  and Branch_ID=N'" + Settings.CurrentBranch_ID + "' and BoxCode=N'" + Settings.CurrentBox + "'");
            if (Settings.DR.HasRows == false)
            {
                if (MessageBox.Show("سوف يتم فتح الكاشير الحالي علي الوردية الحالية", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    //FrmKasherOpen frm = new FrmKasherOpen();
                    //frm.ShowDialog();
                    goto exx;
                }
                else
                    return;
            }
            else
            {
                if (Settings.DR["BoxStatus"].ToString() == "1")
                {
                    MessageBox.Show("تم قفل الكاشير ولا يمكن الاستمرار", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    return;

                }
            }
            //-----------------------------------------------

            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show(" من فضلك ادخل الموظف", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            //s = " Year=" + Pub.CurrentYear + "  and Branch_ID=N'" + Pub.CurrentBranch
            //    + "' and ShiftOrderNo=" + ShiftOrderNo + "  and BoxCode=N'" + Pub.CurrentBox
            //    + "' and EmployeesCode=N'" + txtCode.Text.Trim() + "'";

            //Pub.ExecuteReader("select OrderNo from PaymentsEmployeesBetween where " + s);
            //if (Pub.DR.HasRows)
            //{
            //    MessageBox.Show(" هذا الموظف تم عليه حركة مدفوعات علي هذه الوردية", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return;
            //}




            //if (NewRecord == false && Pub.PaymentsEditDelete == false)
            //{

            //    MessageBox.Show("هذا المستخدم لايستطيع التعديل ", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    if (Pub.ManagerPassword("PaymentsEditDelete") == false)
            //    {
            //        MessageBox.Show("هذا المستخدم لايستطيع التعديل من فضلك حاول مرة اخرى", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //        return;
            //    }
            //}

            if (txtTotal.Text == "")
            {
                MessageBox.Show("لا يوجد مبالغ....لايمكن الحفظ", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }


            try
            {

           mTable.ExecuteNonQuery("BEGIN TransACTION " + Name);

                if (NewRecord)
                {
                    s = " Year=" + Settings.CurrentYear + "  and Branch_ID=N'" + Settings.CurrentBranch_ID + "' and ShiftOrderNo=" + ShiftOrderNo + "  and BoxCode=N'" + Settings.CurrentBox + "'  and OrderNo=" + txtOrderNo.Text;
                    Settings.ExecuteReader("select OrderNo from PaymentsEmployeesBetween where " + s);

                    if (Settings.DR.HasRows)
                    {
                        s = " Year=" + Settings.CurrentYear + "  and Branch_ID=N'" + Settings.CurrentBranch_ID + "' and ShiftOrderNo=" + ShiftOrderNo + "  and BoxCode=N'" + Settings.CurrentBox + "'";
                        txtOrderNo.Text = mTable.Get_New("orderNo", s);
                    }
                }
                mTable.Add_New();
                mTable.SetFiled("Year", Settings.CurrentYear);
                mTable.SetFiled("Branch_ID", Settings.CurrentBranch_ID);
                mTable.SetFiled("BoxCode", Settings.CurrentBox);
                mTable.SetFiled("OrderNo", txtOrderNo.Text);
                mTable.SetFiled(dtpOrderDate);
                mTable.SetFiled("ShiftOrderNo", ShiftOrderNo);
                mTable.SetFiled("EmployeesCode", txtCode.Text);
                mTable.SetFiled("Total", txtTotal.Text);
                mTable.SetFiled("Posted", 1);

                s = " Year=" + Settings.CurrentYear + "  and Branch_ID=N'" + Settings.CurrentBranch_ID + "' and ShiftOrderNo=" + ShiftOrderNo + "   and BoxCode=N'" + Settings.CurrentBox + "' and OrderNo=" + txtOrderNo.Text;
                mTable.Update(s);



                //------------------------------------
                s = " Year=" + Settings.CurrentYear + "  and Branch_ID=N'" + Settings.CurrentBranch_ID + "' and ShiftOrderNo=" + ShiftOrderNo + "   and BoxCode=N'" + Settings.CurrentBox + "' and OrderNo=" + txtOrderNo.Text;
                mTable2.Delete(s);

                for (int i = 0; i < grd.Rows.Count; i++)
                {
                    mTable2.Add_New();
                    mTable2.SetFiled("Year", Settings.CurrentYear);
                    mTable2.SetFiled("Branch_ID", Settings.CurrentBranch_ID);
                    mTable2.SetFiled("BoxCode", Settings.CurrentBox);
                    mTable2.SetFiled("OrderNo", txtOrderNo.Text);
                    mTable2.SetFiled("ShiftOrderNo", ShiftOrderNo);
                    mTable2.SetFiled("Ser", i);

                    mTable2.SetFiled("ShiftOrderNo2",grd.Rows[i].Cells["OrderNo"].Value.ToString());

                  mTable2.SetFiled("OrderDate2", Convert.ToDateTime(grd.Rows[i].Cells["OrderDate"].Value));
            

                    if (grd.Rows[i].Cells["TimeIn"].Value.ToString() != "")
                        mTable2.SetFiled("AttIn", Convert.ToDateTime(grd.Rows[i].Cells["TimeIn"].Value));
                    else
                        mTable2.SetFiled("AttIn", DBNull.Value);
                    
                    if (grd.Rows[i].Cells["TIMEOUT"].Value.ToString() != "")
                        mTable2.SetFiled("AttOUT", Convert.ToDateTime(grd.Rows[i].Cells["TIMEOUT"].Value));
                    else
                        mTable2.SetFiled("AttOUT", DBNull.Value);

                    mTable2.SetFiled("ActulMinute", grd.Rows[i].Cells["ActulMinute"].Value);
                    mTable2.SetFiled("Salary", grd.Rows[i].Cells["Salary"].Value);
                    mTable2.Update();
                }

mTable.ExecuteNonQuery("COMMIT TransACTION " + Name);


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
                //mTable.ExecuteNonQuery("Rollback TransACTION " + Name);
                MessageBox.Show(Ex.Message);
                return;
            }

        }

        public void Retrieve()
        {
            NewRecord = false;
            s = " Year=" + Settings.CurrentYear + "  and Branch_ID=N'" + Settings.CurrentBranch_ID + "' and ShiftOrderNo=" + ShiftOrderNo +
                " and BoxCode=N'" + Settings.CurrentBox + "' and OrderNo=" + txtOrderNo.Text;

            mTable.View(s);
            if (!mTable.DR.HasRows)
            {
                btnNew_Click(null, null);
                return;
            }

            if (mTable.GetFiled("Posted") == "1")
            {
                btnSave.Enabled = true;
                btnDelete.Enabled = true;
                label7.Text = "تم الحفظ";
            }
            else if (mTable.GetFiled("Posted") == "2")
            {
                btnSave.Enabled = false;
                btnDelete.Enabled = false;
                label7.Text = "الغاء";
            }

            dtpOrderDate.Text = mTable.GetFiled("OrderDate");



            txtCode.Text = mTable.GetFiled("EmployeesCode");
            Employees.View("Code=N'" + txtCode.Text + "'");
            txtName.Text = Employees.GetFiled("name");

             s = "";
            s += "SELECT ShiftOrderNo2, \n";
            s += "       CONVERT(NVARCHAR(10), OrderDate2, 111) AS OrderDate, \n";
            s += "       AttIn, \n";
            s += "       AttOUT, \n";
            s += "    RIGHT(CONVERT(CHAR(20), PaymentsEmployeesBetween2.AttIn , 22), 11)  TimeInm, \n";
            s += "     RIGHT(CONVERT(CHAR(20), PaymentsEmployeesBetween2.AttOUT , 22), 11) TIMEOUTm, \n";
            s += "       ActulMinute, \n";
            s += "       Salary \n";
            s += "FROM   dbo.PaymentsEmployeesBetween2 ";
                        s += " where Year=" + Settings.CurrentYear + "  and Branch_ID=N'" + Settings.CurrentBranch_ID + "' and ShiftOrderNo=" + ShiftOrderNo + "   and BoxCode=N'" + Settings.CurrentBox + "' and OrderNo=" + txtOrderNo.Text;
             
            grd.Rows.Clear();
            try
            { Settings.DR.Close(); }catch (Exception)
            { }
            Settings.CMD.CommandText = s;
            Settings.DR = Settings.CMD.ExecuteReader();
            while (Settings.DR.Read())
            {
                grd.Rows.Add();
                grd.Rows[grd.Rows.Count - 1].Cells["OrderNo"].Value = Settings.DR["ShiftOrderNo2"].ToString();
                grd.Rows[grd.Rows.Count - 1].Cells["OrderDate"].Value = Settings.DR["OrderDate"].ToString();
                grd.Rows[grd.Rows.Count - 1].Cells["TimeIn"].Value = Settings.DR["AttIn"].ToString();
                grd.Rows[grd.Rows.Count - 1].Cells["TIMEOUT"].Value = Settings.DR["AttIn"].ToString();
                grd.Rows[grd.Rows.Count - 1].Cells["ActulMinute"].Value = Settings.DR["ActulMinute"].ToString();


                double X = Math.Round(double.Parse("0" + Settings.DR["ActulMinute"].ToString()) / 60, 2);
                double Y = (int)X;
                TimeSpan span = TimeSpan.FromMinutes(X * 60);
                grd.Rows[grd.Rows.Count - 1].Cells["ActulMinutem"].Value = span.ToString(@"hh\:mm");

                grd.Rows[grd.Rows.Count - 1].Cells["TimeInm"].Value = Settings.DR["TimeInm"].ToString();
                grd.Rows[grd.Rows.Count - 1].Cells["TIMEOUTm"].Value = Settings.DR["TIMEOUTm"].ToString();
                grd.Rows[grd.Rows.Count - 1].Cells["Salary"].Value = Settings.DR["Salary"].ToString();
            }

            SumTotal();
        }


        public void btnDelete_Click(System.Object sender, System.EventArgs e)
        {

            if (NewRecord) return;

            //if (!Pub.ShiftIsOpen(ShiftOrderNo))
            //{
            //    MessageBox.Show("تم قفل الوردية الحالية ولا يمكن الاستمرار من فضل اغلاق البرنامج ثم حاول مرة اخرى", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
            //}


           try
           {
            //    if (Pub.PaymentsEditDelete)
            //        DeleteDoc();
            //    else
            //    {
            //        if (Pub.ManagerPassword("PaymentsEmployeesBetweenEditDelete"))
            //        {
            //            DeleteDoc();
            //        }
            //        else
            //        {
            //            MessageBox.Show("هذا المستخدم لايستطيع الالغأ من فضلك حاول مرة اخرى", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //            return;
            //        }
            //    }


            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }


        private void DeleteDoc()
        {
            try
            {
                if (MessageBox.Show("سوف يتم الغأ الحركة....هل انت منأكد؟", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                {
                    throw new Exception("لم يتم الالغأ");
                }
             string TransACTIONID = Name + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Millisecond;
              mTable.ExecuteNonQuery("BEGIN TransACTION " + TransACTIONID);

                mTable.Add_New();
                mTable.SetFiled("Posted", 2);
                s = " Year=" + Settings.CurrentYear + "  and Branch_ID=N'" + Settings.CurrentBranch_ID + "' and ShiftOrderNo =" + ShiftOrderNo + " and BoxCode=N'" + Settings.CurrentBox + "' and OrderNo=" + txtOrderNo.Text;

                mTable.Update(s);

              mTable.ExecuteNonQuery("COMMIT TransACTION " + TransACTIONID);

                Retrieve();

            }
            catch (Exception)
            {
                throw new Exception("لم يتم الالغأ");
            }
        }

        public void btnFirst_Click(System.Object sender, System.EventArgs e)
        {
            s = "Year=" + Settings.CurrentYear + "  and Branch_ID=N'" + Settings.CurrentBranch_ID + "' and ShiftOrderNo=" + ShiftOrderNo + " and BoxCode=N'" + Settings.CurrentBox + "'";
            mTable.MoveFrist(txtOrderNo, s);
            Retrieve();
        }

        public void btnNext_Click(System.Object sender, System.EventArgs e)
        {
            s = "Year=" + Settings.CurrentYear + "  and Branch_ID=N'" + Settings.CurrentBranch_ID + "' and ShiftOrderNo=" + ShiftOrderNo + " and BoxCode=N'" + Settings.CurrentBox + "'";
            mTable.MoveNext(txtOrderNo, s);
            Retrieve();
        }

        public void btnPrevious_Click(System.Object sender, System.EventArgs e)
        {
            s = "Year=" + Settings.CurrentYear + "  and Branch_ID=N'" + Settings.CurrentBranch_ID + "' and ShiftOrderNo=" + ShiftOrderNo + " and BoxCode=N'" + Settings.CurrentBox + "'";
            mTable.MovePrevious(txtOrderNo, s);
            Retrieve();
        }

        public void btnLast_Click(System.Object sender, System.EventArgs e)
        {
            s = "Year=" + Settings.CurrentYear + "  and Branch_ID=N'" + Settings.CurrentBranch_ID + "' and ShiftOrderNo=" + ShiftOrderNo + " and BoxCode=N'" + Settings.CurrentBox + "'";
            mTable.MoveLast(txtOrderNo, s);
            Retrieve();
        }

        public void btnExit_Click(System.Object sender, System.EventArgs e)
        {
            this.Close();
        }

        public void btnSearchByName_Click(System.Object sender, System.EventArgs e)
        {
            string s1 = " OrderNo الكـــود  ,";
            s1 += "   (SELECT NAME FROM dbo.Employees WHERE Code=dbo.PaymentsEmployeesBetween.EmployeesCode)  الاســــم,Amount المبلغ";
            s = "Year=" + Settings.CurrentYear + "  and Branch_ID=N'" + Settings.CurrentBranch_ID + "' and ShiftOrderNo=" + ShiftOrderNo + " and BoxCode=N'" + Settings.CurrentBox + "'";

            mTable.Search(txtOrderNo, s1, s + " order by OrderNo");
            Retrieve();
        }


        private void FrmPaymentsEmployeesBetween_Load(object sender, EventArgs e)
        {
            //Pub.OpenShift();
            Setings.View();
            SaveMsgDontShow = Convert.ToBoolean(Setings.GetFiled("SaveMsgDontShow"));
            BasicDataNo = Convert.ToBoolean(Setings.GetFiled("BasicDataNo"));
            EmployeesTimeLate = int.Parse(Setings.GetFiled("EmployeesTimeLate"));

            s = "select *,Kasher=(SELECT NAME FROM dbo.Box WHERE Code =N'" + Settings.CurrentBox + "'),ShiftName=(SELECT NAME FROM dbo.Shifts WHERE Code =ShiftsOpening.ShiftCode ) FROM ShiftsOpening";
            s += " WHERE (Branch_ID = N'" + Settings.CurrentBranch_ID + "')";
            s += "          AND ( Year = " + Settings.CurrentYear + " ) AND ShiftStatus=0";
            Settings.ExecuteReader(s);

            if (Settings.DR.HasRows)
            {
                dtpOrderDate.Text = Settings.DR["Orderdate"].ToString();
                ShiftOrderNo = Settings.DR["OrderNo"].ToString();
                textBox1.Text = Settings.DR["Kasher"].ToString();
                textBox2.Text = Settings.DR["ShiftName"].ToString();
            }


            btnNew_Click(null, null);
        }

        private void FrmPaymentsEmployeesBetween_KeyDown(object sender, KeyEventArgs e)
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
                //txtOrderNo.Text = mTable.SearchByCode("Code");
                Retrieve();
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message, "بحث بالكود", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void txtCode_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            Employees.Search(txtCode, "Code الكود,Name الاسم");
            txtCode_Validated(null, null);
        }

        private void txtCode_Validated(object sender, EventArgs e)
        {
            if (txtCode.Text.Trim() == "") return;

            Employees.View("Code=N'" + txtCode.Text + "'");
            txtName.Text = Employees.GetFiled("name");


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

        private void btnView_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show(" من فضلك ادخل الموظف", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }



            string s = "";
            s += "SELECT TOP ( 100 ) PERCENT dbo.ShiftsOpening.OrderNo, \n";
            s += "                           CONVERT(NVARCHAR(10), dbo.ShiftsOpening.OrderDate, 111) AS OrderDate, \n";
            s += "                           AttTemp.EmployeeCode, \n";
            s += "                           AttTemp.TimeIn, \n";
            s +=
                "                           AttTemp.TIMEOUT,  RIGHT(CONVERT(CHAR(20), AttTemp.TimeIn, 22), 11) TimeInm,RIGHT(CONVERT(CHAR(20),AttTemp.TIMEOUT , 22), 11) TIMEOUTm, \n";
            s += "                           Datediff(minute, AttTemp.TimeIn, AttTemp.TIMEOUT) AS ActulMinute, \n";
            s += "                           dbo.Employees.HourPrice, \n";
            s +=
                "                           Datediff(minute, AttTemp.TimeIn, AttTemp.TIMEOUT) * ( dbo.Employees.HourPrice / 60 ) Salary \n";
            s += "FROM   dbo.Employees \n";
            s += "       RIGHT OUTER JOIN (SELECT ID, \n";
            s += "                                Branch_ID, \n";
            s += "                                Year, \n";
            s += "                                ShiftOrderNo, \n";
            s += "                                TransType, \n";
            s += "                                EmployeeCode, \n";
            s += "                                dbo.Employeeminuts(TransDate) AS TimeIn, \n";
            s +=
                "                                dbo.Employeeminuts(dbo.Empgetout(Branch_ID, Year, EmployeeCode, ShiftOrderNo)) AS TIMEOUT \n";
            s += "                         FROM   dbo.Att \n";
            s += "                         WHERE  ( TransType = 1 )) AS AttTemp \n";
            s += "         ON dbo.Employees.Code = AttTemp.EmployeeCode \n";
            s += "       RIGHT OUTER JOIN dbo.ShiftsOpening \n";
            s += "         ON AttTemp.Branch_ID = dbo.ShiftsOpening.Branch_ID AND \n";
            s += "            AttTemp.Year = dbo.ShiftsOpening.Year AND \n";
            s += "            AttTemp.ShiftOrderNo = dbo.ShiftsOpening.OrderNo \n";
            s += "WHERE  ( dbo.ShiftsOpening.Year = " + Settings.CurrentYear + " ) AND \n";
            s += "       ( dbo.ShiftsOpening.Branch_ID = '" + Settings.CurrentBranch_ID + "' ) AND \n";
            s += "       ( AttTemp.EmployeeCode = '" + txtCode.Text.Trim() + "' ) AND \n";
            s += "       ( dbo.ShiftsOpening.OrderNo NOT IN (SELECT ShiftOrderNo \n";
            s += "                                           FROM   dbo.PaymentsEmployees \n";
            s += "                                           WHERE  ( Year = " + Settings.CurrentYear + " ) AND \n";
            s += "                                                  ( Branch_ID = '" + Settings.CurrentBranch_ID + "' ) AND \n";
            s += "                                                  ( EmployeesCode = '" + txtCode.Text.Trim() +
                 "' )) ) AND \n";
            s += "       ( dbo.ShiftsOpening.OrderNo NOT IN (SELECT dbo.PaymentsEmployeesBetween2.ShiftOrderNo2 \n";
            s += "                                           FROM   dbo.PaymentsEmployeesBetween \n";
            s += "                                                  LEFT OUTER JOIN dbo.PaymentsEmployeesBetween2 \n";
            s +=
                "                                                    ON dbo.PaymentsEmployeesBetween.Year = dbo.PaymentsEmployeesBetween2.Year AND \n";
            s +=
                "                                                       dbo.PaymentsEmployeesBetween.Branch_ID = dbo.PaymentsEmployeesBetween2.Branch_ID AND \n";
            s +=
                "                                                       dbo.PaymentsEmployeesBetween.OrderNo = dbo.PaymentsEmployeesBetween2.OrderNo AND \n";
            s +=
                "                                                       dbo.PaymentsEmployeesBetween.ShiftOrderNo = dbo.PaymentsEmployeesBetween2.ShiftOrderNo \n";
            s += "                                           WHERE  ( dbo.PaymentsEmployeesBetween.Year = " +
                 Settings.CurrentYear + " ) AND \n";
            s += "                                                  ( dbo.PaymentsEmployeesBetween.Branch_ID = N'" +
                 Settings.CurrentBranch_ID + "' ) AND \n";
            s += "                                                  ( dbo.PaymentsEmployeesBetween.EmployeesCode = N'" +
                 txtCode.Text.Trim() + "' )) ) \n";
            if (buttonEdit3.Text.Trim() != "")
                s += "           AND ( dbo.ShiftsOpening.OrderNo >= " + buttonEdit3.Text.Trim() + " ) \n";
            if (buttonEdit4.Text.Trim() != "")
                s += "             AND ( dbo.ShiftsOpening.OrderNo <= " + buttonEdit4.Text.Trim() + " ) \n";
            s += "ORDER  BY dbo.ShiftsOpening.OrderNo ";

            grd.Rows.Clear();
            try
            { Settings.DR.Close(); }
            catch (Exception)
            { }

            Settings.CMD.CommandText = s;
            Settings.DR = Settings.CMD.ExecuteReader();
            while (Settings.DR.Read())
            {
                grd.Rows.Add();
                grd.Rows[grd.Rows.Count - 1].Cells["OrderNo"].Value = Settings.DR["OrderNo"].ToString();
                grd.Rows[grd.Rows.Count - 1].Cells["OrderDate"].Value = Settings.DR["OrderDate"].ToString();
                grd.Rows[grd.Rows.Count - 1].Cells["TimeIn"].Value = Settings.DR["TimeIn"].ToString();
                grd.Rows[grd.Rows.Count - 1].Cells["TIMEOUT"].Value = Settings.DR["TIMEOUT"].ToString();
                grd.Rows[grd.Rows.Count - 1].Cells["ActulMinute"].Value = Settings.DR["ActulMinute"].ToString();


                double X = Math.Round(double.Parse("0" + Settings.DR["ActulMinute"].ToString()) / 60, 2);
                double Y = (int)X;
                TimeSpan span = TimeSpan.FromMinutes(X * 60);
                grd.Rows[grd.Rows.Count - 1].Cells["ActulMinutem"].Value = span.ToString(@"hh\:mm");

                grd.Rows[grd.Rows.Count - 1].Cells["TimeInm"].Value = Settings.DR["TimeInm"].ToString();
                grd.Rows[grd.Rows.Count - 1].Cells["TIMEOUTm"].Value = Settings.DR["TIMEOUTm"].ToString();
                grd.Rows[grd.Rows.Count - 1].Cells["Salary"].Value = Settings.DR["Salary"].ToString();
            }

            SumTotal();
        }

        private void SumTotal()
        {
            double xx = 0;

            for (int i = 0; i < grd.Rows.Count; i++)
            {
                xx += double.Parse("0" + grd.Rows[i].Cells["Salary"].Value.ToString());
            }
            txtTotal.Text = xx.ToString();

        }
    }
}
