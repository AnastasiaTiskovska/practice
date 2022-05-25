using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Wardrobe: Furniture
    {
        public double v;
        public double cost;
        public Wardrobe()
        {
            this.v = 0;
            Input();
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Введите объем (в см): ");
            v = Convert.ToDouble(Console.ReadLine());
        }
        public virtual void CostWardrobe()
        {
            cost = Math.Sqrt(v) * 0.75;
        }
        public override void GetInfo()
        {
            CostWardrobe();
            Console.WriteLine("Название: {0} \nОбъем: {1} \nСтоимость шкафа: {2:0.00}", name, v, cost);
        }
    }
}
