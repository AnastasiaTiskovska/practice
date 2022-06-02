using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Anim anim = new Anim();
            Dictionary <int, string> Name = new Dictionary <int, string>(3);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Введите наименование: ");
                string name = null;
                name = Console.ReadLine();
                Console.WriteLine("Введите вес: ");
                double weight = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите возраст: ");
                int age = int.Parse(Console.ReadLine());
                anim.Add(new(name, weight, age));
                Name[i + 1] = name;
            }
                Console.WriteLine("============ ");
                foreach (KeyValuePair <int, string> keyValue in Name)
                {
                    Console.WriteLine(keyValue.Key + " - " +keyValue.Value);
                }
             Console.WriteLine("============ ");
             foreach (AgeAnimals x in anim) x.PrintAnimals();
             anim.RemoveAt(1);
             Console.WriteLine("===========");
             Anim cl = (Anim)anim.Clone();
            foreach (AgeAnimals x in cl) x.PrintAnimals();
            Console.ReadLine();
        }  
    }
}
