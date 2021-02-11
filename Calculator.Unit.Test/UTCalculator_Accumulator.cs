using NUnit.Framework;

namespace SWT_0101_Calculator
{
    [TestFixture]
    public class UTCalculator_Accumulator
    {
        private Calculator uut;

        [SetUp]
        public void Setup()
        {
            uut = new Calculator();

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
    }
}