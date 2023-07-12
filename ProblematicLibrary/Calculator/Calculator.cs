using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblematicLibrary.Calculator
{
    public class Calculator : ICalculable
    {
        public double Add(double x, double y)
        {
            return x + y;
        }

        public double Divide(double x, double y)
        {
            if (y != 0)
            {
                return x / y;
            }
            else
            {
                return -1;
            }
            
        }

        public double Multiply(double x, double y)
        {
            return Math.Round(x * y);
        }

        public double Subtract(double x, double y)
        {
            return x - y;
        }
    }
}
