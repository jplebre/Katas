using System;
using NUnit.Framework;

namespace Fibonacci2.UnitTests
{
    [TestFixture]
    public class FibonacciTests
    {
        [Test]
        public void FibonacciGeneratorCreatesSequenceOfRightLength()
        {
            Assert.That(new Fibonacci().SequenceGeneratorOfLength(100), Has.Length.EqualTo(100));
        }

        [Test]
        public void FibonacciGeneratorFirstNumberInSequenceIsZero()
        {
            Assert.That(GetFibonacciNumberAtPosition(1), Is.EqualTo(0));
        }

        [Test]
        public void FibonacciGeneratorSecondNumberInSequenceIsOne()
        {
            Assert.That(GetFibonacciNumberAtPosition(2), Is.EqualTo(1));
        }

        [Test]
        public void FibonacciGeneratorThirdNumberInSequenceIsOne()
        {
            Assert.That(GetFibonacciNumberAtPosition(3), Is.EqualTo(1));
        }

        [Test]
        public void FibonacciGeneratorFourthNumberInSequenceIsTwo()
        {
            Assert.That(GetFibonacciNumberAtPosition(4), Is.EqualTo(2));
        }

        //Helper Method
        private int GetFibonacciNumberAtPosition(int position)
        {
            return new Fibonacci().SequenceGeneratorOfLength(position)[position - 1];
        }
    }
}