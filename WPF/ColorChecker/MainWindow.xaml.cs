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

namespace ColorChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        private List<MyColor> colorList = new List<MyColor>();

        double r;
        double g;
        double b;

        public MainWindow() {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            r = (int)rSlider.Value;
            rValue.Text = r.ToString();
            g = (int)gSlider.Value;
            gValue.Text = g.ToString();
            b = (int)bSlider.Value;
            bValue.Text = b.ToString();

            var newColor = Color.FromRgb((byte)r, (byte)g, (byte)b);

            colorArea.Background = new SolidColorBrush(newColor);
        }

        private void stockButton_Click(object sender, RoutedEventArgs e) {
            r = rSlider.Value;
            g = gSlider.Value;
            b = bSlider.Value;

            var color = new MyColor();

            color.Color = Color.FromRgb((byte)r, (byte)g, (byte) b);

            stockList.Items.Add(color.ToString());
        }
    }
}
