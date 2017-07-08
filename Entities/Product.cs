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

    // Products
    [Table("Products", Schema = "dbo")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"ProductID", Order = 1, TypeName = "int")]
        [Index(@"PK_Products", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Product ID")]
        public int ProductId { get; set; } // ProductID (Primary key)

        [Column(@"ProductName", Order = 2, TypeName = "nvarchar")]
        [Index(@"ProductName", 1, IsUnique = false, IsClustered = false)]
        [Required]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Product name")]
        public string ProductName { get; set; } // ProductName (length: 40)

        [Column(@"SupplierID", Order = 3, TypeName = "int")]
        [Index(@"SupplierID", 1, IsUnique = false, IsClustered = false)]
        [Index(@"SuppliersProducts", 1, IsUnique = false, IsClustered = false)]
        [Display(Name = "Supplier ID")]
        public int? SupplierId { get; set; } // SupplierID

        [Column(@"CategoryID", Order = 4, TypeName = "int")]
        [Index(@"CategoriesProducts", 1, IsUnique = false, IsClustered = false)]
        [Index(@"CategoryID", 1, IsUnique = false, IsClustered = false)]
        [Display(Name = "Category ID")]
        public int? CategoryId { get; set; } // CategoryID

        [Column(@"QuantityPerUnit", Order = 5, TypeName = "nvarchar")]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Quantity per unit")]
        public string QuantityPerUnit { get; set; } // QuantityPerUnit (length: 20)

        [Column(@"UnitPrice", Order = 6, TypeName = "money")]
        [Display(Name = "Unit price")]
        public decimal? UnitPrice { get; set; } // UnitPrice

        [Column(@"UnitsInStock", Order = 7, TypeName = "smallint")]
        [Display(Name = "Units in stock")]
        public short? UnitsInStock { get; set; } // UnitsInStock

        [Column(@"UnitsOnOrder", Order = 8, TypeName = "smallint")]
        [Display(Name = "Units on order")]
        public short? UnitsOnOrder { get; set; } // UnitsOnOrder

        [Column(@"ReorderLevel", Order = 9, TypeName = "smallint")]
        [Display(Name = "Reorder level")]
        public short? ReorderLevel { get; set; } // ReorderLevel

        [Column(@"Discontinued", Order = 10, TypeName = "bit")]
        [Required]
        [Display(Name = "Discontinued")]
        public bool Discontinued { get; set; } // Discontinued

        // Reverse navigation

        /// <summary>
        /// Child OrderDetails where [Order Details].[ProductID] point to this entity (FK_Order_Details_Products)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<OrderDetail> OrderDetails { get; set; } // Order Details.FK_Order_Details_Products

        // Foreign keys

        /// <summary>
        /// Parent Category pointed by [Products].([CategoryId]) (FK_Products_Categories)
        /// </summary>
        [ForeignKey("CategoryId")] public virtual Category Category { get; set; } // FK_Products_Categories
        /// <summary>
        /// Parent Supplier pointed by [Products].([SupplierId]) (FK_Products_Suppliers)
        /// </summary>
        [ForeignKey("SupplierId")] public virtual Supplier Supplier { get; set; } // FK_Products_Suppliers

        public Product()
        {
            UnitPrice = 0m;
            UnitsInStock = 0;
            UnitsOnOrder = 0;
            ReorderLevel = 0;
            Discontinued = false;
            OrderDetails = new System.Collections.Generic.List<OrderDetail>();
        }
    }

}
// </auto-generated>