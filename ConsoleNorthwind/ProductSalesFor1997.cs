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

    // Product Sales for 1997
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class ProductSalesFor1997
    {
        [Column(@"CategoryName", Order = 1, TypeName = "nvarchar")]
        [Required]
        [MaxLength(15)]
        [StringLength(15)]
        [Key]
        [Display(Name = "Category name")]
        public string CategoryName { get; set; } // CategoryName (Primary key) (length: 15)

        [Column(@"ProductName", Order = 2, TypeName = "nvarchar")]
        [Required]
        [MaxLength(40)]
        [StringLength(40)]
        [Key]
        [Display(Name = "Product name")]
        public string ProductName { get; set; } // ProductName (Primary key) (length: 40)

        [Display(Name = "Product sales")]
        public decimal? ProductSales { get; set; } // ProductSales
    }

}
// </auto-generated>
