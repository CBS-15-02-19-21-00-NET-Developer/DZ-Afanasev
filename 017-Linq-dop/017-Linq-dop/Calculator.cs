using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017_Linq_dop
{
    class Calculator
    {
        public dynamic Add (dynamic a, dynamic b)
        {
            return a + b;
        }

        public dynamic Sub(dynamic a, dynamic b)
        {
            return a - b;
        }

        public dynamic Mul(dynamic a, dynamic b)
        {
            return a * b;
        }

        public dynamic Div(dynamic a, dynamic b)
        {
            if (b != 0)
                return a / b;
            else return "На ноль делить нельзя!";
        }
    }
}
