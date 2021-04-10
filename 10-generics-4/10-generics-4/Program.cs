using System;

namespace _10_generics_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Размерность массива: ");
            int u = Convert.ToInt32(Console.ReadLine());
            var list = new MyList<int>(u);
            var t = new Random();

            for(int x = 0; x<u; x++)
            {
                list.Add(x, t.Next(100));

            }

            Console.WriteLine("Массив");
            int[] f = list.GetArray();

            for (int i = 0; i<f.Length; i++)
            {
                Console.Write($"{f[i]} ");
            }

            Console.WriteLine();
            Console.WriteLine($"Длина массива: {list.Lenght} элементов");
        }
    }

    static class ExtensionMyList
    {    

    public static T[] GetArray <T>(this MyList<T> list)
    {
        var temp = new T[list.Lenght];
        for (int i =0; i<list.Lenght; i++)
        {
            temp[i] = list[i];
        }
        return temp;
    }

    }
}
