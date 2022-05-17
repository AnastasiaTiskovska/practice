using System;

namespace зад5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("Введите A = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите B = ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите C = ");
            c = Convert.ToInt32(Console.ReadLine());
            if (a * a + b * b == c * c)
                Console.WriteLine("Этот треугольник прямоугольный");
            else
                Console.WriteLine("Этот треугольник не прямоугольный");
        }
    }
}
