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

namespace Entities
{

    // Summary of Sales by Quarter
    [Table("Summary of Sales by Quarter", Schema = "dbo")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.32.0.0")]
    public class ViewSummaryOfSalesByQuarter /* Column Count = 3 */
    {
        [Column(@"ShippedDate", Order = 1, TypeName = "datetime")]
        [Display(Name = "Shipped date")]
        public System.DateTime? ShippedDate { get; set; } // ShippedDate

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"OrderID", Order = 2, TypeName = "int")]
        [Required]
        [Key]
        [Display(Name = "Order ID")]
        public int OrderId { get; set; } // OrderID (Primary key)

        [Column(@"Subtotal", Order = 3, TypeName = "money")]
        [Display(Name = "Subtotal")]
        public decimal? Subtotal { get; set; } // Subtotal
    }

}
// </auto-generated>
