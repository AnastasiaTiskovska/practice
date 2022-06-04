using System;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static int Mul(int n)
        {
            int prod = 1;
            while (n > 0)
            {
                int rem;
                n = Math.DivRem(n, 10, out rem);
                prod *= rem;
            }
            return prod;
        }

        static void Result(int prod)
        {
            Console.WriteLine("Произведение цифр: " + prod );
        }

        static void Main(string[] args)
        {
            Console.Write("Введите трехзначное число: ");
            int n = int.Parse(Console.ReadLine());
            Task<int> task1 = new Task<int>(() => Mul(n));
            Task task2 = task1.ContinueWith(task => Result(task.Result));
            task1.Start();
            task2.Wait();
            Console.ReadLine();
        }
    }
}
