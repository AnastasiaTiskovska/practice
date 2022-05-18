using System;

namespace Task2
{
    internal class Program
    {
        static double F(double x)
        {
            if ((x > -4) & (x <= 1)) { return (x / (2*x+2)); }
            else if (- 1 < x) { return (x + 3); }
            else { throw new IndexOutOfRangeException("Ошибка: выход за диапазон значения X."); }
        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите х, где -4<x<1 или -1<x: ");
                var x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("F(x)= " + F(x));

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message, ex.StackTrace);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message, ex.StackTrace);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
