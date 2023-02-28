using BussinesLogicLayer;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using AccountingAndSales.Module;

namespace AccountingAndSales.Windows
{
    /// <summary>
    /// Interaction logic for DefindUsers_Window.xaml
    /// </summary>
    public partial class ShowingInvoice_Winsdows : Window
    {
        public ShowingInvoice_Winsdows()
        {
            InitializeComponent();
        }

        private BLL_Invoice bll_invoice = new BLL_Invoice();
        private void rectang_1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ShowingInvoiceDataGrid.ItemsSource = null;
            ShowingInvoiceDataGrid.ItemsSource = bll_invoice.ReadAll(PublicVariable.GetUserID);
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Invoice_Window invoiceWindow = new Invoice_Window();
            invoiceWindow.Windows_Type = 1;
            invoiceWindow.ShowDialog();
            ShowingInvoiceDataGrid.ItemsSource = bll_invoice.ReadAll(PublicVariable.GetUserID);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are You sure Return Invoice Selected?" , "Return Invoice" , MessageBoxButton.YesNo , MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    object item = ShowingInvoiceDataGrid.SelectedItem;
                    if (item == null)
                    {
                        MessageBox.Show("Please Selected Invoice For Return!!!", "Selected Error", MessageBoxButton.OK,
                            MessageBoxImage.Error);
                        return;
                        
                    }
                    int InvoiceID =
                        Convert.ToInt32(
                            (ShowingInvoiceDataGrid.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text);
                    bll_invoice.updateInvoiceType(InvoiceID , false);

                    MessageBox.Show("Invoice Is Return Success." , "Return Success" , MessageBoxButton.OK , MessageBoxImage.Information);

                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                }
                finally
                {
                    ShowingInvoiceDataGrid.ItemsSource = bll_invoice.ReadAll(PublicVariable.GetUserID);
                }
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            object item = ShowingInvoiceDataGrid.SelectedItem;
            if (item == null)
            {
                MessageBox.Show("Please Selected Invoice For Edit." , "Selected Invoice Error" , MessageBoxButton.OK , MessageBoxImage.Error);
                return;
            }



            Invoice_Window invoiceWindow = new Invoice_Window();
            invoiceWindow.Windows_Type = 2;

            invoiceWindow.InvoiceID =
                Convert.ToInt32((ShowingInvoiceDataGrid.SelectedCells[0].Column.GetCellContent(item) as TextBlock)
                    .Text);

            invoiceWindow.CustomerName =
                (ShowingInvoiceDataGrid.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;

            invoiceWindow.InvoiceDateTime =
                (ShowingInvoiceDataGrid.SelectedCells[4].Column.GetCellContent(item) as TextBlock).Text;

            invoiceWindow.Invoice_BuyingPrice =
                Convert.ToInt64((ShowingInvoiceDataGrid.SelectedCells[5].Column.GetCellContent(item) as TextBlock)
                    .Text);

            invoiceWindow.Invoice_SellingPrice =
                Convert.ToInt64((ShowingInvoiceDataGrid.SelectedCells[6].Column.GetCellContent(item) as TextBlock)
                    .Text);

            invoiceWindow.ShowDialog();


            ShowingInvoiceDataGrid.ItemsSource = bll_invoice.ReadAll(PublicVariable.GetUserID);


        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
                Object Items = ShowingInvoiceDataGrid.SelectedItem;

                if (Items == null)
                {
                    MessageBox.Show("Please Selected Invoice For Print!!!", "Accounting And Sales Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                else
                {
                    ShowingReport_Window showingReport_Window = new ShowingReport_Window();
                    //Invoice ID
                    int GetInvoiceID = Convert.ToInt32((ShowingInvoiceDataGrid.SelectedCells[0].Column.GetCellContent(Items) as TextBlock).Text);
                    showingReport_Window.Params[0] = (ShowingInvoiceDataGrid.SelectedCells[0].Column.GetCellContent(Items) as TextBlock).Text;
                    //Customer Name
                    showingReport_Window.Params[1] = (ShowingInvoiceDataGrid.SelectedCells[1].Column.GetCellContent(Items) as TextBlock).Text;
                    //Address
                    showingReport_Window.Params[2] = (ShowingInvoiceDataGrid.SelectedCells[2].Column.GetCellContent(Items) as TextBlock).Text;
                    //PhoneNumber
                    showingReport_Window.Params[3] = (ShowingInvoiceDataGrid.SelectedCells[3].Column.GetCellContent(Items) as TextBlock).Text;
                    //Date
                    showingReport_Window.Params[4] = (ShowingInvoiceDataGrid.SelectedCells[4].Column.GetCellContent(Items) as TextBlock).Text;
                    //Selling Price
                    showingReport_Window.Params[5] = (ShowingInvoiceDataGrid.SelectedCells[6].Column.GetCellContent(Items) as TextBlock).Text;
                    //Invoice Type
                    showingReport_Window.Params[6] = (ShowingInvoiceDataGrid.SelectedCells[8].Column.GetCellContent(Items) as TextBlock).Text;


                    // Send Formaula To Report:

                    showingReport_Window.GetFormula = "{View_InvoiceProduct.Invoice_ID} = " + GetInvoiceID;
                    showingReport_Window.ReportType = "Invoice_Report.rpt";

                    showingReport_Window.ShowDialog();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message , "Accounting And Sales Error" , MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
    }
}
