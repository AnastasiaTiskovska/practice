using System;

namespace task1
{
    class Program
    {
        public delegate void Operation(int a);
        static void Add(int a)
        {
            int x = 20, y = 4;
            a = x + y;
            Console.WriteLine(a);
        }
        static void Sub(int a)
        {
            int x = 20, y = 4;
            a = x - y;
            Console.WriteLine(a);
        }
        static void Div(int a)
        {
            int x = 20, y = 4;
            a = x / y;
            Console.WriteLine(a);
        }
        static void Mul(int a, Operation op)
        {
            int x = 20, y = 4;
            a = x * y;
            op(a);
        }
        static void Main(string[] args)
        {
            Operation operation = null;
            operation += Add;
            operation += Sub;
            operation += Div;
            operation(0);
            Operation mul = Console.WriteLine;
            Mul(0, mul);
            Console.ReadLine();
        }
    }
}
