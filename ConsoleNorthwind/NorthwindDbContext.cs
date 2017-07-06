// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.7
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleNorthwind
{

    using System.Linq;

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class NorthwindDbContext : System.Data.Entity.DbContext, INorthwindDbContext
    {
        public System.Data.Entity.DbSet<AlphabeticalListOfProduct> AlphabeticalListOfProducts { get; set; } // Alphabetical list of products
        public System.Data.Entity.DbSet<Category> Categories { get; set; } // Categories
        public System.Data.Entity.DbSet<CategorySalesFor1997> CategorySalesFor1997 { get; set; } // Category Sales for 1997
        public System.Data.Entity.DbSet<CurrentProductList> CurrentProductLists { get; set; } // Current Product List
        public System.Data.Entity.DbSet<Customer> Customers { get; set; } // Customers
        public System.Data.Entity.DbSet<CustomerAndSuppliersByCity> CustomerAndSuppliersByCities { get; set; } // Customer and Suppliers by City
        public System.Data.Entity.DbSet<CustomerDemographic> CustomerDemographics { get; set; } // CustomerDemographics
        public System.Data.Entity.DbSet<Employee> Employees { get; set; } // Employees
        public System.Data.Entity.DbSet<Invoice> Invoices { get; set; } // Invoices
        public System.Data.Entity.DbSet<Order> Orders { get; set; } // Orders
        public System.Data.Entity.DbSet<OrderDetail> OrderDetails { get; set; } // Order Details
        public System.Data.Entity.DbSet<OrderDetailsExtended> OrderDetailsExtendeds { get; set; } // Order Details Extended
        public System.Data.Entity.DbSet<OrdersQry> OrdersQries { get; set; } // Orders Qry
        public System.Data.Entity.DbSet<OrderSubtotal> OrderSubtotals { get; set; } // Order Subtotals
        public System.Data.Entity.DbSet<Product> Products { get; set; } // Products
        public System.Data.Entity.DbSet<ProductsAboveAveragePrice> ProductsAboveAveragePrices { get; set; } // Products Above Average Price
        public System.Data.Entity.DbSet<ProductSalesFor1997> ProductSalesFor1997 { get; set; } // Product Sales for 1997
        public System.Data.Entity.DbSet<ProductsByCategory> ProductsByCategories { get; set; } // Products by Category
        public System.Data.Entity.DbSet<Region> Regions { get; set; } // Region
        public System.Data.Entity.DbSet<SalesByCategory> SalesByCategories { get; set; } // Sales by Category
        public System.Data.Entity.DbSet<SalesTotalsByAmount> SalesTotalsByAmounts { get; set; } // Sales Totals by Amount
        public System.Data.Entity.DbSet<Shipper> Shippers { get; set; } // Shippers
        public System.Data.Entity.DbSet<SummaryOfSalesByQuarter> SummaryOfSalesByQuarters { get; set; } // Summary of Sales by Quarter
        public System.Data.Entity.DbSet<SummaryOfSalesByYear> SummaryOfSalesByYears { get; set; } // Summary of Sales by Year
        public System.Data.Entity.DbSet<Supplier> Suppliers { get; set; } // Suppliers
        public System.Data.Entity.DbSet<Territory> Territories { get; set; } // Territories

        static NorthwindDbContext()
        {
            System.Data.Entity.Database.SetInitializer<NorthwindDbContext>(null);
        }

        public NorthwindDbContext()
            : base("Name=NorthwindDbContext")
        {
        }

        public NorthwindDbContext(string connectionString)
            : base(connectionString)
        {
        }

        public NorthwindDbContext(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model)
            : base(connectionString, model)
        {
        }

        public NorthwindDbContext(System.Data.Common.DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {
        }

        public NorthwindDbContext(System.Data.Common.DbConnection existingConnection, System.Data.Entity.Infrastructure.DbCompiledModel model, bool contextOwnsConnection)
            : base(existingConnection, model, contextOwnsConnection)
        {
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public bool IsSqlParameterNull(System.Data.SqlClient.SqlParameter param)
        {
            var sqlValue = param.SqlValue;
            var nullableValue = sqlValue as System.Data.SqlTypes.INullable;
            if (nullableValue != null)
                return nullableValue.IsNull;
            return (sqlValue == null || sqlValue == System.DBNull.Value);
        }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new AlphabeticalListOfProductConfiguration());
            modelBuilder.Configurations.Add(new CategoryConfiguration());
            modelBuilder.Configurations.Add(new CategorySalesFor1997Configuration());
            modelBuilder.Configurations.Add(new CurrentProductListConfiguration());
            modelBuilder.Configurations.Add(new CustomerConfiguration());
            modelBuilder.Configurations.Add(new CustomerAndSuppliersByCityConfiguration());
            modelBuilder.Configurations.Add(new CustomerDemographicConfiguration());
            modelBuilder.Configurations.Add(new EmployeeConfiguration());
            modelBuilder.Configurations.Add(new InvoiceConfiguration());
            modelBuilder.Configurations.Add(new OrderConfiguration());
            modelBuilder.Configurations.Add(new OrderDetailConfiguration());
            modelBuilder.Configurations.Add(new OrderDetailsExtendedConfiguration());
            modelBuilder.Configurations.Add(new OrdersQryConfiguration());
            modelBuilder.Configurations.Add(new OrderSubtotalConfiguration());
            modelBuilder.Configurations.Add(new ProductConfiguration());
            modelBuilder.Configurations.Add(new ProductsAboveAveragePriceConfiguration());
            modelBuilder.Configurations.Add(new ProductSalesFor1997Configuration());
            modelBuilder.Configurations.Add(new ProductsByCategoryConfiguration());
            modelBuilder.Configurations.Add(new RegionConfiguration());
            modelBuilder.Configurations.Add(new SalesByCategoryConfiguration());
            modelBuilder.Configurations.Add(new SalesTotalsByAmountConfiguration());
            modelBuilder.Configurations.Add(new ShipperConfiguration());
            modelBuilder.Configurations.Add(new SummaryOfSalesByQuarterConfiguration());
            modelBuilder.Configurations.Add(new SummaryOfSalesByYearConfiguration());
            modelBuilder.Configurations.Add(new SupplierConfiguration());
            modelBuilder.Configurations.Add(new TerritoryConfiguration());
        }

        public static System.Data.Entity.DbModelBuilder CreateModel(System.Data.Entity.DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new AlphabeticalListOfProductConfiguration(schema));
            modelBuilder.Configurations.Add(new CategoryConfiguration(schema));
            modelBuilder.Configurations.Add(new CategorySalesFor1997Configuration(schema));
            modelBuilder.Configurations.Add(new CurrentProductListConfiguration(schema));
            modelBuilder.Configurations.Add(new CustomerConfiguration(schema));
            modelBuilder.Configurations.Add(new CustomerAndSuppliersByCityConfiguration(schema));
            modelBuilder.Configurations.Add(new CustomerDemographicConfiguration(schema));
            modelBuilder.Configurations.Add(new EmployeeConfiguration(schema));
            modelBuilder.Configurations.Add(new InvoiceConfiguration(schema));
            modelBuilder.Configurations.Add(new OrderConfiguration(schema));
            modelBuilder.Configurations.Add(new OrderDetailConfiguration(schema));
            modelBuilder.Configurations.Add(new OrderDetailsExtendedConfiguration(schema));
            modelBuilder.Configurations.Add(new OrdersQryConfiguration(schema));
            modelBuilder.Configurations.Add(new OrderSubtotalConfiguration(schema));
            modelBuilder.Configurations.Add(new ProductConfiguration(schema));
            modelBuilder.Configurations.Add(new ProductsAboveAveragePriceConfiguration(schema));
            modelBuilder.Configurations.Add(new ProductSalesFor1997Configuration(schema));
            modelBuilder.Configurations.Add(new ProductsByCategoryConfiguration(schema));
            modelBuilder.Configurations.Add(new RegionConfiguration(schema));
            modelBuilder.Configurations.Add(new SalesByCategoryConfiguration(schema));
            modelBuilder.Configurations.Add(new SalesTotalsByAmountConfiguration(schema));
            modelBuilder.Configurations.Add(new ShipperConfiguration(schema));
            modelBuilder.Configurations.Add(new SummaryOfSalesByQuarterConfiguration(schema));
            modelBuilder.Configurations.Add(new SummaryOfSalesByYearConfiguration(schema));
            modelBuilder.Configurations.Add(new SupplierConfiguration(schema));
            modelBuilder.Configurations.Add(new TerritoryConfiguration(schema));
            return modelBuilder;
        }

        // Stored Procedures
        public System.Collections.Generic.List<CustOrderHistReturnModel> CustOrderHist(string customerId)
        {
            int procResult;
            return CustOrderHist(customerId, out procResult);
        }

        public System.Collections.Generic.List<CustOrderHistReturnModel> CustOrderHist(string customerId, out int procResult)
        {
            var customerIdParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@CustomerID", SqlDbType = System.Data.SqlDbType.NChar, Direction = System.Data.ParameterDirection.Input, Value = customerId, Size = 5 };
            if (customerIdParam.Value == null)
                customerIdParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };
            var procResultData = Database.SqlQuery<CustOrderHistReturnModel>("EXEC @procResult = [dbo].[CustOrderHist] @CustomerID", customerIdParam, procResultParam).ToList();

            procResult = (int) procResultParam.Value;
            return procResultData;
        }

        public async System.Threading.Tasks.Task<System.Collections.Generic.List<CustOrderHistReturnModel>> CustOrderHistAsync(string customerId)
        {
            var customerIdParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@CustomerID", SqlDbType = System.Data.SqlDbType.NChar, Direction = System.Data.ParameterDirection.Input, Value = customerId, Size = 5 };
            if (customerIdParam.Value == null)
                customerIdParam.Value = System.DBNull.Value;

            var procResultData = await Database.SqlQuery<CustOrderHistReturnModel>("EXEC [dbo].[CustOrderHist] @CustomerID", customerIdParam).ToListAsync();

            return procResultData;
        }

        public System.Collections.Generic.List<CustOrdersDetailReturnModel> CustOrdersDetail(int? orderId)
        {
            int procResult;
            return CustOrdersDetail(orderId, out procResult);
        }

        public System.Collections.Generic.List<CustOrdersDetailReturnModel> CustOrdersDetail(int? orderId, out int procResult)
        {
            var orderIdParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@OrderID", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = orderId.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!orderId.HasValue)
                orderIdParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };
            var procResultData = Database.SqlQuery<CustOrdersDetailReturnModel>("EXEC @procResult = [dbo].[CustOrdersDetail] @OrderID", orderIdParam, procResultParam).ToList();

            procResult = (int) procResultParam.Value;
            return procResultData;
        }

        public async System.Threading.Tasks.Task<System.Collections.Generic.List<CustOrdersDetailReturnModel>> CustOrdersDetailAsync(int? orderId)
        {
            var orderIdParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@OrderID", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = orderId.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!orderId.HasValue)
                orderIdParam.Value = System.DBNull.Value;

            var procResultData = await Database.SqlQuery<CustOrdersDetailReturnModel>("EXEC [dbo].[CustOrdersDetail] @OrderID", orderIdParam).ToListAsync();

            return procResultData;
        }

        public System.Collections.Generic.List<CustOrdersOrdersReturnModel> CustOrdersOrders(string customerId)
        {
            int procResult;
            return CustOrdersOrders(customerId, out procResult);
        }

        public System.Collections.Generic.List<CustOrdersOrdersReturnModel> CustOrdersOrders(string customerId, out int procResult)
        {
            var customerIdParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@CustomerID", SqlDbType = System.Data.SqlDbType.NChar, Direction = System.Data.ParameterDirection.Input, Value = customerId, Size = 5 };
            if (customerIdParam.Value == null)
                customerIdParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };
            var procResultData = Database.SqlQuery<CustOrdersOrdersReturnModel>("EXEC @procResult = [dbo].[CustOrdersOrders] @CustomerID", customerIdParam, procResultParam).ToList();

            procResult = (int) procResultParam.Value;
            return procResultData;
        }

        public async System.Threading.Tasks.Task<System.Collections.Generic.List<CustOrdersOrdersReturnModel>> CustOrdersOrdersAsync(string customerId)
        {
            var customerIdParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@CustomerID", SqlDbType = System.Data.SqlDbType.NChar, Direction = System.Data.ParameterDirection.Input, Value = customerId, Size = 5 };
            if (customerIdParam.Value == null)
                customerIdParam.Value = System.DBNull.Value;

            var procResultData = await Database.SqlQuery<CustOrdersOrdersReturnModel>("EXEC [dbo].[CustOrdersOrders] @CustomerID", customerIdParam).ToListAsync();

            return procResultData;
        }

        public System.Collections.Generic.List<EmployeeSalesByCountryReturnModel> EmployeeSalesByCountry(System.DateTime? beginningDate, System.DateTime? endingDate)
        {
            int procResult;
            return EmployeeSalesByCountry(beginningDate, endingDate, out procResult);
        }

        public System.Collections.Generic.List<EmployeeSalesByCountryReturnModel> EmployeeSalesByCountry(System.DateTime? beginningDate, System.DateTime? endingDate, out int procResult)
        {
            var beginningDateParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@Beginning_Date", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = beginningDate.GetValueOrDefault() };
            if (!beginningDate.HasValue)
                beginningDateParam.Value = System.DBNull.Value;

            var endingDateParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@Ending_Date", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = endingDate.GetValueOrDefault() };
            if (!endingDate.HasValue)
                endingDateParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };
            var procResultData = Database.SqlQuery<EmployeeSalesByCountryReturnModel>("EXEC @procResult = [dbo].[Employee Sales by Country] @Beginning_Date, @Ending_Date", beginningDateParam, endingDateParam, procResultParam).ToList();

            procResult = (int) procResultParam.Value;
            return procResultData;
        }

        public async System.Threading.Tasks.Task<System.Collections.Generic.List<EmployeeSalesByCountryReturnModel>> EmployeeSalesByCountryAsync(System.DateTime? beginningDate, System.DateTime? endingDate)
        {
            var beginningDateParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@Beginning_Date", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = beginningDate.GetValueOrDefault() };
            if (!beginningDate.HasValue)
                beginningDateParam.Value = System.DBNull.Value;

            var endingDateParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@Ending_Date", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = endingDate.GetValueOrDefault() };
            if (!endingDate.HasValue)
                endingDateParam.Value = System.DBNull.Value;

            var procResultData = await Database.SqlQuery<EmployeeSalesByCountryReturnModel>("EXEC [dbo].[Employee Sales by Country] @Beginning_Date, @Ending_Date", beginningDateParam, endingDateParam).ToListAsync();

            return procResultData;
        }

        public System.Collections.Generic.List<SalesByYearReturnModel> SalesByYear(System.DateTime? beginningDate, System.DateTime? endingDate)
        {
            int procResult;
            return SalesByYear(beginningDate, endingDate, out procResult);
        }

        public System.Collections.Generic.List<SalesByYearReturnModel> SalesByYear(System.DateTime? beginningDate, System.DateTime? endingDate, out int procResult)
        {
            var beginningDateParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@Beginning_Date", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = beginningDate.GetValueOrDefault() };
            if (!beginningDate.HasValue)
                beginningDateParam.Value = System.DBNull.Value;

            var endingDateParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@Ending_Date", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = endingDate.GetValueOrDefault() };
            if (!endingDate.HasValue)
                endingDateParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };
            var procResultData = Database.SqlQuery<SalesByYearReturnModel>("EXEC @procResult = [dbo].[Sales by Year] @Beginning_Date, @Ending_Date", beginningDateParam, endingDateParam, procResultParam).ToList();

            procResult = (int) procResultParam.Value;
            return procResultData;
        }

        public async System.Threading.Tasks.Task<System.Collections.Generic.List<SalesByYearReturnModel>> SalesByYearAsync(System.DateTime? beginningDate, System.DateTime? endingDate)
        {
            var beginningDateParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@Beginning_Date", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = beginningDate.GetValueOrDefault() };
            if (!beginningDate.HasValue)
                beginningDateParam.Value = System.DBNull.Value;

            var endingDateParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@Ending_Date", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = endingDate.GetValueOrDefault() };
            if (!endingDate.HasValue)
                endingDateParam.Value = System.DBNull.Value;

            var procResultData = await Database.SqlQuery<SalesByYearReturnModel>("EXEC [dbo].[Sales by Year] @Beginning_Date, @Ending_Date", beginningDateParam, endingDateParam).ToListAsync();

            return procResultData;
        }

        public System.Collections.Generic.List<SalesByCategoryReturnModel> SalesByCategory(string categoryName, string ordYear)
        {
            int procResult;
            return SalesByCategory(categoryName, ordYear, out procResult);
        }

        public System.Collections.Generic.List<SalesByCategoryReturnModel> SalesByCategory(string categoryName, string ordYear, out int procResult)
        {
            var categoryNameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@CategoryName", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = categoryName, Size = 15 };
            if (categoryNameParam.Value == null)
                categoryNameParam.Value = System.DBNull.Value;

            var ordYearParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@OrdYear", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = ordYear, Size = 4 };
            if (ordYearParam.Value == null)
                ordYearParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };
            var procResultData = Database.SqlQuery<SalesByCategoryReturnModel>("EXEC @procResult = [dbo].[SalesByCategory] @CategoryName, @OrdYear", categoryNameParam, ordYearParam, procResultParam).ToList();

            procResult = (int) procResultParam.Value;
            return procResultData;
        }

        public async System.Threading.Tasks.Task<System.Collections.Generic.List<SalesByCategoryReturnModel>> SalesByCategoryAsync(string categoryName, string ordYear)
        {
            var categoryNameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@CategoryName", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = categoryName, Size = 15 };
            if (categoryNameParam.Value == null)
                categoryNameParam.Value = System.DBNull.Value;

            var ordYearParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@OrdYear", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = ordYear, Size = 4 };
            if (ordYearParam.Value == null)
                ordYearParam.Value = System.DBNull.Value;

            var procResultData = await Database.SqlQuery<SalesByCategoryReturnModel>("EXEC [dbo].[SalesByCategory] @CategoryName, @OrdYear", categoryNameParam, ordYearParam).ToListAsync();

            return procResultData;
        }

        public System.Collections.Generic.List<TenMostExpensiveProductsReturnModel> TenMostExpensiveProducts()
        {
            int procResult;
            return TenMostExpensiveProducts(out procResult);
        }

        public System.Collections.Generic.List<TenMostExpensiveProductsReturnModel> TenMostExpensiveProducts(out int procResult)
        {
            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };
            var procResultData = Database.SqlQuery<TenMostExpensiveProductsReturnModel>("EXEC @procResult = [dbo].[Ten Most Expensive Products] ", procResultParam).ToList();

            procResult = (int) procResultParam.Value;
            return procResultData;
        }

        public async System.Threading.Tasks.Task<System.Collections.Generic.List<TenMostExpensiveProductsReturnModel>> TenMostExpensiveProductsAsync()
        {
            var procResultData = await Database.SqlQuery<TenMostExpensiveProductsReturnModel>("EXEC [dbo].[Ten Most Expensive Products] ").ToListAsync();

            return procResultData;
        }

    }
}
// </auto-generated>