using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace _017_Linq_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // считываем авто из текстового файла
                using (StreamReader sr = new StreamReader(@"..\..\..\auto.txt", System.Text.Encoding.Default))
            using (StreamReader buy = new StreamReader(@"..\..\..\buy.txt", System.Text.Encoding.Default))
            {

                var listAuto = new List<Auto> { };
                while (!sr.EndOfStream)
                {                    
                    string line1 = sr.ReadLine();
                    string line2 = sr.ReadLine();
                    int line3 = Convert.ToInt32(sr.ReadLine());
                    string line4 = sr.ReadLine();
                    listAuto.Add(new Auto ( line1, line2, line3, line4));//добавляем автомобиль
                                                       
                }

                Console.WriteLine("Автомобили:");
                foreach (var auto in listAuto)//выводим на экран, проверяем
                    Console.WriteLine(auto.ToString());

                Console.WriteLine(new string('-', 30));

                var listBuyer = new List<Buyer> { };
                while (!buy.EndOfStream)
                {
                    string line1 = buy.ReadLine();
                    string line2 = buy.ReadLine();
                    string line3 = buy.ReadLine();
                    
                    listBuyer.Add(new Buyer(line1, line2, line3));//добавляем покупателя
                }
                Console.WriteLine("Покупатели:");
                foreach (var buyer in listBuyer)//выводим на экран, проверяем
                    Console.WriteLine(buyer.ToString());

                Console.WriteLine(new string('-', 30));

                var query = from buyer in listBuyer
                            join auto in listAuto on buyer.Model equals auto.Marka
                            select new
                            {
                                Name = buyer.Name,
                                Tel = buyer.Tel,
                                Model = buyer.Model,
                                Color = auto.Color,
                                Marka = auto.Model,
                                Year = auto.Year
                            };
                Console.WriteLine("Покупатели с марками авто:");
                foreach (var item in query)//выводим на экран покупателей с авто
                    Console.WriteLine($"{item.Name}, {item.Tel}, {item.Model}, {item.Color}, {item.Marka}, {item.Year}");
            }

       
        
        }
    }
}
