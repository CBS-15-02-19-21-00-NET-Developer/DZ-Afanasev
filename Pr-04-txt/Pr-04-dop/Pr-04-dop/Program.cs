using System;
using System.Text.RegularExpressions;

namespace Pr_04_dop
{
    class Program
    {
        static void Main(string[] args)
        {
            const string login = @"[a-zA-Z]";
            const string password = @"\w";

            var regex_log = new Regex(login);
            var regex_pass = new Regex(password);
            
            Console.WriteLine("Введите логин (только латиница):");
            string youLogin = "";
            while (true)
            {
                string simbol = Console.ReadKey(true).KeyChar.ToString();
                if (simbol == "\r")
                    break;

                bool correct = regex_log.IsMatch(simbol);
                
                if (correct)
                { 
                Console.Write(simbol);
                youLogin += simbol;
                }
               
            }

            Console.WriteLine();
            Console.WriteLine("Введите пароль (цифры или символы):");
            string youPassword = "";
            while (true)
            {
                string simbol = Console.ReadKey(true).KeyChar.ToString();
                if (simbol == "\r")
                    break;

                bool correct = regex_pass.IsMatch(simbol);

                if (correct)
                {
                    Console.Write("*");
                    youPassword += simbol;
                }

            }

            Console.WriteLine(new string('_', 50));
            Console.WriteLine($"Введенный логин: {youLogin}");
            Console.WriteLine($"Введенный пароль: {youPassword}");
        }
    }
}
