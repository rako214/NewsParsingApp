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
using MySql.Data.MySqlClient;


namespace ParsingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Массив строк для чтения новостей
        /// </summary>
        private string[] ReadNews;
        /// <summary>
        /// Счётчики строк для айди, тайтла, линков, описания, пабдаты
        /// </summary>
        private int idc = 0;
        private int titlec = 0;
        private int linkc = 2;
        private int descc = 4;
        private int pubdatec = 6;
        private int linesc = 0;

        /// <summary>
        /// Кнопка чтения новостей из ленты
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReadNews_Click(object sender, EventArgs e)
        {
            rTBRead.Text = "";
            ReadNews = ReadPage();
        }
        /// <summary>
        /// Кнопка загрузки новостей в БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoadNewsToDB_Click(object sender, EventArgs e)
        {
            //Запрос для удаления прошлого сохранения
            string queryDelete = "DELETE FROM news WHERE 1";
            //Запрос для записи данных
            string queryInsert = "INSERT INTO news (id, title, link, description, pubdate) VALUES (@id, @title, @link, @description, @pubdate)";

            MySqlConnection connectionLoadToDB = StartNewSqlConnection();
            MySqlCommand commandLoadToDB = new MySqlCommand(queryDelete, connectionLoadToDB);

            commandLoadToDB.ExecuteNonQuery();

            //Записываем данные в БД
            do
            {
                linesc = WriteToDB(queryInsert, connectionLoadToDB);
            } while (linesc < ReadNews.Length);

            connectionLoadToDB.Close();
        

        }

        private void btnReadNewsFromDB_Click(object sender, EventArgs e)
        {

            MySqlConnection connectionRead = StartNewSqlConnection();

            string query = "SELECT * FROM news";
            MySqlCommand command = new MySqlCommand(query, connectionRead);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                rTBLoad.AppendText(reader[1] + "\n\n");
                rTBLoad.AppendText(reader[2] + "\n\n");
                rTBLoad.AppendText(reader[3] + "\n\n");
                rTBLoad.AppendText(reader[4].ToString() + "\n\n");
            }

            connectionRead.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Reads whole rss page and returns string[] of news
        /// </summary>
        /// <returns>string[]newsText</returns>
        private string[] ReadPage()
        {
            string uri = textBox1.Text;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
            string text = reader.ReadToEnd();

            string[] tagTrash = { "<title>", "</title>", "<link>", "</link>", "<description>", "</description>", "<pubDate>", "</pubDate>"};
            string[] newsText = text.Split(tagTrash, System.StringSplitOptions.RemoveEmptyEntries);

            for (int i = 11; i < newsText.Length; i = i + 2)
            {
               newsText[i] = newsText[i].Replace("+0000", "");
               rTBRead.AppendText(newsText[i] + "\n\n");
            }
            return newsText;
        }

        /// <summary>
        /// Writes all data to DB        
        /// </summary>
        /// <param name="connection"></param>
        private int WriteToDB(string query, MySqlConnection connectionLoadToDB)
        {
            MySqlCommand commandWriteElementsToDB = new MySqlCommand(query, connectionLoadToDB);
            commandWriteElementsToDB.Parameters.Add("@id", MySqlDbType.Int32).Value = idc;
            commandWriteElementsToDB.Parameters.Add("@title", MySqlDbType.Text).Value = rTBRead.Lines[titlec];
            commandWriteElementsToDB.Parameters.Add("@link", MySqlDbType.Text).Value = rTBRead.Lines[linkc];
            commandWriteElementsToDB.Parameters.Add("@description", MySqlDbType.Text).Value = rTBRead.Lines[descc];
            commandWriteElementsToDB.Parameters.Add("@pubDate", MySqlDbType.Text).Value = rTBRead.Lines[pubdatec];
            commandWriteElementsToDB.ExecuteNonQuery();

            idc += 1;
            titlec += 8;
            linkc += 8;
            descc += 8;
            pubdatec += 8;
            linesc += 9;

            return linesc;
        }

        private MySqlConnection StartNewSqlConnection()
        {
            string connectionString = "server = localhost; user = root; database = news; password = ''; Charset = UTF8;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}
