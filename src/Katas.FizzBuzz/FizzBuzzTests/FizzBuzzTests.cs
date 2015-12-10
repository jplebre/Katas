using System;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace FizzBuzzTests.cs
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void FirstNumberIs1()
        {
            Assert.That(new FizzBuzzGenerator().GetNumberAtPosition(0), Is.EqualTo(1));
        }

        [Test]
        public void SecondNumberIs2()
        {
            Assert.That(new FizzBuzzGenerator().GetNumberAtPosition(1), Is.EqualTo(2));
        }
    }

    public class FizzBuzzGenerator
    {
        public int GetNumberAtPosition(int position)
        {
            return position + 1;
        }
    }
}