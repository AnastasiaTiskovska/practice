using System;

namespace зад6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Выберите номер масти(от 1 ло 4):");
            int card = int.Parse(Console.ReadLine());
            switch (card)
            {
                case 1:
                    Console.WriteLine("пики");
                    break;
                case 2:
                    Console.WriteLine("трефи");
                    break;
                case 3:
                    Console.WriteLine("бубны");
                    break;
                case 4:
                    Console.WriteLine("червы");
                    break;
            }
            Console.ReadKey();
        }
    }
}
