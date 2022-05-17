using System;

namespace зад3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите степень n = ");
            int n = int.Parse(Console.ReadLine());
            double summ = 1;
            for (double i = 1; i <= n; i++)
            {
                summ *= a;
            }
            Console.WriteLine("a в степени n = " + summ);
            Console.ReadKey();
        }
    }
}
