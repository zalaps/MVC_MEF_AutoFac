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
    
    public partial class prRetrieveSearchDeal_Result
    {
        public int DealID { get; set; }
        public string DealTitle { get; set; }
        public string DealCode { get; set; }
        public string DealDescription { get; set; }
        public int Hot { get; set; }
        public int Available { get; set; }
        public Nullable<int> SupplierID { get; set; }
        public string SupplierName { get; set; }
        public Nullable<int> TariffID { get; set; }
        public string TariffDescription { get; set; }
        public Nullable<int> TotalItems { get; set; }
    }
}
