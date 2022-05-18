using System;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double [] arr = new double[10];
            Random rand = new Random((int)DateTime.Now.Ticks);
            double max = double.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(100, 201);
                Console.Write($"{arr[i]} ");
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            Console.WriteLine($"\nmax={max}");
            Console.WriteLine("Индекс максимального числа: " + Array.IndexOf(arr, max));
            Console.ReadLine();
        }
    }
}
