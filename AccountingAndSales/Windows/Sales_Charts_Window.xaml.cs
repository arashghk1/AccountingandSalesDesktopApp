using System.Windows;
using BussinesLogicLayer;
using AccountingAndSales.Views;
using System.Windows.Controls;

namespace AccountingAndSales.Windows
{
    /// <summary>
    /// Interaction logic for Sales_Charts_Window.xaml
    /// </summary>
    public partial class Sales_Charts_Window : Window
    {
        public Sales_Charts_Window()
        {
            InitializeComponent();
        }


        BLL_Invoice bLL_Invoice = new BLL_Invoice();

        private void Image_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        TabItem _tabUserPage;
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            if (SaleChartByDate_RadioButton.IsChecked == true)
            {
               MainTab.Items.Clear();
                var SalesChartByDate_UserControl = new SalesChart_View();
                _tabUserPage = new TabItem() { Content = SalesChartByDate_UserControl };
                MainTab.Items.Add(_tabUserPage);
                MainTab.Items.Refresh();

            }
            else if (SalesChartByCustomerName_RadioButton.IsChecked == true)
            {
                MainTab.Items.Clear();
                var SalesChartByCustomerName_UserControl = new SalesChartByCustomerName_View();
                _tabUserPage = new TabItem() { Content = SalesChartByCustomerName_UserControl };
                MainTab.Items.Add(_tabUserPage);
                MainTab.Items.Refresh();


            }
        }
        private void Rectangle_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
