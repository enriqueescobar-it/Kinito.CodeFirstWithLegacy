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

    // Invoices
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class InvoiceConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Invoice>
    {
        public InvoiceConfiguration()
            : this("dbo")
        {
        }

        public InvoiceConfiguration(string schema)
        {
            ToTable("Invoices", schema);
            Property(x => x.ShipName).HasColumnName(@"ShipName").HasColumnType("nvarchar").IsOptional();
            Property(x => x.ShipAddress).HasColumnName(@"ShipAddress").HasColumnType("nvarchar").IsOptional();
            Property(x => x.ShipCity).HasColumnName(@"ShipCity").HasColumnType("nvarchar").IsOptional();
            Property(x => x.ShipRegion).HasColumnName(@"ShipRegion").HasColumnType("nvarchar").IsOptional();
            Property(x => x.ShipPostalCode).HasColumnName(@"ShipPostalCode").HasColumnType("nvarchar").IsOptional();
            Property(x => x.ShipCountry).HasColumnName(@"ShipCountry").HasColumnType("nvarchar").IsOptional();
            Property(x => x.CustomerId).HasColumnName(@"CustomerID").HasColumnType("nchar").IsOptional().IsFixedLength();
            Property(x => x.CustomerName).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Address).HasColumnName(@"Address").HasColumnType("nvarchar").IsOptional();
            Property(x => x.City).HasColumnName(@"City").HasColumnType("nvarchar").IsOptional();
            Property(x => x.Region).HasColumnName(@"Region").HasColumnType("nvarchar").IsOptional();
            Property(x => x.PostalCode).HasColumnName(@"PostalCode").HasColumnType("nvarchar").IsOptional();
            Property(x => x.Country).HasColumnName(@"Country").HasColumnType("nvarchar").IsOptional();
            Property(x => x.Salesperson).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.OrderId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.OrderDate).HasColumnName(@"OrderDate").HasColumnType("datetime").IsOptional();
            Property(x => x.RequiredDate).HasColumnName(@"RequiredDate").HasColumnType("datetime").IsOptional();
            Property(x => x.ShippedDate).HasColumnName(@"ShippedDate").HasColumnType("datetime").IsOptional();
            Property(x => x.ShipperName).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ProductId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ProductName).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.UnitPrice).HasPrecision(19,4).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Quantity).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Discount).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ExtendedPrice).HasColumnName(@"ExtendedPrice").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.Freight).HasColumnName(@"Freight").HasColumnType("money").IsOptional().HasPrecision(19,4);
        }
    }

}
// </auto-generated>