using System;
using System.Windows;
using System.Windows.Controls;
using BussinesEntity;
using BussinesLogicLayer;
using AccountingAndSales.Module;
using System.Transactions;
using System.Text.RegularExpressions;

namespace AccountingAndSales.Windows
{
    /// <summary>
    /// Interaction logic for Invoice_Window.xaml
    /// </summary>
    public partial class Invoice_Window : Window
    {
        public Invoice_Window()
        {
            InitializeComponent();
        }
        BLL_Customer bll_customer = new BLL_Customer();
        BLL_Product bll_product = new BLL_Product();
        BLL_Invoice bll_invoice=new BLL_Invoice();
        BLL_Inventory bll_inventory = new BLL_Inventory();  
        DateTime RegisterDate = DateTime.Now;
        BLL_InvoiceProduct bll_invoiceProduct = new BLL_InvoiceProduct();

        //-------------------------------------------------------

        public int InvoiceID { get; set; }
        public string CustomerName { get; set; }
        public long Invoice_BuyingPrice { get; set; }
        public long Invoice_SellingPrice { get; set; }
        public string InvoiceDateTime { get; set; }
        public byte Windows_Type { get; set; }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //----------------------------------------------

            switch (Windows_Type)
            {
                case 1:
                {
                        //---------------------------------------------------
                        ShowingCustomerDataGrid.ItemsSource = null;
                        ShowingCustomerDataGrid.ItemsSource = bll_customer.CustomerReadAll();
                        //-------------------------------------------------------------------
                        ShowingProductDataGrid.ItemsSource = null;
                        ShowingProductDataGrid.ItemsSource = bll_product.productRead();
                        //------------------------------------------------------------------
                        ShowInvoiceInformation();
                        break;
                }

                case 2:
                {

                    Btn_CreateInvoice.Visibility = Visibility.Hidden;
                    SearchTextBoxCustomer.Visibility = Visibility.Hidden;
                    SaerchTextBoxTextBlock.Visibility = Visibility.Hidden;
                    Btn_ProductAddedInInvoice.IsEnabled = true;
                    //-----------------------------------------------------------------
                    ShowingCustomerDataGrid.ItemsSource = null;
                    ShowingCustomerDataGrid.ItemsSource = bll_customer.CustomerReadAll();
                    ShowingCustomerDataGrid.IsEnabled = false;
                    //-------------------------------------------------------------------
                    ShowingProductDataGrid.ItemsSource = bll_product.productRead();
                    //------------------------------------------------------------------
                    ShowingAddedProductDataGrid.ItemsSource = bll_invoiceProduct.ReadInvoiceProductWhitInvoiceId(InvoiceID);
                    //-------------------------------------
                    DateTimeLabel.Content = InvoiceDateTime;
                    SystemUserRegisterNameLabel.Content =PublicVariable.GetUserName + " " + PublicVariable.GetUserFamily;
                    CustomerNameLabel.Content = CustomerName;
                    InvoiceIDLabel.Content = InvoiceID;
                    TotalBuyingPriceLabel.Content = Invoice_BuyingPrice;
                    TotalPriceLabel.Content = Invoice_SellingPrice;
                    break;
                }
            }





        }
        private void ShowInvoiceInformation()
        {
            SystemUserRegisterNameLabel.Content = PublicVariable.GetUserName + " " + PublicVariable.GetUserFamily;
            DateTimeLabel.Content = RegisterDate.ToString("dd/MM/yyyy  | HH:MM:ss");
                 
        }
        private void Image_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void Header_Rectangle_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Btn_CreateInvoice_Click(object sender, RoutedEventArgs e)
        {
            Object Item = ShowingCustomerDataGrid.SelectedItem;
            if (Item == null)
            {
                MessageBox.Show("Please Selected Customer For Create Invoice", "Customer Selected Invoice", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            using (TransactionScope scope = new TransactionScope())
            {

                try
                {

                    Table_Invoice invoice = new Table_Invoice();

                    invoice.Customer_ID = Convert.ToInt32((ShowingCustomerDataGrid.SelectedCells[0].Column.GetCellContent(Item) as TextBlock).Text);
                    invoice.Invoice_Price = 0;
                    invoice.Invoice_BuyingPrice = 0;
                    invoice.Invoice_DateTime = RegisterDate.ToString("dd/MM/yyyy");
                    invoice.User_ID = PublicVariable.GetUserID;
                    bll_invoice.Create(invoice);



                    //---------------------------------------------- Showing Factor Information In Label:  <---

                    CustomerNameLabel.Content = (ShowingCustomerDataGrid.SelectedCells[1].Column.GetCellContent(Item) as TextBlock).Text;
                    InvoiceIDLabel.Content = bll_invoice.ReadLastedInvoiceID().Invoice_ID;
                    scope.Complete();
                }
                catch
                {
                    MessageBox.Show("Create Invoice Is Problem Please Try Again", "Invoice Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                finally
                {
                    Btn_CreateInvoice.IsEnabled = false;
                    Btn_ProductAddedInInvoice.IsEnabled = true;
                }


            }
        }


        private void ShowingProductDataGrid_PreviewMouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
           


        }

        private void ProductCountQuantity_TextBox_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        public long ProductSellingPrice { get; set; }
        public long ProductBuyingPrice { get; set; }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Object item = ShowingProductDataGrid.SelectedItem;

            if (item == null)
            {
                MessageBox.Show("Please Selected Product And Add To List", "Product Selected Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            int ProductCountOrder = 0;
            // --------------------------------------------- Check Product Quantity:
            if (ProductCountQuantity_TextBox.Text == string.Empty)
            {
                if (MessageBox.Show("The Number Of Products Is Considered 1. Do you Agree?" , "Considered" , MessageBoxButton.YesNo , MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    ProductCountOrder = 1;
                    ProductCountQuantity_TextBox.Text = "1";
                }
                else
                {
                    return;
                }
            }
            else
            {
                ProductCountOrder = Convert.ToInt32(ProductCountQuantity_TextBox.Text);
            }
            int ProductStock = Convert.ToInt32((ShowingProductDataGrid.SelectedCells[4].Column.GetCellContent(item) as TextBlock).Text);
            if (ProductCountOrder > ProductStock)
            {
                MessageBox.Show("The quantity ordered is more than the inventory", "Quantity Order Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            
            
            try
            {
                // -------------------------------------------
                var selectInvoiceItem =bll_invoiceProduct.ReadInvoiceProductWhitInvoiceId(bll_invoice.ReadLastedInvoiceID().Invoice_ID);
                var productIdForCheck = Convert.ToInt32((ShowingProductDataGrid.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text);

                foreach (var t in selectInvoiceItem)
                {
                    if (t.Product_ID == productIdForCheck)
                    {

                        int? QuantityResult = t.InvoiceProduct_Count + Convert.ToInt32(ProductCountQuantity_TextBox.Text);
                        bll_invoiceProduct.UpdateInvoiceProductCount(t.InvoiceProduct_ID, QuantityResult);
                        ShowingAddedProductDataGrid.ItemsSource = null;
                        ShowProductOrderd();
                        return;
                    }
                }

                
                // ------------------------------------------ Create New Invoice Product In Table <--

                Table_InvoiceProduct inbInvoiceProduct = new Table_InvoiceProduct();
                inbInvoiceProduct.InvoiceProduct_Count = Convert.ToInt32(ProductCountQuantity_TextBox.Text);
                inbInvoiceProduct.InvoiceProduct_SellingPrice = Convert.ToInt64((ShowingProductDataGrid.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text);              
                ProductSellingPrice = Convert.ToInt64((ShowingProductDataGrid.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text);
                ProductBuyingPrice = Convert.ToInt64((ShowingProductDataGrid.SelectedCells[3].Column.GetCellContent(item) as TextBlock).Text);
                inbInvoiceProduct.InvoiceProduct_BuyingPrice = Convert.ToInt64((ShowingProductDataGrid.SelectedCells[3].Column.GetCellContent(item) as TextBlock).Text);              
                inbInvoiceProduct.Product_ID =Convert.ToInt32((ShowingProductDataGrid.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text);               
                inbInvoiceProduct.Invoice_ID = bll_invoice.ReadLastedInvoiceID().Invoice_ID;
                bll_invoiceProduct.Create(inbInvoiceProduct);

                // ------------------------------------------------------ Update Product Quantity <--
                bll_inventory.UpdateInventoryCount(-Convert.ToInt32(ProductCountQuantity_TextBox.Text.Trim()) , Convert.ToInt32(inbInvoiceProduct.Product_ID));

                // ----------------------------------------------------- Send To DataGrid <--
                ShowProductOrderd();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            finally
            {
                ShowingProductDataGrid.ItemsSource = bll_product.productRead();
                TotalPriceLabel.Content = "0";
                TotalPriceLabel.Content = Convert.ToInt64(TotalPriceLabel.Content) + (Convert.ToInt64(ProductCountQuantity_TextBox.Text) * ProductSellingPrice);
                TotalBuyingPriceLabel.Content = Convert.ToInt64(TotalBuyingPriceLabel.Content) +(Convert.ToInt64(ProductCountQuantity_TextBox.Text) * ProductBuyingPrice);
                ProductCountQuantity_TextBox.Text = "";
                Btn_ProductDeleteInInvoice.IsEnabled = true;
                Btn_ClosedInvoice.IsEnabled = true;

            }




        }

        private void ShowProductOrderd()
        {
            var resultAddedProduct =  bll_invoiceProduct.ReadInvoiceProductWhitInvoiceId(bll_invoice.ReadLastedInvoiceID().Invoice_ID);
            ShowingAddedProductDataGrid.ItemsSource = null;
            ShowingAddedProductDataGrid.ItemsSource = resultAddedProduct;

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            using (TransactionScope transaction=new TransactionScope())
            {
                // Product Delete:
                if (MessageBox.Show("Are you sure to remove the product?", "Delete Questions", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    try
                    {
                        Object item = ShowingAddedProductDataGrid.SelectedItem;
                        int productIdIsSelected = Convert.ToInt32((ShowingAddedProductDataGrid.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text);
                        int invoiceIdIsSelected = bll_invoice.ReadLastedInvoiceID().Invoice_ID;
                        int GetProductQuantity = Convert.ToInt32((ShowingAddedProductDataGrid.SelectedCells[4].Column.GetCellContent(item) as TextBlock).Text);
                        long GetProductPrice = Convert.ToInt64((ShowingAddedProductDataGrid.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text);
                        long GetProductBuyingPrice = Convert.ToInt64((ShowingAddedProductDataGrid.SelectedCells[3].Column.GetCellContent(item) as TextBlock).Text);
                        if (item == null)
                        {
                            MessageBox.Show("Please Selected Product And Deleted.", "Product Selected Error", MessageBoxButton.OK,
                                MessageBoxImage.Error);
                            return;
                        }
                        bll_invoiceProduct.DeleteInvoiceProductInFactor(productIdIsSelected, invoiceIdIsSelected);
                        ShowingAddedProductDataGrid.ItemsSource = bll_invoiceProduct.ReadInvoiceProductWhitInvoiceId(invoiceIdIsSelected);
                        //---------------------------------- Update Quantity:
                        bll_inventory.UpdateInventoryCount(GetProductQuantity, productIdIsSelected);
                        //---------------------------------- Update Invoice DataGrid
                        ShowingProductDataGrid.ItemsSource = bll_product.productRead();
                        //-------------------------------- Update Invoice Total Price:
                        TotalPriceLabel.Content = Convert.ToInt64(TotalPriceLabel.Content) -(GetProductPrice * GetProductQuantity);
                        TotalBuyingPriceLabel.Content = Convert.ToInt64(TotalBuyingPriceLabel.Content) -(GetProductBuyingPrice * GetProductQuantity);
                        transaction.Complete();
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception);
                    }
                }
            }
           

            





        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are You Sure Finished The Factor?" , "Finish Factor" , MessageBoxButton.YesNo , MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    Table_Invoice newInvoicePrice = new Table_Invoice();
                    newInvoicePrice.Invoice_Price = Convert.ToInt64(TotalPriceLabel.Content);
                    newInvoicePrice.Invoice_BuyingPrice = Convert.ToInt64(TotalBuyingPriceLabel.Content);
                    newInvoicePrice.Invoice_Type = true;
                    bll_invoice.UpdateInvoiceProductFinishPrice(bll_invoice.ReadLastedInvoiceID().Invoice_ID, newInvoicePrice);
                    MessageBox.Show("Factor Register Is Success.", "Register Success", MessageBoxButton.OK,MessageBoxImage.Information);
                }
                catch (Exception exception)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 
                {
                    Console.WriteLine(exception);
                }
                finally
                {
                    ShowingAddedProductDataGrid.ItemsSource = null;
                    ShowingCustomerDataGrid.ItemsSource = bll_customer.CustomerReadAll();
                    ShowingProductDataGrid.ItemsSource = bll_product.productRead();
                    PublicMethod.ClearAllTextboxAndLabelInFactorWindow(ContainerLablePanel);
                    Btn_CreateInvoice.IsEnabled = true;
                    Btn_ProductAddedInInvoice.IsEnabled = false;
                    Btn_ProductDeleteInInvoice.IsEnabled = false;
                    Btn_ClosedInvoice.IsEnabled = false;

                }
             
            }
        }
    }
}
