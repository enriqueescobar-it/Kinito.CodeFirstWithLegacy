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

    // Alphabetical list of products
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class AlphabeticalListOfProductConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AlphabeticalListOfProduct>
    {
        public AlphabeticalListOfProductConfiguration()
            : this("dbo")
        {
        }

        public AlphabeticalListOfProductConfiguration(string schema)
        {
            ToTable("Alphabetical list of products", schema);
            Property(x => x.ProductId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ProductName).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.SupplierId).HasColumnName(@"SupplierID").HasColumnType("int").IsOptional();
            Property(x => x.CategoryId).HasColumnName(@"CategoryID").HasColumnType("int").IsOptional();
            Property(x => x.QuantityPerUnit).HasColumnName(@"QuantityPerUnit").HasColumnType("nvarchar").IsOptional();
            Property(x => x.UnitPrice).HasColumnName(@"UnitPrice").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.UnitsInStock).HasColumnName(@"UnitsInStock").HasColumnType("smallint").IsOptional();
            Property(x => x.UnitsOnOrder).HasColumnName(@"UnitsOnOrder").HasColumnType("smallint").IsOptional();
            Property(x => x.ReorderLevel).HasColumnName(@"ReorderLevel").HasColumnType("smallint").IsOptional();
            Property(x => x.Discontinued).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.CategoryName).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        }
    }

}
// </auto-generated>