using System;
using System.Threading;
using static System.Console;
using static System.Convert;
using System.Diagnostics;

namespace task3
{
    class Program
    {
        static void Sum(int a, int n)
        {
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += Math.Pow(a, i);
            }
            Console.WriteLine("Сумма = " + sum);
        }
        static void Mul(int a, int n)
        {
            double mul = 1;
            for (int i = 1; i <= n; i++)
            {
                mul *= Math.Pow(a, i);
            }
            Console.WriteLine("Произведение = " + mul);
        }
        static void Main(string[] args)
        {
            Write("Введите А:");
            int a = ToInt32(ReadLine());
            Write("Введите N:");
            int n = ToInt32(ReadLine());
            Thread t1 = new Thread(delegate() { Sum(a, n); Mul(a, n); });
            Thread t2 = new Thread(delegate () { Sum(a, n); });
            t1.Start();
            t2.Start();
            Console.ReadKey();
        }
    }
}
