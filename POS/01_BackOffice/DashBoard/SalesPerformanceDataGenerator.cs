using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace POS {
    public class SalesPerformanceDataGenerator : SalesDataGenerator {
        public class TotalSalesItem {
            int uSoldYTDTarget;
            int uSoldYTD;
            decimal revQTDTarget;
            decimal revQTD;
            decimal revYTDTarget;
            decimal revYTD;
            string prod;
            string cat;
            string st;
            public string State {
                get { return st; }
                set { st = value; }
            }
            public string Category {
                get { return cat; }
                set { cat = value; }
            }
            public string Product {
                get { return prod; }
                set { prod = value; }
            }
            public decimal RevenueYTD {
                get { return revYTD; }
                set { revYTD = value; }
            }
            public decimal RevenueYTDTarget {
                get { return revYTDTarget; }
                set { revYTDTarget = value; }
            }
            public decimal RevenueQTD {
                get { return revQTD; }
                set { revQTD = value; }
            }
            public decimal RevenueQTDTarget {
                get { return revQTDTarget; }
                set { revQTDTarget = value; }
            }
            public int UnitsSoldYTD {
                get { return uSoldYTD; }
                set { uSoldYTD = value; }
            }
            public int UnitsSoldYTDTarget {
                get { return uSoldYTDTarget; }
                set { uSoldYTDTarget = value; }
            }
        }
        public class MonthlySalesItem {
            int uSoldTarget;
            int uSold;
            decimal revTarget;
            decimal rev;
            DateTime curtDate;
            string cat;
            string prod;
            string st;

            public string State {
                get { return st; }
                set { st = value; }
            }
            public string Product {
                get { return prod; }
                set { prod = value; }
            }
            public string Category {
                get { return cat; }
                set { cat = value; }
            }
            public DateTime CurrentDate {
                get { return curtDate; }
                set { curtDate = value; }
            }
            public decimal Revenue {
                get { return rev; }
                set { rev = value; }
            }
            public decimal RevenueTarget {
                get { return revTarget; }
                set { revTarget = value; }
            }
            public int UnitsSold {
                get { return uSold; }
                set { uSold = value; }
            }
            public int UnitsSoldTarget {
                get { return uSoldTarget; }
                set { uSoldTarget = value; }
            }
        }

        readonly List<MonthlySalesItem> monthlySales = new List<MonthlySalesItem>();
        readonly List<TotalSalesItem> totalSales = new List<TotalSalesItem>();
        public event EventHandler UpdateDataSource;
        string filterCore;
        public string Filter {
            get { return filterCore; }
            set {
                filterCore = value;
                if(UpdateDataSource != null)
                    UpdateDataSource(this, EventArgs.Empty);
            }
        }
        public IEnumerable<MonthlySalesItem> MonthlySales {
            get {
                var categories =
                from p in monthlySales
                where p.State == Filter
                group p by p.Product into g
                select new { Category = g.Key, Item = g, TotalRevenue = g.Sum(p => p.Revenue) };
                categories.OrderByDescending(d => d.TotalRevenue);
                List<MonthlySalesItem> result = new List<MonthlySalesItem>();
                var xc = categories.Take(5).Select((s => s.Item)).ToArray();
                foreach(var item in xc) {
                    result.AddRange(item.ToArray());
                }
                return result;
            }
        }
        public IEnumerable<TotalSalesItem> TotalSales { get { return totalSales; } }
        public IEnumerable<TotalSalesItem> FilterTotalSales { get { return totalSales.Where((d) => d.State == Filter); } }
        public IEnumerable<TotalSalesItem> TotalSalesTop5 {
            get {
                var categories =
                      from p in totalSales
                      where p.State == Filter
                      group p by p.Product into g
                      select new { Category = g.Key, Item = g, TotalRevenue = g.Sum(p => p.RevenueYTD) };
                categories.OrderByDescending(d => d.TotalRevenue);
                List<TotalSalesItem> result = new List<TotalSalesItem>();
                var groupingData = categories.Take(5).Select((s => s.Item)).ToArray();
                foreach(var item in groupingData) {
                    result.AddRange(item.ToArray());
                }
                return result;
            }
        }
        static SalesPerformanceDataGenerator currentCore;
        public static SalesPerformanceDataGenerator Current {
            get {
                if(currentCore == null) {
                    currentCore = new SalesPerformanceDataGenerator(DataLoader.LoadSales());
                    currentCore.Filter = "Montana";
                    currentCore.Generate();
                }
                return currentCore;

            }
        }

        static SalesPerformanceDataGenerator() { }
        public SalesPerformanceDataGenerator(DataSet dataSet)
            : base(dataSet) {
        }
        protected override void Generate(Context context) {
            TotalSalesItem tsItem = new TotalSalesItem { State = context.State, Category = context.CategoryName, Product = context.ProductName };
            int y = DateTime.Today.Year - 1;
            for(int month = 1; month <= 12; month++) {
                DateTime dt = new DateTime(y, month, 1);
                context.UnitsSoldGenerator.Next();
                int uSold = context.UnitsSoldGenerator.UnitsSold;
                int uSoldTarget = context.UnitsSoldGenerator.UnitsSoldTarget;
                decimal rev = uSold * context.ListPrice;
                decimal revTarget = uSoldTarget * context.ListPrice;
                monthlySales.Add(new MonthlySalesItem
                {
                    State = context.State,
                    Product = context.ProductName,
                    Category = context.CategoryName,
                    CurrentDate = dt,
                    UnitsSold = uSold,
                    UnitsSoldTarget = uSoldTarget,
                    Revenue = rev,
                    RevenueTarget = revTarget
                });
                tsItem.RevenueYTD += rev;
                tsItem.RevenueYTDTarget += revTarget;
                tsItem.UnitsSoldYTD += uSold;
                tsItem.UnitsSoldYTDTarget += uSoldTarget;
                if(month >= 10 && month <= 12) {
                    tsItem.RevenueQTD += rev;
                    tsItem.RevenueQTDTarget += revTarget;
                }
            }
            totalSales.Add(tsItem);
        }
    }
    public static class DataHelper {
        public static double Random(Random random, double deviation, bool positive) {
            int rand = random.Next(positive ? 0 : -1000000, 1000000);
            return (double)rand / 1000000 * deviation;
        }
        public static double Random(Random random, double deviation) {
            return Random(random, deviation, false);
        }
    }
    public abstract class SalesDataGenerator {
        public class Context {
            readonly string st;
            readonly string prodName;
            readonly string catName;
            readonly decimal lPrice;
            readonly UnitsSoldRandomGenerator uSoldGenerator;

            public string State { get { return st; } }
            public string ProductName { get { return prodName; } }
            public string CategoryName { get { return catName; } }
            public decimal ListPrice { get { return lPrice; } }
            public UnitsSoldRandomGenerator UnitsSoldGenerator { get { return uSoldGenerator; } }

            public Context(string st, string prodName, string catName, decimal lPrice, UnitsSoldRandomGenerator uSoldGenerator) {
                this.st = st;
                this.prodName = prodName;
                this.catName = catName;
                this.lPrice = lPrice;
                this.uSoldGenerator = uSoldGenerator;
            }
        }

        protected static string GetState(DataRow region) {
            return (string)region["Region"];
        }
        protected static string GetProductName(DataRow product) {
            return (string)product["Name"];
        }
        protected static decimal GetListPrice(DataRow product) {
            return (decimal)product["ListPrice"];
        }

        readonly DataSet ds;
        readonly DataTable categoriesTable;
        readonly DataTable productsTable;
        readonly DataTable regionsTable;
        readonly Random rand = new Random(1);
        readonly ProductClasses prodClasses;
        readonly RegionClasses regClasses;

        protected DataRowCollection Regions { get { return regionsTable.Rows; } }
        protected DataRowCollection Products { get { return productsTable.Rows; } }
        protected ProductClasses ProdClasses { get { return prodClasses; } }
        protected RegionClasses RegClasses { get { return regClasses; } }
        protected Random Random { get { return rand; } }

        protected SalesDataGenerator(DataSet ds) {
            this.ds = ds;
            categoriesTable = ds.Tables["Categories"];
            productsTable = ds.Tables["Products"];
            regionsTable = ds.Tables["Regions"];
            prodClasses = new ProductClasses(productsTable.Rows);
            regClasses = new RegionClasses(regionsTable.Rows);
        }
        protected double GetRegionWeigtht(DataRow region) {
            return regClasses[(int)region["RegionID"]];
        }
        protected ProductClass GetProductClass(DataRow product) {
            return prodClasses[(int)product["ProductID"]];
        }
        protected string GetCategoryName(DataRow product) {
            return (string)categoriesTable.Select(string.Format("CategoryID = {0}", product["CategoryID"]))[0]["CategoryName"];
        }
        protected UnitsSoldRandomGenerator CreateUnitsSoldGenerator(double regionWeight, ProductClass productClass) {
            return new UnitsSoldRandomGenerator(rand, (int)Math.Ceiling(productClass.SaleProbability * regionWeight));
        }
        protected abstract void Generate(Context context);
        protected virtual void EndGenerate() {
        }
        public void Generate() {
            foreach(DataRow region in Regions) {
                string state = GetState(region);
                double regionWeight = GetRegionWeigtht(region);
                foreach(DataRow product in Products) {
                    UnitsSoldRandomGenerator unitsSoldgenerator = CreateUnitsSoldGenerator(regionWeight, GetProductClass(product));
                    Generate(new Context(state, GetProductName(product), GetCategoryName(product), GetListPrice(product), unitsSoldgenerator));
                }
            }
            EndGenerate();
        }
    }
    public class UnitsSoldRandomGenerator {
        const int MinUnitsSold = 5;

        readonly Random rand;
        readonly int startUnitsSold;
        int? prevUnitsSold;
        int? prevPrevUnitsSold;
        int unitsSold;
        int unitsSoldTarget;
        bool isFirst = true;

        public int UnitsSold { get { return unitsSold; } }
        public int UnitsSoldTarget { get { return unitsSoldTarget; } }

        public UnitsSoldRandomGenerator(Random rand, int startUnitsSold) {
            this.rand = rand;
            this.startUnitsSold = Math.Max(startUnitsSold, MinUnitsSold);
        }
        public void Next() {
            if(isFirst) {
                unitsSold = startUnitsSold;
                isFirst = false;
            }
            else {
                unitsSold = unitsSold + (int)Math.Round(DataHelper.Random(rand, unitsSold * 0.5));
                unitsSold = Math.Max(unitsSold, MinUnitsSold);
            }
            int unitsSoldSum = unitsSold;
            int count = 1;
            if(prevUnitsSold.HasValue) {
                unitsSoldSum += prevUnitsSold.Value;
                count++;
            }
            if(prevPrevUnitsSold.HasValue) {
                unitsSoldSum += prevPrevUnitsSold.Value;
                count++;
            }
            unitsSoldTarget = (int)Math.Round((double)unitsSoldSum / count);
            unitsSoldTarget = unitsSoldTarget + (int)Math.Round(DataHelper.Random(rand, unitsSoldTarget));
            prevPrevUnitsSold = prevUnitsSold;
            prevUnitsSold = unitsSold;
        }
    }
    public class ProductClass {
        readonly List<int> productIDs = new List<int>();
        readonly decimal? minPrice;
        readonly decimal? maxPrice;
        readonly double saleProbability;

        public double SaleProbability { get { return saleProbability; } }

        public ProductClass(decimal? minPrice, decimal? maxPrice, double saleProbability) {
            this.minPrice = minPrice;
            this.maxPrice = maxPrice;
            this.saleProbability = saleProbability;
        }
        public bool AddProduct(int productID, decimal price) {
            bool satisfyMinPrice = !minPrice.HasValue || price >= minPrice.Value;
            bool satisfyMaxPrice = !maxPrice.HasValue || price < maxPrice.Value;
            if(satisfyMinPrice && satisfyMaxPrice) {
                productIDs.Add(productID);
                return true;
            }
            return false;
        }
        public bool ContainsProduct(int productID) {
            return productIDs.Contains(productID);
        }
    }
    public class ProductClasses : List<ProductClass> {
        public new ProductClass this[int productID] {
            get {
                foreach(ProductClass productClass in this)
                    if(productClass.ContainsProduct(productID))
                        return productClass;
                throw new ArgumentException("procutID");
            }
        }

        public ProductClasses(ICollection products) {
            Add(new ProductClass(null, 100m, 0.5));
            Add(new ProductClass(100m, 500m, 0.4));
            Add(new ProductClass(500m, 1500m, 0.3));
            Add(new ProductClass(1500m, null, 0.2));
            foreach(DataRow product in products) {
                int productID = (int)product["ProductID"];
                decimal listPrice = (decimal)product["ListPrice"];
                foreach(ProductClass productClass in this)
                    if(productClass.AddProduct(productID, listPrice))
                        break;
            }
        }
    }
    public class RegionClasses : Dictionary<int, double> {
        public RegionClasses(ICollection regions) {
            int? numberEmployeesMin = null;
            foreach(DataRow region in regions) {
                short numberEmployees = (short)region["NumberEmployees"];
                numberEmployeesMin = numberEmployeesMin.HasValue ? Math.Min(numberEmployeesMin.Value, numberEmployees) : numberEmployees;
            }
            foreach(DataRow region in regions)
                Add((int)region["RegionID"], (short)region["NumberEmployees"] / (double)numberEmployeesMin.Value);
        }
    }
    public static class DataLoader {
        public static string GetRelativePath(string name) {
            name = "Data\\" + name;
            string path = System.Windows.Forms.Application.StartupPath;
            string s = "\\";
            for(int i = 0; i <= 10; i++) {
                if(System.IO.File.Exists(path + s + name))
                    return (path + s + name);
                else
                    s += "..\\";
            }
            path = Environment.CurrentDirectory;
            s = "\\";
            for(int i = 0; i <= 10; i++) {
                if(System.IO.File.Exists(path + s + name))
                    return (path + s + name);
                else
                    s += "..\\";
            }
            return "";
        }
        static DataSet LoadData(string fileName) {
            string path = GetRelativePath(string.Format("{0}.xml", fileName));
            DataSet ds = new DataSet();
            ds.ReadXml(path, XmlReadMode.ReadSchema);
            return ds;
        }
        public static DataSet LoadSales() {
            return LoadData("DashboardSales");
        }
        public static DataSet LoadEmployees() {
            return LoadData("DashboardEmployeesAndDepartments");
        }
        public static DataSet LoadCustomerSupport() {
            return LoadData("DashboardCustomerSupport");
        }
    }
}
