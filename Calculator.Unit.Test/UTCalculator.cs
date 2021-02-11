using System;
using NUnit.Framework;

namespace SWT_0101_Calculator
{
    public class UTCalculator
    {
        private Calculator uut;

        [SetUp]
        public void Setup()
        {
            uut = new Calculator();

        }

        [Test]
        public void Add_2add2_returns4()
        {
       
            Assert.That(uut.Add(2,2), Is.EqualTo(4));
        }

        [Test]
        public void Subtract_4minus2_returns2()
        {
       
            Assert.That(uut.Subtract(4,2), Is.EqualTo(2));
        }

        [TestCase(2,2,4),
         TestCase(16,4,64),
         TestCase(9,3,27)]
        public void Multiply_2x2_returns4(double a, double b, double result)
        {
            var equals= uut.Multiply(a, b);
            Assert.That(result, Is.EqualTo(equals));
        }

        [TestCase(3,2,9),
         TestCase(16,4,65536),
         TestCase(9,3,729)]
        public void Power_2pow2_returns8(double a, double b, double result)
        {
            var equals= uut.Power(a, b);
            Assert.That(result, Is.EqualTo(equals));
        }

        [TestCase(2,2,1),
         TestCase(16,2,8),
         TestCase(9,3,3)]
        public void Divide_8div2_returns4(double a, double b, double result)
        {
            var equals= uut.Divide(a, b);
            Assert.That(result, Is.EqualTo(equals));
        }

        [Test]
        public void Divide_8div0_throwDivideByZeroException()
        {
            
            Assert.That(() => uut.Divide(8, 0), Throws.TypeOf<DivideByZeroException>());

        }
        [Test]
        public void Accumolator_Add2and2thenAdd2and3_ReturnsLatestResult5()
        {
            uut.Add(2, 2);
            uut.Add(2, 3);
            Assert.That(uut.Accumulator,Is.EqualTo(5));
        }
        [Test]
        public void Accumolator_WhenNoActionPerformed_ReturnsZero()
        {
            Assert.That(uut.Accumulator, Is.Zero);
        }
        [Test]
        public void Clear_ClearAccumulator_AccumCleared()
        {
            uut.Add(10, 5);
            uut.Clear();
            Assert.That(uut.Accumulator, Is.EqualTo(0));
        }

        [Test]
        public void Divide_FirstAdd2and2ThenDivideBy2_OverloadDivideMethodReturns2()
        {
            uut.Add(2, 2);
            var result = uut.Divide(2);
            Assert.That(result,Is.EqualTo(2));
        }
    }
}