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

    // Suppliers
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class Supplier
    {
        [Column(@"SupplierID", Order = 1, TypeName = "int")]
        [Required]
        [Key]
        [Display(Name = "Supplier ID")]
        public int SupplierId { get; set; } // SupplierID (Primary key)

        [Required]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Company name")]
        public string CompanyName { get; set; } // CompanyName (length: 40)

        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "Contact name")]
        public string ContactName { get; set; } // ContactName (length: 30)

        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "Contact title")]
        public string ContactTitle { get; set; } // ContactTitle (length: 30)

        [MaxLength(60)]
        [StringLength(60)]
        [Display(Name = "Address")]
        public string Address { get; set; } // Address (length: 60)

        [MaxLength(15)]
        [StringLength(15)]
        [Display(Name = "City")]
        public string City { get; set; } // City (length: 15)

        [MaxLength(15)]
        [StringLength(15)]
        [Display(Name = "Region")]
        public string Region { get; set; } // Region (length: 15)

        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Postal code")]
        public string PostalCode { get; set; } // PostalCode (length: 10)

        [MaxLength(15)]
        [StringLength(15)]
        [Display(Name = "Country")]
        public string Country { get; set; } // Country (length: 15)

        [MaxLength(24)]
        [StringLength(24)]
        [Phone]
        [Display(Name = "Phone")]
        public string Phone { get; set; } // Phone (length: 24)

        [MaxLength(24)]
        [StringLength(24)]
        [Display(Name = "Fax")]
        public string Fax { get; set; } // Fax (length: 24)

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
