using Hand_testing_calculator;
using NUnit.Framework;

namespace UnitTest
{
    [TestFixture]
    public class AccumulatorTest
    {

        private Calculator uut;

        [SetUp]
        public void Setup()
        {
            uut = new Calculator();
        }


        [TestCase(3, 2, 5)]
        [TestCase(6, 2, 8)]
        [TestCase(-3, 2, -1)]
        [TestCase(3, -2, 1)]
        [TestCase(3, 0, 3)]
        public void Add_AddPosAndNegNumbers_AccumulatorIsCorrect(int a, int b, int accumulator)
        {
            uut.Add(a, b);

            Assert.That(uut.Accumulator, Is.EqualTo(accumulator));
        }

        [TestCase(3, 2, 1)]
        [TestCase(-3, -2, -1)]
        [TestCase(-3, 2, -5)]
        public void Subtract_AddPosAndNegNumbers_AccumulatorIsCorrect(int a, int b, int accumulator)
        {
            uut.Subtract(a, b);

            Assert.That(uut.Accumulator, Is.EqualTo(accumulator));
        }


        [TestCase(3, 2, 6)]
        [TestCase(-3, -2, 6)]
        [TestCase(-3, 2, -6)]
        [TestCase(3, -2, -6)]
        [TestCase(0, -2, 0)]
        [TestCase(-2, 0, 0)]
        [TestCase(0, 0, 0)]
        public void Multiply_AddPosAndNegNumbers_AccumulatorIsCorrect(int a, int b, int accumulator)
        {
            uut.Multiply(a, b);

            Assert.That(uut.Accumulator, Is.EqualTo(accumulator));
        }

        [TestCase(2, 3, 8)]
        [TestCase(2, -3, 0.125)]
        [TestCase(-2, -3, -0.125)]
        [TestCase(1, 10, 1)]
        [TestCase(1, -10, 1)]
        [TestCase(10, 0, 1)]
        [TestCase(4, 0.5, 2.0)]
        [TestCase(9, 0.5, 3.0)]
        public void Power_RaiseNumbers_AccumulatorIsCorrect(double x, double exp, double accumulator)
        {
            uut.Power(x, exp);

            Assert.That(uut.Accumulator, Is.EqualTo(accumulator));
        }
    }
}