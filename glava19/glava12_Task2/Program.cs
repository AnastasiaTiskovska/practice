using System;

namespace glava12_Task2
{

    class Program
    {
        public delegate double CalcFigure(double R);
        /// <summary>
        /// finding the circumference
        /// </summary>
        /// <returns> return D double </returns>
        static double Get_Length(double r)
        {
            double D;
            D = 2 * Math.PI * r;
            Console.WriteLine("Длина окружности = {0:0.00}", D);
            return D;
        }
        /// <summary>
        /// finding the area of the circle
        /// </summary>
        /// <returns> return S double </returns>
        static double Get_Area(double r)
        {
            double S;
            S = Math.PI * Math.Pow(r, 2);
            Console.WriteLine("Площадь круга = {0:0.00}", S);
            return S;
        }
        /// <summary>
        ///finding the volume of the ball
        /// </summary>
        /// <returns> return V double </returns>
        static double Get_Volume(double r)
        {
            double V;
            V = 4 / 3 * Math.PI * Math.Pow(r, 3);
            Console.WriteLine("Объём шара = {0:0.00}", V);
            return V;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите радиус: ");
            double rad = Convert.ToDouble(Console.ReadLine());
            CalcFigure CF = new CalcFigure(Get_Length);
            CF += Get_Area;
            CF += Get_Volume;
            // if (CF != null)
            CF(rad);
            Console.ReadLine();
        }
    }
}
