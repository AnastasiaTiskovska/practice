using System;

namespace glava12_3
{
    class Program
    {
        public delegate string String(string s);
        /// <summary>
        /// inserting a line
        /// </summary>
        /// <param name="s"></param>
        /// <returns>return string s2</returns>
        static string Insert(string s)
        {
            string s2 = s.Insert(8, " утром");
            Console.WriteLine(s2);
            return s2;
        }
        /// <summary>
        /// replacement и on a
        /// </summary>
        /// <param name="s"></param>
        /// <returns>return s2</returns>
        static string Replace(string s)
        {
            string s2 = s.Replace("и", "а");
            Console.WriteLine(s2);
            return s2;
        }
        /// <summary>
        /// gluing two lines
        /// </summary>
        /// <param name="s"></param>
        /// <returns>return str</returns>
        static string Concat(string s)
        {
            string s2 = " утром ";
            string str = s + s2;
            Console.WriteLine(str);
            return str;
        }
        static void Main(string[] args)
        {
            string str = "Выйти на улицу";
            String s = new String(Insert);
            s += Replace;
            s += Concat;
            s(str);
            Console.ReadLine();
        }
    }
}
