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

    // engineer_order_item
    [Table("engineer_order_item", Schema = "dbo")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.32.0.0")]
    public class EngineerOrderItem /* Column Count = 3 */
    {
        // Number of columns for table engineer_order_item = 3
        public static int ColumnCount = 3;

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"engineer_order_item_id", Order = 1, TypeName = "int")]
        [Index(@"PK__engineer__1613A3A307C71242", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Engineer order item ID")]
        public int EngineerOrderItemId { get; set; } // engineer_order_item_id (Primary key)

        [Column(@"engineer_order_id", Order = 2, TypeName = "int")]
        [Display(Name = "Engineer order ID")]
        public int? EngineerOrderId { get; set; } // engineer_order_id

        [Column(@"sku", Order = 3, TypeName = "varchar")]
        [Required]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Sku")]
        public string Sku { get; set; } // sku (length: 50)

        // Foreign keys

        /// <summary>
        /// Parent EngineerOrder pointed by [engineer_order_item].([EngineerOrderId]) (EOI_FK)
        /// </summary>
        [ForeignKey("EngineerOrderId")] public virtual EngineerOrder EngineerOrder { get; set; } // EOI_FK
    }

}
// </auto-generated>
