using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progress
{
    public class Student2:Pro
    {
        public string name;
        public string surname;
        public int age;
        public int klass;
        public int russki;
        public int mat;
        public int inf;

        public Student2(string name, string surname, int age, int klass, int russki, int mat, int inf)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.klass = klass;
            this.russki = russki;
            this.mat = mat;
            this.inf = inf;
        }

        public override void Opisanie()
        {
            Console.WriteLine("\nИмя: {0} \nФамилия: {1} \nВозраст: {2} \nКласс: {3} \nРусский язык: {4} \nМатематика: {5} \nИнформатика: {6} ", name, surname, age, klass, russki, mat, inf);
        }

        public override void Evaluation()
        {
            Console.WriteLine("Ср. бл:" + (russki + mat + inf) / 3);
        }
    }
}
