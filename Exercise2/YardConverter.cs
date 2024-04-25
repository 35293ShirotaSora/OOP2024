using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2 {
    internal class YardConverter {
        public static readonly double ratio = 0.9144;

        public static double FromMeter(double meter) {
            return meter / ratio;
        }

        public static double ToMeter(double yard) {
            return yard * ratio;
        }
    }
}
