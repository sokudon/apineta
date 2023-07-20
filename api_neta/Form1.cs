using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace api_neta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    

        private void button1_Click(object sender, EventArgs e)
        {

            var finaldata = "----";
            string[] rank ;

            string s = ",";
            char c = s[0];
            rank = comboBox2.Text.Split(c);

            StringBuilder sb = new StringBuilder();
            for (var i = 0; i < rank.Length; i++) { 

            WebClient wc = new WebClient();
            wc.Encoding = Encoding.UTF8;
            DateTime dt = DateTime.Now;

            string url = textBox2.Text + rank[i];

            string timeset = comboBox1.Text;
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
            double finaldatas = 0;

                if (timeset != "----")
                {
                    for (var ii = length; ii > 0; ii--)
                    {
                        var data = j.data[ii].aggregatedAt;
                        string pattern = "T"+timeset;
                        Match m = Regex.Match(data, pattern);
                        if (m.Success)
                        {

                            finaldata = j.data[ii].aggregatedAt;
                            finaldatas = j.data[ii].score;
                            break;
                        }

                    }

                }
                else {

                    var ii = length;
                        var data = j.data[ii].aggregatedAt;
                            finaldata = j.data[ii].aggregatedAt;
                            finaldatas = j.data[ii].score;
                }

                sb.Append(rank[i].ToString() + "位; " + finaldatas + "\r\n");
                sb.Append(finaldata.Replace("T", " ").Replace("-", "/") + "\r\n");
            }

            Properties.Settings.Default.url = textBox2.Text;
            textBox1.Text = sb.ToString();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.textBox2.Text = Properties.Settings.Default.url;
            this.comboBox2.Text=Properties.Settings.Default.rank ;
            this.comboBox1.Text=Properties.Settings.Default.time ;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            Properties.Settings.Default.time = comboBox1.Text;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.rank = comboBox2.Text;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {

        }


        private void 周年イベントToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
