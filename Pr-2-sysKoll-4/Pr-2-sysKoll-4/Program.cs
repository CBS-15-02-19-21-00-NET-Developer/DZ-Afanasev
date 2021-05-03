using System;
using System.Collections;
using System.Collections.Specialized;
using System.IO;

namespace Pr_2_sysKoll_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var kolll1 = new OrderedDictionary { };
            //заполняем коолекцию
            using (StreamReader sr = new StreamReader(@"..\..\..\kolll.txt", System.Text.Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    string line1 = sr.ReadLine();
                    string line2 = sr.ReadLine();

                    kolll1.Add(line1, line2);
                }
            }

            Console.WriteLine("Вся коллекция");
            foreach (DictionaryEntry name in kolll1)
                Console.WriteLine($"Ключ: { name.Key} Значение: {name.Value}");
            Console.WriteLine(new string ('_', 40));
            Console.WriteLine();

            Console.WriteLine("Ключ 1 для сравнения:");
            string k1 = Console.ReadLine();
            Console.WriteLine("Ключ 2 для сравнения:");
            string k2 = Console.ReadLine();
            bool s = Thokey(k1, k2, kolll1);
            Console.WriteLine($"Результат: {s}");
            
        }

        static bool Thokey (string key1, string key2, OrderedDictionary kolll2)
        {
            string value1="1", value2="2";//По умолчанию - не совпадают
            bool rez;
            foreach (DictionaryEntry name in kolll2)
                if (Convert.ToString(name.Key) == key1)
                    value1 = name.Value.ToString();
            else if (Convert.ToString(name.Key) == key2)
                    value2 = name.Value.ToString();
            rez = value1 == value2;
            return rez;

            
        }
    }
}
