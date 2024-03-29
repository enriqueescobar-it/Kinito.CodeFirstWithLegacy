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


namespace ConfigurationContext
{
    using Entities;
    using Interfaces;

    using System.Linq;

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.32.0.0")]
    public class NorthwindDbContext : System.Data.Entity.DbContext, INorthwindDbContext
    {
        public System.Data.Entity.DbSet<Category> Categories { get; set; } // Categories
        public System.Data.Entity.DbSet<Customer> Customers { get; set; } // Customers
        public System.Data.Entity.DbSet<CustomerDemographic> CustomerDemographics { get; set; } // CustomerDemographics
        public System.Data.Entity.DbSet<Employee> Employees { get; set; } // Employees
        public System.Data.Entity.DbSet<Engineer> Engineers { get; set; } // engineer
        public System.Data.Entity.DbSet<EngineerOrder> EngineerOrders { get; set; } // engineer_order
        public System.Data.Entity.DbSet<EngineerOrderItem> EngineerOrderItems { get; set; } // engineer_order_item
        public System.Data.Entity.DbSet<GeographyType> GeographyTypes { get; set; } // GeographyTypes
        public System.Data.Entity.DbSet<Order> Orders { get; set; } // Orders
        public System.Data.Entity.DbSet<OrderDetail> OrderDetails { get; set; } // Order Details
        public System.Data.Entity.DbSet<Product> Products { get; set; } // Products
        public System.Data.Entity.DbSet<Region> Regions { get; set; } // Region
        public System.Data.Entity.DbSet<Shipper> Shippers { get; set; } // Shippers
        public System.Data.Entity.DbSet<Supplier> Suppliers { get; set; } // Suppliers
        public System.Data.Entity.DbSet<Territory> Territories { get; set; } // Territories
        public System.Data.Entity.DbSet<ViewAlphabeticalListOfProduct> ViewAlphabeticalListOfProducts { get; set; } // Alphabetical list of products
        public System.Data.Entity.DbSet<ViewCategorySalesFor1997> ViewCategorySalesFor1997 { get; set; } // Category Sales for 1997
        public System.Data.Entity.DbSet<ViewCurrentProductList> ViewCurrentProductLists { get; set; } // Current Product List
        public System.Data.Entity.DbSet<ViewCustomerAndSuppliersByCity> ViewCustomerAndSuppliersByCities { get; set; } // Customer and Suppliers by City
        public System.Data.Entity.DbSet<ViewInvoice> ViewInvoices { get; set; } // Invoices
        public System.Data.Entity.DbSet<ViewOrderDetailsExtended> ViewOrderDetailsExtendeds { get; set; } // Order Details Extended
        public System.Data.Entity.DbSet<ViewOrdersQry> ViewOrdersQries { get; set; } // Orders Qry
        public System.Data.Entity.DbSet<ViewOrderSubtotal> ViewOrderSubtotals { get; set; } // Order Subtotals
        public System.Data.Entity.DbSet<ViewProductsAboveAveragePrice> ViewProductsAboveAveragePrices { get; set; } // Products Above Average Price
        public System.Data.Entity.DbSet<ViewProductSalesFor1997> ViewProductSalesFor1997 { get; set; } // Product Sales for 1997
        public System.Data.Entity.DbSet<ViewProductsByCategory> ViewProductsByCategories { get; set; } // Products by Category
        public System.Data.Entity.DbSet<ViewSalesByCategory> ViewSalesByCategories { get; set; } // Sales by Category
        public System.Data.Entity.DbSet<ViewSalesTotalsByAmount> ViewSalesTotalsByAmounts { get; set; } // Sales Totals by Amount
        public System.Data.Entity.DbSet<ViewSummaryOfSalesByQuarter> ViewSummaryOfSalesByQuarters { get; set; } // Summary of Sales by Quarter
        public System.Data.Entity.DbSet<ViewSummaryOfSalesByYear> ViewSummaryOfSalesByYears { get; set; } // Summary of Sales by Year

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

            modelBuilder.Conventions.Add(new CodeFirstStoreFunctions.FunctionsConvention<NorthwindDbContext>("dbo"));
            modelBuilder.ComplexType<ProcedureCsvToIntReturnModel>();

