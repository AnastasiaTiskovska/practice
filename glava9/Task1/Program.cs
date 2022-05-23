using System;

namespace Task1
{
    class IntrefaceClass : Ix, Iy, Iz
    {
        public double w1;
        public IntrefaceClass()
        {
            w1 = 3.54;
        }
        public IntrefaceClass(double w2)
        {
            w1 = w2;
        }
        public void IxF0(double w2)
        {
            Console.WriteLine(w2);
            w2 = Math.Pow(w2, 2);
            Console.WriteLine($"Воведение в квадрат \n{w2}");
        }
        public void IxF1()
        {
            Console.WriteLine(w1);
            w1 = Math.Pow(w1, 2);
            Console.WriteLine($"Возведение в квадрат \n{w1}");
        }
        public void F0(double w2)
        {
            Console.WriteLine(w2);
            w2 = Math.Sqrt(w2);
            Console.WriteLine($"Корень \n{w2}");
        }
        public void F1()
        {
            Console.WriteLine(w1);
            w1 = Math.Sqrt(w1);
            Console.WriteLine($"Корень \n{w1}");
        }
        void Iz.F0(double w2)
        {
            Console.WriteLine(w2);
            w2 = Math.Pow(w2, 2) + 5;
            Console.WriteLine($"Сумма \n{w2}");
        }
        void Iz.F1()
        {
            Console.WriteLine(w1);
            w1 = Math.Pow(w1, 2) + 5;
            Console.WriteLine($"Сумма \n{w1}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IntrefaceClass x0 = new IntrefaceClass();
            IntrefaceClass x1 = new IntrefaceClass();
            Console.WriteLine("Введите число(вещественное) ");
            double w2 = Convert.ToDouble(Console.ReadLine());
            x0.IxF1();
            x1.IxF0(w2);
            (x0 as Iy).F0(w2);
            (x1 as Iz).F1();

            Console.WriteLine("==========Prism test==========");
            Console.WriteLine("==========Ix==========");
            Ix ix = x1;
            ix.IxF0(w2);
            ix.IxF1();
            Console.WriteLine("==========Iy==========");
            Iy iy = x1;
            iy.F0(w2);
            iy.F1();
            Console.WriteLine("==========Iz==========");
            Iz iz = x1;
            iz.F0(w2);
            iz.F1();
        }
    }
}
