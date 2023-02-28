using AccountingAndSales.Module;
using BussinesEntity;
using BussinesLogicLayer;
using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;

namespace AccountingAndSales.Windows
{
    /// <summary>
    /// Interaction logic for DefindUsers_Window.xaml
    /// </summary>
    public partial class Customer_RegisterAndEdit_Windows : Window
    {
        public Customer_RegisterAndEdit_Windows()
        {
            InitializeComponent();
        }
        public byte WindowsType;
        public string Customer_Name;
        public string Customer_Address;
        public string Customer_Tel;
        public int Customer_id;
        BLL_Customer customer = new BLL_Customer();
        private void rectang_1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DateTime RegisterDate = DateTime.Now;
            if (CustomerNameTextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please Fill In The Customer Name Field!!!");
                CustomerNameTextBox.Focus();
            }
            else if (CustomerTelphoneTextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please Fill In The Field Related To The Customer's Phone Number!!!");
                CustomerTelphoneTextBox.Focus();
            }
            else
            {
                try
                {
                    switch (WindowsType)
                    {
                        case 1:
                            {

                                Table_Customers table_Customers = new Table_Customers();
                                table_Customers.Customer_FullName = CustomerNameTextBox.Text.Trim();
                                table_Customers.Customer_PhoneNumber = CustomerTelphoneTextBox.Text.Trim();
                                table_Customers.Customer_Address = CustomerAddressTextBox.Text.Trim();
                                table_Customers.Customer_RegisterDate = RegisterDate.ToString("dd/MM/yyyy");
                                table_Customers.User_ID = PublicVariable.GetUserID;
                                table_Customers.Customer_Delete = false;
                                customer.register(table_Customers);
                                MessageBox.Show("Customer Registeration Is Succss.");
                                break;
                            }
                        case 2:
                            {
                                Table_Customers table_Customers = new Table_Customers();
                                table_Customers.Customer_FullName = CustomerNameTextBox.Text.Trim();
                                table_Customers.Customer_PhoneNumber = CustomerTelphoneTextBox.Text.Trim();
                                table_Customers.Customer_Address = CustomerAddressTextBox.Text.Trim(); 
                                table_Customers.Customer_Delete = false;                   
                                customer.Update(this.Customer_id, table_Customers);
                                MessageBox.Show("Customer Update Information Is Succss.");
                                break;
                            }
                    }

                }
                catch (Exception exceptoin)
                {
                    MessageBox.Show("Customer Register Error:\n" + exceptoin.Message);
                }
                finally
                {
                    this.Close();
                }
            }


        }

        private void CustomerTelphoneTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CustomerNameTextBox.Focus();
            UserRegisterationFullName_Label.Content = PublicVariable.GetUserName + " " + PublicVariable.GetUserFamily;

            //----------------------------------------------------------------------------------------------------


            switch (WindowsType)
            {
                case 2:
                    LabelCustomerRegisterHeader.Content = "Customer Edit";
                    Btn_CustomerRegisterAndEdit.Content = "Customer Edit";
                    CustomerNameTextBox.Text = this.Customer_Name;
                    CustomerTelphoneTextBox.Text = this.Customer_Tel;
                    CustomerAddressTextBox.Text = this.Customer_Address;
                    break;
            }

        }
    }
}
