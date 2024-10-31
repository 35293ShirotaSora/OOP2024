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

        MyColor currentColor;
        MyColor[] colorsTable;

        public MainWindow() {
            InitializeComponent();
            //αチャンネルの初期値設定
            currentColor.Color = Color.FromArgb(255, 0, 0, 0);

            DataContext = colorsTable = GetColorList();

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

            int i;
            for (i = 0; i < colorsTable.Length; i++) {
                if (colorsTable[i].Color.Equals(currentColor.Color)) {
                    currentColor.Name = colorsTable[i].Name;
                    break;
                }
            } 
            colorSelectComboBox.SelectedIndex = i;

            colorArea.Background = new SolidColorBrush(currentColor.Color);
            

            //currentColor.Name = null;
        }

        private void stockButton_Click(object sender, RoutedEventArgs e) {

            /*var stockColor = new MyColor();
            stockColor.Color = Color.FromRgb((byte)r, (byte)g, (byte)b);*/
            /*currentColor = new MyColor {
                Color = Color.FromRgb((byte)rSlider.Value, (byte)gSlider.Value, (byte)bSlider.Value),
                Name = ""
            };*/

            //currentColor.Name = GetColorList().Where(c => c.Color.Equals(currentColor.Color)).Select(c => c.Name).FirstOrDefault();

            if (stockList.Items.Contains(currentColor)) {
                MessageBox.Show("この色はすでにリストに存在します。");
            } else {
                stockList.Items.Insert(0, currentColor);
            }
        }

        public void stockList_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if (stockList.SelectedIndex != -1) {
                colorArea.Background = new SolidColorBrush(((MyColor)stockList.Items[stockList.SelectedIndex]).Color);
                setSliderValue(((MyColor)stockList.Items[stockList.SelectedIndex]).Color);
            }            
            //.Background = new SolidColorBrush(((MyColor)stockList.Items[stockList.SelectedIndex]).Color);
            //setSliderValue(((MyColor)stockList.Items[stockList.SelectedIndex]).Color);
            /*if (stockList.SelectedItem is MyColor selectedColor) {
      
                rValue.Text = selectedColor.Color.R.ToString();
                gValue.Text = selectedColor.Color.G.ToString();
                bValue.Text = selectedColor.Color.B.ToString();

            }*/
        }

        private void setSliderValue(Color color) {
            rSlider.Value = color.R;
            gSlider.Value = color.G;
            bSlider.Value = color.B;
        }

        private void colorSelectComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var tempcurrentColor = (MyColor)((ComboBox)sender).SelectedItem;

            setSliderValue(tempcurrentColor.Color);
            currentColor.Name = tempcurrentColor.Name;
            

        }

        private void clearButton_Click(object sender, RoutedEventArgs e) {
            if (stockList.SelectedItem != null) {
                stockList.Items.Remove(stockList.SelectedItem);
            } else {
                MessageBox.Show("削除する色を選択してください。");
            }
        }

        private void clearAllButton_Click(object sender, RoutedEventArgs e) {
            stockList.Items.Clear();
            
        }
    }
}
