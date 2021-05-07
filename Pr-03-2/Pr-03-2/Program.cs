using System;
using System.IO;
using System.Text;

namespace Pr_03_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = new FileInfo("test.txt");
            StreamWriter stream = file.CreateText();
            for (int i = 0; i < 100; i++)//записываем данные
                stream.WriteLine(i);
            stream.Close();//закрываем поток

            Console.WriteLine("Файл создан. Данные записаны.");
            Console.WriteLine("Нажмите любую клавишу для чтения файла");
            Console.ReadKey();

            StreamReader stream1 = File.OpenText("test.txt");
            string text;
            while ((text = stream1.ReadLine()) != null)
                Console.WriteLine(text);
            
            stream1.Close();//закрываем поток

            Console.WriteLine("Нажмите любую клавишу чтобы удалить файл");
            Console.ReadKey();

            file.Delete();
            Console.WriteLine("Файл удален");
        }
    }
}
