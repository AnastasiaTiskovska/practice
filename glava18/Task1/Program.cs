using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = new Stack<char>();
            string s = "Приветик##, миры#!";
            Console.WriteLine("Строка: " + s);
            foreach (var chr in s)
            {
                if (chr == '#' && line.Count != 0)
                {
                    line.Pop();
                }
                else
                    line.Push(chr);
            }
            var result = new StringBuilder();
            while (line.Count != 0)
                result.Insert(0, line.Pop());
            Console.WriteLine(result.ToString());
            Console.ReadLine();
        }
    }
}
