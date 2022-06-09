using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4
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

        public void Buttons()
        {
            int t1 = int.Parse(textBox2.Text);
            int t2 = int.Parse(textBox3.Text);
            Button button = new Button();
            button.Size = new Size(80, 25);
            button.Location = new Point(t1, t2);
            button.Text = "Кнопка";
            this.Controls.Add(button);
            button.Show();
            button.MouseMove += ctr_MouseMove;
        }

        public void TextBoxs()
        {
            int t1 = int.Parse(textBox2.Text);
            int t2 = int.Parse(textBox3.Text);
            TextBox textBox = new TextBox();
            textBox.Size = new Size(250, 25);
            textBox.Font = new Font(TextBox.DefaultFont, FontStyle.Regular);
            textBox.Location = new Point(t1, t2);
            textBox.Text = "Поле ввода";
            this.Controls.Add(textBox);
            textBox.Show();
            textBox.MouseMove += ctr_MouseMove;
        }



        public void Labels()
        {
            int t1 = int.Parse(textBox2.Text);
            int t2 = int.Parse(textBox3.Text);
            Label label = new Label();
            label.AutoSize = false;
            label.Size = new Size(250, 25);
            label.Font = new Font(label.Font, FontStyle.Regular);
            label.Location = new Point(t1, t2);
            label.Text = "Метка";
            this.Controls.Add(label);
            label.Show();
            label.MouseMove += ctr_MouseMove;
        }

        private void ctr_MouseMove(Object sender, MouseEventArgs e)
        {
            Control c = (Control)sender;
            c.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToString() == "К")
            {
                Buttons();
            }

            if (textBox1.Text.ToString() == "П")
            {
                TextBoxs();
            }

            if (textBox1.Text.ToString() == "М")
            {
                Labels();
            }
        }
    }
}
