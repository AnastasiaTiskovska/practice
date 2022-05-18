using System;

namespace Task5
{
    class Program
    {
        static int Factorial(int n)
        {
            if (n == 1) return n * 1;

            return n * Factorial(n - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите n в качевефакториала: ");
            int n = int.Parse(Console.ReadLine());
            double f = Factorial(n - 1) / Factorial(n - 2);
            Console.WriteLine($"f(n) = {f}");
        }
    }
}
