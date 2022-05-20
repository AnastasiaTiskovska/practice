using System;
using System.Text.RegularExpressions;

namespace Tast1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();

            MatchCollection matches = Regex.Matches(text, @"\S+[уеаоэяюи]+[уеаоэяюи]\b");
            Console.WriteLine("Слова с 2 гласными в конце: ");
            for (int i = matches.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(matches[i].ToString());
            }

            Console.ReadKey();
        }
    }
}
