using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class AnimalCat: Animal
    {
        int k;
        string breed;
        public AnimalCat() : base()
        {
            k = 15;
            breed = null;
            Input();
        }
        public void Input()
        {
            Console.Write("Введите породу кошки: ");
            breed = Console.ReadLine();
        }
        public override void AnimalWeight()
        {
            Weight = k * H * 1000;
        }
        public void Info()
        {
            Console.WriteLine("Кличка кошки: {0} \nРост: {1} \nПорода: {2} \nКоэффициент: {3} \nВес кошки (в граммах): {4:0}", Nickname, H, breed, K, Weight);
        }
    }
}
