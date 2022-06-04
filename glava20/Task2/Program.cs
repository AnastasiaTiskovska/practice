using System;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static double Z1(double a)
        {
            return Math.Pow(((1 + a + Math.Pow(a, 2) / 2 * a + Math.Pow(a, 2)) + 2 - (1 - a + Math.Pow(a, 2) / 2 * a - Math.Pow(a, 2))), -1) * (5 - 2 * Math.Pow(a, 2));
        }

        static double Z2(double a)
        {
            return (4 - Math.Pow(a, 2) / 2);
        }
        static void Main(string[] args)
        {
            Console.Write("Введите число а: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Task[] tasks = new Task[2]
            {
                new Task(() => Console.WriteLine(Z1(a))),
                new Task(() => Console.WriteLine(Z2(a))),
            };
            foreach (var t in tasks)
                t.Start();
            Task.WaitAll(tasks);
            Task.WaitAny(tasks[1]);
            Console.ReadLine();
        }
    }
}
