using System;

namespace _016_Events_3
{
    class Program
    {
        static void Main(string[] args)
        {
            House house = new House("Арканар", "Азиатропное шоссе");
            House clone, clone1;
            clone = house.DeepClone();
            clone1 = house.Clone();

            Console.WriteLine($"Оригинал: {house.Sity} {house.Street}");
            Console.WriteLine($"Полный клон: {clone.Sity} {clone.Street}");
            Console.WriteLine($"Просто клон (ссылка): {clone1.Sity} {clone1.Street}");

            Console.WriteLine("Пробуем поменять клоны на Ирукан Икающий лес");
            Console.WriteLine(new string('_', 20));
            clone.Sity = "Ирукан";
            clone.Street = "Икающий лес";
            Console.WriteLine($"Оригинал: {house.Sity} {house.Street}");
            Console.WriteLine($"Полный клон: {clone.Sity} {clone.Street}");
            Console.WriteLine(new string('_', 20));

            clone1.Sity = "Ирукан";
            clone1.Street = "Икающий лес";
            Console.WriteLine($"Оригинал: {house.Sity} {house.Street}");
            Console.WriteLine($"Просто клон (ссылка): {clone1.Sity} {clone1.Street}");

        }
    }

    class House
    {
        string sity;
        string street;

        public string Sity
            {
            get { return sity; }
            set { sity = value; }
            }

        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        public House(string sity, string street)
        {
            this.sity = sity;
            this.street = street;
        }

        public House Clone()
        {
            return this;
        }

        public House DeepClone()
        {
            return new House(this.sity, this.street);
        }
    }

    
}
