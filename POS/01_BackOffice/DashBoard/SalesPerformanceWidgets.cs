using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;

namespace POS {
    public partial class uDashboard : TutorialControlBase {
        public uDashboard() {
            InitializeComponent();
        }

        Random r = new Random();
        private void widgetView1_QueryControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e) {
            if(e.Document.ControlTypeName == "POS.ucCardWidget") 
            {
                var smallWidget = new ucCardWidget();
                smallWidget.Price = r.Next(100, 1000);
                smallWidget.PPrice = r.NextDouble() - r.NextDouble();
                smallWidget.Delta = r.Next(-50, 100) + r.NextDouble();
                e.Control = smallWidget;
                return;
            }
            //else if (e.Document.ControlTypeName == "POS.ucChoroplethMapItem")
            //{
            //    e.Control = new POS.ucChoroplethMapItem();
            //}



            if (!string.IsNullOrEmpty(e.Document.ControlTypeName))
            {
                var control = Activator.CreateInstance(Type.GetType(e.Document.ControlTypeName)) as Control;
                e.Control = control;
            }
        }
       
    }
}