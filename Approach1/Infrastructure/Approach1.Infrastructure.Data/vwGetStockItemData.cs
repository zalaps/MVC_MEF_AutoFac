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
    
    public partial class vwGetStockItemData
    {
        public int StockItemID { get; set; }
        public string SerialNumber { get; set; }
        public Nullable<int> StockPurchaseOrderID { get; set; }
        public Nullable<int> StockInvoiceID { get; set; }
        public int ProductID { get; set; }
        public string Title { get; set; }
        public Nullable<int> StockReceivedStatus { get; set; }
    }
}
