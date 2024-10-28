using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ColorChecker {
    public struct MyColor {
        public Color Color { get; set; }
        public string Name { get; set; }

        public override string ToString() {
            return $"R : {Color.R}  G : {Color.G}  B : {Color.B}";
        }

        public override bool Equals(object obj) {
            if (obj is MyColor other) {
                return Color.Equals(other.Color);
            }
            return false;
        }

        public override int GetHashCode() {
            return (Color.R, Color.G, Color.B).GetHashCode();
        }


    }
}
