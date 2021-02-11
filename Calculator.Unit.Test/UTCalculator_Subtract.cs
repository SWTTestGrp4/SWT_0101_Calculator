using NUnit.Framework;

namespace SWT_0101_Calculator
{
    public class UTCalculator_Subtract
    {
        private Calculator uut;

        [SetUp]
        public void Setup()
        {
            uut = new Calculator();

        }

        [TestCase(4, 2, 2)]
        [TestCase(-4, 2, -6)]
        [TestCase(-4, -2, -2)]
        public void Subtract_AminusB_returnsResult(int a, int b, int result)
        {
            Assert.That(uut.Subtract(a, b), Is.EqualTo(result));
        }

    }
}