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
            Assert.That(new Fibonacci().FibonacciNumberAtPosition(1), Is.EqualTo(0));
        }

        [Test]
        public void FibonacciNumberAtPoistionTwoIsOne()
        {
            Assert.That(new Fibonacci().FibonacciNumberAtPosition(2), Is.EqualTo(1));
        }
    }
}