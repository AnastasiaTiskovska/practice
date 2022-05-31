using System;
using System.IO;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream file1 = new FileStream(@"f1.txt", FileMode.Open);
            StreamReader reader = new StreamReader(file1);
            string s;
            int n = 0;
            while ((s = reader.ReadLine()) != null) 
            {
                n++;
                Console.WriteLine(s);
            }
            Console.WriteLine("Кол-во строк - " + n);

            reader.Close();
            Console.ReadLine();
        }
    }
}
