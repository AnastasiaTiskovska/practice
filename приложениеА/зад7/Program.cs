using System;

namespace зад7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите радиус цилиндра: ");
            double R = double.Parse(Console.ReadLine());
            Console.Write("Введите высоту цилиндра: ");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("Площадь цилиндра = "+ 2 * Math.PI * R * (h + R) + " см2");
            Console.WriteLine("Объем цилиндра = " + Math.PI * R * R * h + " куб. см");
            Console.ReadKey();
        }
    }
}
