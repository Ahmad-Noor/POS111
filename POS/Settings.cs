using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using DevExpress.XtraEditors;
using ComboBox = System.Windows.Forms.ComboBox;

namespace POS
{
    public class Settings
    {
        //++-----Connection Database

        public static DBEntities db = new DBEntities();

        public static OleDbConnection CON = new OleDbConnection();
        public static OleDbTransaction Transaction;

        public static OleDbCommand CMD = new OleDbCommand();
        public static OleDbDataReader DR;

        public static long CurrentBranch_ID { get; set; }
        public static int CurrentUser_ID { get; set; }
        public static int CurrentYear { get; set; }
        public static string CurrentBox { get; set; }
        public static long CurrentShift_ID { get; set; }

        public enum StockTransType
        {
            StockOpeningBalance = 1,
            StockPurchases = 2,
            StockPurchasesReturn = 3,
            StockSales = 4,
            StockSalesReturn = 5,
            StockTransfersStores = 6, StockInventory = 7,
            StockEquals = 8
        }


        public static double ConvertToDouble(string Value)
        {
            if (Value == null)
            {
                return 0;
            }
            else
            {
                double OutVal;
                double.TryParse(Value, out OutVal);

                if (double.IsNaN(OutVal) || double.IsInfinity(OutVal))
                {
                    return 0;
                }
                return OutVal;
            }
        }


        public static void CreateMaster(string tableName, string Formname, string where = "1=1")
        {
            FrmJobs frm = new FrmJobs(new MATRIX(tableName), Formname, where);
            frm.ShowDialog();
        }
        public static Hashtable GetHashtable(string fCode, string fName, string tableName_Where)
        {


            var ht = new Hashtable();
            try { DR.Close(); }
            catch (Exception) { }
            CMD.CommandText = string.Format("select {0},{1} from {2}", fCode, fName, tableName_Where);
            DR = CMD.ExecuteReader();
            while (Settings.DR.Read())
                ht.Add(DR[fCode].ToString(), DR[fName].ToString());

            return ht;

        }

        public static bool ShiftIsOpen(string ShiftOrderNo)
        {

            return false;
        }
        public static T GetDataTable<T>(string sql) where T : struct
        {
            DataTable dt = new DataTable();

            try { DR.Close(); }
            catch (Exception) { }

            CMD.CommandText = sql;
            DR = CMD.ExecuteReader();
            dt.Load(DR);
            DR.Close();

            var ty = TypeDescriptor.GetConverter(typeof(T));

            try
            {
                var convertFrom = ty.ConvertFrom(dt);
                return (T)convertFrom;
            }
            catch (Exception)
            { }
            return default(T);
        }

        public static TabbedView tabbedView;
        public static void LoadControl(XtraUserControl control)
        {
            tabbedView.BeginUpdate();
            BaseDocument document = tabbedView.AddDocument(control);
            //document.Image = fileTypeImages.Images[12];
            document.Footer = Directory.GetCurrentDirectory();
            document.Caption = control.Name;
            tabbedView.EndUpdate();
            tabbedView.Controller.Activate(document);
        }

        public static OleDbDataReader GetDataTable(string sql)
        {
            try { DR.Close(); }
            catch (Exception) { }

            CMD.CommandText = sql;
            DR = CMD.ExecuteReader();

            return DR;
        }

        public static double Round(object Value)
        {
            double x = double.Parse(Value + "");
            return Math.Round(x, 2);

        }

        public static void Fill_Grid(DataGridView grd, string الجملة)
        {
            DataTable DT = new DataTable();
            try { DR.Close(); }
            catch (Exception) { }


            CMD.CommandText = الجملة;
            DR = CMD.ExecuteReader();
            DT.Load(DR);
            grd.DataSource = DT;
            grd.Refresh();
        }
        public static void Fill_Grid(DevExpress.XtraGrid.GridControl DG, string الجملة)
        {
            DataTable DT = new DataTable();
            try { DR.Close(); }
            catch (Exception) { }

            CMD.CommandText = الجملة;
            DR = CMD.ExecuteReader();
            DT.Load(DR); DG.DataSource = DT;
        }

