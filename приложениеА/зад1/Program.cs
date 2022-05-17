using System;

namespace зад1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите радиус цилиндра: ");
            double R = double.Parse(Console.ReadLine());
            Console.Write("Введите высоту цилиндра: ");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("Объем цилиндра = {0}", Math.PI * R * R * h + " куб. см");
            Console.ReadKey();
        }
    }
}
