using System;

namespace зад2
{
    public class Product : Detail
    {
        int count;
        string name_product;
        public Product() : base()
        {
            this.count = 0;
            this.name_product = String.Empty;
            Input();
        }
        void Input()
        {
            Console.WriteLine("Введите название документа");
            name_product = Console.ReadLine();
            Console.WriteLine("Введите количество накладных в документе");
            count = Convert.ToInt32(Console.ReadLine());
        }
        public override string Vivod()
        {
            return base.Vivod() + " Название документа - " + name_product + " Количество накладных в документе - " + count + " ";
        }
    }
    public class Knot : Detail
    {
        string name_knot;
        public Knot() : base()
        {
            this.name_knot = String.Empty;
            Input();
        }
        void Input()
        {
            Console.WriteLine("Введите название счета ");
            name_knot = Console.ReadLine();
        }
        public override string Vivod()
        {
            return base.Vivod() + " Название счета - " + name_knot + " ";
        }

    }
    public class Mechanism : Detail
    {
        string name_mechanism;
        public Mechanism() : base()
        {
            this.name_mechanism = String.Empty;
            Input();
        }
        void Input()
        {
            Console.WriteLine("Введите название накладной");
            name_mechanism = Console.ReadLine();
        }
        public override string Vivod()
        {
            return base.Vivod() + " Название накладной - " + name_mechanism + " ";
        }
    }
    public class Detail
    {
        string name_detail, material;
        int number;
        public Detail()
        {
            this.name_detail = String.Empty;
            this.number = 0;
            this.material = String.Empty;
            Vvod();
        }
        public void Vvod()
        {
            Console.WriteLine("Введите название квитанции");
            name_detail = Console.ReadLine();
            Console.WriteLine("Введите номер квитанции");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Сумма платежа");
            material = Console.ReadLine();
        }
        public virtual string Vivod()
        {
            return "Название квитанции - " + name_detail + " Номер квитанции - " + number + " Сумма платежей - " + material + " ";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        oper: Console.WriteLine("1-создание накладной, 2-создание счета, 3-создание документа");
            string operation = Console.ReadLine();
            switch (operation)
            {
                case "1":
                    Mechanism mechanism = new Mechanism();
                    Console.WriteLine(mechanism.Vivod());
                    break;
                case "2":
                    Knot knot = new Knot();
                    Console.WriteLine(knot.Vivod());
                    break;
                case "3":
                    Product product = new Product();
                    Console.WriteLine(product.Vivod());
                    break;
                default:
                    Console.WriteLine("Выберите одну из предложенных операций:");
                    goto oper;
            }
            Console.ReadLine();
        }
    }
}