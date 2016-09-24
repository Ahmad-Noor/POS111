using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using ComboBox = System.Windows.Forms.ComboBox;

namespace POS
{
    public class MATRIX
    {

        public OleDbCommand Cmd = new OleDbCommand();
        public OleDbDataReader DR;
        public string جدول;
        string VLU;
        public string FLD;
        public string FldUpdate;

        public MATRIX(string جدول)
        {
            Cmd = Settings.CON.CreateCommand();
            Cmd.Transaction = Settings.Transaction;
            Cmd.CommandType = CommandType.Text;
            this.جدول = "[" + جدول + "]";
        }

        public object this[string fName]
        {
            get
            {
                return DR[fName];
            }
            set { SetFiled(fName, value); }
        }


        //------------- Find
        public bool find(string الشرط)
        {
            الشرط = (الشرط == "" ? "" : " where " + الشرط);
            ExecuteReader(("Select * from " + جدول + الشرط));
            if (DR.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //------------- View
        public void View()
        {
            ExecuteReader();
        }
        public void View(string الشرط)
        {
            الشرط = (الشرط == "" ? "" : " where " + الشرط);
            ExecuteReader(("Select * from " + جدول + الشرط));
        }
        //------------- GetFiled
        public string GetFiled(string الحقل)
        {
            try
            {
                return DR[الحقل].ToString();
            }
            catch (Exception)
            {
                return "";
            }
        }
        public void GetFiled(Control Ctrl)
        {

            //  if(DR.HasRows==true)
            if (Ctrl.HasChildren == true)
            {

                for (int i = 0; i <= Ctrl.Controls.Count - 1; i++)
                {

                    if (Ctrl.Controls[i].HasChildren == true)
                    {
                        GetFiled(Ctrl.Controls[i]);
                    }

                    //If Ctrl.Controls(i).Tag = "MainNo" Then
                    //    Dim x As Integer = 1
                    //End If
                    if (Ctrl.Controls[i].Tag != null)
                    {

                        if (Ctrl.Controls[i].Tag.ToString() != "")
                        {

                            if (Ctrl.Controls[i].Tag.ToString().Substring(0, 1) != "*")
                            {
                                GetFiled(Ctrl.Controls[i]);
                            }
                        }
                    }

                }
            }

            else if (Ctrl.Tag.ToString().Substring(0, 1) != "*")
            {

                switch (Ctrl.GetType().Name)
                {

                    case "ComboBox":

                        try
                        {

                            // # save Text
                            // @ SelectedValue
                            //   defult SelectedIndex
                            if (((System.Windows.Forms.ComboBox)Ctrl).Tag.ToString().Substring(0, 1) == "#")
                            {
                                ((System.Windows.Forms.ComboBox)Ctrl).Text = DR[Symbol(Ctrl)].ToString();

                            }

                            else if (((System.Windows.Forms.ComboBox)Ctrl).Tag.ToString().Substring(0, 1) == "@")
                            {
                                ((System.Windows.Forms.ComboBox)Ctrl).SelectedValue = DR[Symbol(Ctrl)];

                            }

                            else
                            {
                                ((System.Windows.Forms.ComboBox)Ctrl).SelectedIndex = (int)(DR[Symbol(Ctrl)]);
                            }

                        }

                        catch (Exception) { }

                        break;

                    case "CheckBox":

                        try
                        {
                            ((CheckBox)Ctrl).Checked = System.Convert.ToBoolean(DR[Symbol(Ctrl)]);
                        }

                        catch (Exception)
                        {
                            ((CheckBox)Ctrl).Checked = false;
                        }
                        break;

                    case "CheckEdit":

                        try
                        {
                            ((CheckEdit)Ctrl).Checked = System.Convert.ToBoolean(DR[Symbol(Ctrl)]);
                        }

                        catch (Exception)
                        {
                            ((CheckEdit)Ctrl).Checked = false;
                        }
                        break;

                    case "DateTimePicker":

                        try
                        {
                            ((DateTimePicker)Ctrl).Value = (DateTime)DR[Symbol(Ctrl)];
                        }

                        catch (Exception)
                        {
                            ((DateTimePicker)Ctrl).Value = DateTime.Now;
                        }
                        break;

                    case "PictureBox":

                        try
                        {
                            MemoryStream ms = new MemoryStream((byte[])(DR[Symbol(Ctrl)]));
                            ((PictureBox)Ctrl).Image = Image.FromStream(ms);
                            ms.Close();








                        }

                        catch (Exception)
                        {
                            ((PictureBox)Ctrl).Image = null;
                        }

                        break;
                    default:

                        try
                        {
                            Ctrl.Text = (DR[Symbol(Ctrl)].ToString());
                        }

                        catch (Exception)
                        {
                            Ctrl.Text = "";
                        }
                        break;

                    //  }
                }
            }
        }
        public void GetFiled(Control Ctrl, string الحقل)
        {

            switch (Ctrl.GetType().Name)
            {
                case "ComboBox":
                    try
                    {
                        ((System.Windows.Forms.ComboBox)Ctrl).SelectedIndex = 0;
                        ((System.Windows.Forms.ComboBox)Ctrl).SelectedValue = DR[الحقل].ToString();
                    }
                    catch (Exception)
                    { }
                    break;

                case "CheckBox":
                    try
                    {
                        ((CheckBox)Ctrl).Checked = System.Convert.ToBoolean(DR[الحقل]);
                    }
                    catch (Exception)
                    {
                        ((CheckBox)Ctrl).Checked = false;
                    }
                    break;
                case "CheckEdit":
                    try
                    {
                        ((CheckEdit)Ctrl).Checked = System.Convert.ToBoolean(DR[الحقل]);
                    }
                    catch (Exception)
                    {
                        ((CheckBox)Ctrl).Checked = false;
                    }
                    break;
                case "DateTimePicker":
                    try
                    {
                        Ctrl.Text = (DR[الحقل].ToString());
                    }
                    catch (Exception)
                    {
                        Ctrl.Text = DateTime.Now.Date.ToShortTimeString();
                    }
                    break;

                case "PictureBox":

                    try
                    {
                        MemoryStream ms = new MemoryStream((byte[])(DR[الحقل]));
                        ((PictureBox)Ctrl).Image = Image.FromStream(ms);
                    }
                    catch (Exception)
                    {
                        ((PictureBox)Ctrl).Image = null;
                    }

                    break;
                default:

                    try
                    {
                        Ctrl.Text = DR[الحقل].ToString();
                    }
                    catch (Exception)
                    {
                        Ctrl.Text = "";
                    }
                    break;

            }
        }

        //------------- Get

        public string Get_Max(string الحقل)
        {
            ExecuteReader(("Select ISNULL(Max(CONVERT(INT," + الحقل + ")), 0)  from " + جدول));
            return DR[0].ToString();
        }
        public void Get_New(Control Txt)
        {
            ExecuteReader(("Select ISNULL(Max(CONVERT(INT," + Symbol(Txt) + ")), 0)+1 from " + جدول));
            Txt.Text = DR[0].ToString();
        }
        public string Get_New(string الحقل)
        {
            ExecuteReader(("Select ISNULL(Max(CONVERT(INT," + الحقل + ")), 0)+1  from " + جدول));
            return DR[0].ToString();
        }
        public string Get_New(string الحقل, string الشرط)
        {
            الشرط = (الشرط == "" ? "" : " where " + الشرط);
            ExecuteReader(("Select ISNULL(Max(CONVERT(INT," + الحقل + ")), 0)+1  from " + جدول + الشرط));
            return DR[0].ToString();
        }
        public void Get_New(Control Txt, string الشرط)
        {
            الشرط = (الشرط == "" ? "" : " where " + الشرط);
            ExecuteReader(("Select ISNULL(Max(CONVERT(INT," + Symbol(Txt) + ")),0)+1 from " + جدول + الشرط));
            Txt.Text = DR[0].ToString();
        }
        //-------------
        public void Add_New()
        {
            FLD = "";
            VLU = "";
            FldUpdate = "";
            Cmd.Parameters.Clear();
        }
        //------------- SetFiled

        public void SetFiled(string الحقل, object القيمة)
        {
            Cmd.Parameters.Add(new OleDbParameter("amn", القيمة));
            if (FLD != "")
            {
                FLD += ("," + الحقل);
                VLU += ",?";
                FldUpdate += "," + الحقل + "=?";
            }
            else
            {
                FLD = الحقل;
                VLU = "?";
                FldUpdate = الحقل + "=?";
            }

        }
        public void SetFiled(Control Ctrl)
        {
            if (Ctrl.HasChildren)
            {
                for (int i = 0; i <= Ctrl.Controls.Count - 1; i++)
                {
                    if (Ctrl.Controls[i].HasChildren == true)
                    {
                        SetFiled(Ctrl.Controls[i]);
                    }

                    if (Ctrl.Controls[i].Tag != null && Ctrl.Controls[i].Tag.ToString() != "")
                    {
                        SetFiled(Ctrl.Controls[i]);
                    }
                }
            }
            else
            {
                SetFiled(Ctrl.Tag.ToString(), Ctrl);
            }

        }

        public string SearchByCode(string الحقول, string الشرط = "")
        {
            //FrmSearchByCode frm = new FrmSearchByCode();

            //frm.ShowDialog();
            //string s = frm.txtCode.Text.Trim();
            //frm.Close();

            //if (s == "")
            //    return "";

            //الشرط = " " + الحقول + " =N'" + s + "' " + (الشرط == "" ? " " : " and " + الشرط);
            if (find(الشرط))
                return "";//s;
            else
                throw new Exception("الكود غير موجود");

        }

        public void SetFiled(string الحقل, Control Ctrl)
        {

            switch (Ctrl.GetType().Name)
            {
                case "CheckBox":
                    SetFiled(الحقل, ((CheckBox)Ctrl).Checked);
                    break;
                case "ComboBox":
                    // # save Text
                    // @ SelectedValue
                    //   defult SelectedIndex
                    if (((ComboBox)Ctrl).Tag.ToString().Substring(0, 1) == "#")
                    {
                        SetFiled(الحقل, ((ComboBox)Ctrl).Text);
                    }
                    else if (((ComboBox)Ctrl).Tag.ToString().Substring(0, 1) == "@")
                    {
                        SetFiled(الحقل, ((ComboBox)Ctrl).SelectedValue);
                    }
                    else
                    {
                        SetFiled(الحقل, ((ComboBox)Ctrl).SelectedIndex);
                    }

                    break;
                case "DateTimePicker":
                    if (((DateTimePicker)Ctrl).Tag.ToString().Substring(0, 1) == "*")
                    {
                        SetFiled(الحقل, ((DateTimePicker)Ctrl).Value);
                    }
                    else
                    {
                        Cmd.Parameters.Add(new OleDbParameter("amn", ((DateTimePicker)Ctrl).Value));
                        if (FLD != "")
                        {
                            FLD += ("," + الحقل);
                            VLU += ",?";
                            FldUpdate += "," + الحقل + "=?";
                        }
                        else
                        {
                            FLD = الحقل;
                            VLU = "?";
                            FldUpdate = الحقل + "=?";
                        }
                        //SetFiled(الحقل, ((DateTimePicker)Ctrl).Value.Date);
                    }

                    break;
                case "PictureBox":
                    try
                    {
                        if (((PictureBox)Ctrl).Image != null)
                        {
                            Bitmap newBitmap1 = new Bitmap(((PictureBox)Ctrl).Image);
                            var ms1 = new MemoryStream();
                            newBitmap1.Save(ms1, ImageFormat.Jpeg);
                            byte[] photoAray1 = new byte[ms1.Length];
                            ms1.Position = 0;
                            ms1.Read(photoAray1, 0, photoAray1.Length);
                            ms1.Close();
                            SetFiled(الحقل, photoAray1);
                        }

                    }
                    catch (Exception)
                    {
                    }
                    break;


                case "PictureEdit":
                    try
                    {
                        MemoryStream ms = new MemoryStream();
                        ((PictureEdit)Ctrl).Image.Save(ms, ImageFormat.Jpeg);
                        Cmd.Parameters.Add(new OleDbParameter("amn", ms.ToArray()));

                        SetFiled(الحقل, ms.ToArray());
                        ms.Close();
                    }
                    catch (Exception)
                    { }
                    break;

                default:
                    try
                    {
                        SetFiled(الحقل, Ctrl.Text);

                    }
                    catch (Exception)
                    { }
                    break;
            }


        }
        //-------------
        public string Get_Value(string الحقل)
        {
            ExecuteReader(("Select " + الحقل + " from " + جدول));
            if (DR.HasRows)
                return DR[0].ToString();
            else
                return "";
        }
        public string Get_Value(string الحقل, string الشرط)
        {
            الشرط = (الشرط == "" ? "" : " where " + الشرط);
            ExecuteReader(("Select " + الحقل + " F__,* from " + جدول + الشرط));
            if (DR.HasRows)
                return DR[0].ToString();
            else
                return "";

        }
        //------------- Update
        public void Update()
        {
            ExecuteNonQuery("insert into " + جدول + "(" + FLD + ")Values(" + VLU + ")");
        }
        public void Update(string الشرط)
        {
            if (find(الشرط) == true)
                ExecuteNonQuery(("update " + جدول + " set " + FldUpdate + " where " + الشرط));
            else
                Update();

        }
        //------------- Execute
        public void ExecuteNonQuery(string Query)
        {

            try { DR.Close(); }
            catch (Exception) { }

            Cmd.CommandText = Query;
            Cmd.ExecuteNonQuery();
        }
        public void ExecuteReader()
        {

            try { DR.Close(); }
            catch (Exception) { }

            Cmd.CommandText = ("Select * from " + جدول);
            DR = Cmd.ExecuteReader();
            if (DR.HasRows)
            {
                DR.Read();
            }
        }
        public void ExecuteReader(string الجملة)
        {

            try { DR.Close(); }
            catch (Exception) { }

            Cmd.CommandText = الجملة;
            DR = Cmd.ExecuteReader();
            if (DR.HasRows)
                DR.Read();
        }

        //------------- Delete
        public void Delete()
        {
            ExecuteNonQuery(("Delete from " + جدول));
        }
        public void Delete(string الشرط)
        {
            الشرط = الشرط == "" ? "" : " where " + الشرط;
            ExecuteNonQuery("Delete from " + جدول + الشرط);
        }
        //------------- AutoComplet
        public void AutoComplet(TextBox Txt)
        {
            Txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
            Txt.AutoCompleteMode = AutoCompleteMode.Suggest;

            try { DR.Close(); }
            catch (Exception) { }

            Cmd.CommandText = "Select " + Symbol(Txt) + " from " + جدول;
            DR = Cmd.ExecuteReader();
            while (DR.Read())
                Txt.AutoCompleteCustomSource.Add(DR[Symbol(Txt)].ToString());
        }
        public void AutoComplet(TextBox Txt, string الشرط)
        {
            الشرط = الشرط == "" ? "" : " where " + الشرط;
            Txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
            Txt.AutoCompleteMode = AutoCompleteMode.Suggest;
            ExecuteReader("Select " + Symbol(Txt) + " from " + جدول + الشرط);

            try
            {
                while (DR.Read())
                {
                    Txt.AutoCompleteCustomSource.Add((DR[Symbol(Txt)].ToString()));
                }
            }
            catch (Exception) { }
        }




        //-------------  Fill_Grid
        public void Fill_Grid(DataGridView DG)
        {
            DataTable DT = new DataTable();
            string Fld = "";
            for (int i = 0; i <= DG.ColumnCount - 1; i++)
            {
                if (Fld == "")
                {
                    Fld = DG.Columns[i].DataPropertyName;
                }
                else
                {
                    if (DG.Columns[i].DataPropertyName.Trim() != "")
                        Fld += "," + DG.Columns[i].DataPropertyName;
                }
            }

            try { DR.Close(); }
            catch (Exception) { }

            Cmd.CommandText = ("Select " + Fld + " from " + جدول);
            DR = Cmd.ExecuteReader();
            try
            {
                DT.Load(DR);
                DG.DataSource = DT;
            }
            catch (Exception)
            {
                return;
            }
        }



        public void Fill_Grid(DataGridView DG, string الحقول)
        {
            DataTable DT = new DataTable();

            try { DR.Close(); }
            catch (Exception) { }

            Cmd.CommandText = "Select " + الحقول + " from " + جدول;
            DR = Cmd.ExecuteReader();
            try
            {
                DT.Load(DR);
                DG.DataSource = DT;
            }
            catch (Exception)
            {
                return;
            }
        }
        public void Fill_Grid(DataGridView DG, string الحقول, string الشرط)
        {
            DataTable DT = new DataTable();
            if (الحقول == "")
            {
                for (int i = 0; i <= DG.ColumnCount - 1; i++)
                {
                    if (الحقول == "")
                    {
                        الحقول = DG.Columns[i].DataPropertyName;
                    }
                    else
                    {
                        الحقول += "," + DG.Columns[i].DataPropertyName;
                    }
                }
            }


            try { DR.Close(); }
            catch (Exception) { }

            الشرط = (الشرط == "" ? "" : " where " + الشرط);
            Cmd.CommandText = ("Select " + الحقول + " from " + جدول + الشرط);
            DR = Cmd.ExecuteReader();
            try
            {
                DT.Load(DR);
                DG.DataSource = DT;
            }
            catch (Exception)
            {
                return;
            }
        }
        //------------- navigation
        public void MoveFrist(Control Ctrl, Boolean SortNumber = false)
        {
            try
            {
                Get_Value(Symbol(Ctrl), " 1=1 order by " + (SortNumber ? " CONVERT(INT," + Symbol(Ctrl) + ") " : Symbol(Ctrl)));
                Ctrl.Text = DR[0].ToString();
            }
            catch (Exception)
            { }
        }
        public void MoveFrist(Control Ctrl, string الشرط, Boolean SortNumber = false)
        {
            try
            {
                Get_Value(Symbol(Ctrl), الشرط + " order by " + (SortNumber ? " CONVERT(INT," + Symbol(Ctrl) + ") " : Symbol(Ctrl)));
                Ctrl.Text = DR[0].ToString();
            }
            catch (Exception)
            { }
        }

        public void MoveNext(Control Ctrl, Boolean SortNumber = false)
        {
            try
            {
                Get_Value(Symbol(Ctrl), Symbol(Ctrl) + ">" + Ctrl.Text + " order by " + (SortNumber ? " CONVERT(INT," + Symbol(Ctrl) + ") " : Symbol(Ctrl)));
                Ctrl.Text = DR[0].ToString();
            }
            catch (Exception)
            { }

        }
        public void MoveNext(Control Ctrl, string الشرط, Boolean SortNumber = false)
        {
            try
            {
                Get_Value(Symbol(Ctrl), Symbol(Ctrl) + ">" + Ctrl.Text + " and " + الشرط + " order by " + (SortNumber ? " CONVERT(INT," + Symbol(Ctrl) + ") " : Symbol(Ctrl)));
                Ctrl.Text = DR[0].ToString();
            }
            catch (Exception)
            { }
        }

        public void MovePrevious(Control Ctrl, Boolean SortNumber = false)
        {
            try
            {
                Get_Value(Symbol(Ctrl), Symbol(Ctrl) + "<" + Ctrl.Text + " order by " + (SortNumber ? " CONVERT(INT," + Symbol(Ctrl) + ") " : Symbol(Ctrl)) + " Desc");
                Ctrl.Text = DR[0].ToString();
            }
            catch (Exception)
            { }
        }
        public void MovePrevious(Control Ctrl, string الشرط, Boolean SortNumber = false)
        {
            try
            {
                Get_Value(Symbol(Ctrl), Symbol(Ctrl) + "<" + Ctrl.Text + " and " + الشرط + " order by " + (SortNumber ? " CONVERT(INT," + Symbol(Ctrl) + ") " : Symbol(Ctrl)) + " Desc");
                Ctrl.Text = DR[0].ToString();
            }
            catch (Exception) { }
        }

        public void MoveLast(Control Ctrl, Boolean SortNumber = false)
        {
            try
            {
                Get_Value(Symbol(Ctrl), " 1=1 order by " + (SortNumber ? " CONVERT(INT," + Symbol(Ctrl) + ") " : Symbol(Ctrl)) + " Desc");
                Ctrl.Text = DR[0].ToString();
            }
            catch (Exception) { }
        }
        public void MoveLast(Control Ctrl, string الشرط, Boolean SortNumber = false)
        {
            try
            {
                Get_Value(Symbol(Ctrl), الشرط + " order by " + (SortNumber ? " CONVERT(INT," + Symbol(Ctrl) + ") " : Symbol(Ctrl)) + " Desc");
                Ctrl.Text = DR[0].ToString();
            }
            catch (Exception) { }
        }
        //------------- Search
        ///<summary>
        /// Filed_Name1 as alias,Filed_Name2 as alias,...,...,.....
        ///</summary>

        public void Search(Control كنترول, string الحقول, string الشرط = "")
        {
            //Pub.SearchControl = كنترول;
            FrmSearch frm = new FrmSearch();
            DataTable dt = new DataTable();

            try { DR.Close(); }
            catch (Exception) { }


            الشرط = " where 1=1 " + (الشرط == "" ? "" : " and " + الشرط);
            Cmd.CommandText = ("Select " + الحقول + " from " + جدول + الشرط);
            DR = Cmd.ExecuteReader();
            dt.Load(DR);
            frm.bs.DataSource = dt;
            frm.dg.DataSource = frm.bs;
            frm.ShowDialog();
        }

        public void Search2(Control كنترول, string الحقول, string الشرط = "")
        {
            //try { DR.Close(); }
            //catch (Exception) { }

            //Pub.SearchControl = كنترول;
            //FrmSearch2 frm = new FrmSearch2();
            //الحقول = "Select " + الحقول + " from " + جدول;
            //frm.الجملة = الحقول;

            //frm.الشرط = الشرط;

            //الشرط = " where 1=1 " + (الشرط == "" ? "" : " and " + الشرط);

            //frm.tree1.MasterTable = جدول;
            ////frm.tree1.MasterWhere = الشرط;
            //frm.CMD.Connection = Pub.CON;
            //frm.CMD.CommandType = CommandType.Text;
            //frm.CMD.CommandText = (الحقول + الشرط);
            //DR = frm.CMD.ExecuteReader();
            //frm.dt.Load(DR);
            //frm.bs.DataSource = frm.dt;
            //frm.dg.DataSource = frm.bs;
            //frm.ShowDialog();
        }

        public void Search(string الحقول, string الشرط = "")
        {
            //Pub.SearchControl.Text = "";
            FrmSearch frm = new FrmSearch();
            DataTable dt = new DataTable();

            try { DR.Close(); }
            catch (Exception) { }


            الشرط = " where 1=1 " + (الشرط == "" ? "" : " and " + الشرط);
            Cmd.CommandText = ("Select " + الحقول + " from " + جدول + الشرط);
            DR = Cmd.ExecuteReader();
            dt.Load(DR);
            frm.bs.DataSource = dt;
            frm.dg.DataSource = frm.bs;
            frm.ShowDialog();
        }

        public void Search2(string الحقول, string الشرط = "")
        {
            //Pub.SearchControl.Text = "";
            //try { DR.Close(); }
            //catch (Exception) { }
            //Pub.SearchControl.Text = "";
            //FrmSearch2 frm = new FrmSearch2();
            //الحقول = "Select " + الحقول + " from " + جدول;
            //frm.الجملة = الحقول;

            //frm.الشرط = الشرط;

            //الشرط = " where 1=1 " + (الشرط == "" ? "" : " and " + الشرط);

            //frm.tree1.MasterTable = جدول;
            ////frm.tree1.MasterWhere = الشرط;
            //frm.CMD.Connection = Pub.CON;
            //frm.CMD.CommandType = CommandType.Text;
            //frm.CMD.CommandText = (الحقول + الشرط);
            //DR = frm.CMD.ExecuteReader();
            //frm.dt.Load(DR);
            //frm.bs.DataSource = frm.dt;
            //frm.dg.DataSource = frm.bs;
            //frm.ShowDialog();
        }
 

        //--------------- link Combo


        public void FillComboBox(ComboBox CMB, string حقل_كود = "Code", string حقل_الاسم = "Name", string الشرط = "1=1")//, params string[] arrayValue)
        {
            var dt = new DataTable();
            try { DR.Close(); }
            catch (Exception) { }

            Cmd.CommandText = (string.Format("Select '0' {0} ,'---اختار---' {1}  union all Select {0},{1} from {2} where {3} ", حقل_كود, حقل_الاسم, جدول, الشرط));
            DR = Cmd.ExecuteReader();

            dt.Load(DR);//dt.Rows.Add("0", "اختار");

            CMB.DataSource = dt;
            CMB.DisplayMember = حقل_الاسم; CMB.ValueMember = حقل_كود;
            CMB.DropDownStyle = ComboBoxStyle.DropDownList;
            CMB.RightToLeft = RightToLeft.Yes;
        }

        //----------------------------------------

        public string Symbol(Control Ctrl)
        {
            if (Ctrl.Tag.ToString() != "")
            {
                if (Ctrl.Tag.ToString().Substring(0, 1) == "*" || Ctrl.Tag.ToString().Substring(0, 1) == "#" || Ctrl.Tag.ToString().Substring(0, 1) == "@")
                    return Ctrl.Tag.ToString().Substring(1, System.Convert.ToInt32(Ctrl.Tag.ToString().Length - 1));
            }
            return Ctrl.Tag.ToString();
        }

    }



}
