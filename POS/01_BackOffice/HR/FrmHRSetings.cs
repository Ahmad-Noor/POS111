using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace POS
{
    public partial class FrmHRSetings : SkyForm
    {
        public FrmHRSetings()
        {
            InitializeComponent();
        }

        MATRIX HRSetings = new MATRIX("HRSetings");


        private void btnSave_Click(object sender, EventArgs e)
        {

            //Properties.Settings.Default.Save();

            HRSetings.Delete();
            HRSetings.Add_New();

            HRSetings["MonthStart"] = txtMonthStart.Value.Date;
            HRSetings["MonthEnd"] = txtMonthEnd.Value.Date;
            HRSetings.Update();


        }


        private void FrmSetings_Load(object sender, EventArgs e)
        {


            HRSetings.View();
            if (HRSetings.DR.HasRows)
            {
                txtMonthStart.Value = (DateTime)HRSetings["MonthStart"];
                txtMonthEnd.Value = (DateTime)HRSetings["MonthEnd"];

            }
        }






    }
}
