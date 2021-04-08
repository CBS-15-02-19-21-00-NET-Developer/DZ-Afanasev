using System;

namespace _009_Delegates_2
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Число 1");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Число 2");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Операция");
            string z = Console.ReadLine();

            switch (z)
            {
                case "+":
                    { 
                    MyDelegate Add;
                    Add = (x, y) => { return x + y; };
                        int rezult = Add(x, y);
                        Console.WriteLine(rezult);
                        break;
                    }

                case "-":
                    {
                        MyDelegate Sub;
                        Sub = (x, y) => { return x - y; };
                        int rezult = Sub(x, y);
                        Console.WriteLine(rezult);
                        break;
                    }
                
                case "*":
                    {
                        MyDelegate Mul;
                        Mul = (x, y) => { return x * y; };
                        int rezult = Mul(x, y);
                        Console.WriteLine(rezult);
                        break;
                    }

                case "/":
                    {
                        MyDelegate Div;
                        Div = (x, y) => { if (y != 0) return x / y; else return 0; };
                        int rezult = Div(x, y);
                        Console.WriteLine(rezult);
                        break;
                    }
                default:
                    Console.WriteLine("Не понял, что за операция");
                    break;


            }                                       
                       
        }
    }

    public delegate int MyDelegate(int a, int b);
}
