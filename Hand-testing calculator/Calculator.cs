using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hand_testing_calculator
{
    public class Calculator
    {
        public double Accumulator { get; private set; }

        public double Add(double a, double b)
        {
            Accumulator = a + b;
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            Accumulator = a - b;
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            Accumulator= a* b;
            return a * b;
        }

        public double Power(double x, double exp)
        {
            Accumulator = Math.Pow(x, exp);
            return Math.Pow(x, exp);
        }

        public void Clear()
        {
            Accumulator = 0;
        }

        public double Divide(double a, double b)
        {
            if (b == 0)
                throw new ArgumentOutOfRangeException();
            
            return a / b;
        }
    }
}
