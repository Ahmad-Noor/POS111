using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace POS {
    public partial class ucChartProductItem : UserControl {
        public ucChartProductItem() {
            InitializeComponent();
            SalesPerformanceDataGenerator.Current.UpdateDataSource += OnUpdateDataSource;
            monthlySalesItemBindingSource.DataSource = SalesPerformanceDataGenerator.Current.MonthlySales;
        }
        protected override void Dispose(bool disposing) {
            SalesPerformanceDataGenerator.Current.UpdateDataSource -= OnUpdateDataSource;
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        void OnUpdateDataSource(object sender, EventArgs e) {
            monthlySalesItemBindingSource.DataSource = SalesPerformanceDataGenerator.Current.MonthlySales;
        }
    }
}
