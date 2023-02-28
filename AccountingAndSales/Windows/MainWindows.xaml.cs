using System;
using System.Windows;
using AccountingAndSales.Module;
using BussinesLogicLayer;

namespace AccountingAndSales.Windows
{
    /// <summary>
        /// Interaction logic for MainWindows.xaml
    /// </summary>
    public partial class MainWindows : Window
    {
        public MainWindows()
        {
            InitializeComponent();
        }
        BLL_UserSystemLog log = new BLL_UserSystemLog(); 
        DateTime registerDate = DateTime.Now;
        private void AboutUs_Click(object sender, RoutedEventArgs e)
        {

        }
        private void ContactUs_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            log.UpdateExitDate(PublicVariable.GetUserID, registerDate.ToString("dd/MM/yyyy | HH:mm:ss"));
            System.Environment.Exit(0);
        }
        private void Define_Users_Click(object sender, RoutedEventArgs e)
        {
            ShowingDefindUsers_Window defindUsers_Window = new ShowingDefindUsers_Window();
            defindUsers_Window.ShowDialog();

        }
        private void Define_User_Access_Click(object sender, RoutedEventArgs e)
        {


        }
        private void Change_Password_Click(object sender, RoutedEventArgs e)
        {
            SetNewPassword_Window setNewPassword_Window=new SetNewPassword_Window();
            setNewPassword_Window.ShowDialog();
        }
        private void Definitoin_Of_System_Component_Click(object sender, RoutedEventArgs e)
        {
            
        }
        private void UserLoginAndLogoout_Click(object sender, RoutedEventArgs e)
        {
            ShowingUserLog_Winsdow showingUserLog_Winsdows=new ShowingUserLog_Winsdow();
            showingUserLog_Winsdows.ShowDialog();
         
        }
        private void Customer_Definition_Click(object sender, RoutedEventArgs e)
        {
            ShowingCustomer_Windows showingCustomer_Windows = new ShowingCustomer_Windows();
            showingCustomer_Windows.ShowDialog();
        }
        private void Preparing_a_Backup_File_Click(object sender, RoutedEventArgs e)
        {

        }
        private void ItemsDisplay_Click(object sender, RoutedEventArgs e)
        {
            ShowingProduct_Windows showingProduct_Windows = new ShowingProduct_Windows();
            showingProduct_Windows.ShowDialog();

        }
        private void PriceManagment_Click(object sender, RoutedEventArgs e)
        {


        }
        private void InventoryItmes_Click(object sender, RoutedEventArgs e)
        {

        }
        private void SalesChart_Click(object sender, RoutedEventArgs e)
        {
            Sales_Charts_Window sales_Charts_Window=new Sales_Charts_Window();
            sales_Charts_Window.ShowDialog();   
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            log.UpdateExitDate(PublicVariable.GetUserID, registerDate.ToString("dd/MM/yyyy | HH:mm:ss"));
            System.Environment.Exit(0);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LabelCurrentUser.Content = PublicVariable.GetUserName + " " + PublicVariable.GetUserFamily;
            DateTime EnterTime = DateTime.Now;
            LableEnterTime.Content = EnterTime.ToString("t");
        }

        private void AddRecipt_Click(object sender, RoutedEventArgs e)
        {
            Invoice_Window invoice_Window=new Invoice_Window();
            invoice_Window.Windows_Type = 1;
            invoice_Window.ShowDialog();    
        }

        private void ShowInvoice_Click(object sender, RoutedEventArgs e)
        {
            ShowingInvoice_Winsdows showingInvoiceWinsdows = new ShowingInvoice_Winsdows();
            showingInvoiceWinsdows.ShowDialog();
        }

        
        private void CustomerReport_Click(object sender, RoutedEventArgs e)
        {


        }


        private void BaseReporting_Click(object sender, RoutedEventArgs e)
        {
           BaseReporting_Window baseReporting_Window=new BaseReporting_Window();
           baseReporting_Window.ShowDialog();
        }
    }
}
