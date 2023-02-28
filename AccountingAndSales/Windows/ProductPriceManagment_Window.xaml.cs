using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using BussinesEntity;
using System.Data.Entity;
using BussinesLogicLayer;

namespace AccountingAndSales.Windows
{
/// <summary>
    /// Interaction logic for DefindUsers_Window.xaml
/// </summary>
    public partial class ProductPriceManagment_Window : Window
    {
        public ProductPriceManagment_Window()
        {
            InitializeComponent();
        }
        BLL_ProductPrice productPrice=new BLL_ProductPrice();
        public string ProductName;
        public int ProductID;
        

        private void rectang_1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LabelProductName.Content = ProductName;
            ShowingProductPriceManagmentDataGrid.ItemsSource = productPrice.ProductPriceManagementReadByID(ProductID);
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {   
            this.Close();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {

            ProductPrice_RegisterAndEdit_Windows productPrice_RegisterAndEdit_Windows = new ProductPrice_RegisterAndEdit_Windows();
            productPrice_RegisterAndEdit_Windows.Windows_Type = 1;
            productPrice_RegisterAndEdit_Windows.ProductName = this.ProductName;
            productPrice_RegisterAndEdit_Windows.ProductID = this.ProductID;
            productPrice_RegisterAndEdit_Windows.ShowDialog();
            ShowingProductPriceManagmentDataGrid.ItemsSource = productPrice.ProductPriceManagementReadByID(ProductID);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            Object Item = ShowingProductPriceManagmentDataGrid.SelectedItem;

            ProductPrice_RegisterAndEdit_Windows productPrice_RegisterAndEdit_Windows = new ProductPrice_RegisterAndEdit_Windows();

            productPrice_RegisterAndEdit_Windows.Windows_Type = 2;
            if (Item == null)
            {
                MessageBox.Show("Please Selected Product For Edit Price.", "Select Product Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            productPrice_RegisterAndEdit_Windows.ProductPrice_ID = Convert.ToInt32((ShowingProductPriceManagmentDataGrid.SelectedCells[0].Column.GetCellContent(Item) as TextBlock).Text);
            productPrice_RegisterAndEdit_Windows.PriceBuying = Convert.ToInt64((ShowingProductPriceManagmentDataGrid.SelectedCells[1].Column.GetCellContent(Item) as TextBlock).Text);
            productPrice_RegisterAndEdit_Windows.priceSellign = Convert.ToInt64((ShowingProductPriceManagmentDataGrid.SelectedCells[2].Column.GetCellContent(Item) as TextBlock).Text);
            productPrice_RegisterAndEdit_Windows.Des = (ShowingProductPriceManagmentDataGrid.SelectedCells[4].Column.GetCellContent(Item) as TextBlock).Text;

            productPrice_RegisterAndEdit_Windows.ShowDialog();
            ShowingProductPriceManagmentDataGrid.ItemsSource = productPrice.ProductPriceManagementReadByID(ProductID);
        }
    }
}
