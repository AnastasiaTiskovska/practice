using System;
using System.Text.RegularExpressions;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string str = Console.ReadLine();
            Regex regex = new Regex(@"\b(\S+)\b(?=.*\b\1\b.*)");
            MatchCollection matches = regex.Matches(str);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                    Console.Write(match.Value);
            }
            else
            {
                Console.WriteLine("Совпадений не найдено");
            }
        }
    }
}
