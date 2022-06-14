using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows;
using System.Windows.Controls;

namespace Task2
{
    class TestDrawing: Control 
    {
        protected override void OnRender(System.Windows.Media.DrawingContext drawingContext)
        {
            Pen drawingpen = new Pen(Brushes.Black, 2);
            SolidColorBrush colorBrush = new SolidColorBrush(Colors.Red);
            Rect  rectangle = new Rect(330, 18, 70,40);
            Rect rectangles = new Rect(15, 150, 40, 60);
            Rect rectangl = new Rect(40, 195, 40, 60);
            Rect rect = new Rect(65, 240, 40, 60);
            Rect recta = new Rect(90, 285, 40, 60);
            Rect rectas = new Rect(115, 330, 40, 60);

            drawingContext.DrawLine(drawingpen, new Point(10, 50), new Point(50, 10));
            drawingContext.DrawLine(drawingpen, new Point(50, 10), new Point(100, 50));
            drawingContext.DrawLine(drawingpen, new Point(10, 50), new Point(100, 50));
            drawingContext.DrawEllipse(null, drawingpen, new Point(170,35), 40, 20);
            drawingContext.DrawEllipse(colorBrush, drawingpen, new Point(270, 35), 20, 20);
            drawingContext.DrawRectangle(colorBrush, drawingpen, rectangle);

            drawingContext.DrawEllipse(null, drawingpen, new Point(50, 100), 40, 40);
            drawingContext.DrawEllipse(null, drawingpen, new Point(50, 100), 30, 30);
            drawingContext.DrawEllipse(null, drawingpen, new Point(50, 100), 15, 15);

            drawingContext.DrawRectangle(null, drawingpen, rectangles);
            drawingContext.DrawRectangle(null, drawingpen, rectangl);
            drawingContext.DrawRectangle(null, drawingpen, rect);
            drawingContext.DrawRectangle(null, drawingpen, recta);
            drawingContext.DrawRectangle(null, drawingpen, rectas);

            base.OnRender(drawingContext);
        }
    }
}
