using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BussinesEntity;
using System.Collections.ObjectModel;

namespace DataAccessLayer
{
    public class DAL_Invoice
    {
        AccountingAndSales_DBEntities db=new AccountingAndSales_DBEntities();

        public void Create(Table_Invoice invoice)
        {
            db.Table_Invoice.Add(invoice);
            db.SaveChanges();
        }
        public Table_Invoice ReadLastedInvoiceID()
        {
            var Query = db.Table_Invoice.OrderByDescending(i => i.Invoice_ID).First();
            return Query;
        }
        public void UpdateInvoiceProductFinishPrice(int InvoiceID ,Table_Invoice NewInvoice)
        {
            var query = db.Table_Invoice.Where(i => i.Invoice_ID == InvoiceID).SingleOrDefault();
            Table_Invoice invoice = new Table_Invoice();
            invoice = query;
            invoice.Invoice_Price = NewInvoice.Invoice_Price;
            invoice.Invoice_BuyingPrice =NewInvoice.Invoice_BuyingPrice;
            invoice.Invoice_Type = NewInvoice.Invoice_Type;
            db.SaveChanges();
        }
        public List<View_Invoice> ReadAll(int userID)
        {
            var query = db.View_Invoice.Where(i => i.User_ID == userID).ToList();
            return query;
        }
        public void updateInvoiceType(int invoiceID, bool newInvoiceType)
        {
            var query = db.Table_Invoice.Where(i => i.Invoice_ID == invoiceID).SingleOrDefault();
            query.Invoice_Type = newInvoiceType;
            db.SaveChanges();

        }
        public List<Sp_SellingChart_Result> Read3InvoiceForSalesChart()
        {
            var query =  db.Sp_SellingChart();
            return query.ToList();
        }
        public List<sp_SalesChart_By_TotalPriceAnyCustomer_Result> ReadTotalPriceForAnyCustomer()
        {
            var query = db.sp_SalesChart_By_TotalPriceAnyCustomer();
            return query.ToList();
        }

    }
}
