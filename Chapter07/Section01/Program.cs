using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    internal class Program {
        static private Dictionary<string, string> prefOfficeDict = new Dictionary<string, string>();

        static void Main(string[] args) {
            string pref, prefcaploc;
            Console.WriteLine("県庁所在地の登録");

            while (true) {
                Console.Write("都道府県:");
                pref = Console.ReadLine();

                if(pref == null) {
                    break;
                }

                Console.Write("県庁所在地:");
                prefcaploc = Console.ReadLine();
                if (prefOfficeDict.ContainsKey(pref)) {
                    Console.WriteLine("上書きしますか？(Y/N)");
                    if (Console.ReadLine() == "N") {
                        continue;
                    }
                }
                prefOfficeDict.Add(pref, prefcaploc);
            }

            Console.WriteLine();

            Boolean endFlag = false;
            while (!endFlag) {
                switch (menuDisp()) {
                    case "1":
                        allDisp();
                        Console.WriteLine();
                        break;

                    case "2":
                        searchMethod();
                        break;

                    case "9":
                        endFlag = true;
                        break;
                }
            }
        }

      
        private static void allDisp() {
            foreach (var items in prefOfficeDict) {
                Console.WriteLine($"{items.Key}の県庁所在地は{items.Value}です");
            }
        }

        private static void searchMethod() {
            Console.WriteLine("都道府県");
            string searchPref = Console.ReadLine();
            Console.WriteLine($"{searchPref}の県庁所在地は{prefOfficeDict[searchPref]}です。");
            Console.WriteLine();
        }

        private static string menuDisp() {
            Console.WriteLine("**** メニュー ****");
            Console.WriteLine("１: 一覧表示");
            Console.WriteLine("２: 検索");
            Console.WriteLine("９: 終了");
            Console.Write("＞");
            string menuSelect = Console.ReadLine();
            Console.WriteLine();
            return menuSelect;
        }

        /* var employeeDict = new Dictionary<int, Employee> {
               { 100, new Employee(100, "清水遼久") },
               { 112, new Employee(112, "芹沢洋和") },
               { 125, new Employee(125, "岩瀬奈央子") },
            };

            employeeDict.Add(126, new Employee(126,"庄野春香"));

            foreach( var item in employeeDict) {
                Console.WriteLine($"{item}");
            }*/
    }
}
