using System;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.IO;

namespace Pr_2_sysKoll_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var nv = new NameValueCollection { };
            using (StreamReader sr = new StreamReader(@"..\..\..\pok.txt", System.Text.Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    string line1 = sr.ReadLine();
                    string line2 = sr.ReadLine();

                    nv.Add(line1, line2);
                }
            }
            Console.WriteLine("Общий перечень покупателей и покупок:");
            foreach (String name in nv.AllKeys)
            Console.WriteLine($"Покупатель: {name} | Покупка: {nv[name]}");

            Console.WriteLine();
            Console.WriteLine(new string ('_',40));
            Console.WriteLine("Покупки Дмитрия:");
            foreach (String name in nv.GetValues("Дмитрий"))
                Console.WriteLine(name);

            Console.WriteLine();
            Console.WriteLine(new string('_', 40));
            Console.WriteLine("Купили ноутбук:");
            foreach (String name in nv.AllKeys)
            {
                if ( nv.Get(name).Contains("ноутбук"))
                Console.WriteLine($"{name} ");
            }





        }
    }
}
