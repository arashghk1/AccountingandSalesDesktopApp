using System;
using System.Collections.ObjectModel;
using BussinesLogicLayer;


namespace AccountingAndSales.Models
{
    public class SalesChart_Model
    {
        public string Argument { get; set; }
        public double? Value { get; set; }
        public static ObservableCollection<SalesChart_Model> GetDataPoints()
        {
            BLL_Invoice bll_invoice = new BLL_Invoice();
            var result = bll_invoice.Read3InvoiceForSalesChart();
            ObservableCollection<SalesChart_Model> FillData = new ObservableCollection<SalesChart_Model>();

            for (int i = 0; i < result.Count; i++)
            {
                FillData.Add(new SalesChart_Model() { Argument = result[i].Invoice_DateTime, Value = result[i].TotalPriceForDay });
            }
            return FillData;
        }

    }


}
