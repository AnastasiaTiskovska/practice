using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            A classA = new A();
            B classB = new B(5);
            Console.WriteLine($"Kласс a, поле с = {classA.c}");
            Console.WriteLine($"Класс b, поле с2 = {classB.c2}");
        }
    }
}
