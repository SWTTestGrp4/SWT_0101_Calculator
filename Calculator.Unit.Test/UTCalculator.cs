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
        public void Accumolator_AddThenClearThenAdd_ReturnCorrectResultAfterClear()
        {
            uut.Add(2, 2);
            uut.Clear();
            uut.Add(2, 5);
            Assert.That(uut.Accumulator,Is.EqualTo(7));
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