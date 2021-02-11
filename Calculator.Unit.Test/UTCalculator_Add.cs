using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Calculator;

namespace Calculator.Unit.Test
{
    public class UTCalculator_Add
    {
        private SWT_0101_Calculator.Calculator uut;

        [SetUp]
        public void Setup()
        {
            uut = new SWT_0101_Calculator.Calculator();
        }

        [TestCase(2, 2, 4)]
        [TestCase(-2, 2, 0)]
        [TestCase(-2, -2, -4)]
        public void Add_AplusB_returnsResult(int a, int b, int result)
        {
            Assert.That(uut.Add(a, b), Is.EqualTo(result));
        }
    }
}
