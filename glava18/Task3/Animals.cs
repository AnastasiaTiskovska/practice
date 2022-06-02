using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Animals
    {
        public string name;
        public double weight;
        public Animals(string name, double weight)
        {
            this.name = name;
            this.weight = weight;
        }
        virtual public void PrintAnimals()
        {
            Console.WriteLine("\nНаименование: " + name + "\nВес: " + weight);
        }
    }
}
