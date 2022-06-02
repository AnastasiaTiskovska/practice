using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Anim: IEnumerable
    {
        private ArrayList list;
        public Anim()
        {
            list = new ArrayList();
        }
        public Anim(ArrayList a)
        {
            list = a;
        }
        public void Add(AgeAnimals m)
        {
            list.Add(m);
        }
        public Anim Clone()
        {
            return new Anim(list);
        }
        public void RemoveAt(int i)
        {
            list.RemoveAt(i);
        }
        public void Clear()
        {
            list.Clear();
        }
        public IEnumerator GetEnumerator()
        {
            return list.GetEnumerator();
        }
    }
}
