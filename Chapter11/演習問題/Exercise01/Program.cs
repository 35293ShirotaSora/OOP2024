using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            var file = "sample.xml";
            Exercise1_1(file);
            Console.WriteLine();
            Exercise1_2(file);
            Console.WriteLine();
            Exercise1_3(file);
            Console.WriteLine();

            var newfile = "sports.xml";
            Exercise1_4(file, newfile);

            

        }

        private static void Exercise1_1(string file) {
            var xdoc = XDocument.Load(file);
            var sports = xdoc.Root.Elements()
                             .Select(x => new {
                                 Name = x.Element("name").Value,
                                 Teammembers = x.Element("teammembers").Value
                             });
            foreach (var sport in sports) {
                Console.WriteLine("{0} {1}", sport.Name, sport.Teammembers);
            }
        }

        private static void Exercise1_2(string file) {
            var xdoc = XDocument.Load(file);
            var sports = xdoc.Root.Elements()
                            .Select(x => new {
                                Name = x.Element("name").Attribute("kanji").Value,
                                Firstplayed = x.Element("firstplayed").Value,
                            }).OrderBy(x=>x.Firstplayed);

            foreach (var sport in sports) {
                Console.WriteLine("{0}({1})", sport.Name, sport.Firstplayed);
            }

        }

        private static void Exercise1_3(string file) {
            var xdoc = XDocument.Load(file);
            /*var sports = xdoc.Root.Elements()
                             .OrderByDescending(x => x.Element("teammembers").Value)
                             .First();

            Console.WriteLine("{0}", sports.Name);*/

            var sport = xdoc.Root.Elements()
                            .Select(x => new {
                                Name = x.Element("name").Value,
                                Teammembers = x.Element("teammembers").Value
                            })
                            .OrderByDescending(x => int.Parse(x.Teammembers))
                            .First();
            Console.WriteLine("{0}",sport.Name);
        }

        private static void Exercise1_4(string file, string newfile) {
            /*var element = new XElement("ballsport",
                new XElement("name", "サッカー", new XAttribute("kanji", "蹴球")),
                new XElement("teammembers", "11"),
                new XElement("firstplayed", "1863")
            );

            var xdoc = XDocument.Load(file);
            xdoc.Root.Add(element);

            xdoc.Save(newfile);*/
            var xdoc = XDocument.Load(file);
            string name,kanji;
            int teammembers, origin,choice;
            List<XElement> xElements = new List<XElement>();

            while (true) {
                Console.Write("名称:");   name = Console.ReadLine();
                Console.Write("漢字:");   kanji = Console.ReadLine();
                Console.Write("人数:");   teammembers = int.Parse(Console.ReadLine());
                Console.Write("起源:");   origin = int.Parse(Console.ReadLine());

                Console.WriteLine();

                var element = new XElement("ballsport",
                    new XElement("name", name, new XAttribute("kanji", kanji)),
                    new XElement("teammenbers", teammembers),
                    new XElement("firstplayed", origin)
                );

                xElements.Add(element);

                Console.Write("追加(1)/保存(2)>");
                choice = int.Parse(Console.ReadLine());
                if (choice == 2)
                    break;
                Console.WriteLine();
            }
            xdoc.Root.Add(xElements);
            xdoc.Save(newfile);
        }
    }
}
