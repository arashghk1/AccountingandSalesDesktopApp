using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinesEntity;
using DataAccessLayer;

namespace BussinesLogicLayer
{
    public class BLL_Invoice
    {
        DAL_Invoice DAL_invoice = new DAL_Invoice();

        public void Create(Table_Invoice invoice)
        {
            DAL_invoice.Create(invoice);
        }
        public Table_Invoice ReadLastedInvoiceID()
        {
            return DAL_invoice.ReadLastedInvoiceID();
        }
        public void UpdateInvoiceProductFinishPrice(int InvoiceID, Table_Invoice NewInvoice)
        {
            DAL_invoice.UpdateInvoiceProductFinishPrice(InvoiceID , NewInvoice);
        }
        public List<View_Invoice> ReadAll(int userID)
        {
            return DAL_invoice.ReadAll(userID);
        }
        public void updateInvoiceType(int invoiceID, bool newInvoiceType)
        {
            DAL_invoice.updateInvoiceType(invoiceID , newInvoiceType);
        }
        public List<Sp_SellingChart_Result> Read3InvoiceForSalesChart()
        {            
            return DAL_invoice.Read3InvoiceForSalesChart();
        }
        public List<sp_SalesChart_By_TotalPriceAnyCustomer_Result> ReadTotalPriceForAnyCustomer()
        {
            return DAL_invoice.ReadTotalPriceForAnyCustomer();
        }

    }
}
