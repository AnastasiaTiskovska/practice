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
        float x0 = 30;
        float y0 = 20;
        float t = 0;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            {
                Graphics g = e.Graphics;
                DrawTriangle(g, x0, y0, t);
            }
            void DrawTriangle(Graphics g, float x0, float y0, float t)
            {
                Pen p = new Pen(Color.Black, 3);
                g.DrawPolygon(p, new PointF[] { 
                    new PointF(x0 + 40, y0 - 5), 
                    new PointF(x0 + 70, y0 + 30), 
                    new PointF(x0 + 100, y0 - 5) 
                });

                e.Graphics.DrawEllipse(p, 180, 10, 120, 70);
                e.Graphics.Save();

                SolidBrush b = new SolidBrush(Color.Red);
                g.FillEllipse(b, 70, 100, 60, 60);

                e.Graphics.FillRectangle(
                new SolidBrush(Color.FromArgb(255, 0, 0)),
                new Rectangle(190, 100, 100, 60));

                g.DrawPie(p, 240, -40, 200, 200, 0.0F, 60.0F);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
