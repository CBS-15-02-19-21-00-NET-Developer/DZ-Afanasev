using System;

namespace _016_Events_4
{
    class Program
    {

        


        static void Main(string[] args)
        {

            //            Date date2 = new Date(new DateTime(23/03/2020));
            DateTime date1 = new DateTime(2020, 04, 22);
            DateTime date2 = new DateTime(2020, 04, 20);
            TimeSpan date3 = date1 - date2;
            //DateTime date = Convert.ToDateTime( date3);
            int days = Convert.ToInt32(date3.TotalDays);
            Console.WriteLine(days);
        }
    }

    class Date
    {
        //int day, month, year;
        DateTime date;

        public Date (DateTime date)
        {
            this.date = date;
        }

        // Перегрузка оператора -
        public static Date operator -(Date d1, Date d2) 
        {

            TimeSpan timeSpan = d1.date - d2.date;
            DateTime newDate = d1.date.AddDays(timeSpan.Days);                                

            return new Date(newDate);            
        }

        public override string ToString()
        {
            return "Дата: " +date;
        }

    }
}
