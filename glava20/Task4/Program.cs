using System;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Sin (int x)
        {
            Console.WriteLine(x * Math.Sin(x));
        }

        static void Main(string[] args)
        {
            Console.Write("Введите x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Parallel.For(0, 10, Sin);
            Console.ReadLine();

        }
    }
}
