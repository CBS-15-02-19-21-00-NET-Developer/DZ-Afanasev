using System;

namespace _10_generics_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Размерность словаря:");
            int n = Convert.ToInt32(Console.ReadLine());
            var dictionary = new MyDictionary<string, string>(n);

            for (int i = 0; i<n; i++)
            {
                dictionary.Add(i, "стол", "table");
            }

            Console.WriteLine(new string('_', 30));

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(dictionary[i]);
            }
            Console.WriteLine(new string('_', 30));
            Console.WriteLine(dictionary[1]);
            Console.WriteLine(dictionary.Lenght);
        }

    }
}
