using System.Collections.ObjectModel;
using AccountingAndSales.Models;

namespace AccountingAndSales.ViewModel
{
    public class SalesChartByCustomerName_ViewModel
    {

        public ObservableCollection<SalesChart_Model> Data { get; private set; }


        public SalesChartByCustomerName_ViewModel()
        {
            this.Data = SalesChartByCustomerName_Model.GetDataPoints();
        }
    }
}
