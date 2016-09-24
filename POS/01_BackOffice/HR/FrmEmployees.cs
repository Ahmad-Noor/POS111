using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

using DevExpress.XtraEditors.Controls;

namespace POS
{
    public partial class FrmEmployees : SkyForm
    {
        public FrmEmployees(){
            InitializeComponent();
        }

        private MATRIX mTable = new MATRIX("Employees");
        private MATRIX Setings = new MATRIX("Setings");


        private Boolean SaveMsgDontShow = false;
        private Boolean BasicDataNo = false;
        private Boolean NewRecord = false;

        private void btnNew_Click(System.Object sender, System.EventArgs e)
        {


            txtCode.Text = BasicDataNo ? mTable.Get_New("Code") : "";
            if (BasicDataNo)
                txtName.Focus();

            NewRecord = true;
            Pic.Image = null;
            txtFingerPrintCode.Text = "";
            txtName.Text = "";
            cmbGender.SelectedIndex = 0;
            cmbReligionCode.SelectedIndex = 0;
            txtDateofBirth.Text = "";
            txtPlaceofBirth.Text = "";
            txtMotherName.Text = "";
            txtFatherName.Text = "";

            cmbHealthOfficecode.SelectedIndex = 0;
            txtNationalID.Text = "";
            txtNationalIDDate.Text = "";
            txtInusranceID.Text = "";
            txtSpecialization.Text = "";
            cmbMilitaryService.SelectedIndex = 0;
            //--------------------
            dtbDateofLeavingWork.Value = DateTime.Now;
            dtpDateofAppointment.Value = DateTime.Now;
            txtHourPrice.Text = "0";

            cmbMaterialState.SelectedIndex = 0;

            txtAddress.Text = "";
            txtTel1.Text = "";
            txtTel2.Text = "";
            txtMobile1.Text = "";
            txtMobile2.Text = "";
            txtEmail.Text = "";
            cmbCity.SelectedIndex = 0;
            //-------------------- 
            txtVariableSalary.Text = "0";
            txtBasicSalary.Text = "0";
            cmbDepts.SelectedIndex = 0;
            cmbJobs.SelectedIndex = 0;
            cmbManagements.SelectedIndex = 0;
            cmbQualification.SelectedIndex = 0;

            cmbWorkStatus.SelectedIndex = 0;

            cmbManager.SelectedIndex = 0;

           

            //grdMerit.Rows.Count = 1;
            //grdMerit.Rows.Add();
            pnlPic.Controls.Clear();

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
            if (NewRecord && mTable.find("Code=N\'" + txtCode.Text.Trim() + "\'"))
            {
                MessageBox.Show("الكود موجود من قبل...ولا يمكن اضافة جديد بهذا الكود", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtCode.Text = "";
                return;
            }

            if (txtFingerPrintCode.Text.Trim() != "")
            {
                if (mTable.find("Code<>N\'" + txtCode.Text.Trim() + "\' and FingerPrintCode=" + txtFingerPrintCode.Text))
                {
                    MessageBox.Show(
                        string.Format("كود الموظف علي ماكنية البصمة موجود بالفعل علي الموظف : {0}", mTable["Code"]), "",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFingerPrintCode.Text = "";
                    return;
                }

            }
            NewRecord = false;

            mTable.Add_New();

            mTable["Code"] = (BasicDataNo ? Convert.ToInt64(txtCode.Text).ToString() : txtCode.Text);
            mTable["Name"] = txtName.Text;
            mTable["FingerPrintCode"] = txtFingerPrintCode.Text;
            mTable["Gender"] = cmbGender.SelectedIndex;
            mTable["ReligionCode"] = cmbReligionCode.SelectedValue;
            mTable.SetFiled(txtDateofBirth);
            mTable["PlaceofBirth"] = txtPlaceofBirth.Text;
            mTable["MotherName"] = txtMotherName.Text;
            mTable["FatherName"] = txtFatherName.Text;

            mTable["HealthOfficecode"] = cmbHealthOfficecode.SelectedValue;
            mTable["NationalID"] = txtNationalID.Text;
            mTable.SetFiled(txtNationalIDDate);
            mTable["InusranceID"] = txtInusranceID.Text;
            mTable["MaterialState"] = cmbMaterialState.SelectedIndex;
            mTable["MilitaryService"] = cmbMilitaryService.SelectedIndex;
            //--------------------

            if (Pic.Image != null)
            {
                Bitmap newBitmap1 = new Bitmap(Pic.Image);
                var ms1 = new MemoryStream();
                newBitmap1.Save(ms1, ImageFormat.Jpeg);
                byte[] photoAray1 = new byte[ms1.Length];
                ms1.Position = 0;
                ms1.Read(photoAray1, 0, photoAray1.Length);
                ms1.Close();
                mTable["EmployeePicture"] = photoAray1;

            }

            //--------------------


            mTable["Tel1"] = txtTel1.Text;
            mTable["Tel2"] = txtTel2.Text;
            mTable["Mobile1"] = txtMobile1.Text;
            mTable["Mobile2"] = txtMobile2.Text;
            mTable["Email"] = txtEmail.Text;
            mTable["CityCode"] = cmbCity.SelectedValue;
            //-------------------- 
            mTable["VariableSalary"] = txtVariableSalary.Text;
            mTable["BasicSalary"] = txtBasicSalary.Text;
            mTable["JobCode"] = cmbJobs.SelectedValue;
            mTable["DeptCode"] = cmbDepts.SelectedValue;
            mTable["ManagementCode"] = cmbManagements.SelectedValue;
            mTable["Qualification"] = cmbQualification.SelectedValue;
            mTable["WorkStatus"] = cmbWorkStatus.SelectedIndex;
            mTable["Manager"] = cmbManager.SelectedValue;
            mTable["Specialization"] = txtSpecialization.Text;
            mTable.SetFiled(dtbDateofLeavingWork ); 
            mTable.SetFiled( dtpDateofAppointment);
            mTable["HourPrice"] = txtHourPrice.Text;

            mTable.Update("Code=N\'" + txtCode.Text.Trim() + "\'");

            //------------shifts---------------
            var mEmployeesShifts = new MATRIX("EmployeesShifts");
            //mEmployeesShifts.Delete(string.Format("Employeecode='{0}'", txtCode.Text));
            //for (int i = 1; i < grdShifts.Rows.Count; i++)
            //{
            //    if (grdShifts[i, "ShiftName"] != null)
            //    {
            //        mEmployeesShifts.Add_New();
            //        mEmployeesShifts.SetFiled("EmployeeCode", txtCode.Text);
            //        mEmployeesShifts.SetFiled("ShiftCode", grdShifts[i, "ShiftName"]);
            //        mEmployeesShifts.Update();
            //    }
            //}
            //------------HoliDays---------------

            var mEmployeesHoliDays = new MATRIX("EmployeesHoliDays");
            //mEmployeesHoliDays.Delete(string.Format("Employeecode='{0}'", txtCode.Text));
            //for (int i = 1; i < grdHoliDays.Rows.Count; i++)
            //{
            //    if (grdHoliDays[i, "chk"] != null && (bool)grdHoliDays[i, "chk"])
            //    {
            //        mEmployeesHoliDays.Add_New();
            //        mEmployeesHoliDays.SetFiled("EmployeeCode", txtCode.Text);
            //        mEmployeesHoliDays.SetFiled("EnglishName", grdHoliDays[i, "EnglishName"]);
            //        mEmployeesHoliDays.Update();
            //    }
            //}

            //------------      الاستقطاعات      --------------- 



            var mEmployees2 = new MATRIX("Employees2");


            mEmployees2.Delete(string.Format("Employeecode='{0}'", txtCode.Text));

            //for (int i = 1; i < grdDeduction.Rows.Count; i++)
            //{
            //    if ((grdDeduction[i, "DeductiontName"] + "").Trim() != "")
            //    {
            //        mEmployees2.Add_New();
            //        mEmployees2.SetFiled("EmployeeCode", txtCode.Text);
            //        mEmployees2.SetFiled("Code", grdDeduction[i, "DeductiontName"]);
            //        mEmployees2.SetFiled("DataType", 1);
            //        mEmployees2.SetFiled("Type", grdDeduction[i, "Type"]);
            //        mEmployees2.SetFiled("Qty", grdDeduction[i, "Qty"]);
            //        mEmployees2.SetFiled("Value", grdDeduction[i, "Value"]);
            //        mEmployees2.Update();
            //    }
            //}

            //------------      الاستحقاقات    --------------- 
            mEmployees2 = new MATRIX("Employees2");

            //for (int i = 1; i < grdMerit.Rows.Count; i++)
            //{
            //    if ((grdMerit[i, "MerittName"] + "").Trim() != "")
            //    {
            //        mEmployees2.Add_New();
            //        mEmployees2.SetFiled("EmployeeCode", txtCode.Text);
            //        mEmployees2.SetFiled("Code", grdMerit[i, "MerittName"]);
            //        mEmployees2.SetFiled("DataType", 2);
            //        mEmployees2.SetFiled("Type", grdMerit[i, "Type"]);
            //        mEmployees2.SetFiled("Qty", grdMerit[i, "Qty"]);
            //        mEmployees2.SetFiled("Value", grdMerit[i, "Value"]);
            //        mEmployees2.Update();
            //    }
            //}

            //for (int i = 0; i < pnlPic.Controls.Count; i++)
            //{
            //    var doc =new EmployeesDocument();

            //    doc.DocPic= (PictureBox)[i]

            //}
            mEmployees2 = new MATRIX("EmployeesDocuments");
            mEmployees2.Delete(string.Format("Employeecode='{0}'", txtCode.Text));
            foreach (var pic_ in pnlPic.Controls)
            {
                var pic = new PictureBox();
                pic.Image = ((PictureBox)pic_).Image;
                mEmployees2.Add_New();
                mEmployees2["EmployeeCode"] = txtCode.Text;

                //--------------------- 
                //MemoryStream ms = new MemoryStream();
                //pic.Image.Save(ms, pic.Image.RawFormat);
                //byte[] a = ms.ToArray();

                Bitmap newBitmap = new Bitmap(pic.Image);
                var ms = new MemoryStream();
                newBitmap.Save(ms, ImageFormat.Jpeg);
                byte[] photoAray = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(photoAray, 0, photoAray.Length);
                ms.Close();
                mEmployees2["DocPic"] = photoAray;
                //---------------------
                mEmployees2.Update();
            }


            //------------

            if (SaveMsgDontShow)
                btnNew_Click(null, null);
            else if (
                MessageBox.Show("تم حفظ البيانات...هل تريد مستند جديد؟", "حفظ", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information) == DialogResult.Yes)
                btnNew_Click(null, null);
            else
                Retrieve();
            Tree1.FillTree();

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

            txtName.Text = "" + mTable["Name"];
            txtFingerPrintCode.Text = mTable["FingerPrintCode"] + "";
            cmbGender.SelectedIndex = int.Parse("0" + mTable["Gender"]);
            cmbReligionCode.SelectedValue = mTable["ReligionCode"] + "";
            txtDateofBirth.Text = mTable["DateofBirth"] + "";
            txtPlaceofBirth.Text = mTable["PlaceofBirth"] + "";
            txtMotherName.Text = "" + mTable["MotherName"] + "";
            txtFatherName.Text = "" + mTable["FatherName"];

            cmbHealthOfficecode.SelectedValue = "" + mTable["HealthOfficecode"];
            txtNationalID.Text = "" + mTable["NationalID"];
            txtNationalIDDate.Text = "" + mTable["NationalIDDate"];
            txtInusranceID.Text = "" + mTable["InusranceID"];
            cmbMaterialState.SelectedIndex = int.Parse("0" + mTable["MaterialState"]);
            cmbMilitaryService.SelectedIndex = int.Parse("0" + mTable["MilitaryService"]);
            //--------------------
            txtHourPrice.Text = mTable["HourPrice"].ToString();

            txtAddress.Text = "" + mTable["Address"];
            txtTel1.Text = "" + mTable["Tel1"];
            txtTel2.Text = "" + mTable["Tel2"];
            txtMobile1.Text = "" + mTable["Mobile1"];
            txtMobile2.Text = "" + mTable["Mobile2"];
            txtEmail.Text = "" + mTable["Email"];
            cmbCity.SelectedValue = "" + mTable["CityCode"];
            //-------------------- 
            txtVariableSalary.Text = "" + mTable["VariableSalary"];
            txtBasicSalary.Text = "" + mTable["BasicSalary"];
            cmbJobs.SelectedValue = "" + mTable["JobCode"];
            cmbDepts.SelectedValue = "" + mTable["DeptCode"];
            cmbManagements.SelectedValue = "" + mTable["ManagementCode"];
            cmbQualification.SelectedValue = "" + mTable["Qualification"];
            txtSpecialization.Text = "" + mTable["Specialization"];
            cmbWorkStatus.SelectedIndex = int.Parse("0" + mTable["WorkStatus"]);


            mTable.GetFiled(dtbDateofLeavingWork);
            mTable.GetFiled(dtpDateofAppointment);

            try
            {
                byte[] ap1 = (byte[])mTable.DR["EmployeePicture"];
                var ms = new MemoryStream(ap1);
                Pic.Image = Image.FromStream(ms);
                ms.Close();
            }
            catch (Exception)
            {
                Pic.Image = null;
            }
            //-------------------- 
            cmbManager.SelectedValue = "" + mTable["Manager"];
            //grdShifts.Rows.Count = 1;
            //var dr = Settings.GetDataTable(string.Format("select ShiftCode from EmployeesShifts where Employeecode='{0}'", txtCode.Text));
            //while (dr.Read())
            //{
            //    grdShifts.Rows.Add();
            //    grdShifts[grdShifts.Rows.Count - 1, "ShiftName"] = dr["ShiftCode"];
            //}
            //grdShifts.Rows.Add();
            //---------------------
            //for (int i = 0; i < grdHoliDays.Rows.Count; i++)
            //{
            //    grdHoliDays[i, "chk"] = false;
            //}

            //dr = Settings.GetDataTable(string.Format("select EnglishName from EmployeesHoliDays where Employeecode='{0}'", txtCode.Text));

            //while (dr.Read())
            //{
            //    int i = grdHoliDays.FindRow(dr["EnglishName"], 1, grdHoliDays.Cols["EnglishName"].Index, false);
            //    grdHoliDays[i, "chk"] = true;
            //}
            ////---------------------

            //dr = Settings.GetDataTable(string.Format("SELECT Code,Type, Qty, Value FROM dbo.Employees2 where DataType=1 and Employeecode='{0}'", txtCode.Text));
            //grdDeduction.Rows.Count = 1;
            //while (dr.Read())
            //{// grdShifts[grdShifts.Rows.Count - 1, "ShiftName"] = dr["ShiftCode"];
            //    grdDeduction.Rows.Add();
            //    grdDeduction[grdDeduction.Rows.Count - 1, "DeductiontName"] = dr["Code"];
            //    grdDeduction[grdDeduction.Rows.Count - 1, "Type"] = dr["Type"];
            //    grdDeduction[grdDeduction.Rows.Count - 1, "Qty"] = dr["Qty"];
            //    grdDeduction[grdDeduction.Rows.Count - 1, "Value"] = dr["Value"];
            //}
            //grdDeduction.Rows.Add();

            //dr = Settings.GetDataTable(string.Format("SELECT Code,Type,Qty,Value FROM dbo.Employees2 where DataType=2 and Employeecode='{0}'", txtCode.Text));

            //grdMerit.Rows.Count = 1;
            //while (dr.Read())
            //{
            //    grdMerit.Rows.Add();
            //    grdMerit[grdMerit.Rows.Count - 1, "MerittName"] = dr["Code"];
            //    grdMerit[grdMerit.Rows.Count - 1, "Type"] = dr["Type"];
            //    grdMerit[grdMerit.Rows.Count - 1, "Qty"] = dr["Qty"];
            //    grdMerit[grdMerit.Rows.Count - 1, "Value"] = dr["Value"];
            //}
            //grdMerit.Rows.Add();


            pnlPic.Controls.Clear();

            try { Settings.DR.Close(); }
            catch (Exception) { }

            Settings.CMD.CommandText = string.Format("select DocPic from EmployeesDocuments where Employeecode='{0}'", txtCode.Text);
            Settings.DR = Settings.CMD.ExecuteReader();


            while (Settings.DR.Read())
            {
                var n = new PictureBox();
                n.BackgroundImageLayout = ImageLayout.Stretch;

                try
                {
                    byte[] ap = (byte[])(Settings.DR["DocPic"]);
                    var ms = new MemoryStream(ap);
                    n.Image = Image.FromStream(ms);
                    n.SizeMode = PictureBoxSizeMode.StretchImage;
                    n.BorderStyle = BorderStyle.Fixed3D;
                    ms.Close();


                }
                catch (Exception)
                {
                    n.BackgroundImage = null;
                }
                //n.Size = new Size(175, 175);
                n.ContextMenuStrip = contextMenuStrip1;
                n.DoubleClick -= new EventHandler(this.Pic_Click);
                n.DoubleClick += new EventHandler(this.Pic_Click);

                pnlPic.Controls.Add(n);

            }


        }

        public void btnCopyToNew_Click(System.Object sender, System.EventArgs e)
        {
            txtCode.Text = BasicDataNo ? mTable.Get_New("Code") : "";
            NewRecord = true;
            txtName.Text = "نسخة من " + txtName.Text;
            txtCode.Focus();

        }


        public void Tree1_DClick(System.Object sender, System.EventArgs e)
        {
            txtCode.Text = Tree1.CurrentNod();
            Retrieve();
        }

        public void btnDelete_Click(System.Object sender, System.EventArgs e)
        {

            bool Result =
                System.Convert.ToBoolean(MessageBox.Show("سوف يتم حذف...هل هل انت متاكد؟", "حذف",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation));
            if (Result)
            {
                mTable.Delete("Code=N\'" + txtCode.Text.Trim() + "\'");
                btnNew_Click(null, null);
                Tree1.FillTree();
            }
        }

        public void btnFirst_Click(System.Object sender, System.EventArgs e)
        {
            mTable.MoveFrist(txtCode, BasicDataNo);
            Retrieve();
        }

        public void btnNext_Click(System.Object sender, System.EventArgs e)
        {
            mTable.MoveNext(txtCode, BasicDataNo);
            Retrieve();
        }

        public void btnPrevious_Click(System.Object sender, System.EventArgs e)
        {
            mTable.MovePrevious(txtCode, BasicDataNo);
            Retrieve();
        }

        public void btnLast_Click(System.Object sender, System.EventArgs e)
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
            mTable.Search(txtCode, "Code الكـــود,Name الاســــم",
                " 1=1 order by " + (BasicDataNo ? "CONVERT(INT,code)" : "Code"));
            Retrieve();
        }

        private void FrmEmployees_Load(object sender, EventArgs e)
        {
            Pic.Properties.SizeMode = PictureSizeMode.Stretch;
            Setings.View();
            SaveMsgDontShow = Convert.ToBoolean(Setings.GetFiled("SaveMsgDontShow"));
            BasicDataNo = Convert.ToBoolean(Setings.GetFiled("BasicDataNo"));

            var ht = new Hashtable();
            ht.Add("1", "مبلغ");
            ht.Add("2", "نسبة من الراتب الاساسى");
            ht.Add("3", "نسبة من الراتب المتغير");
            //grdDeduction.Cols["Type"].DataMap = ht;
            //grdMerit.Cols["Type"].DataMap = ht;

            ///************************* 
            //grdHoliDays[1, "EnglishName"] = "Saturday";
            //grdHoliDays[1, "ArabicName"] = "السبت";

            //grdHoliDays[2, "EnglishName"] = "Sunday";
            //grdHoliDays[2, "ArabicName"] = "الأحد";

            //grdHoliDays[3, "EnglishName"] = "Monday";
            //grdHoliDays[3, "ArabicName"] = "الإثنين";

            //grdHoliDays[4, "EnglishName"] = "Tuesday";
            //grdHoliDays[4, "ArabicName"] = "الثلاثاء";

            //grdHoliDays[5, "EnglishName"] = "Wednesday";
            //grdHoliDays[5, "ArabicName"] = "الأربعاء";

            //grdHoliDays[6, "EnglishName"] = "Thursday";
            //grdHoliDays[6, "ArabicName"] = "الخميس";

            //grdHoliDays[7, "EnglishName"] = "Friday";
            //grdHoliDays[7, "ArabicName"] = "الجمعة";

            ///*************************
            FillShifts();
            FillDeduction();
            FillMerit();
            Tree1.FillTree();

            FillCities();
            FillReligion();
            FillHealthOffices();
            FillManagements();
            FillJobs();
            FillDepts();
            FillQualification();



            var v = new MATRIX("Employees");
            v.FillComboBox(cmbManager);

            btnNew_Click(null, null);
            Tree1.CheckEdit1.Checked = true;
        }

        private void FillShifts()
        {
            //grdShifts.Cols["ShiftName"].DataMap = Settings.GetHashtable("code", "Name", "Shifts");
        }

        private void FillDeduction()
        {
            //grdDeduction.Cols["DeductiontName"].DataMap = Settings.GetHashtable("code", "Name", "Deduction");
        }

        private void FillMerit()
        {
            //grdMerit.Cols["MerittName"].DataMap = Settings.GetHashtable("code", "Name", "Merit");
        }

        private void FrmEmployees_KeyDown(object sender, KeyEventArgs e)
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
                Tree1.CheckEdit1.Checked = Tree1.CheckEdit1.Checked ? false : true;
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

        private void txtJobCode_Validated(object sender, EventArgs e)
        {
            //txtJobName.Text = Jobs.Get_Value("Name", "main= 0  and Code=N\'" + txtJobCode.Text.Trim() + "\' ");

        }

        private void txtJobCode_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Jobs.Search(txtJobCode, "Code الكـــود,Name الاســــم", " main= 0 order by " + (BasicDataNo ? "CONVERT(INT,code)" : "Code"));
            txtJobCode_Validated(null, null);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(grdShifts[1, 1].ToString());
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Settings.CreateMaster("Deduction", "الاستقطاعات");

            FillDeduction();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Settings.CreateMaster("Merit", "الاستحقاق");
            FillMerit();


        }

