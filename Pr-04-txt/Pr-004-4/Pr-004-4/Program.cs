using System;
using System.Text;
using System.Globalization;
using System.IO;

namespace Pr_004_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            var american = "en-US";
            DateTimeStyles styles = DateTimeStyles.None;

            StreamReader sr = File.OpenText(@"..\..\..\text.txt");
            string line1;
            decimal line2;
            DateTime line3;

            Console.WriteLine("Инфорация из чека в текущей локали:");
            while (!sr.EndOfStream)
            {
                line1 = sr.ReadLine();
                line2 = decimal.Parse(sr.ReadLine());
                line3 = DateTime.Parse(sr.ReadLine());               

                Console.WriteLine($"{ line1} - {line2} - {line3.ToString("d")}");
            }
            sr.BaseStream.Position = 2;

            Console.WriteLine("Инфорация из чека в локали en-US:");
            
            while (!sr.EndOfStream)
            {
                line1 = sr.ReadLine();
                line2 = decimal.Parse(sr.ReadLine(), new CultureInfo(american, false));//вообще не ставит разделитель
                line3 = DateTime.Parse(sr.ReadLine(), new CultureInfo(american, false));//здесь выдает исключение при чтении одной из дат

                Console.WriteLine($"{ line1} - {line2} - {line3.ToString("d")}");
            }
            

        }


     


    }
}
