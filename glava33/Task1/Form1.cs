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
            string ConnectionString = @"Provider = Microsoft.Jet.OLEDB.4.0;" + "Data Source = DBTur_firm.mdb";
            conn = new OleDbConnection(ConnectionString);
        }

        private void туристыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myCommand = new OleDbCommand("SELECT *FROM Туристы", conn);
            dataAdapter = new OleDbDataAdapter(myCommand);
            DataSet dsTourists = new DataSet();
            DataTable dtTourists = dsTourists.Tables.Add("Туристы");
            conn.Open();
            dataAdapter.Fill(dsTourists.Tables["Туристы"]);
            conn.Close();
            dataGridView1.DataSource = dsTourists.Tables["Туристы"].DefaultView;
        }

        private void турыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myCommand = new OleDbCommand("SELECT *FROM Туры", conn);
            dataAdapter = new OleDbDataAdapter(myCommand);
            DataSet dsTurs = new DataSet();
            DataTable dtTurs = dsTurs.Tables.Add("Туры");
            conn.Open();
            dataAdapter.Fill(dsTurs.Tables["Туры"]);
            conn.Close();
            dataGridView1.DataSource = dsTurs.Tables["Туры"].DefaultView;
        }

        private void сезоныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myCommand = new OleDbCommand("SELECT *FROM Сезоны", conn);
            dataAdapter = new OleDbDataAdapter(myCommand);
            DataSet dsSeasons = new DataSet();
            DataTable dtSeasons = dsSeasons.Tables.Add("Сезоны");
            conn.Open();
            dataAdapter.Fill(dsSeasons.Tables["Сезоны"]);
            conn.Close();
            dataGridView1.DataSource = dsSeasons.Tables["Сезоны"].DefaultView;
        }

        private void путевкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myCommand = new OleDbCommand("SELECT *FROM Путевки", conn);
            dataAdapter = new OleDbDataAdapter(myCommand);
            DataSet dsPutevki = new DataSet();
            DataTable dtPutevki = dsPutevki.Tables.Add("Путевки");
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
            conn.Open();
            dataAdapter.Fill(dsOplata.Tables["Оплата"]);
            conn.Close();
            dataGridView1.DataSource = dsOplata.Tables["Оплата"].DefaultView;
        }

        private void информацияОТуристахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myCommand = new OleDbCommand("SELECT *FROM [Информация о туристах]", conn);
            dataAdapter = new OleDbDataAdapter(myCommand);
            DataSet dsInfo = new DataSet();
            DataTable dtInfo = dsInfo.Tables.Add("Информация о туристах");
            conn.Open();
            dataAdapter.Fill(dsInfo.Tables["Информация о туристах"]);
            conn.Close();
            dataGridView1.DataSource = dsInfo.Tables["Информация о туристах"].DefaultView;
        }
    }
}
