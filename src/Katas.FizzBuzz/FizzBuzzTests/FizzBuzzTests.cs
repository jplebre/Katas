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
            Assert.That(GetFizzBuzzResultAtPosition(1), Is.EqualTo("1"));
        }

        [Test]
        public void SecondNumberIs2()
        {
            Assert.That(GetFizzBuzzResultAtPosition(2), Is.EqualTo("2"));
        }

        [Test]
        public void ThirdNumberIsFizz()
        {
            Assert.That(GetFizzBuzzResultAtPosition(3), Is.EqualTo("Fizz"));
        }


        //----- Helper Methods -----
        private static string GetFizzBuzzResultAtPosition(int position)
        {
            return new FizzBuzzGenerator().GetNumberAtPosition(position);
        }

    }
}