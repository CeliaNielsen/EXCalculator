using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXCalculator
{
    public class Calculator
    {
        public  double A { get; private set; }
        public  double B { get; private set; }
        public double X { get; private set; }
        public double EXP { get; private set; }
        

        public Calculator()
        {
            
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Substract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a*b;
        }

        public double Power(double x, double exp)
        {
            return Math.Pow(x, exp);
        }
    }
}
