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
    
    public partial class Table_DataHistory
    {
        public int DataHistory_ID { get; set; }
        public string DataHistory_TableName { get; set; }
        public Nullable<int> DataHistory_WhatID { get; set; }
        public string DataHistory_ActionType { get; set; }
        public Nullable<System.DateTime> DataHistory_ModifyDate { get; set; }
    }
}
