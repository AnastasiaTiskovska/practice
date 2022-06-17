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
using System.Data.SqlClient;

namespace Task1
{
    public partial class Form1 : Form
    {
        string commandText;
        OleDbConnection conn;
        OleDbDataAdapter dataAdapter;
        OleDbCommand MyCommand;
        DataSet ds;

        public Form1()
        {
            InitializeComponent();
            string ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0; " + "Data Source= DBTur_firm.mdb";
            conn = new OleDbConnection(ConnectionString);
        }

        void Tourist()
        {
            commandText = "SELECT* FROM Туристы";
            conn.Open();
            MyCommand = new OleDbCommand();
            MyCommand.Connection = conn;
            MyCommand.CommandText = commandText;
            dataAdapter = new OleDbDataAdapter();
            dataAdapter.SelectCommand = MyCommand;
            ds = new DataSet();
            dataAdapter.Fill(ds, "Туристы");
            dataGridView1.DataSource = ds.Tables["Туристы"].DefaultView;
            conn.Close();
        }

        void Tours()
        {
            commandText = "SELECT* FROM Туры";
            conn.Open();
            MyCommand = new OleDbCommand();
            MyCommand.Connection = conn;
            MyCommand.CommandText = commandText;
            dataAdapter = new OleDbDataAdapter();
            dataAdapter.SelectCommand = MyCommand;
            ds = new DataSet();
            dataAdapter.Fill(ds, "Туры");
            dataGridView1.DataSource = ds.Tables["Туры"].DefaultView;
            conn.Close();
        }

        private void туристыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tourist();
        }

        private void турыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tours();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "Insert into Туристы (Фамилия,Имя,Отчество) values (@fName,@lName,@pName)";
            MyCommand = new OleDbCommand(query, conn);
            MyCommand.Parameters.AddWithValue("@fName", "Швед");
            MyCommand.Parameters.AddWithValue("@lName", "Томас");
            MyCommand.Parameters.AddWithValue("@pName", "Ричард");
            conn.Open();
            MyCommand.ExecuteNonQuery();
            conn.Close();
            Tourist();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "Update Туристы Set Фамилия=@fName,Имя=@lName,Отчество=@pName Where Код_туриста=@id";
            MyCommand = new OleDbCommand(query, conn);
            MyCommand.Parameters.AddWithValue("@fName", "Иванов");
            MyCommand.Parameters.AddWithValue("@lName", "Григорий");
            MyCommand.Parameters.AddWithValue("@pName", "Валентинович");
            MyCommand.Parameters.AddWithValue("@id", 1);
            conn.Open();
            MyCommand.ExecuteNonQuery();
            conn.Close();
            Tourist();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "Delete From Туры Where Код_тура=@id";
            MyCommand = new OleDbCommand(query, conn);
            MyCommand.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value);
            conn.Open();
            MyCommand.ExecuteNonQuery();
            conn.Close();
            Tours();
        }
    }
}
