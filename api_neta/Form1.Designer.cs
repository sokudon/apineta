﻿
namespace api_neta
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.URL = new System.Windows.Forms.TextBox();
            this.TIME = new System.Windows.Forms.ComboBox();
            this.RANK = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.周年イベントToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oldtime = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 105);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(516, 200);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(534, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 200);
            this.button1.TabIndex = 1;
            this.button1.Text = "ぼだ取得";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // URL
            // 
            this.URL.Location = new System.Drawing.Point(58, 29);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(677, 22);
            this.URL.TabIndex = 2;
            this.URL.Text = "https://api.matsurihi.me/api/mltd/v2/events/357/rankings/eventPoint/logs/";
            this.URL.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TIME
            // 
            this.TIME.FormattingEnabled = true;
            this.TIME.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.TIME.Items.AddRange(new object[] {
            "17:00",
            "00:00:00",
            "21:00",
            "21:30",
            "----",
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
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00",
            "22:00",
            "23:00"});
            this.TIME.Location = new System.Drawing.Point(58, 66);
            this.TIME.Name = "TIME";
            this.TIME.Size = new System.Drawing.Size(121, 23);
            this.TIME.TabIndex = 3;
            this.TIME.Text = "17:00";
            this.TIME.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // RANK
            // 
            this.RANK.FormattingEnabled = true;
            this.RANK.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.RANK.Items.AddRange(new object[] {
            "100,2500,5000,10000,25000,50000 ",
            "100,2500,5000,10000"});
            this.RANK.Location = new System.Drawing.Point(239, 65);
            this.RANK.Name = "RANK";
            this.RANK.Size = new System.Drawing.Size(284, 23);
            this.RANK.TabIndex = 5;
            this.RANK.Text = "100,2500,5000,10000,25000,50000";
            this.RANK.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.周年イベントToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(741, 35);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 周年イベントToolStripMenuItem
            // 
            this.周年イベントToolStripMenuItem.Name = "周年イベントToolStripMenuItem";
            this.周年イベントToolStripMenuItem.Size = new System.Drawing.Size(134, 31);
            this.周年イベントToolStripMenuItem.Text = "周年イベント";
            this.周年イベントToolStripMenuItem.Click += new System.EventHandler(this.周年イベントToolStripMenuItem_Click_1);
            // 
            // oldtime
            // 
            this.oldtime.FormattingEnabled = true;
            this.oldtime.Items.AddRange(new object[] {
            "-----",
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
            "12"});
            this.oldtime.Location = new System.Drawing.Point(585, 65);
            this.oldtime.Name = "oldtime";
            this.oldtime.Size = new System.Drawing.Size(121, 23);
            this.oldtime.TabIndex = 7;
            this.oldtime.Text = "----";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(534, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "n日前";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "URL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "時刻";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "ランク";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 317);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.oldtime);
            this.Controls.Add(this.RANK);
            this.Controls.Add(this.TIME);
            this.Controls.Add(this.URL);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "api_neta";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox URL;
        private System.Windows.Forms.ComboBox TIME;
        private System.Windows.Forms.ComboBox RANK;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 周年イベントToolStripMenuItem;
        private System.Windows.Forms.ComboBox oldtime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

