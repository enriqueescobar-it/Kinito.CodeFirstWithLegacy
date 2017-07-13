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

    // Customers
    [Table("Customers", Schema = "dbo")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.32.0.0")]
    public class Customer /* Column Count = 11 */
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"CustomerID", Order = 1, TypeName = "nchar")]
        [Index(@"PK_Customers", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [MaxLength(5)]
        [StringLength(5)]
        [Key]
        [Display(Name = "Customer ID")]
        public string CustomerId { get; set; } // CustomerID (Primary key) (length: 5)

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
        [Index(@"City", 1, IsUnique = false, IsClustered = false)]
        [MaxLength(15)]
        [StringLength(15)]
        [Display(Name = "City")]
        public string City { get; set; } // City (length: 15)

        [Column(@"Region", Order = 7, TypeName = "nvarchar")]
        [Index(@"Region", 1, IsUnique = false, IsClustered = false)]
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

        // Reverse navigation

        /// <summary>
        /// Child CustomerDemographics (Many-to-Many) mapped by table [CustomerCustomerDemo]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<CustomerDemographic> CustomerDemographics { get; set; } // Many to many mapping
        /// <summary>
        /// Child Orders where [Orders].[CustomerID] point to this entity (FK_Orders_Customers)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Order> Orders { get; set; } // Orders.FK_Orders_Customers

        public Customer()
        {
            Orders = new System.Collections.Generic.List<Order>();
            CustomerDemographics = new System.Collections.Generic.List<CustomerDemographic>();
        }
    }

}
// </auto-generated>
