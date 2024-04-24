using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCounter {
    internal class Program {
        static void Main(string[] args) {
            List<Sale> sales = ReadSales(@"C:\\Users\\infosys\\source\\repos\\OOP2024\\Chapter02\\SalesCounter\\bin\\Debug\\data\\Sales.csv");

            foreach (Sale sale in sales) {
                //Console.WriteLine(sale.ShopName + " " + sale.ProductCategory + " " + sale.Amount);
                /*Console.WriteLine("店名:{0} カテゴリー:{1} 売上:{2}",
                                             sale.ShopName, sale.ProductCategory, sale.Amount);*/
                Console.WriteLine($"店名:{sale.ShopName} カテゴリー:{sale.ProductCategory} 売上{sale.Amount}");
            }
        }

        //売り上げデータを読み込み、Saleオブジェクトのリストを返す
        static List<Sale> ReadSales(string filePath) {
            List<Sale> sales = new List<Sale>();
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines) {
                string[] item = line.Split(',');
                Sale sale = new Sale {
                    ShopName = item[0],
                    ProductCategory = item[1],
                    Amount = int.Parse(item[2]),
                };
                sales.Add(sale);
            }
            return sales;
        }
    }
}
