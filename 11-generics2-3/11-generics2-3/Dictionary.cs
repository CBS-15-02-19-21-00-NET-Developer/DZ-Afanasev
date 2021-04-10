using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_generics2_3
{
    class Dictionary<TKey, TValue>
    {
        private readonly MyList<TKey> key;
        private readonly MyList<TValue> value;

        public Dictionary()
        {
            key = new MyList<TKey>();
            value = new MyList<TValue>();
        }

        public void AddToDictionary(TKey k, TValue v)
        {
            key.Add(k);
            value.Add(v);

        }

        public string this [int index]//индексатор
        {
            get { return key[index] + " " + value[index]; }
        }

        public string this [TKey index]//Индексатор
        {
            get
            {
                for (int i = 0; i<key.Count; i++)
                {
                    if ((string)(object)key[i] == (string)(object)index)
                        return "По ключу " + index.ToString().ToUpper() + " найдено значение " + value[i];                    
                }
                return "По ключу " + index + " не найдено значение";
            }
        }

        public int Lenght
        {
            get { return key.Count; }
        }

        public override string ToString()
        {
            string stroka = string.Empty;
            for(int i = 0; i< key.Count; i++)
            {
                stroka += key[i] + " " + value[i] + "\n";
            }
            if (stroka != null)
                return stroka;
            return "В словаре нет значений.";

        }
    }
}
