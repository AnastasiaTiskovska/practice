using System;

namespace зад3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число а: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double z1 = Math.Pow(((1 + a + Math.Pow(a, 2) / 2 * a + Math.Pow(a, 2)) + 2 - (1 - a + Math.Pow(a, 2) / 2 * a - Math.Pow(a, 2))), -1) * (5 - 2 * Math.Pow(a, 2));
            double z2 = (4 - Math.Pow(a, 2) / 2);
            Console.WriteLine("z1 = " + z1);
            Console.WriteLine("z2 = " + z2);
            Console.ReadKey();

        }
    }
}
