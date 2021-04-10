using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_generics_3
{
    class MyDictionary<TKey, TValue>
    {
        private readonly TKey[] key;
        private readonly TValue[] value;
        private readonly int lenght;

        public int Lenght
        {
            get { return lenght; }
        }

        public MyDictionary(int n)//конструктор
        {
            key = new TKey[n];
            value = new TValue[n];
            lenght = n;
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index <= key.Length)
                    return key[index] + " - " + value[index];
                return "Выход за пределы массива";
            }
        }

        public void Add (int i, TKey k, TValue v)
        {
            key[i] = k;
            value[i] = v;

        }
    }
}
