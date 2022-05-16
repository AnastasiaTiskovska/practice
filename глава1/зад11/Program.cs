using System;

namespace зад11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double a = 0;
            double b = 3 * Math.PI;
            int m = 10;
            double h = (b - a) / m;
            for (double i = a; i < b; i += h)
            {
                double y = x * Math.Sin(x);
                Console.WriteLine("y = " + Math.Round(y, 2));
                x = x + h;

            }
            Console.ReadLine();   
        }
    }
}
