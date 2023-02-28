using System;
using System.Windows;
using System.Windows.Input;
using BussinesEntity;
using BussinesLogicLayer;
using AccountingAndSales.Module;
using System.Text.RegularExpressions;
using System.Security.Cryptography;


namespace AccountingAndSales.Windows
{
    /// <summary>
        /// Interaction logic for DefindUsers_Window.xaml
    /// </summary>
    public partial class LicencingAndRegisterFirstUser_Window : Window
    {
        public LicencingAndRegisterFirstUser_Window()
        {
            InitializeComponent();
        }
        public bool CheckNullable()
        {
            if (FirstNameTextBox.Text.Trim().Length == 0)
        {
            MessageBox.Show("Please Fill In The Customer Name Field!!!");
            FirstNameTextBox.Focus();
            return false;
        }
            else if (LastNameTextBox.Text.Trim().Length == 0)
        {
            MessageBox.Show("Please Fill In The Field Related To The Customer's Last Name!!!");
            LastNameTextBox.Focus();
            return false;
        }
            else if (TelphoneNumberTextBox.Text.Trim().Length == 0)
        {
            MessageBox.Show("Please Fill In The Field Related To The Customer's Phone Number!!!");
            TelphoneNumberTextBox.Focus();
            return false;
        }
            else if (AgeTextBox.Text.Trim().Length == 0)
        {
            MessageBox.Show("Please Fill In The Field Related To The Customer's Age!!!");
            AgeTextBox.Focus();
            return false;
        }
            else if (UserNameTextBox.Text.Trim().Length == 0)
        {
            MessageBox.Show("Please Fill In The Field Related To The Customer's Username!!!");
            UserNameTextBox.Focus();
            return false;
        }
            else if (PasswordTextBox.Text.Trim().Length == 0)
        {
            MessageBox.Show("Please Fill In The Field Related To The Customer's Password!!!");
            PasswordTextBox.Focus();
            return false;
        }
        else
        {
            if (PasswordTextBox.Text.Trim() != PasswordRepeatTextBox.Text.Trim())
        {
            MessageBox.Show("Password Not Equals To Repeat Password!!!\nPlease Check Repaet Password.");
            PasswordRepeatTextBox.Focus();
            return false;
        }
        }

            return true;

        }

        BLL_User user = new BLL_User();
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
            else
            {
                try
                {
                    Table_Users table_Users = new Table_Users();
                    table_Users.User_FirstName = FirstNameTextBox.Text.Trim();
                    table_Users.User_LastName = LastNameTextBox.Text.Trim();
                    table_Users.User_Tel = TelphoneNumberTextBox.Text.Trim();
                    table_Users.User_Age = Convert.ToByte(AgeTextBox.Text);
                    if (UserGenderComboBox.SelectedIndex == 0)
                    {
                        table_Users.User_Gender = true;
                    }
                    else if (UserGenderComboBox.SelectedIndex == 1)
                    {
                        table_Users.User_Gender = false;
                    }
                    table_Users.User_Username = UserNameTextBox.Text.Trim();
                    table_Users.User_Paasword = user.PasswordHashing(PasswordTextBox.Text);
                    table_Users.User_Active = true;
                    table_Users.User_Delete = false;
                    table_Users.User_StartDate = RegisterDate.ToString("dd/MM/yyyy");
                    user.Register(table_Users);
                    MessageBox.Show("Customer Registeration Is Succss", "Register Success", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (Exception exceptoin)
                {
                    MessageBox.Show("Customer Register Error:\n" + exceptoin.Message , "Register Or Update Error" ,MessageBoxButton.OK , MessageBoxImage.Error );
                }
                finally
                {
                    this.Close();
                }
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

           
            txt_ActivationCode.Focus();
            


          

            //---------------------------------------> Show User Information In Edit Window <------------------------------------
        }

        private void TelphoneNumberTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void AgeTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
