using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var m1 = new DoubleMatr(3, 4);
            m1.Fill();
            m1.Info();
            Console.WriteLine("=============================================================");
            var m2 = new DoubleMatr(3, 4);
            m2.Fill();
            m2.Info();
            Console.WriteLine("=============================================================");
            var m3 = m1 + m2;
            m3.Info();
            Console.WriteLine("=============================================================");
            var m5 = m1 - m2;
            m5.Info();
            Console.WriteLine("=============================================================");
            var m4 = m1 + 100;
            m4.Info();
            Console.WriteLine("=============================================================");
            Console.WriteLine($"сравнение м1 и м2 {m1==m2}");
            Console.WriteLine($"доступ к индексу 2,3 матрицы м1  {m1[1,2]:F2}");
        }
    }
}
