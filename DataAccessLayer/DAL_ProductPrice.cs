using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BussinesEntity;

namespace DataAccessLayer
{
    public class DAL_ProductPrice
    {
        AccountingAndSales_DBEntities db=new AccountingAndSales_DBEntities();

        public void Register(Table_ProductPriceManagment productPrice)
        {
            db.Table_ProductPriceManagment.Add(productPrice);
            db.SaveChanges();   
        }
        public List<View_ProductPriceManagment> ProductPriceManagmentRead()
        {
            return db.View_ProductPriceManagment.ToList();
        }
        public List<View_ProductPriceManagment> ProductPriceManagementReadByID(int id )
        {
            var Query = db.View_ProductPriceManagment.Where(i => i.Product_ID == id);
            return Query.ToList();
        }
        public void UpdateProductLastPrice(int CTM_ProductID , long CTM_ProductLastPrice , long CTM_ProductLastBuyingPrice)
        {
            db.sp_UpdateLastPrice_Product(CTM_ProductID , CTM_ProductLastPrice , CTM_ProductLastBuyingPrice);
            db.SaveChanges();
            
        }

        public void update(int ProductPriceID , Table_ProductPriceManagment newProductPrice)
        {
            var Query = db.Table_ProductPriceManagment.Where(i => i.ProductPiceManagment_ID == ProductPriceID);
            if (Query.Count() == 1)
            {
                Table_ProductPriceManagment productPrice= new Table_ProductPriceManagment();
                productPrice = Query.Single();
                productPrice.ProductPiceManagment_Buying = newProductPrice.ProductPiceManagment_Buying;
                productPrice.ProductPiceManagment_Selling = newProductPrice.ProductPiceManagment_Selling;
                productPrice.ProductPiceManagment_Dsc = newProductPrice.ProductPiceManagment_Dsc;
                db.SaveChanges();
            }
        }

    }
}
