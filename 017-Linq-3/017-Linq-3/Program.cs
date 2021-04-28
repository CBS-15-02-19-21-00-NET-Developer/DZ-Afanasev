using System;
using System.Collections.Generic;
using System.IO;

namespace _017_Linq_3
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(@"..\..\..\dic.txt", System.Text.Encoding.Default))
            {
                 var dictionary = new Dictionary<dynamic, dynamic> { };
                     
                while (!sr.EndOfStream)
                {
                    string line1 = sr.ReadLine();
                    string line2 = sr.ReadLine();

                    dictionary.Add(line1, line2);

                }
                
                foreach (var item in dictionary)
                {
                    Console.WriteLine($"{item.Key} - {item.Value}");
                }

            }

                      
        }
    }
}
