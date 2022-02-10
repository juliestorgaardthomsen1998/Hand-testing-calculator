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


        //[TestCase(3, 2, 5)]
        //[TestCase(6, 2, 8)]
        //[TestCase(-3, 2, -1)]
        //[TestCase(3, -2, 1)]
        //[TestCase(3, 0, 3)]
        //public void Add_AddPosAndNegNumbers_AccumulatorIsCorrect(int a, int b, int accumulator)
        //{
        //    uut.Add(a, b);

        //    Assert.That(uut.Accumulator, Is.EqualTo(accumulator));
        //}

        //[TestCase(3, 2, 1)]
        //[TestCase(-3, -2, -1)]
        //[TestCase(-3, 2, -5)]
        //public void Subtract_AddPosAndNegNumbers_AccumulatorIsCorrect(int a, int b, int accumulator)
        //{
        //    uut.Subtract(a, b);

        //    Assert.That(uut.Accumulator, Is.EqualTo(accumulator));
        //}


        //[TestCase(3, 2, 6)]
        //[TestCase(-3, -2, 6)]
        //[TestCase(-3, 2, -6)]
        //[TestCase(3, -2, -6)]
        //[TestCase(0, -2, 0)]
        //[TestCase(-2, 0, 0)]
        //[TestCase(0, 0, 0)]
        //public void Multiply_AddPosAndNegNumbers_AccumulatorIsCorrect(int a, int b, int accumulator)
        //{
        //    uut.Multiply(a, b);

        //    Assert.That(uut.Accumulator, Is.EqualTo(accumulator));
        //}

        [TestCase(1,2)]
        [TestCase(-1, 0.5)]
        [TestCase(0, 1)]
        public void Power_RaiseNumbers_AccumulatorIsCorrect(double exp, double result)
        {
            //Act
            uut.Add(2);
            uut.Power(exp);

            //Assert
            Assert.That(uut.Accumulator, Is.EqualTo(result));
        }

        [TestCase(2,2)]
        [TestCase(-1, -1)]
        [TestCase(7, 7)]
        [TestCase(-10, -10)]

        public void Add_Add1PosAndNegNumber_ResultIsCorrect(double a,double result)
        {
            Assert.That(uut.Add(a),Is.EqualTo(result));
        }

        [TestCase(2,2,2,2,2,10)]
        [TestCase(1,2,3,4,5,15)]
        [TestCase(-1,-1,-1,-1,-1,-5)]
       
        public void Add_Add5PosAndNegNumber_AccumulatorIsCorrect(double a1,double a2, double a3, double a4, double a5, double accumulator)
        {
            uut.Add(a1);
            uut.Add(a2);
            uut.Add(a3);
            uut.Add(a4);
            uut.Add(a5);
            Assert.That(uut.Accumulator, Is.EqualTo(accumulator));
        }
    }
}