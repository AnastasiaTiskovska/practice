using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int mascount = 5;
            Furniture[] furnitures = new Furniture[mascount];
            Console.WriteLine("Выберите создаваемый объкт:");
            Console.WriteLine("1. Шкаф \n2. Диван");
            int change = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            double costv = 0;
            double costs = 0;
            double Srcostv = 0;
            double Srcosts = 0;
            while (i < mascount)
            {
                switch (change)
                {
                    case 1:
                        Wardrobe wardrobe = new Wardrobe();
                        wardrobe.CostWardrobe();
                        costv = costv + wardrobe.cost;
                        furnitures[i] = wardrobe as Furniture; ++i; break;
                    case 2:
                        Sofa sofa = new Sofa();
                        sofa.CostSofa();
                        costs = costv + sofa.cost;
                        furnitures[i] = sofa as Furniture; ++i; break;
                    default: Console.WriteLine("Нет такого пункта!"); break;
                }
            }
            for (int t = 0; t < furnitures.Length; t++)
            {
                if (furnitures[t] != null)
                {
                    furnitures[t].GetInfo();
                }
            }
            Srcostv = costv / mascount;
            Srcosts = costs / mascount;
            if (Srcostv == 0)
                Console.WriteLine("Средняя стоимость : {0:0.00}", Srcosts);
            else Console.WriteLine("Средняя стоимость : {0:0.00}", Srcostv);

            Console.ReadLine();
        }
    }
}
