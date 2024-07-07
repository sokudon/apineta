﻿using System;
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

using System.Threading;

namespace api_neta
{
    public partial class date : Form
    {
        public date()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {


            WebClient wc = new WebClient();
            wc.Encoding = Encoding.UTF8;
            DateTime dt = DateTime.Now;

            string url = URLPAST.Text;
            string url2 = URLNOW.Text;

            string idol = (IDOL.SelectedIndex + 1).ToString();
            string rank = RANK.Text;

            url = Regex.Replace(url, "\\/\\d?\\d\\/", "/" + idol + "/");
            url2 = Regex.Replace(url2, "\\/\\d?\\d\\/", "/" + idol + "/");
            url = Regex.Replace(url, "\\/(\\d+,)*\\d+$", "/" + rank);
            url2 = Regex.Replace(url2, "\\/(\\d+,)*\\d+$", "/" + rank);

            URLPAST.Text = url;

            URLNOW.Text = url2;

            string text = "";
            string text2 = "";
            if (NOWONLY.Checked == false)
            {
                try
                {
                    text = wc.DownloadString(url);
                    File.WriteAllText(@"tmp.js", text);
                }
                catch (WebException exc)
                {
                    wc.Dispose();
                    MessageBox.Show(exc.Message);
                    return;
                }
            }

            try
            {
                text2 = wc.DownloadString(url2);
                File.WriteAllText(@"tmp2.js", text2);
            }
            catch (WebException exc)
            {
                MessageBox.Show(exc.Message);
                wc.Dispose();
                return;
            }
            wc.Dispose();

            var json = Codeplex.Data.DynamicJson.Parse(text2);

            label3.Text = "--";
            label4.Text = "--";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";

            if (text2 == "[]")
            {
                return;
            }
            var j = json[0];
            int[] arr = j.data;
            int length = arr.Length -1;//arr.Length - 1;
            var finaldata = "----";
            double finaldatas = 0;
            var timeset = TIME.Text;
            var dateset = dates.Text;
            var datesetkyonen = dates.Text;
            var daydiff = datediff.Text;

            var datesetrg="";
            var datesetkyonenrg="";

            if (dateset != "----")
            {
                datesetrg = dateset.Replace("/", "-") + "T";
                datesetkyonenrg = datesetrg;

                if (daydiff != "----")
                {
                    var days = double.Parse(daydiff);
                    DateTime dateTimeFromTime = DateTime.Parse(dateset);
                    datesetrg = dateTimeFromTime.ToString("MM-ddT");
                    dateTimeFromTime=dateTimeFromTime.AddDays(days);
                    datesetkyonenrg = dateTimeFromTime.ToString("MM-ddT");

                }
            }
            else {
                datesetrg = "";
                datesetkyonenrg = "";

            }

            string pattern = datesetrg + timeset;
            string patternkyonen = datesetkyonenrg + timeset;

            if (length < 0)
            {


                label3.Text = finaldata;
                label4.Text = String.Format("{0:#,0}", finaldatas);

            }
            else
            {
                finaldata = j.data[length].summaryTime;
                finaldatas = j.data[length].score;

                if (timeset != "----")
                {
                    for (var i = length; i > 0; i--)
                    {
                        var data = j.data[i].summaryTime;
                        Match m = Regex.Match(data, pattern);
                        if (m.Success)
                        {

                            finaldata = j.data[i].summaryTime;
                            finaldatas = j.data[i].score;
                            break;
                        }

                    }

                }

                label3.Text = finaldata;
                label4.Text = String.Format("{0:#,0}", finaldatas);

                Properties.Settings.Default.url3 = this.URLNOW.Text;

                if (NOWONLY.Checked == false)
                {
                    var jsonlast = Codeplex.Data.DynamicJson.Parse(text);
                    var jj = jsonlast[0];
                    int[] arr2 = jj.data;
                    length -= Convert.ToInt32(zure2.Text);

                    if (length <0)
                    {
                        length = 0;
                    }
                    if (length > arr2.Length - 1)
                    {
                        length = arr2.Length - 1;
                    }

                    var ffinaldata = jj.data[length].summaryTime;
                    var ffinaldatas = jj.data[length].score;

                    if (timeset != "----")
                    {
                        int length2 = length;

                        for (var i = length2; i > 0; i--)
                        {
                            var data = jj.data[i].summaryTime;
                            Match m = Regex.Match(data, patternkyonen);
                            if (m.Success)
                            {

                                ffinaldata = jj.data[i].summaryTime;
                                ffinaldatas = jj.data[i].score;
                                break;
                            }

                        }

                    }


                    label5.Text = ffinaldata;
                    label6.Text = String.Format("{0:#,0}", ffinaldatas);
                    label7.Text = String.Format("{0:#,0}", finaldatas - ffinaldatas);

                    Properties.Settings.Default.url2 = this.URLPAST.Text;

                }
                else
                {

                    label5.Text = "--";
                    label6.Text = "--";
                    label7.Text = "--";
                }
            }



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            Properties.Settings.Default.rank2 = this.RANK.Text;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.RANK.Text = Properties.Settings.Default.rank2;
            this.IDOL.Text = Properties.Settings.Default.idol;


            this.NOWONLY.Checked = Properties.Settings.Default.genzai;
            this.URLPAST.Text = Properties.Settings.Default.url2;
            this.URLNOW.Text = Properties.Settings.Default.url3;
            this.TIME.Text = Properties.Settings.Default.timeset;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            WebClient wc = new WebClient();
            wc.Encoding = Encoding.UTF8;
            DateTime dt = DateTime.Now;

            string url = URLPAST.Text;
            string url2 = URLNOW.Text;

            string idol = (IDOL.SelectedIndex + 1).ToString();
            string rank = RANK.Text;

            url = Regex.Replace(url, "\\/\\d?\\d\\/", "/" + idol + "/");
            url2 = Regex.Replace(url2, "\\/\\d?\\d\\/", "/" + idol + "/");

            string idolname = Regex.Replace(IDOL.Text, "\\d+[ 　\\t]", "").Trim();


            if (url2.IndexOf("eventPoint") > 0)
            {

                url = Regex.Replace(url, "\\/\\d+$", "/100,2500,5000,10000");
                url2 = Regex.Replace(url2, "\\/\\d+$", "/100,2500,5000,10000");
                idolname = "いべんと";
            }
            else
            {
                url = Regex.Replace(url, "\\/\\d+$", "/1,2,3,10,100,1000");
                url2 = Regex.Replace(url2, "\\/\\d+$", "/1,2,3,10,100,1000");
            }

            URLPAST.Text = url;

            URLNOW.Text = url2;


            string text = "";
            string text2 = "";
            try
            {
                text = wc.DownloadString(url);
                File.WriteAllText(@"d1.js", "var bn='後" + idolname + "';var bd=" + text);
            }
            catch (WebException exc)
            {
                wc.Dispose();
                MessageBox.Show(exc.Message);
                return;
            }


            try
            {
                text2 = wc.DownloadString(url2);
                File.WriteAllText(@"d2.js", "var cn='前" + idolname + "'; var data=" + text2);
            }
            catch (WebException exc)
            {
                MessageBox.Show(exc.Message);
                wc.Dispose();
                return;
            }

            wc.Dispose();
            System.Diagnostics.Process.Start("Highstock compare.html");



        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            System.Diagnostics.Process.Start("https://github.com/sokudon/apineta/tree/master/api_neta/bin/Release");
        }

