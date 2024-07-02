using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    public class TimeWatch {
        DateTime st;

        internal void Start() {
            st = DateTime.Now;
        }

        internal TimeSpan Stop() { 
            return DateTime.Now - st;
            
        }
    }
}
