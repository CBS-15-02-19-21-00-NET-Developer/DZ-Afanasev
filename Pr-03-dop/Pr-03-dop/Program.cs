using System;
using System.IO;

namespace Pr_03_dop
{
    class Program
    {
        static void Main(string[] args)
        {
            var directory = new DirectoryInfo(".");
            for (int i = 0; i < 100; i++)
                directory.CreateSubdirectory("Folder_"+i.ToString());
            Console.WriteLine("Папки созданы в директории работы программы.");
            Console.WriteLine("Нажмите любую клавишу, чтобы их удалить.");
            Console.ReadKey();

            for (int i = 0; i < 100; i++)
                Directory.Delete("Folder_" + i.ToString());
            Console.WriteLine("Папки удалены");
        }
    }
}