        private void button3_Click(object sender, EventArgs e)
        {


            WebClient wc = new WebClient();
            wc.Encoding = Encoding.UTF8;
            DateTime dt = DateTime.Now;

            string url = URLPAST.Text;
            string url2 = URLNOW.Text;

            string idol = (IDOL.SelectedIndex + 1).ToString();
            string rank = RANK.Text;


            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            for (int i = 1; i < 53; i++) //53
            {

                url = Regex.Replace(url, "\\/\\d?\\d\\/", "/" + i.ToString() + "/");
                url2 = Regex.Replace(url2, "\\/\\d?\\d\\/", "/" + i.ToString() + "/");
                url = Regex.Replace(url, "\\/(\\d+,)*\\d+$", "/" + rank);
                url2 = Regex.Replace(url2, "\\/(\\d+,)*\\d+$", "/" + rank);

                URLPAST.Text = url;
                URLNOW.Text = url2;

                string text = "";
                string text2 = "";
                if (NOWONLY.Checked == false)
                {
                    try
                    {
                        text = wc.DownloadString(url);
                        File.WriteAllText(@"tmp.js" + i.ToString(), text);
                    }
                    catch (WebException exc)
                    {
                        wc.Dispose();
                        MessageBox.Show(exc.Message);
                        return;
                    }
                }

                try
                {
                    text2 = wc.DownloadString(url2);
                    File.WriteAllText(@"tmp2.js" + i.ToString(), text2);
                }
                catch (WebException exc)
                {
                    MessageBox.Show(exc.Message);
                    wc.Dispose();
                    return;

                }

                wc.Dispose();

                var json = Codeplex.Data.DynamicJson.Parse(text2);

                IDOL.SelectedIndex = i - 1;
                if (text2 == "[]")
                {
                    sb.Append(IDOL.Text);
                    sb.Append(" ");
                    sb.Append("--");
                    sb.Append(" ");
                    sb.Append("--");
                    sb.Append(" ");
                    sb.AppendLine();
                    continue;
                }
                var j = json[0];
                int[] arr = j.data;
                int length = arr.Length - 1;
                var finaldata = "----";
                double finaldatas = 0;
                var timeset = TIME.Text;

                if (length < 0)
                {



                }
                else
                {


                    finaldata = j.data[length].summaryTime;
                    finaldatas = j.data[length].score;

                    if (timeset != "----")
                    {
                        for (var ii = length; ii > 0; ii--)
                        {
                            var data = j.data[ii].summaryTime;
                            string pattern = timeset;
                            Match m = Regex.Match(data, pattern);
                            if (m.Success)
                            {

                                finaldata = j.data[ii].summaryTime;
                                finaldatas = j.data[ii].score;
                                break;
                            }

                        }

                    }
                }

                sb.Append(IDOL.Text);
                sb.Append(" ");
                sb.Append(finaldata);
                sb.Append(" ");
                sb.Append(finaldatas);
                sb.Append(" ");

                if (NOWONLY.Checked == false)
                {
                    var jsonlast = Codeplex.Data.DynamicJson.Parse(text);
                    var jj = jsonlast[0];

                    length -= 3;
                    var ffinaldata = jj.data[length].summaryTime;
                    var ffinaldatas = jj.data[length].score;


                    if (timeset != "----")
                    {
                        int[] arr2 = jj.data;
                        int length2 = arr.Length - 1;


                        for (var ii = length2; ii > 0; ii--)
                        {
                            var data = jj.data[ii].summaryTime;
                            string pattern = timeset;
                            Match m = Regex.Match(data, pattern);
                            if (m.Success)
                            {

                                ffinaldata = jj.data[ii].summaryTime;
                                ffinaldatas = jj.data[ii].score;
                                break;
                            }

                        }

                    }

                    sb.Append(ffinaldata);
                    sb.Append(" ");
                    sb.Append(ffinaldatas);
                    sb.Append(" ");
                    sb.Append(finaldatas - ffinaldatas);
                }
                sb.AppendLine();
                Thread.Sleep(500);
            }
            string str2 = sb.ToString();
            str2 = Regex.Replace(str2, " ", "\t");

            File.WriteAllText(@"alldata" + RANK.Text + ".txt", str2);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            Properties.Settings.Default.genzai = this.NOWONLY.Checked;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            Properties.Settings.Default.timeset = TIME.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            Properties.Settings.Default.url3 = this.URLNOW.Text;
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            Properties.Settings.Default.idol = this.IDOL.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            Properties.Settings.Default.url2 = this.URLPAST.Text;
        }
    }
}
