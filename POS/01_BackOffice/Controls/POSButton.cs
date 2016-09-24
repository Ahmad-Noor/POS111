using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;

namespace POS
{
    public class POSButton : SimpleButton
    {
        public POSButton()
        {

        }

        public Nullable<long> ItemsID { get; set; }
        public Nullable<long> PerantID { get; set; }
        public Nullable<long> SizeID { get; set; }
        public string ItemsName { get; set; }
        public string SizeName { get; set; }
        public Nullable<double> Price { get; set; }
        public Nullable<bool> ItemService { get; set; }
        public Nullable<bool> ContainSizes { get; set; }


    }
}
