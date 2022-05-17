using System;

namespace зад1
{
        class A
        {
            public int a;
            public int b;
            public A(int a, int b)
            {
                this.a = a;
                this.b = b;
            }
            public double Abs()
            {
                return a * b;
            }
            public double Sqrt()
            {
                return a * Math.Sqrt(b) - Math.Sin(a);
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Введите значение a: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите значение b: ");
                int b = Convert.ToInt32(Console.ReadLine());
                A x = new A(a, b);
                Console.WriteLine("Произведение = " + x.Abs());
                Console.WriteLine("Значение выражения = {0:0.##}", x.Sqrt());
                Console.ReadLine();
            }
        }
}

