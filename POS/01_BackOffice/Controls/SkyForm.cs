using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace POS 
{
    public partial class SkyForm : XtraForm
    {
        public ResourceManager m_resourceManger = null;
        public SkyForm()
        {
            InitializeComponent();


            DataView dataSource = CreateTable(20).DefaultView;

            m_resourceManger = new ResourceManager("POS.Resource", Assembly.GetExecutingAssembly());
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ar-EG");
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("ar-EG");
            
            //foreach (Control ctrl in Controls)
            //{  ctrl.Text = m_resourceManger.GetString(ctrl.Name+".Text");
            //}
             
        }
        public static DataTable CreateTable(int RowCount)
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("Name", typeof(string));
            tbl.Columns.Add("ID", typeof(int));
            tbl.Columns.Add("Number", typeof(int));
            tbl.Columns.Add("Date", typeof(DateTime));
            for (int i = 0; i < RowCount; i++)
                tbl.Rows.Add(new object[] { String.Format("Name{0}", i), i, 3 - i, DateTime.Now.AddDays(i) });
            return tbl;
        }

        public bool View { get; set; }
        public bool Read { get; set; }
        public bool Modify { get; set; }
        public bool Create { get; set; }
        public bool Delete { get; set; }

 

    }
}