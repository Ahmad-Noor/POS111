using System;
using System.Windows.Forms;

namespace POS
{
    public partial class FrmSearch
    {
        public FrmSearch()
        {
            InitializeComponent();
        }


        public BindingSource bs = new BindingSource();

        public void dg_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //try { Pub.SearchControl.Text = (string)(dg.CurrentRow.Cells[0].Value.ToString()); }
            //catch (Exception) { }

            //this.Close();
        }

        public void dg_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Select_(e.ColumnIndex)
        }

        //Private Sub Select_(ByVal ColumnIndex As Integer)
        //    txt.Text = ""
        //    gb.Text = dg.Columns(ColumnIndex).HeaderText
        //    txt.Tag = dg.Columns(ColumnIndex).Name
        //    gb.Tag = ColumnIndex
        //    txt.Select()

        //End Sub
        string s = "";
        public void txt_TextChanged(object sender, EventArgs e)
        {

            s = "";

            for (int i = 0; i < dg.Columns.Count; i++)
            {
                if (rbStart.Checked)
                    s = s == "" ? ("[" + dg.Columns[i].Name + "] LIKE '" + txt.Text + "%' ") : (s + " OR [" + dg.Columns[i].Name + "] LIKE '" + txt.Text + "%'");
                else if (rbEnd.Checked)
                    s = s == "" ? ("[" + dg.Columns[i].Name + "] LIKE '" + txt.Text + "%' ") : (s + " OR [" + dg.Columns[i].Name + "] LIKE '%" + txt.Text + "'");
                else if (rbEquals.Checked)
                    s = s == "" ? ("[" + dg.Columns[i].Name + "]='" + txt.Text + "' ") : (s + " OR [" + dg.Columns[i].Name + "]='" + txt.Text + "' ");
                else if (rbContains.Checked)
                    s = s == "" ? ("[" + dg.Columns[i].Name + "] LIKE '%" + txt.Text + "%' ") : (s + " OR [" + dg.Columns[i].Name + "] LIKE '%" + txt.Text + "%'");

            }
           bs.Filter = s;
        }

        public void FrmSearch_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyData == Keys.Enter)
            //    dg_MouseDoubleClick(null, null);
            //else if (e.KeyData == Keys.Escape)
            //{
            //    try
            //    { this.Close(); }
            //    catch (Exception) { }
            //}
        }

        public void FrmSearch_Load(System.Object sender, System.EventArgs e)
        {
            ////SearchControl = FrmMain.ActiveMdiChild.ActiveControl    ; 
            //int x = 0;
            //dg.Columns[1].Width = 200;

            //for (int i = 0; i < dg.ColumnCount; i++)
            //    x += dg.Columns[i].Width;

            //dg.Columns[dg.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //if (x > 411)
            //{
            //    dg.Width = x + 3; 
            //    this.Width = x + 17;
              
               
            //    txt.Width = x - 25;
            //}
            //txt.Select();
            //this.StartPosition = FormStartPosition.CenterScreen;

            //this.Left = 100;

        }

        public void txt_KeyDown(System.Object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyData == Keys.Down)
            {
                dg.Focus();
                SendKeys.Send("{DOWN}");
            }
            else if (e.KeyData == Keys.Up)
            {
                dg.Focus();
                SendKeys.Send("{UP}");
            }
        }
    }

}