            modelBuilder.Configurations.Add(new CategoryConfiguration());
            modelBuilder.Configurations.Add(new CustomerConfiguration());
            modelBuilder.Configurations.Add(new CustomerDemographicConfiguration());
            modelBuilder.Configurations.Add(new EmployeeConfiguration());
            modelBuilder.Configurations.Add(new EngineerConfiguration());
            modelBuilder.Configurations.Add(new EngineerOrderConfiguration());
            modelBuilder.Configurations.Add(new EngineerOrderItemConfiguration());
            modelBuilder.Configurations.Add(new GeographyTypeConfiguration());
            modelBuilder.Configurations.Add(new OrderConfiguration());
            modelBuilder.Configurations.Add(new OrderDetailConfiguration());
            modelBuilder.Configurations.Add(new ProductConfiguration());
            modelBuilder.Configurations.Add(new RegionConfiguration());
            modelBuilder.Configurations.Add(new ShipperConfiguration());
            modelBuilder.Configurations.Add(new SupplierConfiguration());
            modelBuilder.Configurations.Add(new TerritoryConfiguration());
            modelBuilder.Configurations.Add(new ViewAlphabeticalListOfProductConfiguration());
            modelBuilder.Configurations.Add(new ViewCategorySalesFor1997Configuration());
            modelBuilder.Configurations.Add(new ViewCurrentProductListConfiguration());
            modelBuilder.Configurations.Add(new ViewCustomerAndSuppliersByCityConfiguration());
            modelBuilder.Configurations.Add(new ViewInvoiceConfiguration());
            modelBuilder.Configurations.Add(new ViewOrderDetailsExtendedConfiguration());
            modelBuilder.Configurations.Add(new ViewOrdersQryConfiguration());
            modelBuilder.Configurations.Add(new ViewOrderSubtotalConfiguration());
            modelBuilder.Configurations.Add(new ViewProductsAboveAveragePriceConfiguration());
            modelBuilder.Configurations.Add(new ViewProductSalesFor1997Configuration());
            modelBuilder.Configurations.Add(new ViewProductsByCategoryConfiguration());
            modelBuilder.Configurations.Add(new ViewSalesByCategoryConfiguration());
            modelBuilder.Configurations.Add(new ViewSalesTotalsByAmountConfiguration());
            modelBuilder.Configurations.Add(new ViewSummaryOfSalesByQuarterConfiguration());
            modelBuilder.Configurations.Add(new ViewSummaryOfSalesByYearConfiguration());
        }

