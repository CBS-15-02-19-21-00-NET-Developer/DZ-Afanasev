using System;

namespace _10_generics_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Размерность массива: ");
            int u = Convert.ToInt32(Console.ReadLine());

            var list = new MyList<int>();
            var t = new Random();
            for (int i = 0; i< u; i++)
            {
                list.Add(t.Next(100));
            }

            Console.WriteLine("Элементы массива: ");
            for (int i=0; i<list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(new string ('_', 30));

            Console.WriteLine("Значение для поиска");
            if (list.Conteins(Convert.ToInt32(Console.ReadLine())))
                Console.WriteLine("Это значение есть в массиве");
            else
                Console.WriteLine("Этого значния нет в массиве");
        }
    }

    public interface IMyList<T>
    {
        void Add(T a);
        T this[int index] { get; }
        int Count { get; }
        void Clear();
        bool Conteins(T item);
    }

    public class MyList<T> : IMyList<T>
    {
        private T[] array;//массив элементов типа Т

        public MyList()//конструктор
        {
            array = new T[0];
        }

        public void Add (T a)
        {
            T[] temparrey = new T[array.Length + 1];
            for (int i = 0; i<array.Length; i++)
            {
                temparrey[i] = array[i];
            }
            temparrey[array.Length] = a;
            array = temparrey;
        }

        public T this[int index]
        {
            get { return array[index]; }
        }

        public int Count
        {
            get { return array.Length; }
        }

        public void Clear()
        {
            array = new T[0];
        }

        public bool Conteins (T item)
        {
            for (int i = 0; i<array.Length; i++)
            {
                if ((int)(object)array[i]==(int)(object)item)
                { return true; }

            }
            return false;
        }

        public override string ToString()
        {
            string stroka = null;
            for (int i = 0; i<array.Length; i++)
            {
                stroka += array[i] + " ";
            }
            return "Размерность массива " + array.Length + " Элементы массива:" + stroka;

        }
    }

}
