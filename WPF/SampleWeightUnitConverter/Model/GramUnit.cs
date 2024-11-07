﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleWeightUnitConverter{
    public class GramUnit : WeightUnit {
        private static List<GramUnit> units = new List<GramUnit> {
            new GramUnit{ Name = "g",Coefficient = 1,},
            new GramUnit{ Name = "kg",Coefficient = 10*100},
        };
        public static ICollection<GramUnit> Units { get { return units; } }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="unit"></param>
        /// <param name="value"></param>
        /// <returns></returns>

        public double FromPoundUnit(PoundUnit unit, double value) {
            return (value * unit.Coefficient) * 28.35 / this.Coefficient;
        }
    }
}
