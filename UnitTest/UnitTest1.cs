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

        [Test]
        public void Test1()
        {
            uut.Add(3, 5);
            Assert.That(uut.Add(3,5), Is.EqualTo(8));
        }
    }
}