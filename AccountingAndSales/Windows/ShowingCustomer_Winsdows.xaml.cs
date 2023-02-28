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
    public partial class ShowingCustomer_Windows : Window
    {
        public ShowingCustomer_Windows()
        {
            InitializeComponent();
        }
        BLL_Customer customer = new BLL_Customer();
        private void rectang_1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ShowingCustomerDataGrid.ItemsSource = null;
            ShowingCustomerDataGrid.ItemsSource = customer.CustomerReadAll();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_CustomerRegisteration(object sender, RoutedEventArgs e)
        {
            Customer_RegisterAndEdit_Windows customer_RegisterAndEdit_Windows = new Customer_RegisterAndEdit_Windows();
            customer_RegisterAndEdit_Windows.WindowsType = 1; // 1 Is Means Add Customer.
            customer_RegisterAndEdit_Windows.ShowDialog();
            ShowingCustomerDataGrid.ItemsSource = customer.CustomerReadAll();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Object Item = ShowingCustomerDataGrid.SelectedItem;
            Customer_RegisterAndEdit_Windows customer_RegisterAndEdit_Windows = new Customer_RegisterAndEdit_Windows();
            if (Item == null)
            {
                MessageBox.Show("Please Select Customer For Update.");
                return;
            }
            customer_RegisterAndEdit_Windows.WindowsType = 2; // 1 Is Means Update Or Edit Customer.
            customer_RegisterAndEdit_Windows.Customer_id = Convert.ToInt32((ShowingCustomerDataGrid.SelectedCells[0].Column.GetCellContent(Item) as TextBlock).Text);
            customer_RegisterAndEdit_Windows.Customer_Name = (ShowingCustomerDataGrid.SelectedCells[1].Column.GetCellContent(Item) as TextBlock).Text;
            customer_RegisterAndEdit_Windows.Customer_Address = (ShowingCustomerDataGrid.SelectedCells[2].Column.GetCellContent(Item) as TextBlock).Text;
            customer_RegisterAndEdit_Windows.Customer_Tel = (ShowingCustomerDataGrid.SelectedCells[3].Column.GetCellContent(Item) as TextBlock).Text;



            customer_RegisterAndEdit_Windows.ShowDialog();
            ShowingCustomerDataGrid.ItemsSource = customer.CustomerReadAll();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to delete the Customer?", "Delete Message", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    Object Item = ShowingCustomerDataGrid.SelectedItem;
                    int CustomerID = Convert.ToInt32((ShowingCustomerDataGrid.SelectedCells[0].Column.GetCellContent(Item) as TextBlock).Text);
                    customer.DeleteCustomer(CustomerID);
                    MessageBox.Show("Customer Is Deleted Success.", "User Delete", MessageBoxButton.OK, MessageBoxImage.Information);
                    ShowingCustomerDataGrid.ItemsSource = customer.CustomerReadAll();
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

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete the Customer?", "Delete Message", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    Object Item = ShowingCustomerDataGrid.SelectedItem;
                    if (Item == null)
                    {
                        MessageBox.Show("Please Selected Customer For Delete.", "Customer Select Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    int CustomerID = Convert.ToInt32((ShowingCustomerDataGrid.SelectedCells[0].Column.GetCellContent(Item) as TextBlock).Text);
                    customer.DeleteCustomer(CustomerID);
                    MessageBox.Show("Customer Is Deleted Success.", "User Delete", MessageBoxButton.OK, MessageBoxImage.Information);
                    ShowingCustomerDataGrid.ItemsSource = customer.CustomerReadAll();
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
    }
}
