using System;

namespace зад10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите стоимость 1 кг конфет (1<=A<=100, вещественное число): ");
            double a = Convert.ToDouble(Console.ReadLine());
            for (double i = 0.1; i <= 1; i += 0.1)
            {
                Console.WriteLine(i + " кг конфет стоит " + Math.Round(a * i, 4) + " руб");
            }
            Console.ReadLine();
        }
    }
}
