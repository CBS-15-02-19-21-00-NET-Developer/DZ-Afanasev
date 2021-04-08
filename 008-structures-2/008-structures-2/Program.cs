using System;

namespace _008_structures_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Какую строку вывести?");
            string stroka = Console.ReadLine();
            Console.WriteLine("Каким цветом?");
            Console.WriteLine("0 - красным");
            Console.WriteLine("1 - голубым");
            Console.WriteLine("2 - зеленым");
            int color = Convert.ToInt32(Console.ReadLine());
            PrintColor.Print(stroka, color);
            
        }
    }
    public enum ColorText { red, blue, green }
    static class PrintColor
    {
        public static void Print(string stroka, int color)
        {
            if (color >=0&&color<=2)
            { 
            switch (color)
            { 
                case 0:            
                Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 1:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
            }
            }
            else
                Console.WriteLine("неверный номер цвета");

            Console.WriteLine(stroka);
            Console.ResetColor();

           
                


        }

        
    }
}
