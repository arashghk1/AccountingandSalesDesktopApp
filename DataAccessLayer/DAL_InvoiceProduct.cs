using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BussinesEntity;



namespace DataAccessLayer
{
    public class DalInvoiceProduct
    {
        AccountingAndSales_DBEntities db=new AccountingAndSales_DBEntities();

        public void Create(Table_InvoiceProduct invoiceProduct)
        {
            db.Table_InvoiceProduct.Add(invoiceProduct);
            db.SaveChanges();
        }


        public List<View_InvoiceProduct> ReadInvoiceProductWhitInvoiceId(int invoiceId)
        {
            IQueryable<View_InvoiceProduct> query;
            query = db.View_InvoiceProduct.Where(i => i.Invoice_ID == invoiceId);
            return query.ToList();
        }


        public void DeleteInvoiceProductInFactor(int productId , int invoiceId)
        {
            var query = db.Table_InvoiceProduct.Where(i => i.Product_ID == productId && i.Invoice_ID == invoiceId).SingleOrDefault();
            db.Table_InvoiceProduct.Remove(query);
            db.SaveChanges();
        }

        public void UpdateInvoiceProductCount(int invoiceProductId, int? newCount)
        {
            var query = db.Table_InvoiceProduct.Where(i => i.InvoiceProduct_ID == invoiceProductId);
            if (query.Count() == 1)
            {
                Table_InvoiceProduct invoiceProduct = new Table_InvoiceProduct();
                invoiceProduct = query.SingleOrDefault();
                invoiceProduct.InvoiceProduct_Count = newCount;
                db.SaveChanges();
            }
        }



    }
}
