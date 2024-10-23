using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RssReader {

    public partial class Form1 : Form {

        Dictionary<string, string> rssDict;
        List<ItemData> items;



        public Form1() {
            InitializeComponent();

            rssDict = new Dictionary<string, string> {
                { "国内", "https://news.yahoo.co.jp/rss/topics/domestic.xml" },
                { "国際", "https://news.yahoo.co.jp/rss/topics/world.xml" },
                { "経済", "https://news.yahoo.co.jp/rss/topics/business.xml" },
                { "エンタメ", "https://news.yahoo.co.jp/rss/topics/entertainment.xml" },
                { "スポーツ", "https://news.yahoo.co.jp/rss/topics/sports.xml" },
                { "IT", "https://news.yahoo.co.jp/rss/topics/it.xml" },
                { "科学", "https://news.yahoo.co.jp/rss/topics/science.xml" },
                { "地域", "https://news.yahoo.co.jp/rss/topics/local.xml" },
            };

            foreach (var item in rssDict.Keys) {
                cbRssUrl.Items.Add(item);
            }

            //btRssRegister.Click += btRssRegister_Click;
            cbRssUrl.SelectedIndexChanged += cbRssUrl_SelectedIndexChanged;
            
        }

        private void cbRssUrl_SelectedIndexChanged(object sender, EventArgs e) {
            lbRssTitle.Items.Clear();
        }

        private void btGet_Click(object sender, EventArgs e) {
            if (cbRssUrl.SelectedItem == null)
                return;

            string selectedCategory = cbRssUrl.SelectedItem.ToString();
            string rssUrl = rssDict[selectedCategory];

            using (var wc = new WebClient()) {
                var url = wc.OpenRead(rssUrl);
                var xdoc = XDocument.Load(url);

                items = xdoc.Root.Descendants("item")
                                      .Select(item => new ItemData {
                                          Title = item.Element("title").Value,
                                          Link = item.Element("link").Value,
                                      }).ToList();

                foreach (var item in items) {
                    lbRssTitle.Items.Add(item.Title);
                }
            }
        }

        private void lbRssTitle_SelectedIndexChanged(object sender, EventArgs e) {
            if (lbRssTitle.SelectedItem != null) {
                var selectedTitle = lbRssTitle.SelectedItem.ToString();
                var selectedItem = items.FirstOrDefault(item => item.Title == selectedTitle);
                if (selectedItem != null) {
                    webView21.Source = new Uri(selectedItem.Link);
                }
            }
        }

        private void btRssRegister_Click(object sender, EventArgs e) {
            btRssRegister.Enabled = false;

            string favoriteTitle = tbRssFavorite.Text.Trim();
            string selectedUrl = cbRssUrl.Text.ToString();

            if (!string.IsNullOrEmpty(favoriteTitle) && !string.IsNullOrEmpty(selectedUrl)) {
                cbRssUrl.Items.Add(favoriteTitle);
                rssDict[favoriteTitle] = selectedUrl; 
                tbRssFavorite.Clear();
                MessageBox.Show("登録完了");
            } else {
                MessageBox.Show("名称とURLの両方を入力してください。");
            }
            btRssRegister.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e) {

        }
    }
    public class ItemData {
        public string Title { get; set; }
        public string Link { get; set; }
    }
}
