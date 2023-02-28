using AccountingAndSales.Models;
using System.Collections.ObjectModel;
using System.Windows;

namespace AccountingAndSales.ViewModel
{
    public class SalesChart_ViewModel
    {
        public ObservableCollection<SalesChart_Model> Data { get; private set; }


        public SalesChart_ViewModel()
        {
            this.Data = SalesChart_Model.GetDataPoints();
        }

    }
}
