using System;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyEBookReader
{
    public partial class FormMyEBookReader : Form
    {
        private string theEBook;

        public FormMyEBookReader()
        {
            InitializeComponent();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();
            wc.DownloadStringCompleted += (s, eArgs) =>
            {
                theEBook = eArgs.Result;
                txtBook.Text = theEBook;
            };

            //  Prohect Gutenberg中的电子书，查尔斯·狄更斯所著的《双城记》
            wc.DownloadStringAsync(new Uri("http://www.gutenberg.org/files/98/98-8.txt"));
        }

        private void btnGetStats_Click(object sender, EventArgs e)
        {
            //  从电子书中获取单词
            string[] words = theEBook.Split(new char[] { ' ', '\u000A', ',', '.', ';', ':', '-', '?', '/' },
                StringSplitOptions.RemoveEmptyEntries);

            string[] tenMostCommon = null;
            string longestWord = string.Empty;
            Parallel.Invoke(
                () =>
                {
                    //  找多最常用的10个单词
                    tenMostCommon = FindTenMostCommon(words);
                },
                () =>
                {
                    //  获取最长的单词
                    longestWord = FindLongestWord(words);
                });

            //  完成所有任务之后，创建一个字符串以在消息框中显示所有的统计信息
            StringBuilder bookStats = new StringBuilder("Ten Most Common Words are:\n");
            foreach (string s in tenMostCommon)
            {
                bookStats.AppendLine(s);
            }
            bookStats.AppendFormat("Longest word is: {0}", longestWord);
            bookStats.AppendLine();
            MessageBox.Show(bookStats.ToString(), "Book info");
        }

        private string[] FindTenMostCommon(string[] words)
        {
            var frequencyOrder = from word in words
                                 where word.Length > 6
                                 group word by word into g
                                 orderby g.Count() descending
                                 select g.Key;
            string[] commonWord = (frequencyOrder.Take(10)).ToArray();
            return commonWord;
        }

        private string FindLongestWord(string[] words)
        {
            return (from w in words orderby w.Length descending select w).FirstOrDefault();
        }
    }
}
