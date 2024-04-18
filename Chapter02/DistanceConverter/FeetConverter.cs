using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
    internal class FeetConverter {
        //メートルからフィートを求める
        public double FromMeter(int meter) {
            return meter / 0.3048;
        }
        //フィートからメートルを求める
        public double ToFeet(int feet) {
            return feet * 0.3048;
        }

    }
}
