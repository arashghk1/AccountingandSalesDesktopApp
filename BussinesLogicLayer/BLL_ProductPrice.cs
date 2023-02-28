using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinesEntity;
using DataAccessLayer;

namespace BussinesLogicLayer
{
    public class BLL_ProductPrice
    {
        DAL_ProductPrice DAL_productPrice=new DAL_ProductPrice();

        public void Register(Table_ProductPriceManagment productPrice)
        {
            DAL_productPrice.Register(productPrice);
        }
        public List<View_ProductPriceManagment> ProductPriceManagmentRead()
        {
            return DAL_productPrice.ProductPriceManagmentRead();
        }
        public List<View_ProductPriceManagment> ProductPriceManagementReadByID(int id)
        {
            return DAL_productPrice.ProductPriceManagementReadByID(id);
        }
        public void UpdateProductLastPrice(int CTM_ProductID, long CTM_ProductLastPrice, long CTM_ProductLastBuyingPrice)
        {
           DAL_productPrice.UpdateProductLastPrice(CTM_ProductID , CTM_ProductLastPrice, CTM_ProductLastBuyingPrice);
        }
        public void update(int ProductPriceID, Table_ProductPriceManagment newProductPrice)
        {
            DAL_productPrice.update(ProductPriceID , newProductPrice);
        }
    }
}
