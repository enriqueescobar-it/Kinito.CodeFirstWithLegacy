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
    public class FakeNorthwindDbContext : INorthwindDbContext
    {
        public System.Data.Entity.DbSet<AlphabeticalListOfProduct> AlphabeticalListOfProducts { get; set; }
        public System.Data.Entity.DbSet<Category> Categories { get; set; }
        public System.Data.Entity.DbSet<CategorySalesFor1997> CategorySalesFor1997 { get; set; }
        public System.Data.Entity.DbSet<CurrentProductList> CurrentProductLists { get; set; }
        public System.Data.Entity.DbSet<Customer> Customers { get; set; }
        public System.Data.Entity.DbSet<CustomerAndSuppliersByCity> CustomerAndSuppliersByCities { get; set; }
        public System.Data.Entity.DbSet<CustomerDemographic> CustomerDemographics { get; set; }
        public System.Data.Entity.DbSet<Employee> Employees { get; set; }
        public System.Data.Entity.DbSet<Engineer> Engineers { get; set; }
        public System.Data.Entity.DbSet<EngineerOrder> EngineerOrders { get; set; }
        public System.Data.Entity.DbSet<EngineerOrderItem> EngineerOrderItems { get; set; }
        public System.Data.Entity.DbSet<Invoice> Invoices { get; set; }
        public System.Data.Entity.DbSet<Order> Orders { get; set; }
        public System.Data.Entity.DbSet<OrderDetail> OrderDetails { get; set; }
        public System.Data.Entity.DbSet<OrderDetailsExtended> OrderDetailsExtendeds { get; set; }
        public System.Data.Entity.DbSet<OrdersQry> OrdersQries { get; set; }
        public System.Data.Entity.DbSet<OrderSubtotal> OrderSubtotals { get; set; }
        public System.Data.Entity.DbSet<Product> Products { get; set; }
        public System.Data.Entity.DbSet<ProductsAboveAveragePrice> ProductsAboveAveragePrices { get; set; }
        public System.Data.Entity.DbSet<ProductSalesFor1997> ProductSalesFor1997 { get; set; }
        public System.Data.Entity.DbSet<ProductsByCategory> ProductsByCategories { get; set; }
        public System.Data.Entity.DbSet<Region> Regions { get; set; }
        public System.Data.Entity.DbSet<SalesByCategory> SalesByCategories { get; set; }
        public System.Data.Entity.DbSet<SalesTotalsByAmount> SalesTotalsByAmounts { get; set; }
        public System.Data.Entity.DbSet<Shipper> Shippers { get; set; }
        public System.Data.Entity.DbSet<SummaryOfSalesByQuarter> SummaryOfSalesByQuarters { get; set; }
        public System.Data.Entity.DbSet<SummaryOfSalesByYear> SummaryOfSalesByYears { get; set; }
        public System.Data.Entity.DbSet<Supplier> Suppliers { get; set; }
        public System.Data.Entity.DbSet<Territory> Territories { get; set; }

        public FakeNorthwindDbContext()
        {
            AlphabeticalListOfProducts = new FakeDbSet<AlphabeticalListOfProduct>("ProductId", "ProductName", "Discontinued", "CategoryName");
            Categories = new FakeDbSet<Category>("CategoryId");
            CategorySalesFor1997 = new FakeDbSet<CategorySalesFor1997>("CategoryName");
            CurrentProductLists = new FakeDbSet<CurrentProductList>("ProductId", "ProductName");
            Customers = new FakeDbSet<Customer>("CustomerId");
            CustomerAndSuppliersByCities = new FakeDbSet<CustomerAndSuppliersByCity>("CompanyName", "Relationship");
            CustomerDemographics = new FakeDbSet<CustomerDemographic>("CustomerTypeId");
            Employees = new FakeDbSet<Employee>("EmployeeId");
            Engineers = new FakeDbSet<Engineer>("EngineerId");
            EngineerOrders = new FakeDbSet<EngineerOrder>("EngineerOrderId");
            EngineerOrderItems = new FakeDbSet<EngineerOrderItem>("EngineerOrderItemId");
            Invoices = new FakeDbSet<Invoice>("CustomerName", "Salesperson", "OrderId", "ShipperName", "ProductId", "ProductName", "UnitPrice", "Quantity", "Discount");
            Orders = new FakeDbSet<Order>("OrderId");
            OrderDetails = new FakeDbSet<OrderDetail>("OrderId", "ProductId");
            OrderDetailsExtendeds = new FakeDbSet<OrderDetailsExtended>("OrderId", "ProductId", "ProductName", "UnitPrice", "Quantity", "Discount");
            OrdersQries = new FakeDbSet<OrdersQry>("OrderId", "CompanyName");
            OrderSubtotals = new FakeDbSet<OrderSubtotal>("OrderId");
            Products = new FakeDbSet<Product>("ProductId");
            ProductsAboveAveragePrices = new FakeDbSet<ProductsAboveAveragePrice>("ProductName");
            ProductSalesFor1997 = new FakeDbSet<ProductSalesFor1997>("CategoryName", "ProductName");
            ProductsByCategories = new FakeDbSet<ProductsByCategory>("CategoryName", "ProductName", "Discontinued");
            Regions = new FakeDbSet<Region>("RegionId");
            SalesByCategories = new FakeDbSet<SalesByCategory>("CategoryId", "CategoryName", "ProductName");
            SalesTotalsByAmounts = new FakeDbSet<SalesTotalsByAmount>("OrderId", "CompanyName");
            Shippers = new FakeDbSet<Shipper>("ShipperId");
            SummaryOfSalesByQuarters = new FakeDbSet<SummaryOfSalesByQuarter>("OrderId");
            SummaryOfSalesByYears = new FakeDbSet<SummaryOfSalesByYear>("OrderId");
            Suppliers = new FakeDbSet<Supplier>("SupplierId");
            Territories = new FakeDbSet<Territory>("TerritoryId");
        }

        public int SaveChangesCount { get; private set; }
        public int SaveChanges()
        {
            ++SaveChangesCount;
            return 1;
        }

        public System.Threading.Tasks.Task<int> SaveChangesAsync()
        {
            ++SaveChangesCount;
            return System.Threading.Tasks.Task<int>.Factory.StartNew(() => 1);
        }

        public System.Threading.Tasks.Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken)
        {
            ++SaveChangesCount;
            return System.Threading.Tasks.Task<int>.Factory.StartNew(() => 1, cancellationToken);
        }

        protected virtual void Dispose(bool disposing)
        {
        }

        public void Dispose()
        {
            Dispose(true);
        }

        public System.Data.Entity.Infrastructure.DbChangeTracker _changeTracker;
        public System.Data.Entity.Infrastructure.DbChangeTracker ChangeTracker { get { return _changeTracker; } }
        public System.Data.Entity.Infrastructure.DbContextConfiguration _configuration;
        public System.Data.Entity.Infrastructure.DbContextConfiguration Configuration { get { return _configuration; } }
        public System.Data.Entity.Database _database;
        public System.Data.Entity.Database Database { get { return _database; } }
        public System.Data.Entity.Infrastructure.DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class
        {
            throw new System.NotImplementedException();
        }
        public System.Data.Entity.Infrastructure.DbEntityEntry Entry(object entity)
        {
            throw new System.NotImplementedException();
        }
        public System.Collections.Generic.IEnumerable<System.Data.Entity.Validation.DbEntityValidationResult> GetValidationErrors()
        {
            throw new System.NotImplementedException();
        }
        public System.Data.Entity.DbSet Set(System.Type entityType)
        {
            throw new System.NotImplementedException();
        }
        public System.Data.Entity.DbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            throw new System.NotImplementedException();
        }
        public override string ToString()
        {
            throw new System.NotImplementedException();
        }


        // Stored Procedures
        public System.Collections.Generic.List<CustOrderHistReturnModel> CustOrderHist(string customerId)
        {
            int procResult;
            return CustOrderHist(customerId, out procResult);
        }

        public System.Collections.Generic.List<CustOrderHistReturnModel> CustOrderHist(string customerId, out int procResult)
        {

            procResult = 0;
            return new System.Collections.Generic.List<CustOrderHistReturnModel>();
        }

        public System.Threading.Tasks.Task<System.Collections.Generic.List<CustOrderHistReturnModel>> CustOrderHistAsync(string customerId)
        {
            int procResult;
            return System.Threading.Tasks.Task.FromResult(CustOrderHist(customerId, out procResult));
        }

        public System.Collections.Generic.List<CustOrdersDetailReturnModel> CustOrdersDetail(int? orderId)
        {
            int procResult;
            return CustOrdersDetail(orderId, out procResult);
        }

        public System.Collections.Generic.List<CustOrdersDetailReturnModel> CustOrdersDetail(int? orderId, out int procResult)
        {

            procResult = 0;
            return new System.Collections.Generic.List<CustOrdersDetailReturnModel>();
        }

        public System.Threading.Tasks.Task<System.Collections.Generic.List<CustOrdersDetailReturnModel>> CustOrdersDetailAsync(int? orderId)
        {
            int procResult;
            return System.Threading.Tasks.Task.FromResult(CustOrdersDetail(orderId, out procResult));
        }

        public System.Collections.Generic.List<CustOrdersOrdersReturnModel> CustOrdersOrders(string customerId)
        {
            int procResult;
            return CustOrdersOrders(customerId, out procResult);
        }

        public System.Collections.Generic.List<CustOrdersOrdersReturnModel> CustOrdersOrders(string customerId, out int procResult)
        {

            procResult = 0;
            return new System.Collections.Generic.List<CustOrdersOrdersReturnModel>();
        }

        public System.Threading.Tasks.Task<System.Collections.Generic.List<CustOrdersOrdersReturnModel>> CustOrdersOrdersAsync(string customerId)
        {
            int procResult;
            return System.Threading.Tasks.Task.FromResult(CustOrdersOrders(customerId, out procResult));
        }

        public System.Collections.Generic.List<EmployeeSalesByCountryReturnModel> EmployeeSalesByCountry(System.DateTime? beginningDate, System.DateTime? endingDate)
        {
            int procResult;
            return EmployeeSalesByCountry(beginningDate, endingDate, out procResult);
        }

        public System.Collections.Generic.List<EmployeeSalesByCountryReturnModel> EmployeeSalesByCountry(System.DateTime? beginningDate, System.DateTime? endingDate, out int procResult)
        {

            procResult = 0;
            return new System.Collections.Generic.List<EmployeeSalesByCountryReturnModel>();
        }

        public System.Threading.Tasks.Task<System.Collections.Generic.List<EmployeeSalesByCountryReturnModel>> EmployeeSalesByCountryAsync(System.DateTime? beginningDate, System.DateTime? endingDate)
        {
            int procResult;
            return System.Threading.Tasks.Task.FromResult(EmployeeSalesByCountry(beginningDate, endingDate, out procResult));
        }

        public System.Collections.Generic.List<SalesByYearReturnModel> SalesByYear(System.DateTime? beginningDate, System.DateTime? endingDate)
        {
            int procResult;
            return SalesByYear(beginningDate, endingDate, out procResult);
        }

        public System.Collections.Generic.List<SalesByYearReturnModel> SalesByYear(System.DateTime? beginningDate, System.DateTime? endingDate, out int procResult)
        {

            procResult = 0;
            return new System.Collections.Generic.List<SalesByYearReturnModel>();
        }

        public System.Threading.Tasks.Task<System.Collections.Generic.List<SalesByYearReturnModel>> SalesByYearAsync(System.DateTime? beginningDate, System.DateTime? endingDate)
        {
            int procResult;
            return System.Threading.Tasks.Task.FromResult(SalesByYear(beginningDate, endingDate, out procResult));
        }

        public System.Collections.Generic.List<SalesByCategoryReturnModel> SalesByCategory(string categoryName, string ordYear)
        {
            int procResult;
            return SalesByCategory(categoryName, ordYear, out procResult);
        }

        public System.Collections.Generic.List<SalesByCategoryReturnModel> SalesByCategory(string categoryName, string ordYear, out int procResult)
        {

            procResult = 0;
            return new System.Collections.Generic.List<SalesByCategoryReturnModel>();
        }

        public System.Threading.Tasks.Task<System.Collections.Generic.List<SalesByCategoryReturnModel>> SalesByCategoryAsync(string categoryName, string ordYear)
        {
            int procResult;
            return System.Threading.Tasks.Task.FromResult(SalesByCategory(categoryName, ordYear, out procResult));
        }

        public System.Collections.Generic.List<TenMostExpensiveProductsReturnModel> TenMostExpensiveProducts()
        {
            int procResult;
            return TenMostExpensiveProducts(out procResult);
        }

        public System.Collections.Generic.List<TenMostExpensiveProductsReturnModel> TenMostExpensiveProducts(out int procResult)
        {

            procResult = 0;
            return new System.Collections.Generic.List<TenMostExpensiveProductsReturnModel>();
        }

        public System.Threading.Tasks.Task<System.Collections.Generic.List<TenMostExpensiveProductsReturnModel>> TenMostExpensiveProductsAsync()
        {
            int procResult;
            return System.Threading.Tasks.Task.FromResult(TenMostExpensiveProducts(out procResult));
        }

        // Table Valued Functions
        [System.Data.Entity.DbFunction("NorthwindDbContext", "CsvToInt")]
        public IQueryable<CsvToIntReturnModel> CsvToInt(string array)
        {
            return new System.Collections.Generic.List<CsvToIntReturnModel>().AsQueryable();
        }

    }
}
// </auto-generated>