        public static System.Data.Entity.DbModelBuilder CreateModel(System.Data.Entity.DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new CategoryConfiguration(schema));
            modelBuilder.Configurations.Add(new CustomerConfiguration(schema));
            modelBuilder.Configurations.Add(new CustomerDemographicConfiguration(schema));
            modelBuilder.Configurations.Add(new EmployeeConfiguration(schema));
            modelBuilder.Configurations.Add(new EngineerConfiguration(schema));
            modelBuilder.Configurations.Add(new EngineerOrderConfiguration(schema));
            modelBuilder.Configurations.Add(new EngineerOrderItemConfiguration(schema));
            modelBuilder.Configurations.Add(new GeographyTypeConfiguration(schema));
            modelBuilder.Configurations.Add(new OrderConfiguration(schema));
            modelBuilder.Configurations.Add(new OrderDetailConfiguration(schema));
            modelBuilder.Configurations.Add(new ProductConfiguration(schema));
            modelBuilder.Configurations.Add(new RegionConfiguration(schema));
            modelBuilder.Configurations.Add(new ShipperConfiguration(schema));
            modelBuilder.Configurations.Add(new SupplierConfiguration(schema));
            modelBuilder.Configurations.Add(new TerritoryConfiguration(schema));
            modelBuilder.Configurations.Add(new ViewAlphabeticalListOfProductConfiguration(schema));
            modelBuilder.Configurations.Add(new ViewCategorySalesFor1997Configuration(schema));
            modelBuilder.Configurations.Add(new ViewCurrentProductListConfiguration(schema));
            modelBuilder.Configurations.Add(new ViewCustomerAndSuppliersByCityConfiguration(schema));
            modelBuilder.Configurations.Add(new ViewInvoiceConfiguration(schema));
            modelBuilder.Configurations.Add(new ViewOrderDetailsExtendedConfiguration(schema));
            modelBuilder.Configurations.Add(new ViewOrdersQryConfiguration(schema));
            modelBuilder.Configurations.Add(new ViewOrderSubtotalConfiguration(schema));
            modelBuilder.Configurations.Add(new ViewProductsAboveAveragePriceConfiguration(schema));
            modelBuilder.Configurations.Add(new ViewProductSalesFor1997Configuration(schema));
            modelBuilder.Configurations.Add(new ViewProductsByCategoryConfiguration(schema));
            modelBuilder.Configurations.Add(new ViewSalesByCategoryConfiguration(schema));
            modelBuilder.Configurations.Add(new ViewSalesTotalsByAmountConfiguration(schema));
            modelBuilder.Configurations.Add(new ViewSummaryOfSalesByQuarterConfiguration(schema));
            modelBuilder.Configurations.Add(new ViewSummaryOfSalesByYearConfiguration(schema));
            return modelBuilder;
        }

        // Stored Procedures
        public System.Collections.Generic.List<ProcedureCustomerOrderHistoryReturnModel> ProcedureCustomerOrderHistory(string customerId)
        {
            int procResult;
            return ProcedureCustomerOrderHistory(customerId, out procResult);
        }

        public System.Collections.Generic.List<ProcedureCustomerOrderHistoryReturnModel> ProcedureCustomerOrderHistory(string customerId, out int procResult)
        {
            var customerIdParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@CustomerID", SqlDbType = System.Data.SqlDbType.NChar, Direction = System.Data.ParameterDirection.Input, Value = customerId, Size = 5 };
            if (customerIdParam.Value == null)
                customerIdParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };
            var procResultData = Database.SqlQuery<ProcedureCustomerOrderHistoryReturnModel>("EXEC @procResult = [dbo].[CustOrderHist] @CustomerID", customerIdParam, procResultParam).ToList();

            procResult = (int) procResultParam.Value;
            return procResultData;
        }

        public async System.Threading.Tasks.Task<System.Collections.Generic.List<ProcedureCustomerOrderHistoryReturnModel>> ProcedureCustomerOrderHistoryAsync(string customerId)
        {
            var customerIdParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@CustomerID", SqlDbType = System.Data.SqlDbType.NChar, Direction = System.Data.ParameterDirection.Input, Value = customerId, Size = 5 };
            if (customerIdParam.Value == null)
                customerIdParam.Value = System.DBNull.Value;

            var procResultData = await Database.SqlQuery<ProcedureCustomerOrderHistoryReturnModel>("EXEC [dbo].[CustOrderHist] @CustomerID", customerIdParam).ToListAsync();

            return procResultData;
        }

        public System.Collections.Generic.List<ProcedureCustomerOrderDetailReturnModel> ProcedureCustomerOrderDetail(int? orderId)
        {
            int procResult;
            return ProcedureCustomerOrderDetail(orderId, out procResult);
        }

        public System.Collections.Generic.List<ProcedureCustomerOrderDetailReturnModel> ProcedureCustomerOrderDetail(int? orderId, out int procResult)
        {
            var orderIdParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@OrderID", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = orderId.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!orderId.HasValue)
                orderIdParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };
            var procResultData = Database.SqlQuery<ProcedureCustomerOrderDetailReturnModel>("EXEC @procResult = [dbo].[CustOrdersDetail] @OrderID", orderIdParam, procResultParam).ToList();

            procResult = (int) procResultParam.Value;
            return procResultData;
        }

        public async System.Threading.Tasks.Task<System.Collections.Generic.List<ProcedureCustomerOrderDetailReturnModel>> ProcedureCustomerOrderDetailAsync(int? orderId)
        {
            var orderIdParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@OrderID", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = orderId.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!orderId.HasValue)
                orderIdParam.Value = System.DBNull.Value;

            var procResultData = await Database.SqlQuery<ProcedureCustomerOrderDetailReturnModel>("EXEC [dbo].[CustOrdersDetail] @OrderID", orderIdParam).ToListAsync();

            return procResultData;
        }

        public System.Collections.Generic.List<ProcedureCustomerOrderReturnModel> ProcedureCustomerOrder(string customerId)
        {
            int procResult;
            return ProcedureCustomerOrder(customerId, out procResult);
        }

        public System.Collections.Generic.List<ProcedureCustomerOrderReturnModel> ProcedureCustomerOrder(string customerId, out int procResult)
        {
            var customerIdParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@CustomerID", SqlDbType = System.Data.SqlDbType.NChar, Direction = System.Data.ParameterDirection.Input, Value = customerId, Size = 5 };
            if (customerIdParam.Value == null)
                customerIdParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };
            var procResultData = Database.SqlQuery<ProcedureCustomerOrderReturnModel>("EXEC @procResult = [dbo].[CustOrdersOrders] @CustomerID", customerIdParam, procResultParam).ToList();

            procResult = (int) procResultParam.Value;
            return procResultData;
        }

        public async System.Threading.Tasks.Task<System.Collections.Generic.List<ProcedureCustomerOrderReturnModel>> ProcedureCustomerOrderAsync(string customerId)
        {
            var customerIdParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@CustomerID", SqlDbType = System.Data.SqlDbType.NChar, Direction = System.Data.ParameterDirection.Input, Value = customerId, Size = 5 };
            if (customerIdParam.Value == null)
                customerIdParam.Value = System.DBNull.Value;

            var procResultData = await Database.SqlQuery<ProcedureCustomerOrderReturnModel>("EXEC [dbo].[CustOrdersOrders] @CustomerID", customerIdParam).ToListAsync();

            return procResultData;
        }

        public System.Collections.Generic.List<ProcedureEmployeeSalesByCountryReturnModel> ProcedureEmployeeSalesByCountry(System.DateTime? beginningDate, System.DateTime? endingDate)
        {
            int procResult;
            return ProcedureEmployeeSalesByCountry(beginningDate, endingDate, out procResult);
        }

        public System.Collections.Generic.List<ProcedureEmployeeSalesByCountryReturnModel> ProcedureEmployeeSalesByCountry(System.DateTime? beginningDate, System.DateTime? endingDate, out int procResult)
        {
            var beginningDateParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@Beginning_Date", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = beginningDate.GetValueOrDefault() };
            if (!beginningDate.HasValue)
                beginningDateParam.Value = System.DBNull.Value;

            var endingDateParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@Ending_Date", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = endingDate.GetValueOrDefault() };
            if (!endingDate.HasValue)
                endingDateParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };
            var procResultData = Database.SqlQuery<ProcedureEmployeeSalesByCountryReturnModel>("EXEC @procResult = [dbo].[Employee Sales by Country] @Beginning_Date, @Ending_Date", beginningDateParam, endingDateParam, procResultParam).ToList();

            procResult = (int) procResultParam.Value;
            return procResultData;
        }

        public async System.Threading.Tasks.Task<System.Collections.Generic.List<ProcedureEmployeeSalesByCountryReturnModel>> ProcedureEmployeeSalesByCountryAsync(System.DateTime? beginningDate, System.DateTime? endingDate)
        {
            var beginningDateParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@Beginning_Date", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = beginningDate.GetValueOrDefault() };
            if (!beginningDate.HasValue)
                beginningDateParam.Value = System.DBNull.Value;

            var endingDateParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@Ending_Date", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = endingDate.GetValueOrDefault() };
            if (!endingDate.HasValue)
                endingDateParam.Value = System.DBNull.Value;

            var procResultData = await Database.SqlQuery<ProcedureEmployeeSalesByCountryReturnModel>("EXEC [dbo].[Employee Sales by Country] @Beginning_Date, @Ending_Date", beginningDateParam, endingDateParam).ToListAsync();

            return procResultData;
        }

        public System.Collections.Generic.List<ProcedureSalesByYearReturnModel> ProcedureSalesByYear(System.DateTime? beginningDate, System.DateTime? endingDate)
        {
            int procResult;
            return ProcedureSalesByYear(beginningDate, endingDate, out procResult);
        }

        public System.Collections.Generic.List<ProcedureSalesByYearReturnModel> ProcedureSalesByYear(System.DateTime? beginningDate, System.DateTime? endingDate, out int procResult)
        {
            var beginningDateParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@Beginning_Date", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = beginningDate.GetValueOrDefault() };
            if (!beginningDate.HasValue)
                beginningDateParam.Value = System.DBNull.Value;

            var endingDateParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@Ending_Date", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = endingDate.GetValueOrDefault() };
            if (!endingDate.HasValue)
                endingDateParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };
            var procResultData = Database.SqlQuery<ProcedureSalesByYearReturnModel>("EXEC @procResult = [dbo].[Sales by Year] @Beginning_Date, @Ending_Date", beginningDateParam, endingDateParam, procResultParam).ToList();

            procResult = (int) procResultParam.Value;
            return procResultData;
        }

        public async System.Threading.Tasks.Task<System.Collections.Generic.List<ProcedureSalesByYearReturnModel>> ProcedureSalesByYearAsync(System.DateTime? beginningDate, System.DateTime? endingDate)
        {
            var beginningDateParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@Beginning_Date", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = beginningDate.GetValueOrDefault() };
            if (!beginningDate.HasValue)
                beginningDateParam.Value = System.DBNull.Value;

            var endingDateParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@Ending_Date", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = endingDate.GetValueOrDefault() };
            if (!endingDate.HasValue)
                endingDateParam.Value = System.DBNull.Value;

            var procResultData = await Database.SqlQuery<ProcedureSalesByYearReturnModel>("EXEC [dbo].[Sales by Year] @Beginning_Date, @Ending_Date", beginningDateParam, endingDateParam).ToListAsync();

            return procResultData;
        }

        public System.Collections.Generic.List<ProcedureSalesByCategoryReturnModel> ProcedureSalesByCategory(string categoryName, string ordYear)
        {
            int procResult;
            return ProcedureSalesByCategory(categoryName, ordYear, out procResult);
        }

        public System.Collections.Generic.List<ProcedureSalesByCategoryReturnModel> ProcedureSalesByCategory(string categoryName, string ordYear, out int procResult)
        {
            var categoryNameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@CategoryName", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = categoryName, Size = 15 };
            if (categoryNameParam.Value == null)
                categoryNameParam.Value = System.DBNull.Value;

            var ordYearParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@OrdYear", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = ordYear, Size = 4 };
            if (ordYearParam.Value == null)
                ordYearParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };
            var procResultData = Database.SqlQuery<ProcedureSalesByCategoryReturnModel>("EXEC @procResult = [dbo].[SalesByCategory] @CategoryName, @OrdYear", categoryNameParam, ordYearParam, procResultParam).ToList();

            procResult = (int) procResultParam.Value;
            return procResultData;
        }

        public async System.Threading.Tasks.Task<System.Collections.Generic.List<ProcedureSalesByCategoryReturnModel>> ProcedureSalesByCategoryAsync(string categoryName, string ordYear)
        {
            var categoryNameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@CategoryName", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = categoryName, Size = 15 };
            if (categoryNameParam.Value == null)
                categoryNameParam.Value = System.DBNull.Value;

            var ordYearParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@OrdYear", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = ordYear, Size = 4 };
            if (ordYearParam.Value == null)
                ordYearParam.Value = System.DBNull.Value;

            var procResultData = await Database.SqlQuery<ProcedureSalesByCategoryReturnModel>("EXEC [dbo].[SalesByCategory] @CategoryName, @OrdYear", categoryNameParam, ordYearParam).ToListAsync();

            return procResultData;
        }

        public System.Collections.Generic.List<ProcedureTenMostExpensiveProductsReturnModel> ProcedureTenMostExpensiveProducts()
        {
            int procResult;
            return ProcedureTenMostExpensiveProducts(out procResult);
        }

        public System.Collections.Generic.List<ProcedureTenMostExpensiveProductsReturnModel> ProcedureTenMostExpensiveProducts(out int procResult)
        {
            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };
            var procResultData = Database.SqlQuery<ProcedureTenMostExpensiveProductsReturnModel>("EXEC @procResult = [dbo].[Ten Most Expensive Products] ", procResultParam).ToList();

            procResult = (int) procResultParam.Value;
            return procResultData;
        }

        public async System.Threading.Tasks.Task<System.Collections.Generic.List<ProcedureTenMostExpensiveProductsReturnModel>> ProcedureTenMostExpensiveProductsAsync()
        {
            var procResultData = await Database.SqlQuery<ProcedureTenMostExpensiveProductsReturnModel>("EXEC [dbo].[Ten Most Expensive Products] ").ToListAsync();

            return procResultData;
        }

        // Table Valued Functions
        [System.Data.Entity.DbFunction("NorthwindDbContext", "CsvToInt")]
        [CodeFirstStoreFunctions.DbFunctionDetails(DatabaseSchema = "dbo", ResultColumnName = "IntValue")]
        public IQueryable<ProcedureCsvToIntReturnModel> ProcedureCsvToInt(string array)
        {
            var arrayParam = new System.Data.Entity.Core.Objects.ObjectParameter("array", typeof(string)) { Value = array };

            return ((System.Data.Entity.Infrastructure.IObjectContextAdapter)this).ObjectContext.CreateQuery<ProcedureCsvToIntReturnModel>("[NorthwindDbContext].[CsvToInt](@array)", arrayParam);
        }

    }
}
// </auto-generated>
