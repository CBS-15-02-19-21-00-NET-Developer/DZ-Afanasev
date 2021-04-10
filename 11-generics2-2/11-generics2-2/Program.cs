using System;

namespace _11_generics2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Парк машин:");
            var park = new CarCollection<string>();
            park.AddCar("Tesla X", new DateTime(2020, 12, 12));
            park.AddCar("Renault Kaptur", new DateTime(2017, 09, 12));

            Console.WriteLine(park.ToString());
            Console.WriteLine($"В парке {park.Lenght} машин");

            Console.WriteLine("Введите номер машины:");
            Console.WriteLine(park[Convert.ToInt32(Console.ReadLine())-1]);

        }
    }

    class CarCollection<T> : MyList<T>
        {
        private readonly MyList<string> carName;
        private readonly MyList<DateTime> carYear;

        public CarCollection()
        {
            carName = new MyList<string>();
            carYear = new MyList<DateTime>();
        }

        public void AddCar (string name, DateTime year)
        {
            carName.Add(name);
            carYear.Add(year);
        }

        public new string this[int index]
        {
            get
            {
                if (index<carName.Count)
                    return carName[index] + " "+ carYear[index].Year + "г.";
                return "Нет такой машины";
            }
        }

        public int Lenght
        {
            get { return carName.Count; }
        }

        public void Remove()
        {
            carName.Clear();
            carYear.Clear();
        }

        public override string ToString()
        {
            string stroka = null;
            for (int i = 0; i < carName.Count; i++)
            {
                stroka += "№" + (i + 1) + " " + carName[i] + " " + carYear[i].Year + " г." + "\n";
            }
            if (stroka != null) return stroka;
            return "Нет ни одной машины";
        }

    }
}
