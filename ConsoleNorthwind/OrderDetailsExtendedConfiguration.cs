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

    // Order Details Extended
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class OrderDetailsExtendedConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<OrderDetailsExtended>
    {
        public OrderDetailsExtendedConfiguration()
            : this("dbo")
        {
        }

        public OrderDetailsExtendedConfiguration(string schema)
        {
            ToTable("Order Details Extended", schema);
            Property(x => x.OrderId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ProductId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ProductName).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.UnitPrice).HasPrecision(19,4).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Quantity).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Discount).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ExtendedPrice).HasColumnName(@"ExtendedPrice").HasColumnType("money").IsOptional().HasPrecision(19,4);
        }
    }

}
// </auto-generated>
