using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vokzal vokzal = new Vokzal();
            int Kol = 4;
            for (int i = 0; i < Kol; i++)
            {
                vokzal.Add();
            }
            vokzal[0].ShowInfo();
            vokzal[1].ShowInfo();
            vokzal[2].ShowInfo();
            vokzal.ShowLastTime();
            vokzal.ShowEndPunct();
            Console.ReadKey();
        }
    }
}
