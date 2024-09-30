using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {
            var years = new int[] { 2013, 2016 };

            var books = Library.Books
                .Where(b => years.Contains(b.PublishedYear));

            foreach ( var book in ) {
                Console.WriteLine(book);
            }
            
        }
    }
}
