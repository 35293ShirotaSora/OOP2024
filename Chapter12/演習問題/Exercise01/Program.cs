﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Exercise01 {
    internal class Program {
        private static int length;

        static void Main(string[] args) {
            Exercise1_1("employee.xml");

            // これは確認用
            Console.WriteLine(File.ReadAllText("employee.xml"));
            Console.WriteLine();

            Exercise1_2("employees.xml");
            Exercise1_3("employees.xml");
            Console.WriteLine(File.ReadAllText("employees.xml"));
            Console.WriteLine();

            Exercise1_4("employees.json");

            // これは確認用
            Console.WriteLine(File.ReadAllText("employees.json"));
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

            using(var writer = XmlWriter.Create(outfile, settings)) {
                var serializer = new XmlSerializer(typeof(Employee));
                serializer.Serialize(writer, employee);
            }

            using (var reader = XmlReader.Create(outfile)) {
                var serializer = new XmlSerializer(typeof(Employee));
                var employees = serializer.Deserialize(reader) as Employee;
                Console.WriteLine(employees);
            }
        }

        private static void Exercise1_2(string outfile) {
            var emps = new Employee[] {
                new Employee {
                    Id = 123,
                    Name = "佐藤",
                    HireDate = new DateTime(2012, 5, 3)
                },

                new Employee {
                    Id = 210,
                    Name = "斎藤",
                    HireDate = new DateTime(2009, 1, 23)
                },

            };
            
            using(var writer = XmlWriter.Create(outfile)) {
                var serializer = new DataContractSerializer(emps.GetType());
                serializer.WriteObject(writer, emps);
            }
        }

        private static void Exercise1_3(string file) {
            using(XmlReader reader = XmlReader.Create(file)) {
                var serializer = new DataContractSerializer(typeof(Employee[]));
                var emps = serializer.ReadObject(reader) as Employee[];
                foreach (var emp in emps) {
                    Console.WriteLine("{0}{1}{2}", emp.Id, emp.Name, emp.HireDate);
                }
            }
        }

        private static void Exercise1_4(string file) {
            var emps = new Employee[] {
                new Employee {
                    Id = 123,
                    Name = "佐藤",
                    HireDate = new DateTime(2012, 5, 3)
                },

                new Employee {
                    Id = 210,
                    Name = "斎藤",
                    HireDate = new DateTime(2009, 1, 23)
                },

            };

            using (var stream = new FileStream(file, FileMode.Create, FileAccess.Write)) { 

                var options = new JsonSerializerOptions {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,  //キー名のカスタマイズ
                    Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
                    WriteIndented = true,
                };

              JsonSerializer.Serialize(stream,emps, options);
                
            }
        }
    }
}
