using System;

namespace glava3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x: ");
            double x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите a: ");
            double a = int.Parse(Console.ReadLine());
            double y = RetY(x, a);
            Console.WriteLine("\nЕсли x = " + x + "и a = " + a + "то y =" + y);
        }
        /// <summary>
        /// finding y
        /// </summary>
        /// <param name="x"></param>
        /// <param name="a"></param>
        /// <returns>return y</returns>
        static double RetY(double x, double a)
        {
            if (x < a)
                return 0;
            else if (x > a)
                return (x - a) / (x + a);
            else
                return 1;
        }
    }
}
