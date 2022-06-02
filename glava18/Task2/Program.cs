using System;
using System.IO;
using System.Collections.Generic;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<char> symbols = new Queue<char>();
            Queue<char> digits = new Queue<char>();
            string sr = File.ReadAllText(@"1.txt");
            foreach (char s in sr)
            {
                if (char.IsDigit(s)) digits.Enqueue(s);
                else symbols.Enqueue(s);
            }
            Print(symbols, Console.WriteLine);
            Print(digits, Console.WriteLine);
        }
        private delegate string Output(Action<string> action);
        private static void Print(Queue<char> symbolsOrDigits, Action<string> action)
        {
            Console.WriteLine(string.Join(' ', symbolsOrDigits));
        }
    }
}
