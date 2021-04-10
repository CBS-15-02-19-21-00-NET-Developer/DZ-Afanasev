using System;

namespace _11_generics2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArrayList m = new MyArrayList();
            m.Add(5);
            m.Add(3.1415926);
            m.Add("zzz");
            m.Add('l');
            Console.WriteLine("Массив: ");
            Console.WriteLine(m.ToString());


        }
    }
}
