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

        List<ItemData> items;



        public Form1() {
            InitializeComponent();
        }



        private void btGet_Click(object sender, EventArgs e) {
            using (var wc = new WebClient()) {
                var url = wc.OpenRead(cbRssUrl.Text);
                var xdoc = XDocument.Load(url);

                items = xdoc.Root.Descendants("item")
                                      .Select(item => new ItemData{
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

        private void Form1_Load(object sender, EventArgs e) {
            List<ItemSet> rssUrl = new List<ItemSet>();

            rssUrl.Add(new ItemSet("https://news.yahoo.co.jp/topics/top-picks?source=rss", "主要" ));
            rssUrl.Add(new ItemSet("国内", "https://news.yahoo.co.jp/topics/domestic?source=rss"));

            cbRssUrl.DataSource = rssUrl;
            cbRssUrl.ValueMember = "ItemLink";
            cbRssUrl.DisplayMember = "ItemName";

        }

    }
    public class ItemData {
        public string Title { get; set; }
        public string Link { get; set; }
    }

    public class ItemSet {
        public String ItemName { get; set; }
        public String ItemLink { get; set; }

        public ItemSet(String n, String l) {
            ItemName = n;
            ItemLink = l;
        }
    }
}
