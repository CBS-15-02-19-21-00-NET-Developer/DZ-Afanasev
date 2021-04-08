using System;

namespace _009_Delegates_3
{
    class Program
    {
        delegate int MyDelegate();
        delegate double Massiv(MyDelegate[] a);

        static int GetRandom()
        {
            return new Random().Next(100);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Количество элементов массива");
            int a = Convert.ToInt32(Console.ReadLine());

            MyDelegate[] array = new MyDelegate[a];

            for (int i = 0; i<a; i++)
            {
                array[i] = () => new MyDelegate(GetRandom).Invoke();

            }

            Massiv xxx = delegate (MyDelegate[] a)
            {
                double tecucshee = 0;
                double srednee = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    tecucshee = a[i].Invoke();
                    srednee = srednee + tecucshee;
                    Console.Write(tecucshee + " ");
                }
                Console.WriteLine();
                Console.WriteLine(new string('-', 30));
                return srednee / a.Length;                
            };
            Console.WriteLine();
            
            Console.WriteLine($"Среднее арифметическое: { xxx(array)}");
        }
    }
}
