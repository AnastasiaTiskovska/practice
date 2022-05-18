using System;

namespace Task3
{
    class Rectangle
    {
        double _y1;
        double _y2;
        double _x1;
        double _x2;
        public Rectangle(double y1, double y2, double x1, double x2)
        {
            this._y1 = y1;
            this._y2 = y2;
            this._x1 = x1;
            this._x2 = x2;
        }
        public double P()
        {
            return (Math.Abs(_x2 - _x1) + Math.Abs(_y2 - _y1) * 2);
        }
        public double S()
        {
            return (Math.Abs(_x2 - _x1) * Math.Abs(_y2 - _y1));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(2, 4, 3, 6);
            Console.WriteLine($"Периметр = {rect.P()}");
            Console.WriteLine($"Площадь = {rect.S()}");
        }
    }
}
