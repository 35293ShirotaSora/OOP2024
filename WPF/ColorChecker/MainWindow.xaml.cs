using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace ColorChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {

        MyColor currentColor = new MyColor();
        /*double r;
        double g;
        double b;*/

        public MainWindow() {
            InitializeComponent();
            //αチャンネルの初期値設定
            currentColor.Color = Color.FromArgb(255, 0, 0, 0);

            colorSelectComboBox.DataContext = GetColorList();

        }

        private MyColor[] GetColorList() {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {

            /*r = (int)rSlider.Value;
            rValue.Text = r.ToString();
            g = (int)gSlider.Value;
            gValue.Text = g.ToString();
            b = (int)bSlider.Value;
            bValue.Text = b.ToString();

            var newColor = Color.FromRgb((byte)r, (byte)g, (byte)b);

            colorArea.Background = new SolidColorBrush(newColor);*/

            currentColor.Color = Color.FromRgb((byte)rSlider.Value, (byte)gSlider.Value, (byte)bSlider.Value);
            colorArea.Background = new SolidColorBrush(currentColor.Color);
        }

        private void stockButton_Click(object sender, RoutedEventArgs e) {

            /*var stockColor = new MyColor();
            stockColor.Color = Color.FromRgb((byte)r, (byte)g, (byte)b);*/
            /*currentColor = new MyColor {
                Color = Color.FromRgb((byte)rSlider.Value, (byte)gSlider.Value, (byte)bSlider.Value),
                Name = ""
            };*/

            if (!stockList.Items.OfType<MyColor>().Any(c => c.Equals(currentColor))) {
                stockList.Items.Insert(0, currentColor);
            } else {
                MessageBox.Show("この色はすでにリストに存在します。");
            }
        }

        public void stockList_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            colorArea.Background = new SolidColorBrush(((MyColor)stockList.Items[stockList.SelectedIndex]).Color);
            rSlider.Value = ((MyColor)stockList.Items[stockList.SelectedIndex]).Color.R;
            gSlider.Value = ((MyColor)stockList.Items[stockList.SelectedIndex]).Color.G;
            bSlider.Value = ((MyColor)stockList.Items[stockList.SelectedIndex]).Color.B;

            /*if (stockList.SelectedItem is MyColor selectedColor) {
      
                rValue.Text = selectedColor.Color.R.ToString();
                gValue.Text = selectedColor.Color.G.ToString();
                bValue.Text = selectedColor.Color.B.ToString();

            }*/
        }

        private void colorSelectComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if (colorSelectComboBox.SelectedItem is MyColor selectedColor) {
                colorArea.Background = new SolidColorBrush(selectedColor.Color);
                rSlider.Value = selectedColor.Color.R;
                gSlider.Value = selectedColor.Color.G;
                bSlider.Value = selectedColor.Color.B;

                rValue.Text = selectedColor.Color.R.ToString();
                gValue.Text = selectedColor.Color.G.ToString();
                bValue.Text = selectedColor.Color.B.ToString();
            }
        }
    }
}
