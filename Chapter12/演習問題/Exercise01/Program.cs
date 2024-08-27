using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            Exercise1_1("employee.xml");

            // これは確認用
            Console.WriteLine(File.ReadAllText("employees.xml"));
            Console.WriteLine();

            Exercise1_2("employees.xml");
            Exercise1_3("employees.xml");
            Console.WriteLine();

            //Exercise1_4("employees.json");

            // これは確認用
            //Console.WriteLine(File.ReadAllText("employees.json"));
        }

        private static void Exercise1_1(string outfile) {
            var employee = new Employee {
                Id = 5, 
                Name = "田中",
                HireDate = new DateTime(2010,1,1)
            };

            var settings = new XmlWriterSettings {
                Encoding = new UTF8Encoding(false),
                Indent = true,
                IndentChars = " ",
            };

            using(var writer = XmlWriter.Create("employees.xml", settings)) {
                var serializer = new XmlSerializer(typeof(Employee));
                serializer.Serialize(writer, employee);
            }

            using (var reader = XmlReader.Create("employees.xml")) {
                var serializer = new XmlSerializer(typeof(Employee));
                var employees = serializer.Deserialize(reader) as Employee;
                Console.WriteLine(employees);
            }
        }

        private static void Exercise1_2(string v) {
        
        }

        private static void Exercise1_3(string v) {
        
        }

        private static void Exercise1_4(string v) {
        
        }
    }
}
