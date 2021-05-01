using System;
using System.Collections;
using System.IO;

namespace Pr_2_sysKoll_dop
{
    class Program
    {
        static void Main(string[] args)
        {
            var sanpin = new Hashtable();
            //считываем ключ и значение из файла
            using (StreamReader sr = new StreamReader(@"..\..\..\sanpin.txt", System.Text.Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    string line1 = sr.ReadLine();
                    string line2 = sr.ReadLine();

                    sanpin.Add(line1, line2);
                }
            }
            Console.WriteLine("Все вещества без упорядочивания:");
            foreach (DictionaryEntry name in sanpin)
            {
                Console.WriteLine($"{name.Key} {name.Value}");
            }
            Console.WriteLine(new string('_', 40));
            Console.WriteLine();
            Console.WriteLine("Сортируем по возрастанию:");
            var sort1 = new SortedList();
            
            foreach (DictionaryEntry name in sanpin)//копируем в сортедлист
            {
                sort1.Add(name.Key, name.Value);
            }
            
            foreach (DictionaryEntry name in sort1)
            {
                Console.WriteLine($"{name.Key} {name.Value}");
            }
            Console.WriteLine(new string('_', 40));
            Console.WriteLine();
            Console.WriteLine("Сортируем по убыванию:");

            var sort2 = new SortedList(new DiscendingComparer());
            foreach (DictionaryEntry name in sanpin)//копируем в сортедлист
            {
                sort2.Add(name.Key, name.Value);
            }

            foreach (DictionaryEntry name in sort2)
            {
                Console.WriteLine($"{name.Key} {name.Value}");
            }
        }
    }

    public class DiscendingComparer: IComparer
    {
        CaseInsensitiveComparer comparer = new CaseInsensitiveComparer();
        public int Compare (object x, object y)
        {
            int rezult = comparer.Compare(y, x);
            return rezult;
        }
        

    }
}
