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
using AccountingAndSales.Windows;
using BussinesLogicLayer;

namespace AccountingAndSales.Windows
{
    /// <summary>
    /// Interaction logic for DefindUsers_Window.xaml
    /// </summary>
    public partial class ShowingProductEntryAndExit_Window : Window
    {
        public ShowingProductEntryAndExit_Window()
        {
            InitializeComponent();
        }
        public string productName;
        public int productId;   
        BLL_Inventory inventory=new BLL_Inventory(); 
        private void rectang_1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void BtnShowProductPriceManagment(object sender, RoutedEventArgs e)
        {
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ShowingInventoryDataGrid.ItemsSource = null;
            ShowingInventoryDataGrid.ItemsSource = inventory.InventoryReadByProductNameAndID(productId , productName);   
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TransactionInProduct_AddAndEdit transactionInProduct_AddAndEdit = new TransactionInProduct_AddAndEdit();
            transactionInProduct_AddAndEdit.ProductID =this.productId;
            transactionInProduct_AddAndEdit.ProductName = this.productName;
            transactionInProduct_AddAndEdit.ShowDialog();

            // Showing In DataGrid:
            ShowingInventoryDataGrid.ItemsSource = inventory.InventoryReadByProductNameAndID(productId, productName);


        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void BtnInventoryItems(object sender, RoutedEventArgs e)
        {
            ShowingProductEntryAndExit_Window showingProductEntryAndExit_Window = new ShowingProductEntryAndExit_Window();
            showingProductEntryAndExit_Window.ShowDialog();
        }
        private void ComboBoxProduct_DropDownClosed(object sender, EventArgs e)
        {
            if (ComboBoxProduct.SelectedIndex == 0)
            {
                ShowingInventoryDataGrid.ItemsSource = null;
                ShowingInventoryDataGrid.ItemsSource = inventory.InventoryReadByProductNameAndID(productId, productName);
            }
            else if (ComboBoxProduct.SelectedIndex == 1)
            {
                ShowingInventoryDataGrid.ItemsSource = null;
                ShowingInventoryDataGrid.ItemsSource = inventory.InverntoryAvailableProductRead(productId, productName);
            }
            else if (ComboBoxProduct.SelectedIndex == 2)
            {
                ShowingInventoryDataGrid.ItemsSource = null;
                ShowingInventoryDataGrid.ItemsSource = inventory.InverntoryNoneExistentProductRead(productId, productName);
            }

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            ShowingInventoryDataGrid.ItemsSource = null;
            ShowingInventoryDataGrid.ItemsSource = inventory.InventoryReadByStringValue(txtSearchInput.Text , productId, productName);
        }
    }
}
