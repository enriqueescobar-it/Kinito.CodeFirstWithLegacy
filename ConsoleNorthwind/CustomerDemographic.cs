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

    // CustomerDemographics
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class CustomerDemographic
    {
        [Column(@"CustomerTypeID", Order = 1, TypeName = "nchar")]
        [Required]
        [MaxLength(10)]
        [StringLength(10)]
        [Key]
        [Display(Name = "Customer type ID")]
        public string CustomerTypeId { get; set; } // CustomerTypeID (Primary key) (length: 10)

        [MaxLength]
        [Display(Name = "Customer desc")]
        public string CustomerDesc { get; set; } // CustomerDesc (length: 1073741823)

        // Reverse navigation

        /// <summary>
        /// Child Customers (Many-to-Many) mapped by table [CustomerCustomerDemo]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Customer> Customers { get; set; } // Many to many mapping

        public CustomerDemographic()
        {
            Customers = new System.Collections.Generic.List<Customer>();
        }
    }

}
// </auto-generated>
