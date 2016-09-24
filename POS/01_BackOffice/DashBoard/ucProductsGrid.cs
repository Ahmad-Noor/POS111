using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace POS {
    public partial class ucProductsGrid : UserControl {
        public ucProductsGrid() {
            InitializeComponent();
            SalesPerformanceDataGenerator.Current.UpdateDataSource += OnUpdateDataSource;
            totalSalesItemBindingSource.DataSource = SalesPerformanceDataGenerator.Current.FilterTotalSales;
        }
        void OnUpdateDataSource(object sender, EventArgs e) {
            totalSalesItemBindingSource.DataSource = SalesPerformanceDataGenerator.Current.FilterTotalSales;
        }
        protected override void Dispose(bool disposing) {
            SalesPerformanceDataGenerator.Current.UpdateDataSource -= OnUpdateDataSource;
            if(disposing && (components != null)) {
                components.Dispose();

            }
            base.Dispose(disposing);
        }
    }
}

