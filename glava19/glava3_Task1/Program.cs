using System;

namespace glava3_Task1
{
    class Program
    {
        /// <summary>
        /// class for comparing two numbers
        /// </summary>
        class Sravnenie
        {

            /// <summary>
            /// comparing two numbers a and b
            /// </summary>
            /// <returns> return a double </returns>
            public static double cos(double a, double b)
            {
                return (a < b) ? a : b;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите x: ");
            double x = double.Parse(Console.ReadLine());
            double z = Math.Cos(x * 2) + Math.Cos(x - 3);
            Console.WriteLine("z = " + z);
            var v = Sravnenie.cos(z, x);
            Console.WriteLine("Минимальный элемент: " + v);
        }
    }
}
