using CustomerApp.Objects;
using Microsoft.Win32;
using SQLite;
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

namespace CustomerApp {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        List<Customer> _customers;
        public MainWindow() {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e) {
            if (string.IsNullOrEmpty(NameTextBox.Text)) {
                //MessageBox.Show("名前が未入力です", "入力エラー", MessageBoxButton.OK, MessageBoxImage.Warning);
                MessageBox.Show("名前を入力する必要があります");
                return;
            }

            byte[] imageBytes = null;

            if (LoadedImage.Source != null) {
                var bitmapImage = LoadedImage.Source as BitmapImage;
                if (bitmapImage != null) {
                    using(var memoryStream = new System.IO.MemoryStream()) {
                        BitmapEncoder encoder = new PngBitmapEncoder();
                        encoder.Frames.Add(BitmapFrame.Create(bitmapImage));
                        encoder.Save(memoryStream);
                        imageBytes = memoryStream.ToArray();
                    }
                }
            }

            var customer = new Customer() {
                Name = NameTextBox.Text,
                Phone = PhoneTextBox.Text,
                Address = AddressTextBox.Text,
                Picture = imageBytes
            };

            using (var connection = new SQLiteConnection(App.databasePass)) {
                connection.CreateTable<Customer>();
                connection.Insert(customer);
            }
            ReadDatabase();
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e) {
            var selectedCustomer = CustomerListView.SelectedItem as Customer;
            if (selectedCustomer == null) {
                MessageBox.Show("更新する行を選択してください");
                return;
            }

            if (string.IsNullOrEmpty(NameTextBox.Text) || string.IsNullOrEmpty(PhoneTextBox.Text) || string.IsNullOrEmpty(AddressTextBox.Text)) {
                MessageBox.Show("全て入力してください");
                return;
            }

            selectedCustomer.Name = NameTextBox.Text;
            selectedCustomer.Phone = PhoneTextBox.Text;
            selectedCustomer.Address = AddressTextBox.Text;

            byte[] imageBytes = null;

            if (LoadedImage.Source != null) {
                var bitmapImage = LoadedImage.Source as BitmapImage;
                if (bitmapImage != null) {
                    using (var memoryStream = new System.IO.MemoryStream()) {
                        BitmapEncoder encoder = new PngBitmapEncoder();
                        encoder.Frames.Add(BitmapFrame.Create(bitmapImage));
                        encoder.Save(memoryStream);
                        imageBytes = memoryStream.ToArray();
                    }
                }
            }
            selectedCustomer.Picture = imageBytes;

            using (var connection = new SQLiteConnection(App.databasePass)) {
                connection.CreateTable<Customer>();
                connection.Update(selectedCustomer);
            }
            ReadDatabase();
        }
      
        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e) {
            var filterList = _customers.Where(x=>x.Name.Contains(SearchTextBox.Text)).ToList();
            CustomerListView.ItemsSource = filterList;
            SearchTextBox.Clear();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e) {

            var item = CustomerListView.SelectedItem as Customer;
            if (item == null) {
                MessageBox.Show("削除する行を選択してください");
                return;
            }

            var result = MessageBox.Show("本当に削除しますか?", "削除確認", MessageBoxButton.YesNo, MessageBoxImage.Warning);

            if (result == MessageBoxResult.Yes) {
                using (var connection = new SQLiteConnection(App.databasePass)) {
                    connection.CreateTable<Customer>();
                    connection.Delete(item);
                    ReadDatabase();
                }
            } else {
                return;
            }
        }

        private void ReadDatabase() {
            using (var connection = new SQLiteConnection(App.databasePass)) {
                connection.CreateTable<Customer>();
                _customers = connection.Table<Customer>().ToList();

                foreach (var customer in _customers) {
                    if (customer.Picture != null && customer.Picture.Length > 0) {
                        using (var memoryStream = new System.IO.MemoryStream(customer.Picture)) {
                            var bitmapImage = new BitmapImage();
                            bitmapImage.BeginInit();
                            bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                            bitmapImage.StreamSource = memoryStream;
                            bitmapImage.EndInit();
                            customer.PictureSource = bitmapImage;
                        }
                    }
                }
                CustomerListView.ItemsSource = _customers;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            ReadDatabase();
        }

        private void CustomerListView_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var selectedCustomer = CustomerListView.SelectedItem as Customer;

            if (selectedCustomer != null) {
                NameTextBox.Text = selectedCustomer.Name;
                PhoneTextBox.Text = selectedCustomer.Phone;
                AddressTextBox.Text = selectedCustomer.Address;

                if (selectedCustomer.PictureSource != null) {
                    LoadedImage.Source = selectedCustomer.PictureSource;
                } else {
                    LoadedImage.Source = null;
                }
            } else {
                ClearTextbox();
                LoadedImage.Source = null;
            }
        }

        private void AllClearButton_Click(object sender, RoutedEventArgs e) {
            ClearTextbox();
            ReadDatabase();
        }

        private void OpenFileButton_Click(object sender, RoutedEventArgs e) {
            SelectFile();
        }

        private void ClearTextbox() {
            NameTextBox.Clear();
            PhoneTextBox.Clear();
            AddressTextBox.Clear();
        }

        private void SelectFile() {
            OpenFileDialog openFileDialog = new OpenFileDialog(); {
                openFileDialog.Title = "ファイル選択ダイアログ";
                openFileDialog.Filter = "全てのファイル(*.*)|*.*";
            }
            if (openFileDialog.ShowDialog() == true) {
                LoadedImage.Source = new BitmapImage(new Uri(openFileDialog.FileName));
            }
        }

        private void ImageClearButton_Click(object sender, RoutedEventArgs e) {
            LoadedImage.Source = null;
        }
    }
}
