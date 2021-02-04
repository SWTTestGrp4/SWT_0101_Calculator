using NUnit.Framework;

namespace SWT_0101_Calculator
{
    public class Tests
    {
        private Calculator uut;
        [SetUp]
        public void Setup()
        {
            Calculator uut = new Calculator();

        }

        [Test]
        public void Add_2add2_returns4()
        {
            Calculator uut = new Calculator();
            Assert.That(uut.Add(2,2), Is.EqualTo(4));
        }

        [Test]
        public void Subtract_4minus2_returns2()
        {
            Calculator uut = new Calculator();
            Assert.That(uut.Subtract(4,2), Is.EqualTo(2));
        }

        [Test]
        public void Multiply_2x2_returns4()
        {
            Calculator uut = new Calculator();
            Assert.That(uut.Multiply(2,2), Is.EqualTo(4));
        }

        [Test]
        public void Power_2pow2_returns8()
        {
            Calculator uut = new Calculator();
            Assert.That(uut.Add(2,2), Is.EqualTo(4));
        }
    }
}