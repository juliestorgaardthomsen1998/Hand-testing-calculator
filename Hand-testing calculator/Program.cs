using System;

namespace Hand_testing_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            double number1 = 3;
            double number2 = 4;

            Console.WriteLine("ADD: " + calculator.Add(number1,number2) + "Subtract: " + calculator.Subtract(number1,number2) + "Multiply: " + calculator.Multiply(number1,number2) + "Power: " + calculator.Power(number1,number2));

            Console.ReadKey();

        }
    }
}
