using System;

namespace зад2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трехзначное число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int c1 = a % 10;
            int c2 = a / 10 % 10;
            int c3 = a / 100; 
            if ((c1 != c2) && (c2 != c3) && (c1 != c3))
            {
                Console.WriteLine("Все цифры данного числа различны ");
            }
            else
            {
                Console.WriteLine("Есть совпадения ");
            }
            Console.ReadKey();
        }
    }
}
