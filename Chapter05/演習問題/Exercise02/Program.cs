using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("数列:");
            var s1 = Console.ReadLine();
            var n1 = int.Parse(s1);
            Console.WriteLine(int.TryParse(n1));
        }
    }
}
