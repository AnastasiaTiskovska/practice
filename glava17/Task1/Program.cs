using System;
using Shape;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {  
            Console.WriteLine("Введите стороны треугольника: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Triangle triagle = new Triangle(a, b, c);
            triagle.IsTriangle();
            Console.WriteLine("Периметр треугольника = " + triagle.Perimetr(a, b, c));
            Console.WriteLine("Площадь треугольника = " + triagle.Square(a, b, c));
            Console.WriteLine("Введите стороны прямоугольника: ");
            int r = int.Parse(Console.ReadLine());
            int t = int.Parse(Console.ReadLine());
            Rectangle rectangle = new Rectangle(r, t);
            Console.WriteLine("Периметр прямоугольника = " + rectangle.Perimetr(r, t));
            Console.WriteLine("Площадь прямоугольника = " + rectangle.Square(r, t));
            Console.ReadLine();
        }
    }
}
