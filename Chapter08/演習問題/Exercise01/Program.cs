using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {

            //8.1
            var today1 = DateTime.Now;
            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();
            var now = today1.ToString("ggyy年 M月d日", culture);
            var dayOfWeek = culture.DateTimeFormat.GetDayName(today1.DayOfWeek);

            Console.WriteLine(today1.ToString("d") + " " +  today1.ToString("t"));
            Console.WriteLine(today1.ToString("yyyy年MM月dd日 HH時mm分ss秒"));
            Console.WriteLine(now + "(" + dayOfWeek + ")");

            //Console.WriteLine(NextDay(today1,DayOfWeek.Monday));


        }

        //8.2
        public static DateTime NextDay(DateTime date, DayOfWeek dayOfWeek) {
            var days = (int)dayOfWeek - (int)date.DayOfWeek;
            days += 7;
            return date.AddDays(days);
        }
    }
}
