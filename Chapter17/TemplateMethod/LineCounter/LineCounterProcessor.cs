﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LineCounter;

namespace LineCounter {
    class LineCounterProcessor : TextProcessor{

        private int _count;

        protected override void Initialize(string fname) {
            _count = 0;
        }

        protected override void Execute(string line) {
            _count++;
        }

        protected override void Terminate() {
            Console.WriteLine("{0}行",_count);
        }
    }
}
