using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
namespace POS
{
    public partial class Tree : UserControl
    {
        public Tree()
        {
            InitializeComponent();
        }

        private void LblActive_Click(object sender, EventArgs e)
        {
            CheckEdit1.Checked = Convert.ToBoolean(!CheckEdit1.Checked);
        }

        private string MasterTable_;
        public string MasterTable
        {
            get
            {
                return MasterTable_;
            }
            set
            {
                MasterTable_ = value;
            }
        }

        private string MasterWhere_;
        public string MasterWhere
        {
            get
            {
                return MasterWhere_;
            }
            set
            {
                MasterWhere_ = value;
            }
        }

        //public void Tree_Resize(object sender, System.EventArgs e)
        //{
             
        //    TreeList1.Width = base.Width;
        //    TreeList1.Height = base.Height - 18;

        //    //CheckEdit1.Location = new Point(base.Width - 32, base.Height - 19);
        //    //LblActive.Location = new Point(base.Width - 61, base.Height - 18);
        //}

        string Sql = "";
        private MATRIX Setings = new MATRIX("Setings");

        public void FillTree(string Find = "")
        {
            if (CheckEdit1.Checked == true)
            {
                TreeList1.Nodes.Clear();
                TreeList1.BeginUnboundLoad();

                Setings.View();
                if (Convert.ToBoolean(Setings.GetFiled("BasicDataNo")))
                    Sql = ("Select Code , CONVERT(INT,code)  T_Code , Name,Main , MainNo From " + MasterTable + ((MasterWhere + "".Trim() != "") ? " Where " + MasterWhere : " order by CONVERT(INT, Code) "));
                else
                    Sql = ("Select Code , Code T_Code,Name, Main,MainNo  From " + MasterTable + ((MasterWhere + "".Trim() != "") ? " Where " + MasterWhere : " order by Code"));

                DataTable DT = new DataTable();

                try
                { Settings.DR.Close(); }
                catch (Exception) { }

                TreeList1.SelectImageList = ImageList1;

                Settings.CMD.CommandText = Sql;
                try
                {
                    Settings.DR = Settings.CMD.ExecuteReader();
                    DT.Load(Settings.DR);

                    TreeList1.DataSource = DT;
                    TreeList1.KeyFieldName = "Code";
                    TreeList1.ParentFieldName = "MainNo";

                     
                   
                }
                catch (Exception)
                {
                    if (Convert.ToBoolean(Setings.GetFiled("BasicDataNo")))
                        Settings.CMD.CommandText = "Select CONVERT(INT,Code ) code,CONVERT(INT,code ) T_Code,Name From " + MasterTable + " order by CONVERT(INT,code )";
                    else
                        Settings.CMD.CommandText = "Select Code , code T_Code,Name From " + MasterTable + " order by code  ";

                  
                    Settings.DR = Settings.CMD.ExecuteReader();
                    int x = 0;
                    while (Settings.DR.Read())
                    {
                        TreeListNode P = null;
                        TreeListNode xNode = TreeList1.AppendNode(new object(), P);
                        xNode.SetValue(0, Settings.DR["Code"]);
                        xNode.SetValue(1, Settings.DR["Name"]);
                        x++;
                    }
                }
                TreeList1.EndUnboundLoad();
            }
            else
                TreeList1.Nodes.Clear();





            if (Find.Trim() != "")
            {
                TreeList1.FocusedNode = TreeList1.FindNodeByFieldValue("Code", Find);
                //var node = TreeList1.FindNodeByFieldValue("T_Code",Find );
                //  if (node != null)
                //  {
                //      node.Expanded = true;
                //      node.Visible = true;
                //      TreeList1.FocusedNode = node;
                //  }
            }


        }

        public void TreeList1_GetSelectImage(object sender, GetSelectImageEventArgs e)
        {
            try
            {
                if ((bool)(e.Node["Main"]))
                {
                    if (e.Node.Expanded == true)
                        e.NodeImageIndex = 1;
                    else
                        e.NodeImageIndex = 0;
                }
                else
                    e.NodeImageIndex = 2;
            }
            catch (Exception) { }

        }

        public void TreeList1_AfterExpand(System.Object sender, DevExpress.XtraTreeList.NodeEventArgs e)
        {
            if (e.Node.Expanded == true)
                e.Node.ImageIndex = 1;
        }

        public void TreeList1_AfterCollapse(System.Object sender, DevExpress.XtraTreeList.NodeEventArgs e)
        {
            if (e.Node.Expanded == false)
                e.Node.ImageIndex = 0;
        }

        public string CurrentNod()
        {
            try
            {
                return (TreeList1.FocusedNode.GetValue(0) + "");
            }
            catch (Exception)
            { }

            return "";
        }



        private void CheckEdit1_CheckedChanged(object sender, EventArgs e)
        {
            FillTree();
        }


        public delegate void DEventHandler(object sender, EventArgs e);
        public event DEventHandler Dclick;
        private void TreeList1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Dclick(null, null);
            }
            catch (Exception)
            { }

        }


    }
}
