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
    
    public partial class vwViewQAFormQuestion
    {
        public int ResponseID { get; set; }
        public int QAFormID { get; set; }
        public decimal Score { get; set; }
        public int QuestionID { get; set; }
        public string QuestionText { get; set; }
        public decimal QuestionWeight { get; set; }
        public int SectionID { get; set; }
        public string SectionName { get; set; }
    }
}