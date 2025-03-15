using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labs
{


    internal class MyMath
    {

        public double X { get; set; }
        public double Y { get; set; }
        public MyMath() { X = 0; Y = 0; }

        public double Add()
        {
            return X + Y;
        }

        public double Sub()
        {
            return X - Y;
        }
        public double Mul()
        {
            return X * Y;
        }
        public double Div()
        {
            if (Y != 0) return X / Y;
            else { throw new Exception("cant divide by zero"); }

        }


    }
}
