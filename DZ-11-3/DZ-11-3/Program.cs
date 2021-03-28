using System;

namespace DZ_11_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Employee
    {
        string surname, name;
        double stavka;//ставка без учета стажа и должности
        public double nalog; //налог
        //double oklad; //оклад
        public Employee (string surname, string name)
        {
            this.surname = surname;
            this.name = name;
        }

        public double Glavbuh (double stavka, int tipDol, int stag)
        {
            nalog = stavka * tipDol * stag * 0.06;
            return stavka * tipDol * stag;           
             
        }
    }
}
