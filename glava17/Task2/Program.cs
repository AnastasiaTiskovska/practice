using System;
using Progress;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 2;
            Pro[] pros = new Pro[n];
            pros[0] = new Student1("Анастасия", "Тишковская", 14, 8, 8, 9, 5);
            pros[1] = new Student2("Кирилл", "Руховец", 16, 9, 5, 5, 5);
            foreach (Pro elem in pros)
            {
                elem.Opisanie();
                elem.Evaluation();
            }
            Console.ReadLine();
        }
    }
}
