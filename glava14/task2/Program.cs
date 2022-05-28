using System;
using System.Threading;
using System.Diagnostics;

namespace task2
{
    class Program
    {
        static void sum()
        {
            int summa = 0;
            for (int i = 1; i <= 10; i++)
            {
                summa += i;
            }
            Console.WriteLine(summa);
        }

        static void Main(string[] args)
        {
            Stopwatch sWatch = new Stopwatch();
            sWatch.Start();
                Thread thread1 = new Thread(new ThreadStart(sum));
                Thread thread2 = new Thread(new ThreadStart(sum));
                thread1.Start();
                thread2.Start();
            sWatch.Stop();
            Console.WriteLine($"Затраченное время в миллисекундах = {sWatch.ElapsedMilliseconds.ToString()}");
            Console.ReadLine();
        }
    }
}
