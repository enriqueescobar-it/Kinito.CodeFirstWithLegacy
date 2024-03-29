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


namespace ConfigurationContext
{
    using Entities;
    using Interfaces;

    // Invoices
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.32.0.0")]
    public class ViewInvoiceConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ViewInvoice>
    {
        public ViewInvoiceConfiguration()
            : this("dbo")
        {
        }

        public ViewInvoiceConfiguration(string schema)
        {
            Property(x => x.ShipName).IsOptional();
            Property(x => x.ShipAddress).IsOptional();
            Property(x => x.ShipCity).IsOptional();
            Property(x => x.ShipRegion).IsOptional();
            Property(x => x.ShipPostalCode).IsOptional();
            Property(x => x.ShipCountry).IsOptional();
            Property(x => x.CustomerId).IsOptional().IsFixedLength();
            Property(x => x.Address).IsOptional();
            Property(x => x.City).IsOptional();
            Property(x => x.Region).IsOptional();
            Property(x => x.PostalCode).IsOptional();
            Property(x => x.Country).IsOptional();
            Property(x => x.OrderDate).IsOptional();
            Property(x => x.RequiredDate).IsOptional();
            Property(x => x.ShippedDate).IsOptional();
            Property(x => x.UnitPrice).HasPrecision(19,4);
            Property(x => x.ExtendedPrice).IsOptional().HasPrecision(19,4);
            Property(x => x.Freight).IsOptional().HasPrecision(19,4);
        }
    }

}
// </auto-generated>
