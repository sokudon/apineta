using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace api_neta
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); // フォームの起動
        }
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            var finaldata = "----";
            string[] rank;

            string s = ",";
            char c = s[0];
            rank = RANK.Text.Split(c);

            StringBuilder sb = new StringBuilder();
            for (var i = 0; i < rank.Length; i++)
            {

                WebClient wc = new WebClient();
                wc.Encoding = Encoding.UTF8;
                DateTime dt = DateTime.Now;

                string url = URL.Text + rank[i];

                string timeset = TIME.Text;
                string text = "";


                try
                {
                    text = wc.DownloadString(url);
                    //File.WriteAllText(@"tmp.js", text);
                }
                catch (WebException exc)
                {
                    wc.Dispose();
                    MessageBox.Show(exc.Message);
                    return;
                }

                wc.Dispose();

                var json = Codeplex.Data.DynamicJson.Parse(text);



                var j = json[0];
                int[] arr = j.data;
                int length = arr.Length - 1;

                if (oldtime.Text == "----")
                {

                }
                else
                {
                    length = length - 48 * Convert.ToInt32(oldtime.Text);
                    if (length < 0)
                    {
                        textBox1.Text = sb.ToString() + "\r\n\r\n" + rank[i] + "位はこれより前の日の探せるデータが存在してません。";
                        return;
                    }

                }
                double finaldatas = 0;

                if (timeset != "----")
                {
                    for (var ii = length; ii > 0; ii--)
                    {
                        var data = j.data[ii].aggregatedAt;
                        string pattern = "T" + timeset;
                        Match m = Regex.Match(data, pattern);
                        if (m.Success)
                        {

                            finaldata = j.data[ii].aggregatedAt;
                            finaldatas = j.data[ii].score;
                            break;
                        }

                    }

                }
                else
                {

                    var ii = length;
                    var data = j.data[ii].aggregatedAt;
                    finaldata = j.data[ii].aggregatedAt;
                    finaldatas = j.data[ii].score;
                }

                sb.Append(rank[i].ToString() + "位; " + finaldatas + "\r\n");
                sb.Append(finaldata.Replace("T", " ").Replace("-", "/") + "\r\n");
            }

            textBox1.Text = sb.ToString();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            Properties.Settings.Default.url = URL.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "api_neta buid:" + Properties.Settings.Default.buiddate;
            RANK.Text = Properties.Settings.Default.rank;
            TIME.Text = Properties.Settings.Default.time;
            URL.Text = Properties.Settings.Default.url;
            textBox2.Text = Properties.Settings.Default.api_goog;
            
            read_line();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            Properties.Settings.Default.time = TIME.Text;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.rank = RANK.Text;
        }



        private void 周年イベントToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            date form2 = new date();
            form2.ShowDialog();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void ajax_Click(object sender, EventArgs e)
        {
            string baseUrl = this.textBox2.Text;
            string text = textBox1.Text;
            string pattern = @"/(\d+)/"; // 数字1文字以上
            string encodedText = HttpUtility.UrlEncode(text); // URLエンコー
            string url =URL.Text;
            Match match = Regex.Match(url, pattern);

            if (match.Success)
            {
                string eventId = match.Groups[1].Value;
                Console.WriteLine(eventId); // "367"

                string requestUrl = $"{baseUrl}?text={encodedText}&url={eventId}";
                Main(requestUrl);
            }
        }


        static async Task Main(string url)
        {

            string requestUrl = url;

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(requestUrl);
                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Response: {result}");
                }
                else
                {
                    MessageBox.Show($"Error: {response.StatusCode}");
                }
            }
        }





        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            Properties.Settings.Default.api_goog = textBox2.Text; write_line();
        }

        private void write_line()
        {
            string s = URL.Text +"\r\n"+textBox2.Text;
            //ファイルを上書きし、Shift JISで書き込む
            System.IO.StreamWriter sw = new System.IO.StreamWriter(
               "setting.txt",
                false,
                System.Text.Encoding.GetEncoding(65001));
          
                sw.Write(s);
            sw.Close();
        }

        private void read_line()
        {
            string line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("setting.txt");
                    URL.Text = sr.ReadLine();
                    textBox2.Text = sr.ReadLine();

                //close the file
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }


        }
    }

}
