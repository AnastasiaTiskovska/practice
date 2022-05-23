using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Vokzal
{
    List<Poezd> Poezda = new List<Poezd>();

    public Poezd this[int index]
    {
        get
        {
            return Poezda[index];
        }
        set
        {
            if (index >= 0 && value is Poezd)
            {
                Poezda.Add(value);
                Poezda.Sort();
            }
        }
    }

    public void Add()
    {
        int namber = 0;
        bool flag = true;
        while (flag)
        {
            try
            {
                Console.Write("Введите номер поезда: ");
                namber = Convert.ToInt32(Console.ReadLine());
                flag = !flag;
            }
            catch
            {
                Console.WriteLine("Неверный формат номера");
            }
        }

        Console.Write("Введите конечный пункт назначения: ");
        string EndPunct = Console.ReadLine();
        Poezd poezd = new Poezd(EndPunct, namber);
        Poezda.Add(poezd);
        Poezda.Sort();
    }

    public void ShowLastTime()
    {
        Console.Write("Введите время для сравнения: ");
        Poezd p1 = new Poezd("null", 1);
        for (int i = 0; i < Poezda.Count; i++)
            if (p1 < this[i])
                this[i].ShowInfo();
    }

    public void ShowEndPunct()
    {
        Console.Write("Введите пункт назначения: ");
        string punkt = Console.ReadLine();
        int num = 0;
        for (int i = 0; i < Poezda.Count; i++)
        {
            if (Poezda[i].EndPunct == punkt)
            {
                Console.WriteLine(Poezda[i]);
                num++;
            }
        }
        if (num == 0)
            Console.WriteLine("В заданный пункт назначения поезда не ходят!");
    }

}
