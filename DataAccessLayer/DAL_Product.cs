using BussinesEntity;
using System.Collections.Generic;
using System.Linq;


namespace DataAccessLayer
{
    public class DAL_Product
    {
        AccountingAndSales_DBEntities db = new AccountingAndSales_DBEntities();


        public void Create(Table_Product product)
        {
            db.sp_Insert_Product(product.Product_Name, product.Product_Discription, product.Product_Image, product.Product_RegisterDate, product.User_ID);
            db.SaveChanges();

        }
        public List<View_Product> ProductRead()
        {
            var Query = db.View_Product.SqlQuery("SELECT * FROM View_Product WHERE Product_Delete = 0");
            //var Query = db.View_Product.Where(i => i.Product_Delete==false);
            return Query.ToList();
        }
        public List<View_Product> ShearchProductWithString(string InputValue)
        {
            var Query = db.View_Product.Where(i => i.Product_Delete==false && 
                                                    (i.Product_Name.Contains(InputValue) || i.Register_User.Contains(InputValue)));
            return Query.ToList();
        }
        public List<View_Product> SearchAvailableProduct()
        {
            var Query = db.View_Product.Where(i => i.Product_Delete ==false && i.Product_LastInventory > 0);
            return Query.ToList();
        }
        public List<View_Product> SearchNon_AvailableProduct()
        {
            var Query = db.View_Product.Where(i =>i.Product_Delete==false && i.Product_LastInventory <= 0);
            return Query.ToList();
        }
        public View_Product ReadProductByID(int ProductID)
        {
            var Query = db.View_Product.Where(i =>i.Product_Delete ==false && i.Product_ID == ProductID);
            return Query.Single();
        }
        public void EditProductWhitImage(Table_Product product)
        {
            db.sp_Edit_Product(product.Product_ID , product.Product_Name , product.Product_Discription , product.Product_Image);
            db.SaveChanges();
        }
        public void DeleteProduct(int ProductID)
        {
            var Query = db.Table_Product.Where(i => i.Product_Delete == false && i.Product_ID == ProductID);
            if (Query.Count() == 1)
            {
                Table_Product product = new Table_Product();
                product = Query.SingleOrDefault();
                product.Product_Delete = true;
                db.SaveChanges();
            }
        }
        public void EditProductWithdoutImage(Table_Product product)
        {
            db.sp_NewUpdate_Product_forNotImage(product.Product_ID, product.Product_Name, product.Product_Discription);
            db.SaveChanges();
        }

    }
}
