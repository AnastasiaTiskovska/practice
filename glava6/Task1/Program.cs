using System;

namespace Task1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите сообшение: ");
            string message = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Ведите символ для удаления слова: ");
            string symbol = Convert.ToString(Console.ReadLine());
            string[] words = message.Split(' ');
            string result = "";
            foreach (string word in words)
            {
                if (word.Contains(symbol) == false)
                    result += word + ' ';
            }
            Console.WriteLine(result);
        }
    }
}
