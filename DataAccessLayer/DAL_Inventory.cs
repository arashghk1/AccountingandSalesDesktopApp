using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BussinesEntity;

namespace DataAccessLayer
{
    public class DAL_Inventory
    {
        AccountingAndSales_DBEntities db=new AccountingAndSales_DBEntities();

        public void Create(Table_Inventory inventory)
        {
            db.Table_Inventory.Add(inventory);
            db.SaveChanges();
        }
        public List<View_Inventory> InventoryReadAll()
        {
            return db.View_Inventory.ToList();
        }
        public List<View_Inventory> InverntoryAvailableProductRead(int InputProductID, string InputProductName)
        {
            var Query = db.View_Inventory.Where(i => i.Inventory_Count > 0 && i.Product_ID == InputProductID && i.Product_Name == InputProductName);
            return Query.ToList();
        }
        public List<View_Inventory> InverntoryNoneExistentProductRead(int InputProductID, string InputProductName)
        {
            var Query = db.View_Inventory.Where(i => i.Inventory_Count <= 0 && i.Product_ID == InputProductID && i.Product_Name == InputProductName);
            return Query.ToList();
        }
        public List<View_Inventory> InventoryReadByStringValue(string InputValue , int InputProductID, string InputProductName)
        {
            var Query = db.View_Inventory.Where(
                i => i.Product_ID == InputProductID &&
                i.Product_Name == InputProductName &&
                (
                i.InventoryCountStatus == InputValue || 
                i.Register_User.Contains(InputValue) || 
                i.Product_Name.Contains(InputValue) ||
                i.Inventory_Date.Equals(InputValue)
                )
                ); 
                return Query.ToList();

        }
        public List<View_Inventory> InventoryReadByProductNameAndID(int InputProductID ,string InputProductName)
        {
            var Query = db.View_Inventory.Where(i => i.Product_ID == InputProductID && i.Product_Name == InputProductName);
            return Query.ToList();
        }
        public void UpdateInventoryCount(int InventoryCount , int ProductID)
        {
            db.sp_Update_ProductLastQuantity(InventoryCount, ProductID);
            db.SaveChanges();
        }
    }
}
