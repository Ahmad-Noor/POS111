using System;
using System.Windows.Forms;

namespace POS {
    public partial class ucCategorySales : UserControl {
        public ucCategorySales() {
            InitializeComponent();
            SalesPerformanceDataGenerator.Current.UpdateDataSource += OnUpdateDataSource;
            totalSalesItemBindingSource.DataSource = SalesPerformanceDataGenerator.Current.FilterTotalSales;
        }
        protected override void Dispose(bool disposing) {
            SalesPerformanceDataGenerator.Current.UpdateDataSource -= OnUpdateDataSource;
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        void OnUpdateDataSource(object sender, EventArgs e) {
            totalSalesItemBindingSource.DataSource = SalesPerformanceDataGenerator.Current.FilterTotalSales;
        }
    }
}
