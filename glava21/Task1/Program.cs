using System;


namespace Task1
{
    class Program
    {
        public class Singleton
        {
            private static object _sync = new object();

            private static Singleton _instance;

            private string _data;

            public string Data
            {
                get
                {
                    return _data;
                }
                set
                {
                    lock (_sync)
                    {
                        _data = value;
                    }
                }
            }

            private Singleton(string data)
            {
                Data = data;
            }

            public static Singleton GetInstance(string data)
            {
                lock (_sync)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton(data);
                    }
                }
                return _instance;
            }

            public override string ToString()
            {
                return Data;
            }
        }

        static void Main(string[] args)
        {
            var singleton = Singleton.GetInstance("Ура, лето!");
            var singleton2 = Singleton.GetInstance("Не хочу учиться!");
            Console.WriteLine(singleton2.Data);
            Console.ReadLine();
        }
    }
}
