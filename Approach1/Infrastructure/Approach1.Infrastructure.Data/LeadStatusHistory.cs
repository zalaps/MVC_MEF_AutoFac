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
    
    public partial class LeadStatusHistory
    {
        public int LeadStatusHistoryId { get; set; }
        public int LeadId { get; set; }
        public System.DateTime Occured { get; set; }
        public string Annotation { get; set; }
        public int LeadStatusDetailId { get; set; }
        public Nullable<int> UserId { get; set; }
    
        public virtual Lead Lead { get; set; }
        public virtual LeadStatusDetail LeadStatusDetail { get; set; }
        public virtual User User { get; set; }
    }
}
