using System.Collections.Generic;
using System.IO;

namespace Test01 {
    class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {
            _score = ReadScore(filePath);
        }


        //メソッドの概要：スコアデータを読み込み、Studentオブジェクトのリストを返す
        private static IEnumerable<Student> ReadScore(string filePath) {
            List<Student> scores = new List<Student>();
            string[] lines = File.ReadAllLines(filePath);
            foreach (var line in lines) {
                string[] item = line.Split(',');
                Student score = new Student {
                    Name = item[0],
                    Subject = item[1],
                    Score = int.Parse(item[2]),
                };
                scores.Add(score);
            }
            return scores;
        }

        //メソッドの概要：学生別の点数を求める
        public IDictionary<string, int> GetPerStudentScore() {
            var dict = new Dictionary<string, int>();
            foreach (var sale in _score) {
                if (dict.ContainsKey(sale.Name)) {
                    dict[sale.Name] += sale.Score;
                } else {
                    dict[sale.Name] = sale.Score;
                }
            }
            return dict;
        }
    }
}
