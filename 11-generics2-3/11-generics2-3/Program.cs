using System;

namespace _11_generics2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Словарь:");
            var dic = new Dictionary<string, string>();

            dic.AddToDictionary("sun", "солнце");
            dic.AddToDictionary("cap", "чашка");
            dic.AddToDictionary("tea", "чай");
            dic.AddToDictionary("pen", "ручка");

            Console.WriteLine(dic.ToString());
            Console.WriteLine();
            Console.WriteLine($"В словаре {dic.Lenght} записей");
            Console.WriteLine(new string ('-',30));

            Console.WriteLine("Введите номер записи в словаре");
            string str = Console.ReadLine();
            if (string.IsNullOrEmpty(str))//является ли пустой строкой
                Console.WriteLine("Вы не ввели номер записи в словаре");
            else
            {
                int nomer = Convert.ToInt32(str);
                Console.WriteLine(dic[nomer - 1]);
                    }

            Console.WriteLine("Введите значение для поиска");
            string p = Console.ReadLine();
            Console.WriteLine(dic[p]);

        }
    }
}
