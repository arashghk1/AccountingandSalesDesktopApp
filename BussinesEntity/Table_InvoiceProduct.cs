//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BussinesEntity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Table_InvoiceProduct
    {
        public int InvoiceProduct_ID { get; set; }
        public Nullable<int> InvoiceProduct_Count { get; set; }
        public Nullable<int> Product_ID { get; set; }
        public Nullable<long> InvoiceProduct_SellingPrice { get; set; }
        public Nullable<long> InvoiceProduct_BuyingPrice { get; set; }
        public Nullable<int> Invoice_ID { get; set; }
    
        public virtual Table_Invoice Table_Invoice { get; set; }
        public virtual Table_Product Table_Product { get; set; }
    }
}
