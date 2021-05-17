using System;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;

namespace Pr_004_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            var file = new FileInfo("test.txt");//создаем файл
            StreamWriter stream = file.CreateText();

            //тырим сайт
            WebClient client = new WebClient();
            string reply = client.DownloadString("https://itvdn.com/ru/support");
        
            //задаем шаблон электронной почты
            Regex email = new Regex(@"[0-9A-Za-z_.-]+@[0-9a-zA-Z-]+\.[a-zA-Z]{2,4}");

            MatchCollection collection = email.Matches(reply);
            Console.WriteLine("Адреса электронной почты:");
            stream.WriteLine("Адреса электронной почты:");

            foreach (Match element in collection)
            {
                Console.WriteLine(element.Value);
                stream.WriteLine(element.Value);
            }

            //Ссылки задаются очень по разному
            //Могут быть якори, может быть скрипт
            //Нужно подстраиваться под нужный сайт            
            //эта работает на этом сайте
            var webLink = new Regex(@"href\s*=\s*(?:[""'](?<link>[^""']*)[""']|(?<link>\S+)><div)");
            //var webLink = new Regex(@"href\s*=\s*(?:[""'](?<link>[^""']*)[""'])");
            //var webLink = new Regex(@"href\s*=\s*(?:[""'](?<link>[^""']*)[""']|(?<link>\S+))>(?<text>\S+)</span>");

            /*
            MatchCollection collectionWeb = webLink.Matches(reply);
            foreach (Match element in collectionWeb)
            {
                Console.WriteLine("Ссылка: {0,-25}  на {1,-3} позиции с заголовком {2}.", element.Value, element.Index, element);
            }*/
            Console.WriteLine();
            stream.WriteLine();
            Console.WriteLine("Ссылки:");
            stream.WriteLine("Ссылки:");
            for (Match m = webLink.Match(reply); m.Success; m = m.NextMatch())
            {           
                Console.WriteLine(m.Groups["link"]);
                stream.WriteLine(m.Groups["link"]);
            }


            //Regex tel = new Regex(@"^((\+?7|8)[ \-] ?)?((\(\d{3}\))|(\d{3}))?([ \-])?(\d{3}[\- ]?\d{2}[\- ]?\d{2})$");
            Regex tel = new Regex(@"(\+7|\+38|\+44)(\s|\-|\(\s)\d{3}(\s|\-\))\d{3}(\s|\-)\d{2}(\s|\-)\d{2}");
            //рус, укр, бел
            //между цифрами пробел или -, первые 3 цифры (код) могут быть в скобках
            MatchCollection collectionTel = tel.Matches(reply);
            Console.WriteLine();
            stream.WriteLine();
            Console.WriteLine("Номера телефонов:");
            stream.WriteLine("Номера телефонов:");

            foreach (Match element in collectionTel)
            {
                Console.WriteLine(element.Value);
                stream.WriteLine(element.Value);
            }
            stream.Close();
            Console.WriteLine("Данные сохранены в файл test.txt");
            //Console.WriteLine(reply);
        
            //Российский номер телефона
            //^((\+?7|8)[ \-] ?)?((\(\d{3}\))|(\d{3}))?([ \-])?(\d{3}[\- ]?\d{2}[\- ]?\d{2})$ 
        }
    }
}
