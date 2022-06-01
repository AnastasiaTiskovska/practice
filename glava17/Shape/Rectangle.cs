using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public class Rectangle
    {
        public int r;
        public int t;
        public Rectangle(int r, int t)
        {
            this.r = r;
            this.t = t;
        }

        public int Perimetr(int r, int t)
        {
            return 2 * (r + t);
        }

        public double Square(int r, int t)
        {
            return r * t;
        }
    }
}
