using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Sofa: Furniture
    {
        public double s;
        public double cost;
        public Sofa()
        {
            this.s = 0;
            Input();
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Введите площадь дивана (в см): ");
            s = Convert.ToDouble(Console.ReadLine());
        }
        public virtual void CostSofa()
        {
            cost = Math.Pow(s, 2) / 3 + 5000;
        }
        public override void GetInfo()
        {
            CostSofa();
            Console.WriteLine("Название: {0} \nПлощадь: {1} \nСтоимость дивана: {2:0.00}", name, s, cost);
        }
    }
}
