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

    // Order Details
    [Table("Order Details", Schema = "dbo")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.32.0.0")]
    public class OrderDetail /* Column Count = 5 */
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"OrderID", Order = 1, TypeName = "int")]
        [Index(@"OrderID", 1, IsUnique = false, IsClustered = false)]
        [Index(@"OrdersOrder_Details", 1, IsUnique = false, IsClustered = false)]
        [Index(@"PK_Order_Details", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Order ID")]
        public int OrderId { get; set; } // OrderID (Primary key)

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"ProductID", Order = 2, TypeName = "int")]
        [Index(@"ProductID", 1, IsUnique = false, IsClustered = false)]
        [Index(@"ProductsOrder_Details", 1, IsUnique = false, IsClustered = false)]
        [Index(@"PK_Order_Details", 2, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Product ID")]
        public int ProductId { get; set; } // ProductID (Primary key)

        [Column(@"UnitPrice", Order = 3, TypeName = "money")]
        [Required]
        [Display(Name = "Unit price")]
        public decimal UnitPrice { get; set; } // UnitPrice

        [Column(@"Quantity", Order = 4, TypeName = "smallint")]
        [Required]
        [Display(Name = "Quantity")]
        public short Quantity { get; set; } // Quantity

        [Column(@"Discount", Order = 5, TypeName = "real")]
        [Required]
        [Display(Name = "Discount")]
        public float Discount { get; set; } // Discount

        // Foreign keys

        /// <summary>
        /// Parent Order pointed by [Order Details].([OrderId]) (FK_Order_Details_Orders)
        /// </summary>
        [ForeignKey("OrderId")] public virtual Order Order { get; set; } // FK_Order_Details_Orders

        /// <summary>
        /// Parent Product pointed by [Order Details].([ProductId]) (FK_Order_Details_Products)
        /// </summary>
        [ForeignKey("ProductId")] public virtual Product Product { get; set; } // FK_Order_Details_Products

        public OrderDetail()
        {
            UnitPrice = 0m;
            Quantity = 1;
            Discount = 0f;
        }
    }

}
// </auto-generated>
