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

    public interface INorthwindDbContext : System.IDisposable
    {
        System.Data.Entity.DbSet<AlphabeticalListOfProduct> AlphabeticalListOfProducts { get; set; } // Alphabetical list of products
        System.Data.Entity.DbSet<Category> Categories { get; set; } // Categories
        System.Data.Entity.DbSet<CategorySalesFor1997> CategorySalesFor1997 { get; set; } // Category Sales for 1997
        System.Data.Entity.DbSet<CurrentProductList> CurrentProductLists { get; set; } // Current Product List
        System.Data.Entity.DbSet<Customer> Customers { get; set; } // Customers
        System.Data.Entity.DbSet<CustomerAndSuppliersByCity> CustomerAndSuppliersByCities { get; set; } // Customer and Suppliers by City
        System.Data.Entity.DbSet<CustomerDemographic> CustomerDemographics { get; set; } // CustomerDemographics
        System.Data.Entity.DbSet<Employee> Employees { get; set; } // Employees
        System.Data.Entity.DbSet<Invoice> Invoices { get; set; } // Invoices
        System.Data.Entity.DbSet<Order> Orders { get; set; } // Orders
        System.Data.Entity.DbSet<OrderDetail> OrderDetails { get; set; } // Order Details
        System.Data.Entity.DbSet<OrderDetailsExtended> OrderDetailsExtendeds { get; set; } // Order Details Extended
        System.Data.Entity.DbSet<OrdersQry> OrdersQries { get; set; } // Orders Qry
        System.Data.Entity.DbSet<OrderSubtotal> OrderSubtotals { get; set; } // Order Subtotals
        System.Data.Entity.DbSet<Product> Products { get; set; } // Products
        System.Data.Entity.DbSet<ProductsAboveAveragePrice> ProductsAboveAveragePrices { get; set; } // Products Above Average Price
        System.Data.Entity.DbSet<ProductSalesFor1997> ProductSalesFor1997 { get; set; } // Product Sales for 1997
        System.Data.Entity.DbSet<ProductsByCategory> ProductsByCategories { get; set; } // Products by Category
        System.Data.Entity.DbSet<Region> Regions { get; set; } // Region
        System.Data.Entity.DbSet<SalesByCategory> SalesByCategories { get; set; } // Sales by Category
        System.Data.Entity.DbSet<SalesTotalsByAmount> SalesTotalsByAmounts { get; set; } // Sales Totals by Amount
        System.Data.Entity.DbSet<Shipper> Shippers { get; set; } // Shippers
        System.Data.Entity.DbSet<SummaryOfSalesByQuarter> SummaryOfSalesByQuarters { get; set; } // Summary of Sales by Quarter
        System.Data.Entity.DbSet<SummaryOfSalesByYear> SummaryOfSalesByYears { get; set; } // Summary of Sales by Year
        System.Data.Entity.DbSet<Supplier> Suppliers { get; set; } // Suppliers
        System.Data.Entity.DbSet<Territory> Territories { get; set; } // Territories

        int SaveChanges();
        System.Threading.Tasks.Task<int> SaveChangesAsync();
        System.Threading.Tasks.Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken);
        System.Data.Entity.Infrastructure.DbChangeTracker ChangeTracker { get; }
        System.Data.Entity.Infrastructure.DbContextConfiguration Configuration { get; }
        System.Data.Entity.Database Database { get; }
        System.Data.Entity.Infrastructure.DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
        System.Data.Entity.Infrastructure.DbEntityEntry Entry(object entity);
        System.Collections.Generic.IEnumerable<System.Data.Entity.Validation.DbEntityValidationResult> GetValidationErrors();
        System.Data.Entity.DbSet Set(System.Type entityType);
        System.Data.Entity.DbSet<TEntity> Set<TEntity>() where TEntity : class;
        string ToString();

        // Stored Procedures
        System.Collections.Generic.List<CustOrderHistReturnModel> CustOrderHist(string customerId);
        System.Collections.Generic.List<CustOrderHistReturnModel> CustOrderHist(string customerId, out int procResult);
        System.Threading.Tasks.Task<System.Collections.Generic.List<CustOrderHistReturnModel>> CustOrderHistAsync(string customerId);

        System.Collections.Generic.List<CustOrdersDetailReturnModel> CustOrdersDetail(int? orderId);
        System.Collections.Generic.List<CustOrdersDetailReturnModel> CustOrdersDetail(int? orderId, out int procResult);
        System.Threading.Tasks.Task<System.Collections.Generic.List<CustOrdersDetailReturnModel>> CustOrdersDetailAsync(int? orderId);

        System.Collections.Generic.List<CustOrdersOrdersReturnModel> CustOrdersOrders(string customerId);
        System.Collections.Generic.List<CustOrdersOrdersReturnModel> CustOrdersOrders(string customerId, out int procResult);
        System.Threading.Tasks.Task<System.Collections.Generic.List<CustOrdersOrdersReturnModel>> CustOrdersOrdersAsync(string customerId);

        System.Collections.Generic.List<EmployeeSalesByCountryReturnModel> EmployeeSalesByCountry(System.DateTime? beginningDate, System.DateTime? endingDate);
        System.Collections.Generic.List<EmployeeSalesByCountryReturnModel> EmployeeSalesByCountry(System.DateTime? beginningDate, System.DateTime? endingDate, out int procResult);
        System.Threading.Tasks.Task<System.Collections.Generic.List<EmployeeSalesByCountryReturnModel>> EmployeeSalesByCountryAsync(System.DateTime? beginningDate, System.DateTime? endingDate);

        System.Collections.Generic.List<SalesByYearReturnModel> SalesByYear(System.DateTime? beginningDate, System.DateTime? endingDate);
        System.Collections.Generic.List<SalesByYearReturnModel> SalesByYear(System.DateTime? beginningDate, System.DateTime? endingDate, out int procResult);
        System.Threading.Tasks.Task<System.Collections.Generic.List<SalesByYearReturnModel>> SalesByYearAsync(System.DateTime? beginningDate, System.DateTime? endingDate);

        System.Collections.Generic.List<SalesByCategoryReturnModel> SalesByCategory(string categoryName, string ordYear);
        System.Collections.Generic.List<SalesByCategoryReturnModel> SalesByCategory(string categoryName, string ordYear, out int procResult);
        System.Threading.Tasks.Task<System.Collections.Generic.List<SalesByCategoryReturnModel>> SalesByCategoryAsync(string categoryName, string ordYear);

        System.Collections.Generic.List<TenMostExpensiveProductsReturnModel> TenMostExpensiveProducts();
        System.Collections.Generic.List<TenMostExpensiveProductsReturnModel> TenMostExpensiveProducts(out int procResult);
        System.Threading.Tasks.Task<System.Collections.Generic.List<TenMostExpensiveProductsReturnModel>> TenMostExpensiveProductsAsync();


        // Table Valued Functions
    }

}
// </auto-generated>
