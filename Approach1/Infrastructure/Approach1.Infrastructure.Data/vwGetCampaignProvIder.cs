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
    
    public partial class vwGetCampaignProvIder
    {
        public int CampaignID { get; set; }
        public Nullable<int> ProviderID { get; set; }
        public string ProviderName { get; set; }
        public Nullable<bool> RequireSpecificData { get; set; }
        public Nullable<bool> RequireBankDetails { get; set; }
        public Nullable<bool> IsVAS { get; set; }
    }
}
