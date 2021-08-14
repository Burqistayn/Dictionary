using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class MyDictionary<T1,T2>
    {
        T1[] t1;
        T2[] t2;
        public MyDictionary()
        {
            t1 = new T1[0];
            t2 = new T2[0];
        }
        public void Add(T1 t1v, T2 t2v)
        {
            T1[] tempT1 = t1;
            T2[] tempT2 = t2;

            t1 = new T1[t1.Length + 1];
            t2 = new T2[t2.Length + 1];

            for (int i = 0; i < tempT1.Length; i++)
            {
                t1[i] = tempT1[i];
                t2[i] = tempT2[i];
            }

            t1[t1.Length - 1] = t1v;
            t2[t2.Length - 1] = t2v;
        }
        public void Listed()
        {
            for (int i = 0; i < t1.Length; i++)
            {
                Console.WriteLine("[{0} , {1}]",t1[i],t2[i]);
            }
        }
        public int Count
        {
            get { return t1.Length; }
        }
    }
}
