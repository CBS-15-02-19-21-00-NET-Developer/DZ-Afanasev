using System;

namespace _008_structures_dop
{
    class Program
    {
        static void Main()
        {


            Console.WriteLine("Введите день рождения в формате: дд/мм/гггг");
            string drVvod = Console.ReadLine();
            DateTime now = DateTime.Now;
            DateTime dr = DateTime.Parse(drVvod);

            if (dr.DayOfYear > now.DayOfYear) //др еще не наступил                        
                Console.WriteLine($"До дня рождения осталось: {dr.DayOfYear - now.DayOfYear - 1} дней");

            else // др уже прошел                       
                Console.WriteLine($"До дня рождения осталось: {365 - (now.DayOfYear - dr.DayOfYear) - 1} дней");



            TimeSpan projito = now - dr;

            Console.WriteLine($"Вы прожили {projito.Days} дней с даты рождения");

        }
    }
}
