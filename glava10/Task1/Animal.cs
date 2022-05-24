using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Animal
    {
        private string nickname;
        private double h;
        private double weight;
        private int k;
        public Animal()
        {
            nickname = null;
            k = 15;
            h = 0;
            weight = 0;
            Input();
        }
        public virtual void AnimalWeight()
        {
            weight = k * h;
        }
        public string Nickname { get { return nickname; } set { nickname = value; } }
        public double H { get { return h; } set { h = value; } }
        public double Weight { get { return weight; } set { weight = value; } }
        public int K { get { return k; } set { k = value; } }
        public void Input()
        {
            Console.Write("Введите кличку кошки: ");
            nickname = Convert.ToString(Console.ReadLine());
            Console.Write("Введите рост животного (в метрах): ");
            h = double.Parse(Console.ReadLine());
        }
    }
}
