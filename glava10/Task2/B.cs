using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class B: A
    {
        private int _d;
        public int c2
        {
            get
            {
                int i = 0;
                while ( i < 10)
                {
                    _d += c;
                    i++;
                }
                return _d;
            }
            set
            {
                _d = value;
            }
        }
        public B() : base()
        {

        }
        public B(int d)
        {
            d = 5;
        }
    }
}
