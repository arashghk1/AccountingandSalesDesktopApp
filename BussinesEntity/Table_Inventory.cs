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
    
    public partial class Table_Inventory
    {
        public int Inventory_ID { get; set; }
        public long Inventory_Count { get; set; }
        public string Inventory_Date { get; set; }
        public string Inventory_Description { get; set; }
        public int User_ID { get; set; }
        public int Product_ID { get; set; }
    
        public virtual Table_Product Table_Product { get; set; }
        public virtual Table_Users Table_Users { get; set; }
    }
}
