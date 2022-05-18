using System;

namespace Task1
{
    internal class Program
    {
        static double y1(double x)
        {
            return (2 * x / Math.Sin(x)) - 4 * x;
        }
        static double y2(double x)
        {
            return (1 / Math.Pow(Math.Tan(x),2) * (x - 1));
        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите значение Х1: ");
                double x1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Результат формулы y1: {0:0.00}", y1(x1));
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message, ex.StackTrace);
            }
            try
            {
                Console.Write("Введите значение Х2: ");
                int x2 = int.Parse(Console.ReadLine());
                Console.Write("Результат формулы y2: {0:0.00}", y2(x2));
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message, ex.StackTrace);
            }
            Console.ReadLine();
        }
    }
}