        private void simpleButton3_Click_1(object sender, EventArgs e)
        {
            //FrmShifts frm = new FrmShifts();
            //frm.ShowDialog();
            FillShifts();
        }

        private void grdDeduction_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            Settings.CreateMaster("Cities", "المدن");
            FillCities();
        }

        private void FillCities()
        {
            var v = new MATRIX("Cities");
            v.FillComboBox(cmbCity);

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Settings.CreateMaster("Religion", "الديانة");
            FillReligion();
        }

        private void FillReligion()
        {
            var v = new MATRIX("Religion");
            v.FillComboBox(cmbReligionCode);
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            Settings.CreateMaster("HealthOffices", "مكاتب الصحة");
            FillHealthOffices();
        }

        private void FillHealthOffices()
        {
            var v = new MATRIX("HealthOffices");
            v.FillComboBox(cmbHealthOfficecode);
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            Settings.CreateMaster("Jobs", "الوظائف");
            FillJobs();
        }
        private void FillJobs()
        {
            var v = new MATRIX("Jobs");
            v.FillComboBox(cmbJobs);
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            Settings.CreateMaster("Depts", "الاقسام");
            FillDepts();
        }

        private void FillDepts()
        {
            var v = new MATRIX("Depts");
            v.FillComboBox(cmbDepts);
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            Settings.CreateMaster("Managements", "إدارات");
            FillManagements();
        }


