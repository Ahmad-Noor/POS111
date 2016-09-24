using System;
using System.Windows.Forms;

namespace POS
{
    public partial class FrmDBBackup : SkyForm
    {
        public FrmDBBackup()
        {
            InitializeComponent();
        }
 
 

  


        public void btnExit_Click(System.Object sender, System.EventArgs e)
        {
          Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //var saveFileDialog1=new SaveFileDialog();
            //saveFileDialog1.FileName = Properties.Settings.Default.DataBase + " " + DateTime.Now.ToString(@" yyyy-MM-dd hh-mm") + ".bak";
            //saveFileDialog1.ShowDialog();
            //string s = null;
            //s = saveFileDialog1.FileName;
            //Pub.ExecuteNonQuery("Backup database " + Properties.Settings.Default.DataBase + " to disk='" + s + "'");
            //MessageBox.Show("Backup Complete!!");
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }
        
 
      



    }
}
