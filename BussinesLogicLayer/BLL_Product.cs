using BussinesEntity;
using DataAccessLayer;
using System.Collections.Generic;
using System.Windows.Media.Imaging;

namespace BussinesLogicLayer
{
    public class BLL_Product
    {
        DAL_Product DAL_product = new DAL_Product();


        public void Create(Table_Product product)
        {
            DAL_product.Create(product);
        }
        public List<View_Product> productRead()
        {
            return DAL_product.ProductRead();
        }
        public List<View_Product> ShearchProductWithString(string InputValue)
        {
            return DAL_product.ShearchProductWithString(InputValue);
        }
        public List<View_Product> SearchAvailableProduct()
        {
            return DAL_product.SearchAvailableProduct();
        }
        public List<View_Product> SearchNon_AvailableProduct()
        {
            return DAL_product.SearchNon_AvailableProduct();
        }
        public View_Product ReadProductByID(int ProductID)
        {
            return DAL_product.ReadProductByID(ProductID);
        }
        public void EditProductWhitImage(Table_Product product)
        {
            DAL_product.EditProductWhitImage(product);

        }
        public void DeleteProduct(int ProductID)
        {
            DAL_product.DeleteProduct(ProductID);
        }
        public void EditProductWithdoutImage(Table_Product product)
        {
            DAL_product.EditProductWithdoutImage(product);
        }
    }
}
