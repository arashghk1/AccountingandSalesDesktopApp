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
using System.Windows.Navigation;
using System.Windows.Shapes;
using AccountingAndSales.Windows;
using Microsoft.Win32;
using BussinesEntity;
using BussinesLogicLayer;
using AccountingAndSales.Module;

namespace AccountingAndSales
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class LoginWindows : Window
    {
        public LoginWindows()
        {
            InitializeComponent();

        }
        DateTime registerDate=DateTime.Now; 

        BLL_User user = new BLL_User();
        BLL_UserSystemLog log = new BLL_UserSystemLog();

        private void btn_Exit_Click(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void btn_Login_Click(object sender, RoutedEventArgs e)
        {
            if(txt_Username.Text.Trim().Length == 0 && txt_Password.Password.Trim().Length == 0)
            {
                MessageBox.Show("Username And Password Not Valid.");
            }
            else if (user.Login(txt_Username.Text, user.PasswordHashing(txt_Password.Password)) == 1)
            {
                RegistryKey UserNamekey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\AccountingAndSales");
                try
                {
                    UserNamekey.SetValue("UsernameRegister", txt_Username.Text.Trim());
                    PublicVariable.GetUserID = user.GetUserInformation(txt_Username.Text , user.PasswordHashing(txt_Password.Password)).User_ID;
                    PublicVariable.GetUserName = user.GetUserInformation(txt_Username.Text, user.PasswordHashing(txt_Password.Password)).User_FirstName;
                    PublicVariable.GetUserFamily = user.GetUserInformation(txt_Username.Text, user.PasswordHashing(txt_Password.Password)).User_LastName;

                    //------------------------------------------------------ Command For System Log.

                    try
                    {
                        Table_UserLog userLog = new Table_UserLog();
                        string ComputerName = "";
                        string IPv4 = "";
                        string IPv6 = "";
                        log.GetSystemInformation(ref ComputerName, ref IPv4, ref IPv6);
                        userLog.UserLog_CompuerName = ComputerName;
                        userLog.UserLog_IPAddress = IPv4;
                        userLog.UserLog_IPV6Address = IPv6;
                        userLog.UserLog_EnterDate = registerDate.ToString("dd/MM/yyyy | HH:MM:ss");
                        userLog.User_ID = PublicVariable.GetUserID;

                        log.Register(userLog);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, "error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                finally
                {
                    UserNamekey.Close();
                }
                MainWindows mainWindows = new MainWindows();
                mainWindows.Show();

                this.Close();
            }
            else if (user.Login(txt_Username.Text, txt_Password.Password) == 0)
            {
                MessageBox.Show("User Is Not Exsit.");
            }
            else
            {
                MessageBox.Show("This is Problem Please Try Again.");
            }

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (!user.checkUserExist())
            {
                lbl_ActiveAndCreateUser.Visibility = Visibility.Visible;
                lbl_ActiveAndCreateUser_Image.Visibility = Visibility.Visible;
            }
            else
            {
                lbl_ActiveAndCreateUser.Visibility = Visibility.Hidden;
                lbl_ActiveAndCreateUser_Image.Visibility = Visibility.Hidden;
            }

            RegistryKey masterKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\AccountingAndSales");
            txt_Username.Text = masterKey.GetValue("UsernameRegister").ToString();
        }

        private void rectang_1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            LicencingAndRegisterFirstUser_Window licencingAndRegisterFirstUser_Window = new LicencingAndRegisterFirstUser_Window();
            licencingAndRegisterFirstUser_Window.ShowDialog();
        }

        private void Label_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Forget Password.");
        }
    }
}
