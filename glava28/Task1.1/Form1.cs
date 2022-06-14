using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1._1
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
            Pen p = new Pen(Color.Black, 1);
            e.Graphics.DrawEllipse(p, 10, 10, 120, 120);
            e.Graphics.DrawEllipse(p, 20, 20, 100, 100);
            e.Graphics.DrawEllipse(p, 40, 40, 60, 60);

            e.Graphics.DrawRectangle(p, 160, 10, 40, 70);
            e.Graphics.DrawRectangle(p, 180, 60, 40, 70);
            e.Graphics.DrawRectangle(p, 200, 110, 40, 70);
            e.Graphics.DrawRectangle(p, 220, 160, 40, 70);
            e.Graphics.DrawRectangle(p, 240, 210, 40, 70);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
