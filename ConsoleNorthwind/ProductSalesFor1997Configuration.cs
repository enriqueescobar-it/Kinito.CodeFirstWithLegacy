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


namespace ConsoleNorthwind
{

    // Product Sales for 1997
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class ProductSalesFor1997Configuration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ProductSalesFor1997>
    {
        public ProductSalesFor1997Configuration()
            : this("dbo")
        {
        }

        public ProductSalesFor1997Configuration(string schema)
        {
            ToTable("Product Sales for 1997", schema);
            HasKey(x => new { x.CategoryName, x.ProductName });

            Property(x => x.CategoryName).HasColumnName(@"CategoryName").HasColumnType("nvarchar").IsRequired().HasMaxLength(15).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ProductName).HasColumnName(@"ProductName").HasColumnType("nvarchar").IsRequired().HasMaxLength(40).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ProductSales).HasColumnName(@"ProductSales").HasColumnType("money").IsOptional().HasPrecision(19,4);
        }
    }

}
// </auto-generated>
