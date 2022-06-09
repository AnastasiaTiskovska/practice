using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            dataGridView1.RowCount = 12;

            dataGridView1.ColumnCount = 12;
            listBox1.Items.Clear();
            Random rnd = new Random();
            int n = 0, sum = 0, t = 0;

            do
            {
                for (int i = 0; i < 12; i++)
                {

                    n = rnd.Next(-25, 25);
                    dataGridView1.Rows[i].Cells[t].Value = n;
                    sum += n;

                }

                listBox1.Items.Add("Столбец  " + t.ToString() + "  Сумма = " + sum.ToString());
                sum = 0;
                t++;
            } 
            while (t < 12);
            foreach (DataGridViewColumn column in dataGridView1.Columns)
                column.Width = 30;
        }
    }
}
