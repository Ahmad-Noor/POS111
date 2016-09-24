using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Charts.Model;
using DevExpress.XtraEditors;

namespace POS
{
    public partial class Sky_UserControl : XtraUserControl
    {
        public Sky_UserControl()
        {
            InitializeComponent();
        }

        public string Text2 { get; set; }
 
        public string Text { get; set; }

        private void createAlarmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
