using System;
using System.Collections.Generic;

namespace Task2
{
    class Program
    {
        enum Employs
        {
            Manager = 150,
            Teacher = 270,
            Director = 290
        };

        static class Accauntant
        {
            public static bool AskForBonus(Employs emp, int workedHours)
            {
                return (int)emp < workedHours;
            }
        }

        static void Main(string[] args)
        {
            var empHours = new Dictionary<Employs, int>
            {
                [Employs.Manager] = 100,
                [Employs.Teacher] = 310,
                [Employs.Director] = 90
            };

            foreach (var pair in empHours)
            {
                Console.WriteLine($"{ pair.Key }: { Accauntant.AskForBonus(pair.Key, pair.Value) }");
            }
        }
    }
}
