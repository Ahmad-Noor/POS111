using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
//using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;
using DevExpress.XtraSplashScreen;

namespace POS
{
    public partial class frmBackOffice : SkyForm
    {
        public frmBackOffice()
        {
            InitializeComponent();
            try
            {
                foreach (Control ctrl in Controls)
                {
                    ctrl.Text = m_resourceManger.GetString(ctrl.Name + ".Text");
                }
            }
            catch (Exception)
            {

            }

        }
        DBEntities db= new DBEntities();
        private void frmBackOffice_Load(object sender, EventArgs e)
        {
            SkinHelper.InitSkinPopupMenu(iPaintStyle);
            Settings.tabbedView = tabbedView;
            // -------------------------------------- 
            Settings.LoadControl(new uDashboard());
            ///--------------------------------------
            
 
            TreeList1.KeyFieldName = "FormID";TreeList1.ParentFieldName = "Perant_FormID";
            TreeList1.DataSource = db.LKUPMainTrees.OrderBy(c=>c.indexSort).ToList();
            TreeList1.ExpandToLevel(0);








 

        }
  
        //void LoadControl(XtraUserControl control)
        //{
        //    tabbedView.BeginUpdate();
        //    //frmBackOffice control = new frmBackOffice(); 
        //    BaseDocument document = tabbedView.AddDocument(control);
        //    document.Image = fileTypeImages.Images[12];
        //    document.Footer = Directory.GetCurrentDirectory();
        //    document.Caption = control.Name;
        //    tabbedView.EndUpdate();//    tabbedView.Controller.Activate(document);
        //}
         
 

        private void TreeList1_DoubleClick(object sender, EventArgs e)
        {
            var ss = TreeList1.FocusedNode.GetValue("FormName");
            if (ss != null && Type.GetType("POS." + ss.ToString()) != null)
            {
                var control = Activator.CreateInstance(Type.GetType("POS." + ss.ToString())) as Sky_UserControl;
                Settings.LoadControl(control);
            }


        }

        private void TreeList1_GetStateImage(object sender, DevExpress.XtraTreeList.GetStateImageEventArgs e)
        {
            if (e.Node.GetDisplayText("Icon") == "0")
                e.NodeImageIndex = e.Node.Expanded ? 1 : 0;
            else if (e.Node.GetDisplayText("Icon") == "2") e.NodeImageIndex = 2;
            else if (e.Node.GetDisplayText("Icon") == "3") e.NodeImageIndex = 3;
            else if (e.Node.GetDisplayText("Icon") == "4") e.NodeImageIndex = 4;
        }

    }
}
