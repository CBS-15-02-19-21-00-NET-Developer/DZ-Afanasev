using System;

//Афанасьев
//ДЗ 13-4

namespace DZ_13_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ключ");
            string key = Console.ReadLine();

            if (key == "exp")
            {
                DocumentWorker doc2 = new ExpertDocumentWorker();
                doc2.OpenDocument();
                doc2.EditDocument();
                doc2.SaveDocument();

            }
            else if (key == "pro")
            {
                DocumentWorker doc3 = new ProDocumentWorker();
                doc3.OpenDocument();
                doc3.EditDocument();
                doc3.SaveDocument();
            }
            else
            { 
            DocumentWorker doc1 = new DocumentWorker();
            doc1.OpenDocument();
            doc1.EditDocument();
            doc1.SaveDocument();
            }


        }
    }

    class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.WriteLine("Документ открыт");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("Редактирование документа доступно в версии ПРО");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("Сохранение документа доступно в версии ПРО");
        }

    }

    class ProDocumentWorker:DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Документ отредактирован");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступнов в версии Эксперт");
        }
    }

    class ExpertDocumentWorker:DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Документ отредактирован");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате");
        }
    }
}
