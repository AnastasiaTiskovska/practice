using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black, 2);
            g.DrawRectangle(pen, 200, 50, 200, 350);
            g.DrawRectangle(pen, 210, 60, 180, 300);
            g.DrawEllipse(pen, 280, 362, 35, 35);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
