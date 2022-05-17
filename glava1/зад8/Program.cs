using System;

namespace зад8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите диапазон:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Все четные числа в диапазоне: "); 
            do
            {
                if (a % 2 == 0)
                {
                    Console.WriteLine(a);
                }
                a++ ;
            } while (a <= b) ; 
            Console.ReadKey();
        }
    }
}
