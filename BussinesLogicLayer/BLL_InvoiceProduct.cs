using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinesEntity;
using DataAccessLayer;

namespace BussinesLogicLayer
{
    public class BLL_InvoiceProduct
    {
        DalInvoiceProduct _dalInvoiceProduct = new DalInvoiceProduct();

        public void Create(Table_InvoiceProduct invoiceProduct)
        {
            _dalInvoiceProduct.Create(invoiceProduct);
        }



        public List<View_InvoiceProduct> ReadInvoiceProductWhitInvoiceId(int invoiceId)
        {
            return _dalInvoiceProduct.ReadInvoiceProductWhitInvoiceId(invoiceId);
        }

        public void DeleteInvoiceProductInFactor(int productId, int invoiceId)
        {
            _dalInvoiceProduct.DeleteInvoiceProductInFactor(productId , invoiceId);
        }

        public void UpdateInvoiceProductCount(int invoiceProductId, int? newCount)
        {
            _dalInvoiceProduct.UpdateInvoiceProductCount(invoiceProductId , newCount);
        }
    }
}
