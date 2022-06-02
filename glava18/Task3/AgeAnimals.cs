using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class AgeAnimals: Animals
    {
        int age;
        public AgeAnimals(string name, double weight, int age)
            : base (name, weight)
        {
            this.age = age;
        }
        virtual public void PrintAnimals()
        {
            Console.WriteLine("\nНаименование: " + name + "\nВес: " + weight + "\nВозраст: " + age);
        }
    }
}
