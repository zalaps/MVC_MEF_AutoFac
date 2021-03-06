//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Approach1.Infrastructure.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Deal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Deal()
        {
            this.DealBundleMappings = new HashSet<DealBundleMapping>();
            this.DealBundleMappings1 = new HashSet<DealBundleMapping>();
            this.ProviderRangeDealMappings = new HashSet<ProviderRangeDealMapping>();
            this.SaleRuleDealMappings = new HashSet<SaleRuleDealMapping>();
            this.SaleRuleDealMappings1 = new HashSet<SaleRuleDealMapping>();
            this.BundleDealMappings = new HashSet<BundleDealMapping>();
            this.DealCampaigns = new HashSet<DealCampaign>();
            this.DealProductMappings = new HashSet<DealProductMapping>();
            this.OrderItems = new HashSet<OrderItem>();
            this.OrderRetentions = new HashSet<OrderRetention>();
            this.TelkomSpecificProviders = new HashSet<TelkomSpecificProvider>();
        }
    
        public int DealID { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int Hot { get; set; }
        public int Available { get; set; }
        public int Multiple { get; set; }
        public Nullable<int> SupplierId { get; set; }
        public Nullable<int> TariffId { get; set; }
        public Nullable<int> MsId { get; set; }
        public Nullable<int> EMId { get; set; }
        public decimal GP { get; set; }
        public decimal Cost { get; set; }
        public int DealType { get; set; }
        public string RatePlan { get; set; }
        public string ExternalReference { get; set; }
        public Nullable<int> CreatedByUserId { get; set; }
        public Nullable<System.DateTime> CreatedOnDate { get; set; }
        public Nullable<int> UpdatedByUserId { get; set; }
        public Nullable<System.DateTime> UpdatedOnDate { get; set; }
        public bool IsPublished { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<int> SaleRuleId { get; set; }
        public Nullable<System.DateTime> ExpiryDate { get; set; }
        public Nullable<bool> IsInsurable { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DealBundleMapping> DealBundleMappings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DealBundleMapping> DealBundleMappings1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProviderRangeDealMapping> ProviderRangeDealMappings { get; set; }
        public virtual SaleRule SaleRule { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SaleRuleDealMapping> SaleRuleDealMappings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SaleRuleDealMapping> SaleRuleDealMappings1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BundleDealMapping> BundleDealMappings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DealCampaign> DealCampaigns { get; set; }
        public virtual DealType DealType1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DealProductMapping> DealProductMappings { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual Tariff Tariff { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItem> OrderItems { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderRetention> OrderRetentions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TelkomSpecificProvider> TelkomSpecificProviders { get; set; }
    }
}
