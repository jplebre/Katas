using System;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace FizzBuzzTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void FirstNumberIs1()
        {
            Assert.That(GetFizzBuzzResultAtPosition(1), Is.EqualTo(1));
        }

        [Test]
        public void SecondNumberIs2()
        {
            Assert.That(GetFizzBuzzResultAtPosition(2), Is.EqualTo(2));
        }


        //----- Helper Methods -----
        private static int GetFizzBuzzResultAtPosition(int position)
        {
            return new FizzBuzzGenerator().GetNumberAtPosition(position);
        }

    }
}