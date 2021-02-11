using NUnit.Framework;

namespace SWT_0101_Calculator
{
    [TestFixture]
    public class UTCalculator_Multiply
    {
        private Calculator uut;

        [SetUp]
        public void Setup()
        {
            uut = new Calculator();

        }

        [TestCase(2,2,4),
         TestCase(16,4,64),
         TestCase(9,3,27)]
        public void Multiply_axb_returnsResult(double a, double b, double result)
        {
            var equals= uut.Multiply(a, b);
            Assert.That(result, Is.EqualTo(equals));
        }
    }
}