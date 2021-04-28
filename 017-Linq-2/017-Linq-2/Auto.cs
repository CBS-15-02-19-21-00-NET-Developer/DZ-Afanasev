using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017_Linq_2
{
    struct Auto
    {
        readonly string marka;
        readonly string model;
        readonly int year;
        readonly string color;

        public Auto(string marka, string model, int year, string color)
        {
            this.marka = marka;
            this.model = model;
            this.year = year;
            this.color = color;
        }

        public string Marka
        {
            get { return marka; }
        }

        public string Model
        {
            get { return model; }
        }

        public int Year
        {
            get { return year; }
        }

        public string Color
        {
            get { return color; }
        }

        public override string ToString()
        {
            return "Марка: " + marka + " Модель: " + model + " Год выпуска: " + year + " Цвет: " + color;
        }

    }
}
