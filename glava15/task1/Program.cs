using System;
using static System.Console;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new();
            for (int i = 0; i < 10; i++)
            {
                myList.Append(i);
            }
            foreach (var item in myList)
            {
                Write($"{item}   ");
            }
            var len = myList.count;
            WriteLine($"\nКоличество элементов: {len}");
            WriteLine($"\n3-й элемент: {myList[2]}");
            ReadLine();
        }
    }
}