        public static void Show_Form(Form Child)
        {
            //for (int i = 0; i < Application.OpenForms.Count; i++)
            //{
            //    if (Application.OpenForms[i].Name == Child.Name)
            //    {
            //        Application.OpenForms[i].Activate();
            //        return;
            //    }
            //}

            //for (int i = 0; i < Application.OpenForms.Count; i++)
            //{

            //if (Application.OpenForms[i].Name.ToUpper() == "FrmMain".ToUpper())
            //{
            //Child.MaximizeBox = false;
            //Child.FormBorderStyle = FormBorderStyle.FixedSingle;
            //Child.StartPosition = FormStartPosition.CenterScreen;
            //Child.MdiParent = (FrmMain)Application.OpenForms[i];
            ////Child.BackgroundImage = Properties.Resources.Calculation;;
            //Child.BackColor = Color.WhiteSmoke;
            ////Child.BackgroundImageLayout = ImageLayout.Stretch;
            //Child.Show();


            //Child.MaximizeBox = false;
            //Child.FormBorderStyle = FormBorderStyle.FixedSingle;
            Child.StartPosition = FormStartPosition.CenterScreen;
            //Child.MdiParent = (FrmMain)Application.OpenForms[i];
            //Child.BackgroundImage = Properties.Resources.Calculation;;
            //Child.BackColor = Color.WhiteSmoke;
            //Child.BackgroundImageLayout = ImageLayout.Stretch;
            Child.Show();

            //break;
            //}
            //}
        }

        public static void CreateShift()
        {
            var ShiftsTransaction = db.POS_ShiftsTransaction.Where(c => c.Branch_ID == CurrentBranch_ID && c.OrderStatus == 1).FirstOrDefault();
            if (ShiftsTransaction == null)
            {
                POS_ShiftsTransaction st = new POS_ShiftsTransaction();
                st.CreationDate = DateTime.Now;
                st.UserCreate = Settings.CurrentUser_ID;
                st.Branch_ID = Settings.CurrentBranch_ID;
                var ss = db.POS_ShiftsTransaction.Where(c => c.Branch_ID == CurrentBranch_ID).Max(c => c.OrderNo);
                st.OrderNo = ss == null ? 1 : ss + 1;
                st.OrderStatus = 1;
                st.Note = "Create by system.";

                var type = db.POS_ShifTypes.Where(c => c.Branch_ID == CurrentBranch_ID & c.FromTime >= DateTime.Now && c.ToTime <= DateTime.Now).FirstOrDefault();
                if (type != null)
                {
                    st.ShifTypes_ID = type.ID;
                }

                db.POS_ShiftsTransaction.Add(st);
                db.SaveChanges();
                CurrentShift_ID = st.ID;

                //------Assign Orders To Current Shift
                db.AssignOrdersToCurrentShift(st.ID, CurrentBranch_ID);

            }
            else
            {
                CurrentShift_ID = ShiftsTransaction.ID;
            }

        }

        public static string Shift_isOpen()
        {
            var ShiftsTransaction = db.POS_ShiftsTransaction.Where(c => c.Branch_ID == CurrentBranch_ID && c.ID == CurrentShift_ID).FirstOrDefault();
            string OrderStatus = "";
            if (ShiftsTransaction.OrderStatus != 1)
            {
                OrderStatus = "Shift is close";
            }

            return OrderStatus;//Equal ""  shift is open
        }
        public static void ExecuteReader(string الجملة)
        {
            try { DR.Close(); }
            catch (Exception) { }

            CMD.CommandText = الجملة;
            DR = CMD.ExecuteReader();
            if (DR.HasRows)
                DR.Read();
        }


        public static void ExecuteNonQuery(string Query)
        {
            try { DR.Close(); }
            catch (Exception) { }

            CMD.CommandText = Query;
            CMD.ExecuteNonQuery();
        }

        public static void Search(Control كنترول, string الجملة)
        {
            //try { DR.Close(); }
            //catch (Exception) { }

            //SearchControl = كنترول;
            //FrmSearch frm = new FrmSearch();
            //DataTable dt = new DataTable();
            //CMD.CommandText = الجملة;
            //DR = CMD.ExecuteReader();
            //dt.Load(DR);
            //frm.bs.DataSource = dt;
            //frm.dg.DataSource = frm.bs;
            //frm.ShowDialog();
        }



        #region Link Combo


        //-----------------Link Combo
        private static int CmbIndex = 0;
        private static DataTable DT;
        public static void Fill_cmb_DT(string الجمله, params string[] ArrayValue)
        {
            DT = new System.Data.DataTable();
            DT.Clear();
            try { DR.Close(); }
            catch (Exception) { }

            CMD.CommandText = الجمله;
            DR = CMD.ExecuteReader();
            DT.Load(DR);
            DT.Rows.Add(ArrayValue);
            DT.DefaultView.Sort = DT.Columns[CmbIndex].Caption;
        }
        public static void Combo(ComboBox CMB, string حقل_كود, string حقل_الاسم)
        {
            CMB.DataSource = DT;
            CMB.DisplayMember = حقل_الاسم;
            CMB.ValueMember = حقل_كود;
        }
        #endregion


    }

}
