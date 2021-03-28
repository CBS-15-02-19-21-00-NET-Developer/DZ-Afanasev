using System;

namespace DZ_11_2
{
    class Program
    {
        static void Main(string[] args)
        {            
            Converter converter = new Converter(27.64, 32.76, 0.34);
            // неплохо было бы автоматически подгружать курс с сайта центробанка
            // но пока не знаю, как это сделать

            Console.Write("100 гривен в долларах: ");
            Console.WriteLine(converter.ToUsd(100));
            Console.Write("100 долларов в гривнах: ");
            Console.WriteLine(converter.FromUsd(100));
        }
    }

    class Converter
    {
        double usd, eur, rub;

        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }

        public double ToUsd (double valuta)
        {
            return valuta / usd;
        }

        public double FromUsd(double valuta)
        {
            return valuta * usd;
        }

        public double ToEur(double valuta)
        {
            return valuta / eur;
        }

        public double FromEur(double valuta)
        {
            return valuta * eur;
        }

        public double ToRub(double valuta)
        {
            return valuta / rub;
        }

        public double FromRub(double valuta)
        {
            return valuta * rub;
        }

    }

}

