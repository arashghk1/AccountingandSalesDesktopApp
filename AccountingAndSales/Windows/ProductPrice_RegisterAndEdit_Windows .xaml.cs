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
    public partial class ProductPrice_RegisterAndEdit_Windows : Window
    {
        public ProductPrice_RegisterAndEdit_Windows()
        {
            InitializeComponent();
        }
        public string ProductName;
        public int ProductID;
        BLL_ProductPrice BLL_productPrice = new BLL_ProductPrice();

        public byte Windows_Type { get; set; }
        public int ProductPrice_ID { get; set; }
        public Int64 PriceBuying { get; set; }
        public Int64 priceSellign { get; set; }
        public string Des { get; set; }

        private bool CheckNullable()
        {
            if (PriceBuyingTextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please Fill In The Buying Price Field!!!");
                PriceBuyingTextBox.Focus();
                return false;
            }
            else if (PriceSellingTextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please Fill In The Selling Price Field!!!");
                PriceSellingTextBox.Focus();
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
            switch (Windows_Type)
            {
                case 2:
                    {
                        LabelProductPrice_RegisterAndEdit_Header.Content = "Product Price Edit";
                        Btn_SaveAndEdit.Content = "Edit Price";
                        PriceBuyingTextBox.Text =this.PriceBuying.ToString();
                        PriceSellingTextBox.Text = this.priceSellign.ToString();
                        DescriptionTextBox.Text = this.Des;
                        break;
                    }
                    
            }

            PriceBuyingTextBox.Focus();
            UserRegisterationFullName_Label.Content = PublicVariable.GetUserName + " " + PublicVariable.GetUserFamily;
            ProductNameLable.Content = this.ProductName;
        }
        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnSaveAndEdit_Click(object sender, RoutedEventArgs e)
        {
            DateTime RegisterDate = DateTime.Now;
            if (!CheckNullable())
            {
                return;
            }
            switch (Windows_Type)
            {

                case 1:
                    {
                        using (TransactionScope transactionScope = new TransactionScope())
                        {
                            try
                            {

                                //---------------------------------------------------- Create New Price:  <===
                                Table_ProductPriceManagment productPrice = new Table_ProductPriceManagment();
                                productPrice.ProductPiceManagment_Buying = Convert.ToInt32(PriceBuyingTextBox.Text.Trim());
                                productPrice.ProductPiceManagment_Selling = Convert.ToInt32(PriceSellingTextBox.Text.Trim());
                                productPrice.ProductPiceManagment_Dsc = DescriptionTextBox.Text.Trim();
                                productPrice.ProductPiceManagment_Date = RegisterDate.ToString("dd/MM/yyyy");
                                productPrice.Product_ID = this.ProductID;
                                productPrice.User_ID = PublicVariable.GetUserID;
                                BLL_productPrice.Register(productPrice);
                                //----------------------------------------------------- Update Old Price To New Price:   <===
                                BLL_productPrice.UpdateProductLastPrice(this.ProductID, Convert.ToInt64(PriceSellingTextBox.Text) , Convert.ToInt32(PriceBuyingTextBox.Text.Trim()));

                                //------------------------------------------------------
                                transactionScope.Complete();
                                MessageBox.Show("New Product Price Register Success.", "Success Price Register", MessageBoxButton.OK, MessageBoxImage.Information);
                                
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Is Problem.", "Exception Not Save", MessageBoxButton.OK, MessageBoxImage.Error);
                            }
                            finally
                            {
                                this.Close();
                            }
                            break;
                        }
                    }
                    
                case 2:
                    {
                        try
                        {
                            Table_ProductPriceManagment productPrice = new Table_ProductPriceManagment();
                            productPrice.ProductPiceManagment_Buying = Convert.ToInt32(PriceBuyingTextBox.Text.Trim());
                            productPrice.ProductPiceManagment_Selling = Convert.ToInt32(PriceSellingTextBox.Text.Trim());
                            productPrice.ProductPiceManagment_Dsc = DescriptionTextBox.Text.Trim();
                            BLL_productPrice.update(this.ProductPrice_ID, productPrice);
                            MessageBox.Show("Product Price Edit Is Success.", "Success Price Update", MessageBoxButton.OK, MessageBoxImage.Information);
                           
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Is Problem.", "Exception Not Save", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                        finally
                        {
                            this.Close();
                        }
                        break;
                    }            
            }
        }
    }
}
