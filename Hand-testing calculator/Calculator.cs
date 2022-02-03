using System;
using System.Collections.Generic;
using System.Text;

namespace Hand_testing_calculator
{
    public class Calculator
    {

        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Power(double a, double b)
        {
            return Math.Pow(a, b);
        }
    }
}
