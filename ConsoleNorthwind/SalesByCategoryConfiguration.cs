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

    // Sales by Category
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class SalesByCategoryConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SalesByCategory>
    {
        public SalesByCategoryConfiguration()
            : this("dbo")
        {
        }

        public SalesByCategoryConfiguration(string schema)
        {
            ToTable("Sales by Category", schema);
            Property(x => x.CategoryId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.CategoryName).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ProductName).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ProductSales).HasColumnName(@"ProductSales").HasColumnType("money").IsOptional().HasPrecision(19,4);
        }
    }

}
// </auto-generated>