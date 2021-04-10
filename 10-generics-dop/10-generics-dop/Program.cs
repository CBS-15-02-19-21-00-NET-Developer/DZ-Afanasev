using System;

namespace _10_generics_dop
{
    class Program
    {
        static void Main()
        {
            int xxx = MyClass<int>.FactoryMethod();
            Console.WriteLine(xxx.GetType().Name);

            double zzz = MyClass<double>.FactoryMethod();
            Console.WriteLine(zzz.GetType().Name);

        }
    }

    class MyClass<T> where T : new()
    {
        //public T field;
        public static T FactoryMethod() 
        {
            return new T();
            //Console.WriteLine(field.GetType());
        }
    }
}
