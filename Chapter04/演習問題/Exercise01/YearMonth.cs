using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    public class YearMonth {
        //4.1.1
        public int Year { get;private set; } 
        public int Month { get; private set; }

        public YearMonth(int year, int month) {
            Year = year;
            Month = month;
        }

        //4.1.2
        public bool Is21Century {
            get{
                return 2000 < Year && Year < 2101;
            } 
        }

        //4.1.3
        public YearMonth AddOneMonth(YearMonth[] ymCollection) {
            if(Month == 12) {      //yaer + 1,month = 1
                return new YearMonth(Year + 1, 1) ;
            } else {                    //month + 1
                return new YearMonth(Year,Month + 1);
            }
        }

        //4.1.4
        public override string ToString() {
            //return Year + "年" + Month + "月";
            return $"{Year}年{Month}月";
        }
    }
}
