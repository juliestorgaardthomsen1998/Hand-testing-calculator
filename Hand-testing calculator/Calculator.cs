using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hand_testing_calculator
{
    public class Calculator
    {
        public double Accumulator { get; private set; }

        public double Add(double a)
        {
            Accumulator = a + Accumulator;
            return Accumulator;
        }

        public double Subtract(double a)
        {
            Accumulator = Accumulator-a;
            return Accumulator;
        }

        public double Multiply(double a)
        {
            Accumulator = Accumulator * a;
            return Accumulator;
        }

        public double Power(double exp)
        {
            Accumulator = Math.Pow(Accumulator, exp);
            return Accumulator;
        }

        public void Clear()
        {
            Accumulator = 0;
        }

        public double Divide(double a)
        {
            if (a == 0.0)
            { 
                throw new DivideByZeroException("can't divide by zero");
            }
            
            Accumulator = Accumulator / a;
            return Accumulator;
        }
    }
}
