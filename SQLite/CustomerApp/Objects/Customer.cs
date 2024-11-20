using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace CustomerApp.Objects {
    public class Customer {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        /// <summary>
        /// 名前
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 電話番号
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 住所
        /// </summary>
        public string Address {  get; set; }
        /// <summary>
        /// 画像
        /// </summary>
        public byte[] Picture { get; set; }
        [Ignore]
        public BitmapImage PictureSource { get; set; }

        public override string ToString() {
            return $"{Id} {Name} {Phone} {Address} {Picture}";
        }
    }
}
