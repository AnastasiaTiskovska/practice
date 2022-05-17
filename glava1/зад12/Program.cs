using System;

namespace зад12
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int n, max = 0, min = 100;
            Console.WriteLine("Введите число");
            n = int.Parse(Console.ReadLine());
            int n1 = n;
            while (n > 0)
            {
                if (max < n % 10) max = n % 10;
                n /= 10;
            }
            
            while (n1 > 0)
            {
                if (min > n1 % 10) min = n1 % 10;
                n1 /= 10;
            }
            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.ReadKey();
        }
    }
}