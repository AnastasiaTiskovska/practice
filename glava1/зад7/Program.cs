using System;

namespace зад7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите диапазон:");
            int a = Convert.ToInt32(Console.ReadLine()); 
            int b = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Все четные числа в диапазоне: "); 
            while (a <= b) {
                if (a % 2 == 0)
                {
                    Console.WriteLine(a);
                }
                a++ ;
            }
            Console.ReadKey();
        }
    }
}
