using System;

namespace DZ_14_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Расширение файла (xml, txt, doc):");
            string tip = Console.ReadLine();

            if (tip=="xml")
            {
                AbstractHandler file = new XMLHandler();
                file.Open();
                file.Create();
                file.Chenge();
                file.Save();


            }
            else if (tip == "txt")
            {
                AbstractHandler file1 = new TXTHandler();
                file1.Open();
                file1.Create();
                file1.Chenge();
                file1.Save();
            }
            else if (tip == "doc")
            {
                AbstractHandler file2 = new DOCHandler ();
                file2.Open();
                file2.Create();
                file2.Chenge();
                file2.Save();
            }
            else
            {
                AbstractHandler file3 = new AbstractHandler();
                file3.Open();
                file3.Create();
                file3.Chenge();
                file3.Save();
            }
        }
    }

     class AbstractHandler
    {
        public virtual void Open()
        {
            Console.WriteLine("Открыт файл неизвестного формата");
        }


        public virtual void Create()
        {
            Console.WriteLine("Создан файл неизвестного формата");

        }

        public virtual void Chenge()
        {
            Console.WriteLine("Файл неизвестного формата отредактирован");
        }

        public virtual void Save()
        {
            Console.WriteLine("Файл неизвестного формата сохранен");
        }
    }

    class XMLHandler: AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Открыт файл xml");

        }


        public override void Create()
        {
            Console.WriteLine("Создан файл xml");

        }

        public override void Chenge()
        {
            Console.WriteLine("Файл xml отредактирован");
        }

        public override void Save()
        {
            Console.WriteLine("Файл xml сохранен");
        }
    }

    class TXTHandler: AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Открыт файл txt");

        }


        public override void Create()
        {
            Console.WriteLine("Создан файл txt");

        }

        public override void Chenge()
        {
            Console.WriteLine("Файл txt отредактирован");
        }

        public override void Save()
        {
            Console.WriteLine("Файл txt сохранен");
        }
    }

    class DOCHandler: AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Открыт файл doc");

        }


        public override void Create()
        {
            Console.WriteLine("Создан файл doc");

        }

        public override void Chenge()
        {
            Console.WriteLine("Файл doc отредактирован");
        }

        public override void Save()
        {
            Console.WriteLine("Файл doc сохранен");
        }
    }


}
