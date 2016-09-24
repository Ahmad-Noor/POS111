using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using DevExpress.CodeParser;
using Microsoft.Office.Interop.Excel;
using Application = System.Windows.Forms.Application;


namespace POS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(){
            //var s = Assembly.GetManifestResourceStream("POS.Resources.splashScreen.png");
            //System.Reflection.Assembly s = this.GetType().Assembly;
                var ss = Assembly.GetExecutingAssembly().GetManifestResourceNames();

            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Blue");// Visual Studio 2013 Blue        Blue
            var splashScreenImage = new Bitmap(CurrentAssembly.GetManifestResourceStream("POS.Resources.SplashScreen.png"));
            DevExpress.XtraSplashScreen.SplashScreenManager.ShowImage(splashScreenImage, true, false);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            //Thread.CurrentThread.CurrentUICulture = new CultureInfo("ar-EG");
            //Thread.CurrentThread.CurrentCulture = new CultureInfo("ar-EG");
            //Application.Run(new ssMain());
             
            Application.Run(new frmMain()); 
         
        }



        static Assembly currentAssemblyCore;
        static Assembly CurrentAssembly
        {
            get
            {if (currentAssemblyCore == null)
                    currentAssemblyCore = Assembly.GetExecutingAssembly();
                return currentAssemblyCore;
            }
        }
  

    }
}
