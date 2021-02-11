using NUnit.Framework;

namespace SWT_0101_Calculator
{
    [TestFixture]
    public class UTCalculator_Power
    {
        private Calculator uut;

        [SetUp]
        public void Setup()
        {
            uut = new Calculator();

        }

        [TestCase(3,2,9),
         TestCase(16,4,65536),
         TestCase(9,3,729)]
        public void Power_2pow2_returns8(double a, double b, double result)
        {
            var equals= uut.Power(a, b);
            Assert.That(result, Is.EqualTo(equals));
        }

    }
}