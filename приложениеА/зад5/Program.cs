using System;

namespace зад5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите четырехзначне число: ");
            int n = int.Parse(Console.ReadLine());
            int res = 0;
            while (n > 0)
            {
                res *= 10;
                res += n % 10;
                n /= 10;
            }
            Console.WriteLine("Число справа на лево: " + res );
            Console.ReadKey();
        }
    }
}
