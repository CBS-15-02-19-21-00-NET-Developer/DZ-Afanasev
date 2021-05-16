using System;
using System.IO;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace Pr_004_3
{
    class Program
    {
        static void Main(string[] args)
        {
            const string pattern = @" без | безо | в | во | вместо | вне | для | за | из | изо | из-за | из-под | к | ко | кроме | между | меж | на | над | надо | о | об | обо | от | ото | перед | передо | пред | предо | по | под | подо | при | про | ради | с | со | сквозь | среди | у | через | чрез ";

            Console.OutputEncoding = Encoding.Unicode;

            StreamReader stream1 = File.OpenText(@"..\..\..\text.txt");
             
            string text;
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);// игнорируем регистр

            Console.WriteLine("Изначальный текст:");
            Console.WriteLine(new string('_', 40));
            while ((text = stream1.ReadLine()) != null)
                Console.WriteLine(text);

            Console.WriteLine(new string('_', 40));
            Console.WriteLine();

            Console.WriteLine("Корректированный текст:");
            Console.WriteLine(new string('_', 40));
            stream1.BaseStream.Position = 2;

            while ((text = stream1.ReadLine()) != null)                
                Console.WriteLine(regex.Replace(text, " ГАВ! "));

            stream1.Close();//закрываем поток
            

            
        }
    }
}
