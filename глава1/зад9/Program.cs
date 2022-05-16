using System;

namespace зад9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите диапазон:");
            int a = Convert.ToInt32(Console.ReadLine()); 
            int b = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Все четные числа в диапазоне: "); 
            for (int i = a; i <= b ; i ++ ) 
                {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
