using NUnit.Framework;
using Hand_testing_calculator;

namespace UnitTest
{
    public class Tests
    {
        private Calculator uut;

        [SetUp]
        public void Setup()
        {
            uut = new Calculator();
        }


        [TestCase(3, 2, 5)]
        [TestCase(-3, -2, -5)]
        [TestCase(-3, 2, -1)]
        [TestCase(3, -2, 1)]
        [TestCase(3, 0, 3)]
        public void Add_AddPosAndNegNumbers_ResultIsCorrect(int a, int b, int result)
        {
            Assert.That(uut.Add(a, b), Is.EqualTo(result));
        }


        [TestCase(3, 2, 1)]
        [TestCase(-3, -2, -1)]
        [TestCase(-3, 2, -5)]
        public void Subtract_SubtractPosAndNegNumbers_ResultIsCorrect(int a, int b, int result)
        {
            Assert.That(uut.Subtract(a, b), Is.EqualTo(result));
        }


        [TestCase(3, 2, 6)]
        [TestCase(-3, -2, 6)]
        [TestCase(-3, 2, -6)]
        [TestCase(3, -2, -6)]
        [TestCase(0, -2, 0)]
        [TestCase(-2, 0, 0)]
        [TestCase(0, 0, 0)]
        public void Multiply_MultiplyNunmbers_ResultIsCorrect(int a, int b, int result)
        {
            Assert.That(uut.Multiply(a, b), Is.EqualTo(result));
        }


        [TestCase(2, 3, 8)]
        [TestCase(2, -3, 0.125)]
        [TestCase(-2, -3, -0.125)]
        [TestCase(1, 10, 1)]
        [TestCase(1, -10, 1)]
        [TestCase(10, 0, 1)]
        [TestCase(4, 0.5, 2.0)]
        [TestCase(9, 0.5, 3.0)]
        public void Power_RaiseNumbers_ResultIsCorrect(double x, double exp, double result)
        {
            Assert.That(uut.Power(x, exp), Is.EqualTo(result));
        }

        //[TestCase(2, 3, 8)]
        //[TestCase(2, -3, 0.125)]
        //[TestCase(-2, -3, -0.125)]
        //[TestCase(1, 10, 1)]
        //[TestCase(1, -10, 1)]
        //[TestCase(10, 0, 1)]
        //[TestCase(4, 0.5, 2.0)]
        //[TestCase(9, 0.5, 3.0)]
        //public void Clear_ClearAccumulator_AccumulatorIsSetToZero(double a, double result)
        //{
        //    Assert.That(uut.Clear(), Is.EqualTo(0));
        //}
    }
}