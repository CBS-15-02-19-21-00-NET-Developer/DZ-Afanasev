using System;

namespace _009_Delegates_dop
{
    class Program
    {
        static void Main()
        {
            int a = 5, b = 10, c = 45;
            //переменные, с которыми работаем
            MyDelegate myDelegate = delegate (int a, int b, int c) { return (a + b + c) / 3; };
            //анонимный метод
            int rezult = myDelegate(a, b, c);

            Console.WriteLine(rezult);
        }
    }

    public delegate int MyDelegate(int a, int b, int c);
    // делегат принимает 3 интовых значения и выдает инт (можно поменять на дробное, если нужна точность)
}
