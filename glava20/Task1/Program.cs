using System;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static int Permutation(int n)
        {
            int res = 0;
            while (n > 0)
            {
                res *= 10;
                res += n % 10;
                n /= 10;
            }
            return res;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите четырехзначне число: ");
            int n = int.Parse(Console.ReadLine());
            Task task1 = new Task(() => Console.WriteLine(Permutation(n)));
            task1.Start();
            Task task2 = Task.Factory.StartNew(() => Console.WriteLine(Permutation(n)));
            Task task3 = Task.Run(() => Console.WriteLine(Permutation(n)));
            Console.ReadLine();
        }
    }
}   
