using BussinesLogicLayer;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace AccountingAndSales.Windows
{
    /// <summary>
    /// Interaction logic for DefindUsers_Window.xaml
    /// </summary>
    public partial class ShowingDefindUsers_Window : Window
    {
        public ShowingDefindUsers_Window()
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ShowingUserDataGrid.ItemsSource = null;
            ShowingUserDataGrid.ItemsSource = user.UserReadAll();
        }

        private void btn_CustomerRegisteration(object sender, RoutedEventArgs e)
        {
            User_RegisterAndEdit_Window user_RegisterAndEdit_Window = new User_RegisterAndEdit_Window();
            user_RegisterAndEdit_Window.Windows_Type = 1;
            user_RegisterAndEdit_Window.ShowDialog();
            ShowingUserDataGrid.ItemsSource = user.UserReadAll();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Object Item = ShowingUserDataGrid.SelectedItem;
            User_RegisterAndEdit_Window user_RegisterAndEdit_Window = new User_RegisterAndEdit_Window();

            //-------------------------------------------> send Value To Register And Edit Window: <----------------------------------
            if (Item == null)
            {
                MessageBox.Show("Please Selected User In DataGrid For Edit.", "User Selected Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            user_RegisterAndEdit_Window.Windows_Type = 2;
            user_RegisterAndEdit_Window.UserID = Convert.ToInt32((ShowingUserDataGrid.SelectedCells[0].Column.GetCellContent(Item) as TextBlock).Text);
            user_RegisterAndEdit_Window.UserName = (ShowingUserDataGrid.SelectedCells[1].Column.GetCellContent(Item) as TextBlock).Text;
            user_RegisterAndEdit_Window.UserFamily = (ShowingUserDataGrid.SelectedCells[2].Column.GetCellContent(Item) as TextBlock).Text;
            user_RegisterAndEdit_Window.UserTel = (ShowingUserDataGrid.SelectedCells[3].Column.GetCellContent(Item) as TextBlock).Text;
            user_RegisterAndEdit_Window.UserAge = Convert.ToByte((ShowingUserDataGrid.SelectedCells[4].Column.GetCellContent(Item) as TextBlock).Text);
            user_RegisterAndEdit_Window.UserGender = (ShowingUserDataGrid.SelectedCells[5].Column.GetCellContent(Item) as TextBlock).Text;
            user_RegisterAndEdit_Window.User_UserName = (ShowingUserDataGrid.SelectedCells[7].Column.GetCellContent(Item) as TextBlock).Text;


            user_RegisterAndEdit_Window.ShowDialog();


            //-----------------------------------> DataGrid Update After Close RegisterAndEdit Window <-------------------------------
            ShowingUserDataGrid.ItemsSource = user.UserReadAll();
        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            ShowingUserDataGrid.ItemsSource = user.ReadUserByString(SearchTextBox.Text.Trim());
        }

        private void QuantityComboBox_DropDownClosed(object sender, EventArgs e)
        {
            if (QuantityComboBox.SelectedIndex == 0)
            {
                ShowingUserDataGrid.ItemsSource = user.ActiveUserRead();
            }
            else if (QuantityComboBox.SelectedIndex == 1)
            {
                ShowingUserDataGrid.ItemsSource = user.DeActiveUserRead();
            }
            else
            {
                ShowingUserDataGrid.ItemsSource = user.UserReadAll();
            }
        }

        private void ImageSearchMouseDown(object sender, MouseButtonEventArgs e)
        {
            SearchTextBox.Focus();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete the user?" ,"Delete Message" , MessageBoxButton.YesNo , MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    Object Item = ShowingUserDataGrid.SelectedItem;
                    if (Item == null)
                    {
                        MessageBox.Show("Please Selected User For Delete.", "User Selected Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                    int userID = Convert.ToInt32((ShowingUserDataGrid.SelectedCells[0].Column.GetCellContent(Item) as TextBlock).Text);
                    user.DeleteUser(userID);
                    MessageBox.Show("User Is Deleted Success.", "User Delete", MessageBoxButton.OK, MessageBoxImage.Information);
                    ShowingUserDataGrid.ItemsSource = user.UserReadAll();
                }
                catch (Exception EX)
                {
                    MessageBox.Show(EX.Message, "Delete System Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                return;
            }
            
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to delete the user?", "Delete Message", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    Object Item = ShowingUserDataGrid.SelectedItem;
                    int userID = Convert.ToInt32((ShowingUserDataGrid.SelectedCells[0].Column.GetCellContent(Item) as TextBlock).Text);
                    user.DeleteUser(userID);
                    MessageBox.Show("User Is Deleted Success.", "User Delete", MessageBoxButton.OK, MessageBoxImage.Information);
                    ShowingUserDataGrid.ItemsSource = user.UserReadAll();
                }
                catch (Exception EX)
                {
                    MessageBox.Show(EX.Message, "Delete System Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                return;
            }

        }
    }
}
