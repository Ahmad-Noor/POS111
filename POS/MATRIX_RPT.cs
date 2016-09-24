using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Management;
using System.Windows.Forms;

namespace POS
{
    class MATRIX_RPT
    {
        public CrystalDecisions.CrystalReports.Engine.ReportDocument DEC = new CrystalDecisions.CrystalReports.Engine.ReportDocument();


        DataTable TB_rpt = new DataTable();
        DataColumn Column = new DataColumn();
        public MATRIX_RPT(string rptname)
        {

            TB_rpt.Rows.Clear();
            Column = new DataColumn();
            Column.DataType = typeof(String);
            Column.ColumnName = "المسار";
            //Column.Caption = "المسار";
            TB_rpt.Columns.Add(Column);

            string path = "";
            GetRptPath(Application.StartupPath + @"\Reports\", rptname);



            CrystalDecisions.Shared.TableLogOnInfo LI = new CrystalDecisions.Shared.TableLogOnInfo();
            try
            {
                DEC.Load(path);
            }
            catch (Exception)
            {
                throw new Exception("   التقرير قيد التطوير     ");
            }

            foreach (Table T in DEC.Database.Tables)
            { 
                //LI = T.LogOnInfo;
                //LI.ConnectionInfo.ServerName = Properties.Settings.Default.ServerName;
                //LI.ConnectionInfo.DatabaseName = Properties.Settings.Default.DataBase;

                //if (Pub.Authentication == "0")
                //{
                //    LI.ConnectionInfo.IntegratedSecurity = true;
                //}
                //else
                //{
                //    LI.ConnectionInfo.UserID = Properties.Settings.Default.UserName;
                //    LI.ConnectionInfo.Password = Properties.Settings.Default.UserPassword;
                //}
                //T.ApplyLogOnInfo(LI);

                 

            }

            for (int SubR = 0; SubR < DEC.Subreports.Count; SubR++)
            {

                foreach (Table TableInfo in DEC.Subreports[SubR].Database.Tables)
                {
                    //LI = TableInfo.LogOnInfo;
                    //LI.ConnectionInfo.ServerName = Properties.Settings.Default.ServerName;
                    //LI.ConnectionInfo.DatabaseName = Properties.Settings.Default.DataBase;

                    //if (Pub.Authentication == "0")
                    //{
                    //    LI.ConnectionInfo.IntegratedSecurity = true;
                    //}
                    //else
                    //{
                    //    LI.ConnectionInfo.UserID = Properties.Settings.Default.UserName;
                    //    LI.ConnectionInfo.Password = Properties.Settings.Default.UserPassword;
                    //}
                    //TableInfo.ApplyLogOnInfo(LI);
                }
            }



        }


        private void GetRptPath(string Path, string rpt_name)
        {
            DirectoryInfo dir = new DirectoryInfo(Path);

            try
            {
                foreach (FileInfo file in dir.GetFiles())
                    if (file.Name == rpt_name)
                        TB_rpt.Rows.Add(file.FullName);
            }
            catch (Exception)
            { }
            //////////////////////////////// 
            try
            {
                foreach (DirectoryInfo Directory in dir.GetDirectories())
                    GetRptPath(Directory.FullName, rpt_name);
            }
            catch (Exception)
            { }

        }

        public void SelectionFormula(string الفلتر)
        {
            DEC.DataDefinition.RecordSelectionFormula = الفلتر;
        }
        public void SelectionFormula_sub(string سب_ريبورت, string الفلتر)
        {
            DEC.Subreports[سب_ريبورت].RecordSelectionFormula = الفلتر;
        }

        public void SetParameter(string الاسم, object القيمة)
        {
            DEC.SetParameterValue(الاسم, القيمة);
        }
        public void SetParameter_sub(string سب_ريبورت, string الاسم, object القيمة)
        {
            DEC.Subreports[سب_ريبورت].SetParameterValue(الاسم, القيمة);
        }


        public void Formula(string الاسم, string القيمة)
        {
            DEC.DataDefinition.FormulaFields[الاسم].Text = "'" + القيمة + "'";
        }
        public void Formula(string الاسم, object القيمة)
        {
            DEC.DataDefinition.FormulaFields[الاسم].Text = القيمة.ToString();
        }
        public void Formula_sub(string سب_ريبورت, string الاسم, string القيمة)
        {
            DEC.Subreports[سب_ريبورت].DataDefinition.FormulaFields[الاسم].Text = القيمة;
        }

        public void SetDataSource(object DS)
        {
            DEC.SetDataSource(DS);
        }

        public void Show(CrystalDecisions.Windows.Forms.CrystalReportViewer الاداة)
        {
            الاداة.ReportSource = DEC;
        }
        public void Show()
        {
            Form frm = new Form();
            CrystalDecisions.Windows.Forms.CrystalReportViewer Cry = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            frm.WindowState = FormWindowState.Maximized;
            frm.Controls.Add(Cry);
            Cry.Refresh();
            Cry.Dock = DockStyle.Fill;
            Cry.ReportSource = DEC;
            Cry.Refresh();
            //Cry.DisplayGroupTree = false;
            //Cry.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            frm.Show();
        }

        public void PrintToPrinter()
        {

            DEC.PrintToPrinter(1, false, 1, 1);
            DEC.Refresh();

        }
        public void PrintToPrinter(string برنتر, int عدد_نسخ = 1)
        {
            try
            {
                DEC.PrintOptions.PrinterName = برنتر;
            }
            catch (Exception)
            {
                MessageBox.Show("الطابعة غير موجودة", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DEC.PrintToPrinter(عدد_نسخ, false, 0, 0);
            DEC.Refresh();



        }
    }


}
