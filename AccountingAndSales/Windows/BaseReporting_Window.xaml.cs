using System;
using System.Windows;
using System.Windows.Input;
using BussinesLogicLayer;


namespace AccountingAndSales.Windows
{
    /// <summary>
    /// Interaction logic for BaseReporting_Window.xaml
    /// </summary>
    public partial class BaseReporting_Window : Window
    {
        public BaseReporting_Window()
        {
            InitializeComponent();
        }
        public string ReportingSelecteName;
        BLL_Customer bll_Customer = new BLL_Customer();
        ShowingReport_Window showingReport_Window;
        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_CreateInvoice_Copy_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Btn_CreateInvoice_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                showingReport_Window = new ShowingReport_Window();
                showingReport_Window.ReportType = ReportingSelecteName;
                showingReport_Window.GetFormula = ReportingFormula();
                showingReport_Window.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message , "Accounting And Sales Error" , MessageBoxButton.OK , MessageBoxImage.Error);
            }
        }



        // ***************************************************** Formaula Report Functions <--


        private string ReportingFormula()
        {
            string formula = "";

            switch (ReportingSelecteName)
            {
                case "CustomerList.rpt":
                    {
                        if (AllCustomer_RadioButton.IsChecked == true)
                        {
                            formula = " ";
                        }
                        else if (Active_RadioButton.IsChecked == true)
                        {
                            formula = " not {View_Customer.Customer_Delete}";
                        }
                        else if (NoneActive_RadioButton.IsChecked == true)
                        {
                            formula = " {View_Customer.Customer_Delete}";
                        }
                        break;
                    }
                case "AllSelling_Report.rpt":
                    {
                        showingReport_Window.Params[0] = String.Format("{0:dd/MM/yyyy}", Convert.ToDateTime(DataPicker_FromDate.Text));
                        showingReport_Window.Params[1] = String.Format("{0:dd/MM/yyyy}", Convert.ToDateTime(DataPicker_ToDate.Text));

                        formula = "{ View_Invoice.Invoice_DateTime} in '" + String.Format("{0:dd/MM/yyyy}", Convert.ToDateTime(DataPicker_FromDate.Text)) + "' to '" + String.Format("{0:dd/MMM/yyyy}", Convert.ToDateTime(DataPicker_ToDate.Text)) + "'";


                        if (AllSellingInvoice_RadioButton.IsChecked == true)
                        {
                            formula += " ";
                        }
                        else if (SellingInvoice_RadioButton.IsChecked == true)
                        {
                            formula += " and {View_Invoice.Invoice_Type}";
                        }
                        else if (ReturnInvoice_RadioButton.IsChecked == true)
                        {
                            formula += " and not {View_Invoice.Invoice_Type}";
                        }

                        // ************************************************ For ComboBox Customer Name Condition <--

                        if (ComboBox_SelectedCustomer.SelectedValue != null)
                        {
                            formula +=(" and {View_Invoice.Customer_ID} = " + ComboBox_SelectedCustomer.SelectedValue);
                        }
                        break;
                    }
                case "SellingAll_CustomerGroup.rpt":
                    {
                        showingReport_Window.Params[0] = String.Format("{0:dd/MM/yyyy}", Convert.ToDateTime(DataPicker_FromDate.Text));
                        showingReport_Window.Params[1] = String.Format("{0:dd/MM/yyyy}", Convert.ToDateTime(DataPicker_ToDate.Text));

                        formula = "{ View_Invoice.Invoice_DateTime} in '" + String.Format("{0:dd/MM/yyyy}", Convert.ToDateTime(DataPicker_FromDate.Text)) + "' to '" + String.Format("{0:dd/MMM/yyyy}", Convert.ToDateTime(DataPicker_ToDate.Text)) + "'";


                        if (AllSellingInvoice_RadioButton.IsChecked == true)
                        {
                            formula += " ";
                        }
                        else if (SellingInvoice_RadioButton.IsChecked == true)
                        {
                            formula += " and {View_Invoice.Invoice_Type}";
                        }
                        else if (ReturnInvoice_RadioButton.IsChecked == true)
                        {
                            formula += " and not {View_Invoice.Invoice_Type}";
                        }

                        // ************************************************ For ComboBox Customer Name Condition <--

                        if (ComboBox_SelectedCustomer.SelectedValue != null)
                        {
                            formula += (" and {View_Invoice.Customer_ID} = " + ComboBox_SelectedCustomer.SelectedValue);
                        }
                        break;
                    }
            } 

            return formula;
        }













        //                                             ****************************************************
        //                                              ************************************************
        //                                                ****** For ListView Items Events ********
        //                                                     *********************************
        //                                                       ****************************
        //                                                             ****************
        //                                                                 *********
        //                                                                    ***
        //                                                                     *

        // ************************************************************  For Customer Reporting Selected In ListView <--
        private void CustomerReport_Image_click(object sender, MouseButtonEventArgs e)
        {
            ReportingSelecteName = "CustomerList.rpt";
            AllSellingReport_GroupBox.Visibility = Visibility.Hidden;
            CustomerReporting_GroupBox.Visibility = Visibility.Visible;
        }
        private void CustomerReport_TextBlock_click(object sender, MouseButtonEventArgs e)
        {
            ReportingSelecteName = "CustomerList.rpt";
            AllSellingReport_GroupBox.Visibility = Visibility.Hidden;
            CustomerReporting_GroupBox.Visibility = Visibility.Visible;
        }
        private void CustomerReport_UnderItem_Click(object sender, MouseButtonEventArgs e)
        {
            ReportingSelecteName = "CustomerList.rpt";
            AllSellingReport_GroupBox.Visibility = Visibility.Hidden;
            CustomerReporting_GroupBox.Visibility = Visibility.Visible;
        }


        // ************************************************************  For System Users Reporting Selected In ListView <--
        private void SystemUserReporting_UnderItem_Click(object sender, MouseButtonEventArgs e)
        {
            ReportingSelecteName = "SystemUser.rpt";
            AllSellingReport_GroupBox.Visibility = Visibility.Hidden;
            CustomerReporting_GroupBox.Visibility = Visibility.Hidden;
        }
        private void SystemUserReporting_Image_Click(object sender, MouseButtonEventArgs e)
        {
            ReportingSelecteName = "SystemUser.rpt";
            AllSellingReport_GroupBox.Visibility = Visibility.Hidden;
            CustomerReporting_GroupBox.Visibility = Visibility.Hidden;
        }
        private void SystemUserReporting_TextBlock_Click(object sender, MouseButtonEventArgs e)
        {
            ReportingSelecteName = "SystemUser.rpt";
            AllSellingReport_GroupBox.Visibility = Visibility.Hidden;
            CustomerReporting_GroupBox.Visibility = Visibility.Hidden;
        }


        // ************************************************************  For Product Reporting Selected In ListView <--
        private void ProductReporting_UnderItem_Click(object sender, MouseButtonEventArgs e)
        {
            ReportingSelecteName = "Product_Report.rpt";
            AllSellingReport_GroupBox.Visibility = Visibility.Hidden;
            CustomerReporting_GroupBox.Visibility = Visibility.Hidden;
        }
        private void ProductReporting_Image_Click(object sender, MouseButtonEventArgs e)
        {
            ReportingSelecteName = "Product_Report.rpt";
            AllSellingReport_GroupBox.Visibility = Visibility.Hidden;
            CustomerReporting_GroupBox.Visibility = Visibility.Hidden;
        }
        private void ProductReporting_TextBlock_Click(object sender, MouseButtonEventArgs e)
        {
            ReportingSelecteName = "Product_Report.rpt";
            AllSellingReport_GroupBox.Visibility = Visibility.Hidden;
            CustomerReporting_GroupBox.Visibility = Visibility.Hidden;
        }

        // ************************************************************  For Product Reporting Selected In ListView <--

        private void SellingReportUnit_Func()
        {
            CustomerReporting_GroupBox.Visibility = Visibility.Hidden;
            AllSellingReport_GroupBox.Visibility = Visibility.Visible;
            ComboBox_SelectedCustomer.ItemsSource = bll_Customer.CustomerReadAll();
            ComboBox_SelectedCustomer.DisplayMemberPath = "Customer_FullName";
            ComboBox_SelectedCustomer.SelectedValuePath = "Customer_ID";

            ReportingSelecteName = "AllSelling_Report.rpt";

        }


        private void AllSellingReport_UnderItem_Click(object sender, MouseButtonEventArgs e)
        {
            SellingReportUnit_Func();
        }
        private void AllSellingReport_Image_Click(object sender, MouseButtonEventArgs e)
        {
            SellingReportUnit_Func();
        }
        private void AllSellingReport_TextBlock_Click(object sender, MouseButtonEventArgs e)
        {
            SellingReportUnit_Func();
        }


        // ************************************************************  For Sales Invoice Reports - Customer Grouping Selected In ListView <--

        private void InvoiceCustomerGroup_Func()
        {
            CustomerReporting_GroupBox.Visibility = Visibility.Hidden;
            AllSellingReport_GroupBox.Visibility = Visibility.Visible;
            ComboBox_SelectedCustomer.ItemsSource = bll_Customer.CustomerReadAll();
            ComboBox_SelectedCustomer.DisplayMemberPath = "Customer_FullName";
            ComboBox_SelectedCustomer.SelectedValuePath = "Customer_ID";

            ReportingSelecteName = "SellingAll_CustomerGroup.rpt";

        }
        private void InvoiceCustomerGroup_ListBoxItem_Click(object sender, MouseButtonEventArgs e)
        {
            InvoiceCustomerGroup_Func();
        }
        private void InvoiceCustomerGroup_Image_Click(object sender, MouseButtonEventArgs e)
        {
            InvoiceCustomerGroup_Func();
        }
        private void InvoiceCustomerGroup_TextBlock_Click(object sender, MouseButtonEventArgs e)
        {
            InvoiceCustomerGroup_Func();
        }
    }
}
