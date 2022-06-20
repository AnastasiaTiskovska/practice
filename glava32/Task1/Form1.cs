using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Task1
{
    public partial class Form1 : Form
    {
        OleDbConnection conn;
        OleDbDataAdapter dataAdapter;
        OleDbCommand myCommand;

        public Form1()
        {
            InitializeComponent();
            string ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0; " + "Data Source= DBTur_firm.mdb";
            conn = new OleDbConnection(ConnectionString);
        }

        private void туристыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myCommand = new OleDbCommand("SELECT *FROM Туристы", conn);
            dataAdapter = new OleDbDataAdapter(myCommand);
            DataSet dsTourist = new DataSet();
            DataTable dtTourist = dsTourist.Tables.Add("Туристы");
            DataColumn dсIDtourist = dtTourist.Columns.Add("Код туриста", typeof(Int32));
            dсIDtourist.Unique = true;
            DataColumn dcName = dtTourist.Columns.Add("Имя");
            DataColumn dcFirstname = dtTourist.Columns.Add("Отчество");
            DataColumn dcMiddleName = dtTourist.Columns.Add("Фамилия");
            conn.Open();
            dataAdapter.Fill(dsTourist.Tables["Туристы"]);
            conn.Close();
            dataGridView1.DataSource = dsTourist.Tables["Туристы"].DefaultView;
        }

        private void информацияОТуристахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myCommand = new OleDbCommand("SELECT *FROM [Информация о туристах]", conn);
            dataAdapter = new OleDbDataAdapter(myCommand);
            DataSet dsInfo = new DataSet();
            DataTable dtInfo = dsInfo.Tables.Add("Информация о туристах");
            DataColumn dсIDinfo = dtInfo.Columns.Add("Код туриста", typeof(Int32));
            dсIDinfo.Unique = true;
            DataColumn dcPassport = dtInfo.Columns.Add("Серия паспорта");
            DataColumn dcCity = dtInfo.Columns.Add("Город");
            DataColumn dcStrana = dtInfo.Columns.Add("Страна");
            DataColumn dcTelefone = dtInfo.Columns.Add("Телефон");
            DataColumn dcIndex = dtInfo.Columns.Add("Индекс");
            conn.Open();
            dataAdapter.Fill(dsInfo.Tables["Информация о туристах"]);
            conn.Close();
            dataGridView1.DataSource = dsInfo.Tables["Информация о туристах"].DefaultView;
        }

        private void турыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myCommand = new OleDbCommand("SELECT *FROM Туры", conn);
            dataAdapter = new OleDbDataAdapter(myCommand);
            DataSet dsTours = new DataSet();
            DataTable dtTours = dsTours.Tables.Add("Туры");
            DataColumn dсIDtour = dtTours.Columns.Add("Код тура", typeof(Int32));
            dсIDtour.Unique = true;
            DataColumn dcName = dtTours.Columns.Add("Название");
            DataColumn dcPrice = dtTours.Columns.Add("Цена", typeof(Decimal));
            DataColumn dcInformation = dtTours.Columns.Add("Информация");
            conn.Open();
            dataAdapter.Fill(dsTours.Tables["Туры"]);
            conn.Close();
            dataGridView1.DataSource = dsTours.Tables["Туры"].DefaultView;
        }

        private void сезоныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myCommand = new OleDbCommand("SELECT *FROM Сезоны", conn);
            dataAdapter = new OleDbDataAdapter(myCommand);
            DataSet dsSezone = new DataSet();
            DataTable dtSezone = dsSezone.Tables.Add("Сезоны");
            DataColumn dсIDsezone = dtSezone.Columns.Add("Код сезона", typeof(Int32));
            dсIDsezone.Unique = true;
            DataColumn dcIdTour = dtSezone.Columns.Add("Код тура");
            DataColumn dcStart = dtSezone.Columns.Add("Дата начала");
            DataColumn dcEnd = dtSezone.Columns.Add("Дата конца");
            DataColumn dcSezon = dtSezone.Columns.Add("Сезон закрыт");
            DataColumn dcMesta = dtSezone.Columns.Add("Количество мест");
            conn.Open();
            dataAdapter.Fill(dsSezone.Tables["Сезоны"]);
            conn.Close();
            dataGridView1.DataSource = dsSezone.Tables["Сезоны"].DefaultView;
        }

        private void путевкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myCommand = new OleDbCommand("SELECT *FROM Путевки", conn);
            dataAdapter = new OleDbDataAdapter(myCommand);
            DataSet dsPutevki = new DataSet();
            DataTable dtPutevki = dsPutevki.Tables.Add("Путевки");
            DataColumn dсIDputevki = dtPutevki.Columns.Add("Код путевки", typeof(Int32));
            dсIDputevki.Unique = true;
            DataColumn dcIdTourist = dtPutevki.Columns.Add("Код туриста");
            DataColumn dcIdSezon = dtPutevki.Columns.Add("Код сезона");
            conn.Open();
            dataAdapter.Fill(dsPutevki.Tables["Путевки"]);
            conn.Close();
            dataGridView1.DataSource = dsPutevki.Tables["Путевки"].DefaultView;
        }

        private void оплатаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myCommand = new OleDbCommand("SELECT *FROM Оплата", conn);
            dataAdapter = new OleDbDataAdapter(myCommand);
            DataSet dsOplata = new DataSet();
            DataTable dtOplata = dsOplata.Tables.Add("Оплата");
            DataColumn dсIDoplata = dtOplata.Columns.Add("Код оплаты", typeof(Int32));
            dсIDoplata.Unique = true;
            DataColumn dcIdPutevki = dtOplata.Columns.Add("Код путевки");
            DataColumn dcDate = dtOplata.Columns.Add("Дата оплаты");
            DataColumn dcSumma = dtOplata.Columns.Add("Сумма");
            conn.Open();
            dataAdapter.Fill(dsOplata.Tables["Оплата"]);
            conn.Close();
            dataGridView1.DataSource = dsOplata.Tables["Оплата"].DefaultView;
        }
    }
}
