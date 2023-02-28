using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using BussinesLogicLayer;
using System.Text.RegularExpressions;

namespace AccountingAndSales.Windows
{
    /// <summary>
        /// Interaction logic for DefindUsers_Window.xaml
    /// </summary>
    public partial class ShowingUserLog_Winsdow : Window
    {
        public ShowingUserLog_Winsdow()
        {
            InitializeComponent();
        }

        BLL_UserSystemLog BLL_userSystem = new BLL_UserSystemLog();
        private void UserNameBindInComboBox()
        {

            //for (int i = 0; i < result.Count; i++)
            //{
            //    UserNameComboBox.Items.Add(result[i].UserFullName);
            //}
            var Result = BLL_userSystem.GetUserFullNameForComboBox();

            UserNameComboBox.ItemsSource = Result.ToList();
            UserNameComboBox.DisplayMemberPath = "User_FullName";
            UserNameComboBox.SelectedValuePath = "User_ID";

        }

        private void rectang_1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {


            DataGridShowingUserLog.ItemsSource = null;
            DataGridShowingUserLog.ItemsSource = BLL_userSystem.ReadAllUserLog();

            //---------------------------------------------------------------------
            UserNameBindInComboBox();


        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
        private void ImageSearch_MouseDown(object sender, MouseButtonEventArgs e)
        {
            SearchTextBox.Focus();
        }
        private void btn_CreateReport(object sender, RoutedEventArgs e)
        {

        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            DataGridShowingUserLog.ItemsSource = null;
            DataGridShowingUserLog.ItemsSource = BLL_userSystem.ReadUserLogBetweenDate(SearchTextBox.Text, "27/12/2022   03:41:28");

        }

        private void UserNameComboBox_DropDownClosed(object sender, EventArgs e)
        {
            if (UserNameComboBox.SelectedIndex == -1)
            {
                DataGridShowingUserLog.ItemsSource = null;
                DataGridShowingUserLog.ItemsSource = BLL_userSystem.ReadAllUserLog();
            }
            else
            {
                DataGridShowingUserLog.ItemsSource = null;
                DataGridShowingUserLog.ItemsSource = BLL_userSystem.ReadUserLogWhitUserIDForComboBox(Convert.ToInt32(UserNameComboBox.SelectedValue));
            }
            
        }

        private void TimeControlForSearch()
        {
            string Front_Time = H_From_Txt.Text.Trim() + ":" + M_From_Txt.Text.Trim() +":" + S_From_Txt.Text.Trim();
            string To_Time = H_To_Txt.Text.Trim() + ":" + M_To_Txt.Text.Trim() +":" + S_To_Txt.Text.Trim();
            string ResultEnterDate = EnterDateTextBox.Text.Trim() + " | " + Front_Time;
            string ResultExitDate = ExitDateTextBox.Text.Trim() + " | " + To_Time;
            DataGridShowingUserLog.ItemsSource = null;
            DataGridShowingUserLog.ItemsSource = BLL_userSystem.ReadUserLogBetweenDate(ResultEnterDate , ResultExitDate);
        }

        private void EnterDateTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9-/]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void ExitDateTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9-/]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void H_From_Txt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void M_From_Txt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void S_From_Txt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled=regex.IsMatch(e.Text);
        }

        private void H_To_Txt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void M_To_Txt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void S_To_Txt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void ImageDateTime_MouseDown(object sender, MouseButtonEventArgs e)
        {
           TimeControlForSearch();
        }
    }
}
