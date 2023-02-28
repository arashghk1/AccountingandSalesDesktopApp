using BussinesLogicLayer;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace AccountingAndSales.Windows
{
    /// <summary>
    /// Interaction logic for DefindUsers_Window.xaml
    /// </summary>
    public partial class ShowingProduct_Windows : Window
    {
        public ShowingProduct_Windows()
        {
            InitializeComponent();
        }
        BLL_Product product = new BLL_Product();
        private void rectang_1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void BtnShowProductPriceManagment(object sender, RoutedEventArgs e)
        {
            object item = ShowingProductDataGrid.SelectedItem;
            ProductPriceManagment_Window productPriceManagment_Window = new ProductPriceManagment_Window();
            productPriceManagment_Window.ProductName = (ShowingProductDataGrid.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
            productPriceManagment_Window.ProductID = Convert.ToInt32((ShowingProductDataGrid.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text);
            productPriceManagment_Window.ShowDialog();
            ShowingProductDataGrid.ItemsSource = product.productRead();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ShowingProductDataGrid.ItemsSource = product.productRead();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void BtnInventoryItems(object sender, RoutedEventArgs e)
        {
            object item = ShowingProductDataGrid.SelectedItem;
            ShowingProductEntryAndExit_Window showingProductEntryAndExit_Window = new ShowingProductEntryAndExit_Window();
            showingProductEntryAndExit_Window.productName = (ShowingProductDataGrid.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
            showingProductEntryAndExit_Window.productId = Convert.ToInt32((ShowingProductDataGrid.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text);
            showingProductEntryAndExit_Window.ShowDialog();
            ShowingProductDataGrid.ItemsSource = product.productRead();
        }

        private void Btn_NewProductRegister(object sender, RoutedEventArgs e)
        {
            Product_RegisterAndEdit_Windows product_RegisterAndEdit_Windows = new Product_RegisterAndEdit_Windows();
            product_RegisterAndEdit_Windows.Windews_Type = 1;
            product_RegisterAndEdit_Windows.ShowDialog();
            ShowingProductDataGrid.ItemsSource = null;
            ShowingProductDataGrid.ItemsSource = product.productRead();
        }

        private void Btn_EditProduct(object sender, RoutedEventArgs e)
        {
            Object Item = ShowingProductDataGrid.SelectedItem;
            if (Item == null)
            {
                MessageBox.Show("Please Selected Product And Edit.", "Selected Product Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            Product_RegisterAndEdit_Windows product_RegisterAndEdit_Windows = new Product_RegisterAndEdit_Windows();


            product_RegisterAndEdit_Windows.Windews_Type = 2;
            product_RegisterAndEdit_Windows.ProductID = Convert.ToInt32((ShowingProductDataGrid.SelectedCells[0].Column.GetCellContent(Item) as TextBlock).Text);
            product_RegisterAndEdit_Windows.ProductName = (ShowingProductDataGrid.SelectedCells[1].Column.GetCellContent(Item) as TextBlock).Text;
            product_RegisterAndEdit_Windows.ProductDescription = (ShowingProductDataGrid.SelectedCells[6].Column.GetCellContent(Item) as TextBlock).Text;
            
            product_RegisterAndEdit_Windows.ShowDialog();



            ShowingProductDataGrid.ItemsSource = null;
            ShowingProductDataGrid.ItemsSource = product.productRead();
            ShowingProductDataGrid.Items.Refresh();
        }

        private void Btn_DeleteProduct(object sender, RoutedEventArgs e)
        {

        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            ShowingProductDataGrid.ItemsSource = product.ShearchProductWithString(SearchTextBox.Text.Trim());
        }

        private void QuantityComboBox_DropDownClosed(object sender, EventArgs e)
        {
            if (QuantityComboBox.SelectedIndex == 0)
            {
                ShowingProductDataGrid.ItemsSource = product.SearchAvailableProduct();
            }
            else if (QuantityComboBox.SelectedIndex == 1)
            {
                ShowingProductDataGrid.ItemsSource = product.SearchNon_AvailableProduct();
            }
            else
            {
                ShowingProductDataGrid.ItemsSource = null;
                ShowingProductDataGrid.ItemsSource = product.productRead();
            }
        }

        private void ImageSearchMouseDown(object sender, MouseButtonEventArgs e)
        {
            SearchTextBox.Focus();
        }

        private void Window_Activated(object sender, EventArgs e)
        {
           
           

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete the Product?", "Delete Message", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    Object Item = ShowingProductDataGrid.SelectedItem;
                    int ProductID = Convert.ToInt32((ShowingProductDataGrid.SelectedCells[0].Column.GetCellContent(Item) as TextBlock).Text);
                    int AvaiableCount =Convert.ToInt32((ShowingProductDataGrid.SelectedCells[3].Column.GetCellContent(Item) as TextBlock).Text);
                    if (AvaiableCount > 0)
                    {
                        MessageBox.Show("The Desired Item Is In Stock, You Cannot Delete It.", "Delete Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }

                    product.DeleteProduct(ProductID);
                    MessageBox.Show("Product Is Deleted Success.", "User Delete", MessageBoxButton.OK, MessageBoxImage.Information);
                    ShowingProductDataGrid.ItemsSource = product.productRead();
                }
                catch (Exception EX)
                {
                    MessageBox.Show(EX.Message, "Delete System Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                return;
            }
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
            
        }
        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
        }

        private void ShowingProductDataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ShowingProductDataGrid.ItemsSource = null;
            ShowingProductDataGrid.ItemsSource = product.productRead();
            ShowingProductDataGrid.Items.Refresh();
        }
    }
}
