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
    
    public partial class OrderCancelReasonDetailCampaignMapping
    {
        public int OrderCancelReasonDetailCampaignMappingId { get; set; }
        public int OrderCancelReasonDetailId { get; set; }
        public int CampaignID { get; set; }
        public bool IsActive { get; set; }
    
        public virtual Campaign Campaign { get; set; }
        public virtual OrderCancelReasonDetail OrderCancelReasonDetail { get; set; }
    }
}
