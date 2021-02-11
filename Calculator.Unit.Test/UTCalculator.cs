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

        [TestCase(4,2,2)]
        [TestCase(-4, 2, -6)]
        [TestCase(-4, -2, -2)]
        public void Subtract_AminusB_returnsResult(int a, int b, int result)
        {
            Assert.That(uut.Subtract(a,b), Is.EqualTo(result));
        }

       
        
        

        [Test]
        public void Clear_Add10And5ThenClearAccumulator_AccumCleared()
        {
            uut.Add(10, 5);
            uut.Clear();
            Assert.That(uut.Accumulator, Is.EqualTo(0));
        }

        [Test]
        public void Clear_Add10And10ThenClearAccumulator_AccumCleared()
        {
            uut.Add(10, 10);
            uut.Clear();
            Assert.That(uut.Accumulator, Is.EqualTo(0));
        }

        [Test]
        public void Clear_Add10And5ThenDontClearAccumulator_AccumNotCleared()
        {
            uut.Add(10, 5);
            Assert.That(uut.Accumulator, Is.Not.EqualTo(0));
        }

        
    }
}