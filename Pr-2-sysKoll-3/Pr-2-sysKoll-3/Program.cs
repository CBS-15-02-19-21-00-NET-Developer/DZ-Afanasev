using System;
using System.Collections;
using System.Collections.Specialized;
using System.IO;

namespace Pr_2_sysKoll_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 способ - хештейбл
            var schet = new Hashtable { };
            using (StreamReader sr = new StreamReader(@"..\..\..\schet.txt", System.Text.Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    string line1 = sr.ReadLine();
                    string line2 = sr.ReadLine();

                    schet.Add(line1, line2);
                }
            }

            Console.WriteLine("Коллекция Hashtabl");
            Console.WriteLine("Общий перечень счетов и сумм банка 'Рога и копыта':");            
            foreach (DictionaryEntry name in schet)
                Console.WriteLine($"Рачетный счет: {name.Key} | Сумма: {name.Value}");

            Console.WriteLine(new string ('_', 40));
            Console.WriteLine();

            // 2 способ - ЛистДикшонари
            var schet1 = new ListDictionary { };
            using (StreamReader sr = new StreamReader(@"..\..\..\schet.txt", System.Text.Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    string line1 = sr.ReadLine();
                    string line2 = sr.ReadLine();

                    schet1.Add(line1, line2);
                }
            }

            Console.WriteLine("Коллекция ListDictionary");
            Console.WriteLine("Общий перечень счетов и сумм банка 'Рога и копыта':");
            foreach (DictionaryEntry name in schet1)
                Console.WriteLine($"Рачетный счет: {name.Key} | Сумма: {name.Value}");

            Console.WriteLine(new string('_', 40));
            Console.WriteLine();

            // 3 способ - ГибридДикшонари
            var schet2 = new HybridDictionary { };
            using (StreamReader sr = new StreamReader(@"..\..\..\schet.txt", System.Text.Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    string line1 = sr.ReadLine();
                    string line2 = sr.ReadLine();

                    schet2.Add(line1, line2);
                }
            }

            Console.WriteLine("Коллекция HybridDictionary");
            Console.WriteLine("Общий перечень счетов и сумм банка 'Рога и копыта':");
            foreach (DictionaryEntry name in schet2)
                Console.WriteLine($"Рачетный счет: {name.Key} | Сумма: {name.Value}");

            Console.WriteLine(new string('_', 40));
            Console.WriteLine();

            // 4 способ - ОрдередДикшонари
            var schet3 = new OrderedDictionary { };
            using (StreamReader sr = new StreamReader(@"..\..\..\schet.txt", System.Text.Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    string line1 = sr.ReadLine();
                    string line2 = sr.ReadLine();

                    schet3.Add(line1, line2);
                }
            }

            Console.WriteLine("Коллекция OrderedDictionary");
            Console.WriteLine("Общий перечень счетов и сумм банка 'Рога и копыта':");
            foreach (DictionaryEntry name in schet3)
                Console.WriteLine($"Рачетный счет: {name.Key} | Сумма: {name.Value}");

            Console.WriteLine(new string('_', 40));
        }
    }
}
