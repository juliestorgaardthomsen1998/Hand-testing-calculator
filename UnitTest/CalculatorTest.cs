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

        //Tester Add 
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
        public void Add_Add2PosDecimalNumber_ResultIs7Comma5()
        {
            //Act
            uut.Add(2.3);
            double number2 = uut.Add(5.2);

            //Assert
            Assert.That(number2, Is.EqualTo(7.5));
        }

        //Tester subtract 
        [Test]
        public void Subtract_1posNumber_ResultIsNeg3()
        {
            //Act
            double number1 = uut.Subtract(3);
            

            //Assert
            Assert.That(number1, Is.EqualTo(-3));
        }

        [Test]
        public void Subtract_1posAnd1NegNumber_ResultIs7()
        {
            //Act
            uut.Subtract(-10);
            double number1 = uut.Subtract(3);


            //Assert
            Assert.That(number1, Is.EqualTo(7));
        }

        [Test]
        public void Subtract_2NegNumber_ResultIs7()
        {
            //Act
            uut.Subtract(-3);
            double number1 = uut.Subtract(-4);


            //Assert
            Assert.That(number1, Is.EqualTo(7));
        }

        [Test]
        public void Subtract_2DecimalNumber_ResultIsNeg2Comma2()
        {
            //Act
            uut.Subtract(1.2);
            double number1 = uut.Subtract(1);


            //Assert
            Assert.That(number1, Is.EqualTo(-2.2));
        }

        //Tester multiply
        [Test]
        public void Multiply_Multiply2PosNumber_ResultIs20()
        {
            //Act
            double number1 = uut.Add(5);
            double number2 = uut.Multiply(4);

            //Assert
            Assert.That(number2,Is.EqualTo(20));
        }

        [Test]
        public void Multiply_Multiply1PosNumberAnd1NegNumber_ResultIsNeg15()
        {
            //Act
            double number1 = uut.Add(5);
            double number2 = uut.Multiply(-3);

            //Assert
            Assert.That(number2, Is.EqualTo(-15));
        }

        [Test]
        public void Multiply_Multiply2NegNumbers_ResultIs8()
        {
            //Act
            double number1 = uut.Add(-2);
            double number2 = uut.Multiply(-4);

            //Assert
            Assert.That(number2, Is.EqualTo(8));
        }
        [Test]
        public void Multiply_Multiply2DecimalNumber_ResultIs27Comma04()
        {
            //Act
            double number1 = uut.Add(5.2);
            double number2 = uut.Multiply(5.2);

            //Assert
            Assert.That(number2, Is.EqualTo(27.04).Within(0.1));
        }

        //Tester power
        [Test]
        public void Power_Power2exp_resultIs9()
        {
            //Act
            double number1 =uut.Add(3);
            double number2 = uut.Power(2);

            //Assert
            Assert.That(number2, Is.EqualTo(9));
        }

        [Test]
        public void Power_PoweMinus1exp_resultIs0Point5()
        {
            //Act
            double number1 = uut.Add(2);
            double number2 = uut.Power(-1);

            //Assert
            Assert.That(number2, Is.EqualTo(0.5));
        }

        [Test]
        public void Power_Power0exp_resultIs1()
        {
            //Act
            double number1 = uut.Add(3);
            double number2 = uut.Power(0);

            //Assert
            Assert.That(number2, Is.EqualTo(1));
        }

        
        //Tester clear
        [Test]
        public void Clear_ClearAccumulator_AccumulatorIsSetToZero()
        {
            //Act
            uut.Add(3);
            uut.Clear();

            //Assert
            Assert.That(uut.Accumulator, Is.EqualTo(0));
        }

        //Tester divide
        [Test]
        public void Divide_1posNumber_ResultIs3()
        {
            //Act
            uut.Add(9);                   
            double number1 = uut.Divide(3);

            //Assert
            Assert.That(number1, Is.EqualTo(3));
        }

        [Test] 
        public void Divide_2posNumber_ResultIs1Comma5()
        {
            //Act
            uut.Add(9);
            uut.Divide(3);
            double number1 = uut.Divide(2);

            //Assert
            Assert.That(number1, Is.EqualTo(1.5));
        }

        [Test]
        public void Divide_with0_ResultException()
        {
            //Act
            uut.Add(9);
            double number1 = 0;

            //Assert
            Assert.That(() => uut.Divide(number1),
                Throws.TypeOf<DivideByZeroException>());
        }

    }
}