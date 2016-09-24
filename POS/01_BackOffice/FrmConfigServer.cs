using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;


using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Microsoft.Win32;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using System.Collections.Specialized;
using System.Diagnostics;
using OpenFileDialog = System.Windows.Forms.OpenFileDialog;

//using Microsoft.SqlServer.Management.Smo;
//using Microsoft.SqlServer.Management.Common;

//using System.Collections.Specialized;

namespace POS
{
    public partial class FrmConfigServer
    {
        public FrmConfigServer()
        {

            InitializeComponent();
        }

        public void CmdSave_Click(System.Object sender, System.EventArgs e)
        {

            if (cmbSVR.Text == "")
            {
                MessageBox.Show("Please Choose Server...");
                return;
            }

            if (txtUser.Text == "")
            {
                MessageBox.Show("Please Enter User Name...");
                return;
            }

            if (txtPassword.Text == "")
            {
                MessageBox.Show("Please Enter User Password");
                return;
            }

            if (DatabaseCombo.Text == "")
            {
                MessageBox.Show("Please Choose Data Base");
                return;
            }

            try
            {
                Settings.CON.Close();
            }

            catch (Exception)
            { }

            try
            {






                //Pub.CON.ConnectionString = ("Provider=SQLOLEDB.1;Password=" + POS.Properties.Settings.Default.UserPassword + ";Persist Security Info=True;User ID=" + POS.Properties.Settings.Default.UserName + ";Initial Catalog=" + POS.Properties.Settings.Default.DataBase + ";Data Source=" + POS.Properties.Settings.Default.ServerName);
                Settings.CON.Open();
                Settings.CMD.Connection = Settings.CON;
                //Properties.Settings.Default.ServerName = cmbSVR.Text;
                //Properties.Settings.Default.UserName = txtUser.Text;
                //Properties.Settings.Default.UserPassword = txtPassword.Text;
                //Properties.Settings.Default.DataBase = DatabaseCombo.Text;
                //Properties.Settings.Default.Save();

                Application.Exit();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // "Error de conexión"
            }
        }

        private void ServerCombo_DropDown(object sender, EventArgs e)
        {

            //try
            //{

            //    SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
            //    DataTable table = instance.GetDataSources();

            //    foreach (DataRow row in table.Rows)
            //    {
            //        cmbSVR.Items.Add(row[0].ToString() + (row[1].ToString() != "" ? "\\" + row[1].ToString() : ""));
            //    }

            //}
            //catch { }
            //Cursor = Cursors.Default;
        }

        private void DatabaseCombo_DropDown(object sender, EventArgs e)
        {
            //if (cmbSVR.Text.Trim() == "")
            //{
            //    MessageBox.Show("Please Choose Server...");
            //    return;
            //}

            //String conxString = "Data Source=" + cmbSVR.Text.Trim() + "; Integrated Security=True;";

            //using (SqlConnection sqlConx = new SqlConnection(conxString))
            //{
            //    sqlConx.Open();
            //    DataTable tblDatabases = sqlConx.GetSchema("Databases");
            //    sqlConx.Close();

            //    foreach (DataRow row in tblDatabases.Rows)
            //    {
            //        DatabaseCombo.Items.Add(row["database_name"]);
            //    }
            //}
        }

        private void ConfigServer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmConfigServer_Load(object sender, EventArgs e)
        {
            //RegistryKey rk = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server");
            //String[] instances = (String[])rk.GetValue("InstalledInstances");
            //if (instances.Length > 0)
            //{
            //    foreach (String element in instances)
            //    {
            //        //if (element == "MSSQLSERVER")cmbSVR.Items.Add(System.Environment.MachineName);
            //        //else
            //        //    cmbSVR.Items.Add(System.Environment.MachineName + @"\" + element);
            //    }
            //}

            //Thread threadGetNetworkInstances = new Thread(GetNetworkInstances);
            //threadGetNetworkInstances.Start();

            txtFolderPath.Text = Application.StartupPath + "\\DATA";

        }

        private void GetNetworkInstances()
        {
            //DataTable dt = SmoApplication.EnumAvailableSqlServers(false);

            //if (dt.Rows.Count > 0)
            //{
            //    foreach (DataRow dr in dt.Rows)
            //    {
            //        AddNetworkInstance(dr["Name"].ToString());
            //    }
            //}


            //DataTable dataTable = SmoApplication.EnumAvailableSqlServers(true);
            //cmbSVR.ValueMember = "Name";
            //cmbSVR.DataSource = dataTable;


            SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
            DataTable table = instance.GetDataSources();

            foreach (var row in table.Rows)
            {
                foreach (var column in table.Columns)
                {
                    cmbSVR.Items.Add(column);
                }
            }

        }
        delegate void SetMessageCallback(string text);

