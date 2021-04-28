using System;

namespace _017_Linq_dop
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 20, b = 5;
            Calculator calc = new Calculator();
            Console.WriteLine($"{a} + {b} = {calc.Add(a, b)}");
            Console.WriteLine($"{a} - {b} = {calc.Sub(a, b)}");
            Console.WriteLine($"{a} * {b} = {calc.Mul(a, b)}");
            Console.WriteLine($"{a} / {b} = {calc.Div(a, b)}");
        }
    }
}
