using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class A
    {
        private int _a;
        private int _b;

        public A(int a, int b)
        {
            _a = a;
            _b = b;
        }
        public A()
        {
            _a = 4;
            _b = 5;
        }
        public int c
        {
            get
            {
                int i = 0;
                while (i < 10)
                {
                    _a += _b;
                    i++;
                }
                return _a;
            }
            set { }
        }
    }
}
