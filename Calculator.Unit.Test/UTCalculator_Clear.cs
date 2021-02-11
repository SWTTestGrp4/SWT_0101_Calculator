using NUnit.Framework;

namespace SWT_0101_Calculator
{
    public class UTCalculator_Clear
    {
        private Calculator uut;

        [SetUp]
        public void Setup()
        {
            uut = new Calculator();

        }

        [TestCase(10,5,0)]
        [TestCase(10, 10, 0)]
        public void Clear_Add10And5ThenClearAccumulator_AccumCleared(double a, double b, double result)
        {
            var equals = uut.Accumulator;
                uut.Add(a,b);
                uut.Clear();
                Assert.That(result, Is.EqualTo(equals));
        }

        [Test]
        public void Clear_Add10And5ThenDontClearAccumulator_AccumNotCleared()
        {
            uut.Add(10, 5);
            Assert.That(uut.Accumulator, Is.Not.EqualTo(0));
        }
    }
}