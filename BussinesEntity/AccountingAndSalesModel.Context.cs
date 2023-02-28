﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class AccountingAndSales_DBEntities : DbContext
    {
        public AccountingAndSales_DBEntities()
            : base("name=AccountingAndSales_DBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Table_Customers> Table_Customers { get; set; }
        public virtual DbSet<Table_DataHistory> Table_DataHistory { get; set; }
        public virtual DbSet<Table_Inventory> Table_Inventory { get; set; }
        public virtual DbSet<Table_Invoice> Table_Invoice { get; set; }
        public virtual DbSet<Table_InvoiceProduct> Table_InvoiceProduct { get; set; }
        public virtual DbSet<Table_Product> Table_Product { get; set; }
        public virtual DbSet<Table_ProductPriceManagment> Table_ProductPriceManagment { get; set; }
        public virtual DbSet<Table_UserLog> Table_UserLog { get; set; }
        public virtual DbSet<Table_Users> Table_Users { get; set; }
        public virtual DbSet<Users_View> Users_View { get; set; }
        public virtual DbSet<View_Customer> View_Customer { get; set; }
        public virtual DbSet<View_Inventory> View_Inventory { get; set; }
        public virtual DbSet<View_Invoice> View_Invoice { get; set; }
        public virtual DbSet<View_InvoiceProduct> View_InvoiceProduct { get; set; }
        public virtual DbSet<View_Product> View_Product { get; set; }
        public virtual DbSet<View_ProductPriceManagment> View_ProductPriceManagment { get; set; }
        public virtual DbSet<View_UserLog> View_UserLog { get; set; }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_Edit_Product(Nullable<int> product_ID, string product_Name, string product_Description, byte[] product_Image)
        {
            var product_IDParameter = product_ID.HasValue ?
                new ObjectParameter("Product_ID", product_ID) :
                new ObjectParameter("Product_ID", typeof(int));
    
            var product_NameParameter = product_Name != null ?
                new ObjectParameter("Product_Name", product_Name) :
                new ObjectParameter("Product_Name", typeof(string));
    
            var product_DescriptionParameter = product_Description != null ?
                new ObjectParameter("Product_Description", product_Description) :
                new ObjectParameter("Product_Description", typeof(string));
    
            var product_ImageParameter = product_Image != null ?
                new ObjectParameter("Product_Image", product_Image) :
                new ObjectParameter("Product_Image", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Edit_Product", product_IDParameter, product_NameParameter, product_DescriptionParameter, product_ImageParameter);
        }
    
        public virtual int sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_Insert_Product(string product_Name, string product_Description, byte[] product_Image, string product_RegisterDate, Nullable<int> user_ID)
        {
            var product_NameParameter = product_Name != null ?
                new ObjectParameter("Product_Name", product_Name) :
                new ObjectParameter("Product_Name", typeof(string));
    
            var product_DescriptionParameter = product_Description != null ?
                new ObjectParameter("Product_Description", product_Description) :
                new ObjectParameter("Product_Description", typeof(string));
    
            var product_ImageParameter = product_Image != null ?
                new ObjectParameter("Product_Image", product_Image) :
                new ObjectParameter("Product_Image", typeof(byte[]));
    
            var product_RegisterDateParameter = product_RegisterDate != null ?
                new ObjectParameter("Product_RegisterDate", product_RegisterDate) :
                new ObjectParameter("Product_RegisterDate", typeof(string));
    
            var user_IDParameter = user_ID.HasValue ?
                new ObjectParameter("User_ID", user_ID) :
                new ObjectParameter("User_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Insert_Product", product_NameParameter, product_DescriptionParameter, product_ImageParameter, product_RegisterDateParameter, user_IDParameter);
        }
    
        public virtual int sp_NewUpdate_Product_forNotImage(Nullable<int> product_ID, string product_Name, string product_Description)
        {
            var product_IDParameter = product_ID.HasValue ?
                new ObjectParameter("Product_ID", product_ID) :
                new ObjectParameter("Product_ID", typeof(int));
    
            var product_NameParameter = product_Name != null ?
                new ObjectParameter("Product_Name", product_Name) :
                new ObjectParameter("Product_Name", typeof(string));
    
            var product_DescriptionParameter = product_Description != null ?
                new ObjectParameter("Product_Description", product_Description) :
                new ObjectParameter("Product_Description", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_NewUpdate_Product_forNotImage", product_IDParameter, product_NameParameter, product_DescriptionParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_Update_ExitDateInUserLogTable(Nullable<int> user_ID, string exitDate)
        {
            var user_IDParameter = user_ID.HasValue ?
                new ObjectParameter("User_ID", user_ID) :
                new ObjectParameter("User_ID", typeof(int));
    
            var exitDateParameter = exitDate != null ?
                new ObjectParameter("ExitDate", exitDate) :
                new ObjectParameter("ExitDate", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Update_ExitDateInUserLogTable", user_IDParameter, exitDateParameter);
        }
    
        public virtual int sp_Update_ProductLastQuantity(Nullable<long> inverntory_Count, Nullable<int> product_ID)
        {
            var inverntory_CountParameter = inverntory_Count.HasValue ?
                new ObjectParameter("Inverntory_Count", inverntory_Count) :
                new ObjectParameter("Inverntory_Count", typeof(long));
    
            var product_IDParameter = product_ID.HasValue ?
                new ObjectParameter("Product_ID", product_ID) :
                new ObjectParameter("Product_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Update_ProductLastQuantity", inverntory_CountParameter, product_IDParameter);
        }
    
        public virtual int sp_UpdateLastPrice_Product(Nullable<int> product_ID, Nullable<long> product_LastPrice, Nullable<long> product_LastBuyingPrice)
        {
            var product_IDParameter = product_ID.HasValue ?
                new ObjectParameter("Product_ID", product_ID) :
                new ObjectParameter("Product_ID", typeof(int));
    
            var product_LastPriceParameter = product_LastPrice.HasValue ?
                new ObjectParameter("Product_LastPrice", product_LastPrice) :
                new ObjectParameter("Product_LastPrice", typeof(long));
    
            var product_LastBuyingPriceParameter = product_LastBuyingPrice.HasValue ?
                new ObjectParameter("Product_LastBuyingPrice", product_LastBuyingPrice) :
                new ObjectParameter("Product_LastBuyingPrice", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_UpdateLastPrice_Product", product_IDParameter, product_LastPriceParameter, product_LastBuyingPriceParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual ObjectResult<Sp_SellingChart_Result> Sp_SellingChart()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Sp_SellingChart_Result>("Sp_SellingChart");
        }
    
        public virtual ObjectResult<sp_SalesChart_By_TotalPriceAnyCustomer_Result> sp_SalesChart_By_TotalPriceAnyCustomer()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_SalesChart_By_TotalPriceAnyCustomer_Result>("sp_SalesChart_By_TotalPriceAnyCustomer");
        }
    }
}