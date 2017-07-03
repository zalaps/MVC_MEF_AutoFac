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
    
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            this.CCQueries = new HashSet<CCQuery>();
            this.OrderBillLimits = new HashSet<OrderBillLimit>();
            this.SaleReferralLists = new HashSet<SaleReferralList>();
            this.OrderItems = new HashSet<OrderItem>();
            this.OrderBundles = new HashSet<OrderBundle>();
            this.OrderRecordings = new HashSet<OrderRecording>();
            this.OrderTelcoAttributes = new HashSet<OrderTelcoAttribute>();
            this.OrderVettings = new HashSet<OrderVetting>();
            this.QAForms = new HashSet<QAForm>();
            this.QAProgresses = new HashSet<QAProgress>();
            this.QAQueues = new HashSet<QAQueue>();
            this.RetensionsOrderStatusQueues = new HashSet<RetensionsOrderStatusQueue>();
        }
    
        public int OrderID { get; set; }
        public System.DateTime OrderDate { get; set; }
        public int UserId { get; set; }
        public int BrandId { get; set; }
        public int CampaignId { get; set; }
        public int DialerAgentId { get; set; }
        public Nullable<int> Period { get; set; }
        public string Comments { get; set; }
        public string CallFlag { get; set; }
        public string BasketReference { get; set; }
        public int EscalationIndex { get; set; }
        public Nullable<int> DebitOrderDay { get; set; }
        public int CustomerId { get; set; }
        public Nullable<int> LeadId { get; set; }
        public Nullable<int> VerifierId { get; set; }
        public int EmailCommSentStatusId { get; set; }
        public int SMSCommSentStatusId { get; set; }
        public Nullable<bool> BillingIsPaid { get; set; }
        public Nullable<System.DateTime> BillingDate { get; set; }
        public Nullable<int> OverrideVettingUserId { get; set; }
        public Nullable<int> VettingHistoryId { get; set; }
        public Nullable<int> MSOrdermasterId { get; set; }
        public Nullable<int> EMOrdermasterId { get; set; }
        public Nullable<decimal> Affordability { get; set; }
    
        public virtual Brand Brand { get; set; }
        public virtual Campaign Campaign { get; set; }
        public virtual Customer Customer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CCQuery> CCQueries { get; set; }
        public virtual VettingHistory VettingHistory { get; set; }
        public virtual CommSentStatu CommSentStatu { get; set; }
        public virtual CommSentStatu CommSentStatu1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderBillLimit> OrderBillLimits { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SaleReferralList> SaleReferralLists { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItem> OrderItems { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderBundle> OrderBundles { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderRecording> OrderRecordings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderTelcoAttribute> OrderTelcoAttributes { get; set; }
        public virtual User User1 { get; set; }
        public virtual User User2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderVetting> OrderVettings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QAForm> QAForms { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QAProgress> QAProgresses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QAQueue> QAQueues { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RetensionsOrderStatusQueue> RetensionsOrderStatusQueues { get; set; }
    }
}