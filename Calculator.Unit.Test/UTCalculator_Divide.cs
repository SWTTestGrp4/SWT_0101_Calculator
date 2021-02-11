using System;
using NUnit.Framework;

namespace SWT_0101_Calculator
{
    [TestFixture]
    public class UTCalculator_Divide
    {
        private Calculator uut;
        [SetUp]
        public void Setup()
        {
            uut = new Calculator();

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
        public void Divide_FirstAdd2and2ThenDivideBy2_OverloadDivideMethodReturns2()
        {
            uut.Add(2, 2);
            var result = uut.Divide(2);
            Assert.That(result,Is.EqualTo(2));
        }

        [Test]
        public void Divide_Add2and2ThenDivideBy0_OverloadThrowsDivideByZeroException()
        {
            //ACT
            uut.Add(2, 2);
            //ASSERT
            Assert.That(()=>uut.Divide(0), Throws.TypeOf<DivideByZeroException>());
        }
    }
}