using Section01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            Exercise1_2();
            Console.WriteLine();
            Exercise1_3();
            Console.WriteLine();
            Exercise1_4();
            Console.WriteLine();
            Exercise1_5();
            Console.WriteLine();
            Exercise1_6();
            Console.WriteLine();
            Exercise1_7();
            Console.WriteLine();
            Exercise1_8();

            Console.ReadLine();
        }

        private static void Exercise1_2() {
            var max = Library.Books
                .Max(b => b.Price);
            var book = Library.Books.First(b => b.Price == max);
            Console.WriteLine(book);
        }

        private static void Exercise1_3() {
            var query = Library.Books
                .GroupBy(b => b.PublishedYear)
                .Select(g => new { PublishedYear = g.Key, Count = g.Count() });
        }

        private static void Exercise1_4() {
            var query = Library.Books
                .Join(Library.Categories,
                        Book => Book.CategoryId,
                        category => category.Id,
                        (book, categpry) => new {
                            book.Title,
                            book.PublishedYear,
                            book.Price,
                            CategoryName = categpry.Name,
                        });
            foreach (var item in query) {
                Console.WriteLine("{0}年 {1}円 {2} ({3})",
                    item.PublishedYear,
                    item.Price,
                    item.Title,
                    item.CategoryName
                    );
            }
        }

        private static void Exercise1_5() {
            
        }

        private static void Exercise1_6() {
            
        }

        private static void Exercise1_7() {
            
        }

        private static void Exercise1_8() {
            
        }
    }
}
