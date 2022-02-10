using System;
using NUnit.Framework;
using Hand_testing_calculator;

namespace UnitTest
{
    [TestFixture]
    public class CalculatorTest
    {
        private Calculator uut;

        [SetUp]
        public void Setup()
        {
            //Arrange
            uut = new Calculator();
        }

        [Test]
        public void Add_Add1PosNumber_ResultIs4()
        {
            //Act
            double number1 = uut.Add(4);

            //Assert
            Assert.That(number1, Is.EqualTo(4));
        }

        [Test]
        public void Add_Add2PosNumber_ResultIs6()
        {
            //Act
            uut.Add(2);
            double number2 = uut.Add(4);

            //Assert
            Assert.That(number2, Is.EqualTo(6));
        }

        [Test]
        public void Add_Add1PosAnd1NegNumber_ResultIs6()
        {
            //Act
            uut.Add(-2);
            double number2 = uut.Add(8);

            //Assert
            Assert.That(number2, Is.EqualTo(6));
        }



        [Test]
        public void Clear_ClearAccumulator_AccumulatorIsSetToZero()
        {
            //Act
            uut.Clear();

            //Assert
            Assert.That(uut.Accumulator, Is.EqualTo(0));
        }

        
    }
}