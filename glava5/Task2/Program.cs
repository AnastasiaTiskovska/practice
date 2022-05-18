using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размерность массива: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Random rnd = new Random();
            int sum = 0;
            int CountOtr = 0;
            int CountZero = 0;
            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(-10, 10);
                Console.WriteLine($"{arr[i]} ");
                if (arr[i] > 0)
                {
                    sum += arr[i];
                }
                else if (arr[i] < 0)
                {
                    CountOtr++;
                }
                else if (arr[i] == 0)
                {
                    CountZero++;
                }
            }
            Console.WriteLine("Отсортированный начальный массив: ", arr);
            Array.Sort(arr);
            Array.ForEach(arr, Console.WriteLine);
            Console.WriteLine("Введите число для поиска: ");
            int k = int.Parse(Console.ReadLine());
            int SortIndexSearch = Array.BinarySearch(arr, k);
            Console.WriteLine(SortIndexSearch);
            Console.WriteLine($"Сумма всех положительных элементов: {sum}");
            Console.WriteLine($"Кол-во отрицательных элементов: {CountOtr}");
            Console.WriteLine($"Кол-во нулевых элементов: {CountZero}");
        }
    }
}

