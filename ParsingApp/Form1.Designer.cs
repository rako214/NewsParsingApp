﻿namespace ParsingApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.rTBRead = new System.Windows.Forms.RichTextBox();
            this.rTBLoad = new System.Windows.Forms.RichTextBox();
            this.btnReadNews = new System.Windows.Forms.Button();
            this.btnLoadNewsToDB = new System.Windows.Forms.Button();
            this.btnReadNewsFromDB = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rTBRead
            // 
            this.rTBRead.Location = new System.Drawing.Point(35, 47);
            this.rTBRead.Name = "rTBRead";
            this.rTBRead.Size = new System.Drawing.Size(326, 355);
            this.rTBRead.TabIndex = 0;
            this.rTBRead.Text = "";
            // 
            // rTBLoad
            // 
            this.rTBLoad.Location = new System.Drawing.Point(416, 47);
            this.rTBLoad.Name = "rTBLoad";
            this.rTBLoad.Size = new System.Drawing.Size(350, 355);
            this.rTBLoad.TabIndex = 1;
            this.rTBLoad.Text = "";
            // 
            // btnReadNews
            // 
            this.btnReadNews.Location = new System.Drawing.Point(35, 442);
            this.btnReadNews.Name = "btnReadNews";
            this.btnReadNews.Size = new System.Drawing.Size(151, 23);
            this.btnReadNews.TabIndex = 2;
            this.btnReadNews.Text = "Прочитать новости";
            this.btnReadNews.UseVisualStyleBackColor = true;
            this.btnReadNews.Click += new System.EventHandler(this.btnReadNews_Click);
            // 
            // btnLoadNewsToDB
            // 
            this.btnLoadNewsToDB.Location = new System.Drawing.Point(35, 485);
            this.btnLoadNewsToDB.Name = "btnLoadNewsToDB";
            this.btnLoadNewsToDB.Size = new System.Drawing.Size(151, 23);
            this.btnLoadNewsToDB.TabIndex = 3;
            this.btnLoadNewsToDB.Text = "Загрузить новости в БД";
            this.btnLoadNewsToDB.UseVisualStyleBackColor = true;
            this.btnLoadNewsToDB.Click += new System.EventHandler(this.btnLoadNewsToDB_Click);
            // 
            // btnReadNewsFromDB
            // 
            this.btnReadNewsFromDB.Location = new System.Drawing.Point(534, 442);
            this.btnReadNewsFromDB.Name = "btnReadNewsFromDB";
            this.btnReadNewsFromDB.Size = new System.Drawing.Size(156, 23);
            this.btnReadNewsFromDB.TabIndex = 4;
            this.btnReadNewsFromDB.Text = "Прочитать новости из БД";
            this.btnReadNewsFromDB.UseVisualStyleBackColor = true;
            this.btnReadNewsFromDB.Click += new System.EventHandler(this.btnReadNewsFromDB_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(317, 485);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "https://news.yandex.ru/games.rss";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 452);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 545);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnReadNewsFromDB);
            this.Controls.Add(this.btnLoadNewsToDB);
            this.Controls.Add(this.btnReadNews);
            this.Controls.Add(this.rTBLoad);
            this.Controls.Add(this.rTBRead);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rTBRead;
        private System.Windows.Forms.RichTextBox rTBLoad;
        private System.Windows.Forms.Button btnReadNews;
        private System.Windows.Forms.Button btnLoadNewsToDB;
        private System.Windows.Forms.Button btnReadNewsFromDB;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

