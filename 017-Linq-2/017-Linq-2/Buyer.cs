using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017_Linq_2
{
    struct Buyer
    {
        readonly string name;
        readonly string model;
        readonly string tel;

        public Buyer (string name, string model, string tel)
        {
            this.name = name;
            this.model = model;
            this.tel = tel;
        }

        public string Name
        {
            get { return name; }
        }

        public string Model
        {
            get { return model; }
        }

        public string Tel
        {
            get { return tel; }
        }

        public override string ToString()
        {
            return "Покупатель: " + name + " Модель: " + model + " Телефон: " + tel;
        }
    }
}
