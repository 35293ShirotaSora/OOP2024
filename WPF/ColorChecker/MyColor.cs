using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ColorChecker {
    public class MyColor {
        public Color Color { get; set; }
        public string Name { get; set; } = string.Empty;

        public override string ToString() {
            return $"RGB({Color.R}, {Color.G}, {Color.B})";
        }
    }
}
