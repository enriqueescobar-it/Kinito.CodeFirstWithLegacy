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

    // Products by Category
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class ProductsByCategoryConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ProductsByCategory>
    {
        public ProductsByCategoryConfiguration()
            : this("dbo")
        {
        }

        public ProductsByCategoryConfiguration(string schema)
        {
            ToTable("Products by Category", schema);
            Property(x => x.CategoryName).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ProductName).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.QuantityPerUnit).HasColumnName(@"QuantityPerUnit").HasColumnType("nvarchar").IsOptional();
            Property(x => x.UnitsInStock).HasColumnName(@"UnitsInStock").HasColumnType("smallint").IsOptional();
            Property(x => x.Discontinued).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        }
    }

}
// </auto-generated>
