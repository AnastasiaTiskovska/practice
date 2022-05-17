using System;

namespace зад2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите трехзначное число: ");
            int n = int.Parse(Console.ReadLine());
            int prod = 1;
            while (n > 0)
             {
                 int rem;
                 n = Math.DivRem(n, 10, out rem);
                 prod *= rem;
             }
            Console.WriteLine("Произведение трехзначного числа = {0}", prod);
            Console.ReadKey();
        }
    }
}
