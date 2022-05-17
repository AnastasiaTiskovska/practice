using System;

namespace зад4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x = ");
            double x = double.Parse(Console.ReadLine());
            double y = 0;
            if (x >= 0.1 && x <= 1.5) y = Math.Log(Math.Exp(x)+4 ) - 2 * x;
            else if (x > 1.5) y = Math.Pow (x,2) - 1;
            Console.WriteLine("y = " + y);
            Console.ReadLine(); 
        }
    }
}
