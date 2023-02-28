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
using BussinesLogicLayer;
using AccountingAndSales.Module;
using System.Text.RegularExpressions;
using System.Transactions;

namespace AccountingAndSales.Windows
{
/// <summary>
    /// Interaction logic for DefindUsers_Window.xaml
/// </summary>
    public partial class TransactionInProduct_AddAndEdit : Window
    {
        public TransactionInProduct_AddAndEdit()
        {
            InitializeComponent();
        }
        public string ProductName;
        public int ProductID;
        BLL_Inventory BLL_inventory= new BLL_Inventory();
        private bool CheckNullable()
        {
            if (QuantityTextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please Fill In The Buying Price Field!!!");
                QuantityTextBox.Focus();
                return false;
            }
            return true;
        }

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
            if (!CheckNullable())
            {
                return;
            }
            using (TransactionScope transactionScope = new TransactionScope())
            {
                try
                {
                    //---------------------------------------------------- Create New Transaction:  <===
                    Table_Inventory inventory = new Table_Inventory();
                    inventory.Inventory_Date = RegisterDate.ToString("dd/MM/yyyy");
                    inventory.Inventory_Description =DescriptionTextBox.Text.Trim();
                    inventory.User_ID = PublicVariable.GetUserID; 
                    inventory.Product_ID =this.ProductID;
                    if (QuantityTypeComboBox.SelectedIndex == 0)
                    {
                        inventory.Inventory_Count = Convert.ToInt32(QuantityTextBox.Text.Trim());
                    }
                    else if (QuantityTypeComboBox.SelectedIndex == 1)
                    {
                        inventory.Inventory_Count = -Convert.ToInt32(QuantityTextBox.Text.Trim());
                    }

                    BLL_inventory.Create(inventory);

                    //----------------------------------------------------- Update Old Quantity To New Quantity:   <===
                    BLL_inventory.UpdateInventoryCount(Convert.ToInt32(inventory.Inventory_Count) , this.ProductID);
                    //-------------------------------------------------------
                    transactionScope.Complete();    
                    MessageBox.Show("New Transaction Register Success.");



                }
                catch (Exception)
                {
                    MessageBox.Show("Transaction Register Is Problem.Please Try Again.");
                }
                finally
                {
                    this.Close();
                }

            }


        }

        private void PriceBuying_PreViewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void PriceSelling_PreviewTextInput_Event(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            QuantityTextBox.Focus();
            UserRegisterationFullName_Label.Content = PublicVariable.GetUserName + " " + PublicVariable.GetUserFamily;
            ProductNameLable.Content = this.ProductName;
        }
    }
}
