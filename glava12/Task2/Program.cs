using System;

namespace Task2
{
    class Program
    {
        delegate int Operation(int x, int y);
        static void Main(string[] args)
        {
            Console.Write("x = ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("y = ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Выберите операцию: \n1. Сложение \n2. Вычитание \n3. Умножение \n4. Деление");
            int operation = int.Parse(Console.ReadLine());
            switch(operation)
            {
                case 1:
                    Operation add = (x, y) => x + y;
                    Console.WriteLine("x + y = " + add(x, y));
                    break;
                case 2:
                    Operation sub = (x, y) => x - y;
                    Console.WriteLine("x - y = " + sub(x, y));
                    break;
                case 3:
                    Operation mul = (x, y) => x * y;
                    Console.WriteLine("x * y = " + mul(x, y));
                    break;
                case 4:
                    try
                    {
                        Operation div = (x, y) => x / y;
                        Console.WriteLine("x / y = " + div(x, y));
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
            }
            Console.Read();
        }
    }
}
