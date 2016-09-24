using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;
using DevExpress.XtraSplashScreen;

namespace POS
{
    public partial class frmMain : SkyForm
    {
        public frmMain()
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
        private DBEntities db = new DBEntities();
        private void frmMain_Load(object sender, EventArgs e)
        {
            SplashScreenManager.HideImage(1000, this);


          Settings.CurrentBranch_ID =1;
          Settings.CurrentUser_ID = 1;

            var users = db.Users.ToList();
            foreach (var user in users)
            {

                SimpleButton btn = new SimpleButton();
                btn.Text = user.UserName;
                btn.Tag = user.ID;


                btn.Appearance.Options.UseFont = true;
                btn.Image = global::POS.Properties.Resources.user_32;
                btn.ImageLocation = ImageLocation.MiddleLeft;
                btn.Width = 150;
                btn.Height = 50;
                //btn.Click += new System.EventHandler(this.btnSave_Click);

                flowLayoutPanel1.Controls.Add(btn);
            }
        }



        private void btnupdatemenu_Click(object sender, EventArgs e)
        {
            //    db.ScreensPermissions.RemoveRange(db.ScreensPermissions.ToList());
            //    for (int i = 0; i < navBarControl1.Items.Count; i++)
            //    {
            //        var sp = new ScreensPermission();
         
            //        sp.Key = navBarControl1.Items[i].Name;
            //        sp.Caption = navBarControl1.Items[i].Caption;
            //        db.ScreensPermissions.Add(sp);
            //        db.SaveChanges();
            //    }
        }

        private void dashboardTileBarItem_ItemClick(object sender, TileItemEventArgs e)
        {
            Settings.Show_Form(new frmPOS_Orders());
        }

        private void navButton2_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            Settings.Show_Form(new frmBackOffice());
        }

        private void employeesTileBarItem_ItemClick(object sender, TileItemEventArgs e)
        {
            //Settings.Show_Form(new Form1());
        }

        private void navButtonClose_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            Application.Exit();
        }
    }
}
