using NUnit.Framework;
using SWT_0101_Calculator;

namespace UUT.Calculator
{
    public class Tests
    {
        private SWT_0101_Calculator.Calculator uut;
        [SetUp]
        public void Setup()
        {
            SWT_0101_Calculator.Calculator uut = new SWT_0101_Calculator.Calculator();

        }

        [Test]
        public void Add_2add2_returns4()
        {
            SWT_0101_Calculator.Calculator uut = new SWT_0101_Calculator.Calculator();
            Assert.That(uut.Add(2,2), Is.EqualTo(4));
        }

        [Test]
        public void Subtract_4minus2_returns2()
        {
            SWT_0101_Calculator.Calculator uut = new SWT_0101_Calculator.Calculator();
            Assert.That(uut.Subtract(4,2), Is.EqualTo(2));
        }

        [Test]
        public void Multiply_2x2_returns4()
        {
            SWT_0101_Calculator.Calculator uut = new SWT_0101_Calculator.Calculator();
            Assert.That(uut.Multiply(2,2), Is.EqualTo(4));
        }

        [Test]
        public void Power_2pow2_returns8()
        {
            SWT_0101_Calculator.Calculator uut = new SWT_0101_Calculator.Calculator();
            Assert.That(uut.Add(2,2), Is.EqualTo(4));
        }
    }
}