using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFileProcessor;


namespace TextNumberSizeChange {
    class ToHankakuProcessor : TextProcessor{
        Dictionary<char, char> ToHankaku = new Dictionary<char, char>() {
            {'０','0'},{'１','1'},{'２','2'},{'３','3'},{'４','4'},
            {'５','5'},{'６','6'},{'７','7'},{'８','8'},{'９','9'}
        };

        private int _count;

        protected override void Initialize(string fname) {
            _count = 0;
        }

        protected override void Execute(string line) {
            _count++;
            string convertedLine = ConvertToHankaku(line);
            Console.WriteLine(convertedLine);
        }

        private string ConvertToHankaku(string input) {
            char[] output = new char[input.Length];
            for (int i = 0; i < input.Length; i++) {
                output[i] = ToHankaku.ContainsKey(input[i]) ? ToHankaku[input[i]] : input[i];
            }
            return new string(output);
        }

        protected override void Terminate() {
            Console.WriteLine("{0}行",_count);
        }
    }
}
