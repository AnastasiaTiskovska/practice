using System;

namespace зад4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Math.Round(b);

            double result = (b / a);
            Math.Round(result);
            Console.WriteLine("{0:.00} / {1:.00} = {2:.00} ", b, a, result);
            Console.ReadKey();
        }
    }
}
