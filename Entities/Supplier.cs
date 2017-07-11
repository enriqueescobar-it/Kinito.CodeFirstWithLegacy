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

    // Suppliers
    [Table("Suppliers", Schema = "dbo")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.32.0.0")]
    public class Supplier
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"SupplierID", Order = 1, TypeName = "int")]
        [Index(@"PK_Suppliers", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Supplier ID")]
        public int SupplierId { get; set; } // SupplierID (Primary key)

        [Column(@"CompanyName", Order = 2, TypeName = "nvarchar")]
        [Index(@"CompanyName", 1, IsUnique = false, IsClustered = false)]
        [Required]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Company name")]
        public string CompanyName { get; set; } // CompanyName (length: 40)

        [Column(@"ContactName", Order = 3, TypeName = "nvarchar")]
        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "Contact name")]
        public string ContactName { get; set; } // ContactName (length: 30)

        [Column(@"ContactTitle", Order = 4, TypeName = "nvarchar")]
        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "Contact title")]
        public string ContactTitle { get; set; } // ContactTitle (length: 30)

        [Column(@"Address", Order = 5, TypeName = "nvarchar")]
        [MaxLength(60)]
        [StringLength(60)]
        [Display(Name = "Address")]
        public string Address { get; set; } // Address (length: 60)

        [Column(@"City", Order = 6, TypeName = "nvarchar")]
        [MaxLength(15)]
        [StringLength(15)]
        [Display(Name = "City")]
        public string City { get; set; } // City (length: 15)

        [Column(@"Region", Order = 7, TypeName = "nvarchar")]
        [MaxLength(15)]
        [StringLength(15)]
        [Display(Name = "Region")]
        public string Region { get; set; } // Region (length: 15)

        [Column(@"PostalCode", Order = 8, TypeName = "nvarchar")]
        [Index(@"PostalCode", 1, IsUnique = false, IsClustered = false)]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Postal code")]
        public string PostalCode { get; set; } // PostalCode (length: 10)

        [Column(@"Country", Order = 9, TypeName = "nvarchar")]
        [MaxLength(15)]
        [StringLength(15)]
        [Display(Name = "Country")]
        public string Country { get; set; } // Country (length: 15)

        [Column(@"Phone", Order = 10, TypeName = "nvarchar")]
        [MaxLength(24)]
        [StringLength(24)]
        [Phone]
        [Display(Name = "Phone")]
        public string Phone { get; set; } // Phone (length: 24)

        [Column(@"Fax", Order = 11, TypeName = "nvarchar")]
        [MaxLength(24)]
        [StringLength(24)]
        [Display(Name = "Fax")]
        public string Fax { get; set; } // Fax (length: 24)

        [Column(@"HomePage", Order = 12, TypeName = "ntext")]
        [MaxLength]
        [Display(Name = "Home page")]
        public string HomePage { get; set; } // HomePage (length: 1073741823)

        // Reverse navigation

        /// <summary>
        /// Child Products where [Products].[SupplierID] point to this entity (FK_Products_Suppliers)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Product> Products { get; set; } // Products.FK_Products_Suppliers

        public Supplier()
        {
            Products = new System.Collections.Generic.List<Product>();
        }
    }

}
// </auto-generated>
