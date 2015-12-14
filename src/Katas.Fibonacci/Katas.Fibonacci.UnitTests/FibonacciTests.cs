using System;
using NUnit.Framework;

namespace Katas.Fibonacci.UnitTests
{
    [TestFixture]
    public class FibonacciTests
    {
        [Test]
        public void FibonacciNumberAtPositionOneIsZero()
        {
            Assert.That(GetFibonacciNumberAtPosition(1), Is.EqualTo(0));
        }

        [Test]
        public void FibonacciNumberAtPositionTwoIsOne()
        {
            Assert.That(GetFibonacciNumberAtPosition(2), Is.EqualTo(1));
        }

        [Test]
        public void FibonacciNumberAtPositionThreeIsOne()
        {
            Assert.That(GetFibonacciNumberAtPosition(3), Is.EqualTo(1));
        }

        [Test]
        public void FibonacciNumberAtPositionFourIsTwo()
        {
            Assert.That(GetFibonacciNumberAtPosition(4), Is.EqualTo(2));
        }

        [Test]
        public void FibonacciGeneratorReturnsSequenceOfLength()
        {
            Assert.That(new Fibonacci().GenerateFibonacciSequenceWithLength(40), Has.Length.EqualTo(40));
        }

        [Test]
        public void FibonacciGeneratorFirstFourNumbersAreCorrect()
        {
            Assert.That(new Fibonacci().GenerateFibonacciSequenceWithLength(4), Is.EqualTo(new int[] {0,1,1,2}));
        }


        //Helper Methods
        private int GetFibonacciNumberAtPosition(int position)
        {
            return new Fibonacci().FibonacciNumberAtPosition(position);
        }
    }
}