        //private void AddNetworkInstance(string text)
        //{
        //    if (this.cmbSVR.InvokeRequired)
        //    {
        //        SetMessageCallback d = new SetMessageCallback(AddNetworkInstance);
        //        this.BeginInvoke(d, new object[] { text });
        //    }
        //    else
        //    {
        //        this.cmbSVR.Items.Add(text);
        //    }
        //}
        Server srv;
        ServerConnection conn;
        private void btnConnect_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {


            FolderBrowserDialog Dialog = new FolderBrowserDialog();
            Dialog.Description = "Please Select Location to Store your New Database Files";

            if (Dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtFolderPath.Text = Dialog.SelectedPath;

                //DirectoryInfo BackUpSource = new DirectoryInfo(@"DATA\DATABASE");
                //DirectoryInfo BackUpDestination = new DirectoryInfo(Dialog.SelectedPath);
                //System.IO.Directory.CreateDirectory(BackUpDestination.ToString() + "\\Your Backup Files");
                //foreach (FileInfo File in BackUpSource.GetFiles())
                //{
                //    if ((File.Name == "SCHOOL_DATABASE.sdf"))
                //    {
                //        File.CopyTo(System.IO.Path.Combine(BackUpDestination.ToString() + "\\Your Backup Files", File.Name), true);
                //    }
                //}
                //////////Copy photos//////////////////////////////
                //System.IO.Directory.CreateDirectory(BackUpDestination.ToString() + "\\Your Backup Files\\Photos");
                //BackUpSource = new DirectoryInfo(@"DATA\DATABASE\PHOTOS");
                //foreach (FileInfo File in BackUpSource.GetFiles())
                //{
                //    File.CopyTo(System.IO.Path.Combine(BackUpDestination.ToString() + "\\Your Backup Files\\Photos", File.Name), true);
                //}
                ///////////////end copy photos/////////////////////////////////

            }
        }





        private void simpleButton2_Click(object sender, EventArgs e)
        {//"DbName.mdf", "DbName_log.LDF"
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                openFileDialog.Filter = "DataBase (*.mdf)|*.mdf";
                if (openFileDialog.ShowDialog( ) == DialogResult.OK)
                {
                    txtMDFFile.Text = openFileDialog.FileName;
                }
            }
            //"DbName.mdf", "DbName_log.LDF"

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            var path = Application.StartupPath + "\\Database.sql";
            if (File.Exists(path))
            {

                StreamReader readtext = new StreamReader(path);
                string reader = readtext.ReadToEnd();
                readtext.Close();
                reader = reader.Replace("DatabaseSkysysPath", txtFolderPath.Text);
                reader = reader.Replace("DatabaseSkysysName", textBox3.Text);

                StreamWriter writetext = new StreamWriter(path);
                writetext.Write(reader);
                writetext.Close();

                string s = String.Format("-S {0} -i {1} ", cmbSVR.Text, path); // -b option forces failed exit status on error
                ProcessStartInfo info = new ProcessStartInfo("sqlcmd", s);
                info.UseShellExecute = false;
                info.CreateNoWindow = true; info.WindowStyle = ProcessWindowStyle.Hidden;
                info.RedirectStandardOutput = true;
                Process p = new Process();
                p.StartInfo = info;
                p.Start();

                labelControl9.Visible = true;
                button2_Click(null, null);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DatabaseCombo.Items.Clear();

            string sqlSErverInstance;


            sqlSErverInstance = cmbSVR.SelectedItem.ToString();


            conn = new ServerConnection(sqlSErverInstance, txtUser.Text, txtPassword.Text);

            srv = new Server(conn);

            foreach (Database db in srv.Databases)
            {
                DatabaseCombo.Items.Add(db.Name);
            }
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            srv.AttachDatabase(textBox1.Text, new StringCollection { txtMDFFile.Text, txtLogFile.Text }, AttachOptions.None);
            labelControl10.Visible = true;
            button2_Click(null, null);
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                openFileDialog.Filter = "DataBase log File (*.LDF)|*.LDF";
                if (openFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    txtLogFile.Text = openFileDialog.FileName;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmbSVR.Items.Clear();
            DataTable dt = SqlDataSourceEnumerator.Instance.GetDataSources();
            foreach (DataRow dr in dt.Rows)
            {
                cmbSVR.Items.Add(string.Concat(dr["ServerName"], "\\", dr["InstanceName"]));
            }
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseCombo.Items.Clear();

                string sqlSErverInstance;


                sqlSErverInstance = cmbSVR.Text;


                conn = new ServerConnection(sqlSErverInstance, txtUser.Text, txtPassword.Text);

                srv = new Server(conn);

                foreach (Database db in srv.Databases)
                {
                    DatabaseCombo.Items.Add(db.Name);
                }


                //Pub.CON.ConnectionString = ("Provider=SQLOLEDB.1;Password=" + POS.Properties.Settings.Default.UserPassword + ";Persist Security Info=True;User ID=" + POS.Properties.Settings.Default.UserName + ";Initial Catalog=master ;Data Source=" + Properties.Settings.Default.ServerName);
                Settings.CON.Open();
                Settings.CMD.Connection = Settings.CON;

                btnConnection.Enabled = false;
                lblConnection.Visible = true;
                btn1.Enabled = true;
                btn2.Enabled = true;
                btn3.Enabled = true;
                button2_Click(null, null);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

    }

}
