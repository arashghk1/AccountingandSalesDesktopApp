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
    
    public partial class Table_ProductPriceManagment
    {
        public int ProductPiceManagment_ID { get; set; }
        public long ProductPiceManagment_Buying { get; set; }
        public long ProductPiceManagment_Selling { get; set; }
        public string ProductPiceManagment_Date { get; set; }
        public string ProductPiceManagment_Dsc { get; set; }
        public int Product_ID { get; set; }
        public int User_ID { get; set; }
    
        public virtual Table_Product Table_Product { get; set; }
        public virtual Table_Users Table_Users { get; set; }
    }
}