using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinesEntity;
using DataAccessLayer;

namespace BussinesLogicLayer
{
    public class BLL_Inventory
    {
        DAL_Inventory DAL_inventory=new DAL_Inventory();

        public void Create(Table_Inventory inventory)
        {
            DAL_inventory.Create(inventory);
        }
        public List<View_Inventory> InverntoryReadAll()
        {
            return DAL_inventory.InventoryReadAll();
        }
        public List<View_Inventory> InverntoryAvailableProductRead(int InputProductID, string InputProductName)
        {
            return DAL_inventory.InverntoryAvailableProductRead(InputProductID , InputProductName);
        }
        public List<View_Inventory> InverntoryNoneExistentProductRead(int InputProductID, string InputProductName)
        {      
            return DAL_inventory.InverntoryNoneExistentProductRead(InputProductID,InputProductName);
        }
        public List<View_Inventory> InventoryReadByStringValue(string InputValue , int InputProductID, string InputProductName)
        {
            return DAL_inventory.InventoryReadByStringValue(InputValue ,InputProductID,InputProductName);
        }
        public List<View_Inventory> InventoryReadByProductNameAndID(int InputProductID, string InputProductName)
        {
            return DAL_inventory.InventoryReadByProductNameAndID(InputProductID, InputProductName);
        }
        public void UpdateInventoryCount(int InventoryCount, int ProductID)
        {
            DAL_inventory.UpdateInventoryCount(InventoryCount, ProductID);
        }
    }
}
