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
    
    public partial class View_Invoice
    {
        public int Invoice_ID { get; set; }
        public string Invoice_DateTime { get; set; }
        public Nullable<long> Invoice_Price { get; set; }
        public Nullable<long> Invoice_BuyingPrice { get; set; }
        public string Invoice_Description { get; set; }
        public Nullable<int> Customer_ID { get; set; }
        public Nullable<int> User_ID { get; set; }
        public string Customer_FullName { get; set; }
        public string Customer_Address { get; set; }
        public string Customer_PhoneNumber { get; set; }
        public string User_FirstName { get; set; }
        public string User_LastName { get; set; }
        public string UserRegister { get; set; }
        public Nullable<bool> Invoice_Type { get; set; }
        public string InvoiceTypeEnglish { get; set; }
    }
}