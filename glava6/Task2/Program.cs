using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст: ");
            string str = Console.ReadLine();

            int max = 0;
            int count = 0;
            foreach (char ch in str)
                if (ch == ' ') { max = Math.Max(max, count); count = 0; }
                else count++;
            max = Math.Max(max, count);
            Console.WriteLine(max);
        }
    }
}
