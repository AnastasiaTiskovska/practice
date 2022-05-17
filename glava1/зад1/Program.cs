using System;

namespace зад1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите катеты прямоугольного треугольника:");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double P = a + b + Math.Sqrt(a * a + b * b);
            Console.WriteLine("P = " + P);
            Console.ReadKey();
        }
    }
}
