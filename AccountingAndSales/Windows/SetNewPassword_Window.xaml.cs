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
    public partial class SetNewPassword_Window : Window
    {
        public SetNewPassword_Window()
        {
            InitializeComponent();
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
            try
            {
                if (oldPassTextBox.Password == "" || NewPassTextBox.Password == "")
                {
                    MessageBox.Show("Please Fill The All Text Block For Complit.");
                    return;
                }
                var OldPassExist = user.CheckExistPass(PublicVariable.GetUserID, user.PasswordHashing(oldPassTextBox.Password));
                if (OldPassExist)
                {
                    user.UpdatePassword(PublicVariable.GetUserID, user.PasswordHashing(NewPassTextBox.Password));
                    MessageBox.Show("Password Is Change Success", "Password Change", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Old Pass Is Not Exist Please Try Again...", "Old Password Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch
            {
                MessageBox.Show("Not Save New Password.Please Check Try Again." , "Save Error" , MessageBoxButton.OK , MessageBoxImage.Error);
            }
            finally
            {
                this.Close();
            }

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            UserRegisterationFullName_Label.Content = PublicVariable.GetUserName + " " + PublicVariable.GetUserFamily;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
