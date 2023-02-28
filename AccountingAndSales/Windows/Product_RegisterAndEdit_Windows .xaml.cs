using AccountingAndSales.Module;
using BussinesEntity;
using BussinesLogicLayer;
using Microsoft.Win32;
using System;
using System.IO;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace AccountingAndSales.Windows
{
    /// <summary>
    /// Interaction logic for DefindUsers_Window.xaml
    /// </summary>
    public partial class Product_RegisterAndEdit_Windows : Window
    {
        public Product_RegisterAndEdit_Windows()
        {
            InitializeComponent();
        }

        BLL_Product BLL_product = new BLL_Product();
        string SelectedImageFileName;
        string ImageName;
        private void SelectedImage()
        {
            try
            {
                FileDialog fileDialog = new OpenFileDialog();
                fileDialog.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
                fileDialog.DefaultExt = "*.png";
                fileDialog.Title = "Please Select Image For Product";
                if (fileDialog.ShowDialog().Value == true)
                {
                    SelectedImageFileName = fileDialog.SafeFileName;
                    ImageName = fileDialog.FileName;
                    ImageSourceConverter imageSourceConverter = new ImageSourceConverter();
                    ProductImageSelection.SetValue(System.Windows.Controls.Image.SourceProperty, imageSourceConverter.ConvertFromString(ImageName));
                }
                else
                {
                    fileDialog = null;
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }
        public byte Windews_Type { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }


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
            switch (Windews_Type)
            {
                case 1:
                    {
                        
                        try
                        {
                            FileStream fileStream = new FileStream(ImageName, FileMode.Open, FileAccess.Read);
                            byte[] Imagebuffer = new byte[fileStream.Length];
                            fileStream.Read(Imagebuffer, 0, Imagebuffer.Length);
                            fileStream.Close();

                            Table_Product product = new Table_Product();
                            product.Product_Name = ProductNameTextBox.Text.Trim();
                            product.Product_Discription = ProductDesctiptionTextBox.Text.Trim();
                            product.Product_RegisterDate = RegisterDate.ToString("dd/MM/yyyy");
                            product.Product_Image = Imagebuffer;
                            product.User_ID = PublicVariable.GetUserID;

                            BLL_product.Create(product);
                            MessageBox.Show("Register Success.");
                        }
                        catch
                        {
                            MessageBox.Show("Product Registeration Is Problem.\nIs Continue?", "Not Register", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                        finally
                        {
                            this.Close();
                        }

                        break;
                    }
                case 2:
                    {
                       
                        try
                        {
                            if (ImageName != null)
                            {
                                FileStream fileStream = new FileStream(ImageName, FileMode.Open, FileAccess.Read);
                                byte[] Imagebuffer = new byte[fileStream.Length];
                                fileStream.Read(Imagebuffer, 0, Imagebuffer.Length);
                                fileStream.Close();

                                Table_Product Product = new Table_Product();
                                Product.Product_ID = this.ProductID;
                                Product.Product_Name = ProductNameTextBox.Text.Trim();
                                Product.Product_Discription = ProductDesctiptionTextBox.Text.Trim();
                                Product.Product_Image = Imagebuffer;
                                BLL_product.EditProductWhitImage(Product);
                                MessageBox.Show("Product Edit Is Success.", "Edit Success", MessageBoxButton.OK, MessageBoxImage.Information);
                            }
                            else
                            {
                                Table_Product Product = new Table_Product();
                                Product.Product_ID = this.ProductID;
                                Product.Product_Name = ProductNameTextBox.Text.Trim();
                                Product.Product_Discription = ProductDesctiptionTextBox.Text.Trim();
                                BLL_product.EditProductWithdoutImage(Product);
                                MessageBox.Show("Product Edit Is Success.", "Edit Success", MessageBoxButton.OK, MessageBoxImage.Information);

                            }

                        }
                        catch
                        {
                            MessageBox.Show("Product Edit Is Problem.\nIs Continue?", "Not Register", MessageBoxButton.OK, MessageBoxImage.Error);

                        }
                        finally
                        {
                            this.Close();
                        }
                        break;
                    }
            }

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            UserRegisterationFullName_Label.Content = PublicVariable.GetUserName + " " + PublicVariable.GetUserFamily;
            switch (Windews_Type)
            {
                case 1:
                    break;

                case 2:
                    {
                        LabelProductRegisterAndEditHeader.Content = "Product Edit";
                        BtnRegisterAndEdit.Content = "Edit Product";
                        ProductNameTextBox.Text = this.ProductName;
                        ProductDesctiptionTextBox.Text = this.ProductDescription;
                        ShowImage();

                        break;
                    }
            }

        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            SelectedImage();
        }


        public void ShowImage()
        {

            View_Product product = BLL_product.ReadProductByID(ProductID);

            if (product.Product_Image != null)
            {
                byte[] ImageArray = product.Product_Image;
                MemoryStream stream = new MemoryStream();
                stream.Write(ImageArray, 0, ImageArray.Length);
                System.Drawing.Image image = System.Drawing.Image.FromStream(stream);
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                MemoryStream memoryStream = new MemoryStream();
                image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Bmp);
                memoryStream.Seek(0, SeekOrigin.Begin);
                bitmap.StreamSource = memoryStream;
                bitmap.EndInit();
                ProductImageSelection.Source = bitmap;

            }

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ShowingProduct_Windows showingProductWindows = new ShowingProduct_Windows();
            showingProductWindows.ShowingProductDataGrid.ItemsSource = null;
            showingProductWindows.ShowingProductDataGrid.ItemsSource = BLL_product.productRead();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            ShowingProduct_Windows showingProductWindows = new ShowingProduct_Windows();
            showingProductWindows.ShowingProductDataGrid.ItemsSource = null;
            showingProductWindows.ShowingProductDataGrid.ItemsSource = BLL_product.productRead();
        }
    }
}
