
namespace api_neta
{
    partial class date
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.IDOL = new System.Windows.Forms.ComboBox();
            this.URLPAST = new System.Windows.Forms.TextBox();
            this.URLNOW = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RANK = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.makegraph = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.allidol = new System.Windows.Forms.Button();
            this.NOWONLY = new System.Windows.Forms.CheckBox();
            this.TIME = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.zure2 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dates = new System.Windows.Forms.ComboBox();
            this.datediff = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IDOL
            // 
            this.IDOL.FormattingEnabled = true;
            this.IDOL.Items.AddRange(new object[] {
            "1\t天海春香",
            "2\t如月千早",
            "3\t星井美希",
            "4\t萩原雪歩",
            "5\t高槻やよい",
            "6\t菊地真",
            "7\t水瀬伊織",
            "8\t四条貴音",
            "9\t秋月律子",
            "10\t三浦あずさ",
            "11\t双海亜美",
            "12\t双海真美",
            "13\t我那覇響",
            "14\t春日未来",
            "15\t最上静香",
            "16\t伊吹翼",
            "17\t田中琴葉",
            "18\t島原エレナ",
            "19\t佐竹美奈子",
            "20\t所恵美",
            "21\t徳川まつり",
            "22\t箱崎星梨花",
            "23\t野々原茜",
            "24\t望月杏奈",
            "25\tロコ",
            "26\t七尾百合子",
            "27\t高山紗代子",
            "28\t松田亜利沙",
            "29\t高坂海美",
            "30\t中谷育",
            "31\t天空橋朋花",
            "32\tエミリー",
            "33\t北沢志保",
            "34\t舞浜歩",
            "35\t木下ひなた",
            "36\t矢吹可奈",
            "37\t横山奈緒",
            "38\t二階堂千鶴",
            "39\t馬場このみ",
            "40\t大神環",
            "41\t豊川風花",
            "42\t宮尾美也",
            "43\t福田のり子",
            "44\t真壁瑞希",
            "45\t篠宮可憐",
            "46\t百瀬莉緒",
            "47\t永吉昴",
            "48\t北上麗花",
            "49\t周防桃子",
            "50\tジュリア",
            "51\tつむぎ",
            "52\tかおり"});
            this.IDOL.Location = new System.Drawing.Point(93, 12);
            this.IDOL.Name = "IDOL";
            this.IDOL.Size = new System.Drawing.Size(169, 23);
            this.IDOL.TabIndex = 1;
            this.IDOL.Text = "21\t徳川まつり";
            this.IDOL.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // URLPAST
            // 
            this.URLPAST.Location = new System.Drawing.Point(56, 53);
            this.URLPAST.Name = "URLPAST";
            this.URLPAST.Size = new System.Drawing.Size(637, 22);
            this.URLPAST.TabIndex = 2;
            this.URLPAST.Text = "https://api.matsurihi.me/mltd/v1/events/241/rankings/logs/idolPoint/21/100";
            this.URLPAST.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // URLNOW
            // 
            this.URLNOW.Location = new System.Drawing.Point(56, 81);
            this.URLNOW.Name = "URLNOW";
            this.URLNOW.Size = new System.Drawing.Size(637, 22);
            this.URLNOW.TabIndex = 3;
            this.URLNOW.Text = "https://api.matsurihi.me/mltd/v1/events/290/rankings/logs/idolPoint/21/100";
            this.URLNOW.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "去年";
            // 
            // RANK
            // 
            this.RANK.FormattingEnabled = true;
            this.RANK.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "10",
            "100",
            "1000",
            "----",
            "100",
            "2500",
            "5000",
            "10000"});
            this.RANK.Location = new System.Drawing.Point(312, 12);
            this.RANK.Name = "RANK";
            this.RANK.Size = new System.Drawing.Size(121, 23);
            this.RANK.TabIndex = 5;
            this.RANK.Text = "100";
            this.RANK.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "今年";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "去年と比較";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(323, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(323, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(548, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "label7";
            // 
            // makegraph
            // 
            this.makegraph.Location = new System.Drawing.Point(515, 294);
            this.makegraph.Name = "makegraph";
            this.makegraph.Size = new System.Drawing.Size(119, 23);
            this.makegraph.TabIndex = 13;
            this.makegraph.Text = "cmp_highc生成";
            this.makegraph.UseVisualStyleBackColor = true;
            this.makegraph.Click += new System.EventHandler(this.button2_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(24, 298);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(490, 15);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "グラフ生成、grafu.zipを展開して exeとおなじパスにHighstockなんらをおいてください\r\n";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "アイドル";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(268, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "ランク";
            // 
            // allidol
            // 
            this.allidol.Location = new System.Drawing.Point(515, 265);
            this.allidol.Name = "allidol";
            this.allidol.Size = new System.Drawing.Size(133, 23);
            this.allidol.TabIndex = 18;
            this.allidol.Text = "52人alldata.txt";
            this.allidol.UseVisualStyleBackColor = true;
            this.allidol.Click += new System.EventHandler(this.button3_Click);
            // 
            // NOWONLY
            // 
            this.NOWONLY.AutoSize = true;
            this.NOWONLY.Location = new System.Drawing.Point(192, 128);
            this.NOWONLY.Name = "NOWONLY";
            this.NOWONLY.Size = new System.Drawing.Size(114, 19);
            this.NOWONLY.TabIndex = 19;
            this.NOWONLY.Text = "現行のみ取得";
            this.NOWONLY.UseVisualStyleBackColor = true;
            this.NOWONLY.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // TIME
            // 
            this.TIME.FormattingEnabled = true;
            this.TIME.Items.AddRange(new object[] {
            "----",
            "17:00",
            "00:00:00",
            "01:00",
            "02:00",
            "03:00",
            "04:00",
            "05:00",
            "06:00",
            "07:00",
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00",
            "22:00",
            "23:00"});
            this.TIME.Location = new System.Drawing.Point(396, 126);
            this.TIME.Name = "TIME";
            this.TIME.Size = new System.Drawing.Size(121, 23);
            this.TIME.TabIndex = 20;
            this.TIME.Text = "----";
            this.TIME.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(323, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "時間指定";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(309, 269);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(205, 15);
            this.label11.TabIndex = 22;
            this.label11.Text = "全員分の特定時刻の一覧でーた:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(523, 132);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 15);
            this.label13.TabIndex = 25;
            this.label13.Text = "去年検索ずれ";
            // 
            // zure2
            // 
            this.zure2.FormattingEnabled = true;
            this.zure2.Items.AddRange(new object[] {
            "全件(-624)",
            "-192",
            "-144",
            "-96",
            "-48",
            "-24",
            "-23",
            "-22",
            "-21",
            "-20",
            "-19",
            "-18",
            "-17",
            "-16",
            "-15",
            "-14",
            "-13",
            "-12",
            "-11",
            "-10",
            "-9",
            "-8",
            "-7",
            "-6",
            "-5",
            "-4",
            "-3",
            "-2",
            "-1",
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "48",
            "96",
            "144",
            "192"});
            this.zure2.Location = new System.Drawing.Point(622, 126);
            this.zure2.Name = "zure2";
            this.zure2.Size = new System.Drawing.Size(71, 23);
            this.zure2.TabIndex = 26;
            this.zure2.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(541, 157);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 15);
            this.label12.TabIndex = 27;
            this.label12.Text = "日付指定";
            // 
            // dates
            // 
            this.dates.FormattingEnabled = true;
            this.dates.Items.AddRange(new object[] {
            "----",
            "06/29",
            "06/30",
            "07/01",
            "07/02",
            "07/03",
            "07/04",
            "07/05",
            "07/06",
            "07/07",
            "07/08",
            "07/09",
            "07/10",
            "07/11",
            "07/12",
            "07/13"});
            this.dates.Location = new System.Drawing.Point(622, 154);
            this.dates.Name = "dates";
            this.dates.Size = new System.Drawing.Size(71, 23);
            this.dates.TabIndex = 28;
            this.dates.Text = "----";
            // 
            // datediff
            // 
            this.datediff.FormattingEnabled = true;
            this.datediff.Items.AddRange(new object[] {
            "----",
            "-1",
            "1"});
            this.datediff.Location = new System.Drawing.Point(622, 183);
            this.datediff.Name = "datediff";
            this.datediff.Size = new System.Drawing.Size(71, 23);
            this.datediff.TabIndex = 29;
            this.datediff.Text = "----";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(526, 186);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 15);
            this.label14.TabIndex = 30;
            this.label14.Text = "去年日付ズレ";
            // 
            // date
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 329);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.datediff);
            this.Controls.Add(this.dates);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.zure2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TIME);
            this.Controls.Add(this.NOWONLY);
            this.Controls.Add(this.allidol);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.makegraph);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RANK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.URLNOW);
            this.Controls.Add(this.URLPAST);
            this.Controls.Add(this.IDOL);
            this.Name = "date";
            this.Text = "周年イベント";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox IDOL;
        private System.Windows.Forms.TextBox URLPAST;
        private System.Windows.Forms.TextBox URLNOW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox RANK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button makegraph;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button allidol;
        private System.Windows.Forms.CheckBox NOWONLY;
        private System.Windows.Forms.ComboBox TIME;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox zure2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox dates;
        private System.Windows.Forms.ComboBox datediff;
        private System.Windows.Forms.Label label14;
    }
}