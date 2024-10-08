using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Winform
{
    interface ICalculator
    {
        double Add(double x, double y);
        double Subtract(double x, double y);
        double Multiply(double x, double y);
        double Divide(double x, double y);
    }
    internal class Math : ICalculator
    {
        public double Add(double x, double y)
        {
            return x + y;
        }

        public double Divide(double x, double y)
        {
            return x / y;
        }

        public double Multiply(double x, double y)
        {
            return (x * y);
        }

        public double Subtract(double x, double y)
        {
            return x - y;
        }
    }
}
