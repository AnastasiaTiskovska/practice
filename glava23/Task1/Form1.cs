using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = (string)listBox1.Items[0];
            char i = Convert.ToChar(textBox1.Text);
            char j = Convert.ToChar(textBox2.Text);
            label4.Text += str.Replace(i, j);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
