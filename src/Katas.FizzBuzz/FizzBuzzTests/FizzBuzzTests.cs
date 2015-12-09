using System;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace FizzBuzzTests.cs
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void FirstNumberIs()
        {
            Assert.That(new FizzBuzzGenerator().GetNumberAtPosition(0), Is.EqualTo(1));
        }
    }

    public class FizzBuzzGenerator
    {
        public int GetNumberAtPosition(int position)
        {
            return 1;
        }
    }
}