        private void FillManagements()
        {
            var v = new MATRIX("Managements");
            v.FillComboBox(cmbManagements);
        }
        private void FillQualification()
        {
            var v = new MATRIX("Qualification");
            v.FillComboBox(cmbQualification);
        }
        private void simpleButton11_Click(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog f = new OpenFileDialog();
                f.InitialDirectory = "C:/Picture/";
                f.Filter = "All Files|*.*|JPEGs|*.jpg|Bitmaps|*.bmp|GIFs|*.gif";
                f.FilterIndex = 2;
                if (f.ShowDialog() == DialogResult.OK)
                {
                    var n = new PictureBox();
                    n.Image = Image.FromFile(f.FileName);
                    n.SizeMode = PictureBoxSizeMode.StretchImage;
                    n.BorderStyle = BorderStyle.Fixed3D;
                    //n.Size = new Size(175, 175);
                    n.ContextMenuStrip = contextMenuStrip1;
                    n.DoubleClick -= new EventHandler(Pic_Click);
                    n.DoubleClick += new EventHandler(Pic_Click);

                    pnlPic.Controls.Add(n);
                }
            }
            catch { }





        }


        private void Pic_Click(object sender, EventArgs e)
        {
            PictureBox pic = new PictureBox();
            pic.Image = ((PictureBox)sender).Image;

            pic.SizeMode = PictureBoxSizeMode.AutoSize;
            var panel1 = new Panel();
            panel1.AutoScroll = true; panel1.Dock = DockStyle.Fill;
            panel1.Controls.Add(pic);
            var frm = new Form();
            frm.Controls.Add(panel1);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.WindowState = FormWindowState.Maximized; frm.ShowDialog();

        }
        private void حذقToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("سوف يتم حذف المستند...هل هل انت متاكد؟", "حذف",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                var ss = contextMenuStrip1.SourceControl;
                pnlPic.Controls.Remove(ss);
            }

        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void btnQualification_Click(object sender, EventArgs e)
        {
            Settings.CreateMaster("Qualification", "المؤهلات");
            FillQualification();
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void pnlPic_Paint(object sender, PaintEventArgs e)
        {

        }




    }
}
