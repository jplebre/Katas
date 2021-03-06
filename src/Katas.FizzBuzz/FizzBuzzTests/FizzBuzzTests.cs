﻿using System;
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

        [Test]
        public void FifthNumberIsBuzz()
        {
            Assert.That(GetFizzBuzzResultAtPosition(5), Is.EqualTo("Buzz"));
        }

        [Test]
        public void NinthNumberIsFizz()
        {
            Assert.That(GetFizzBuzzResultAtPosition(9), Is.EqualTo("Fizz"));
        }

        [Test]
        public void TenthNumberIsBuzz()
        {
            Assert.That(GetFizzBuzzResultAtPosition(10), Is.EqualTo("Buzz"));
        }

        [Test]
        public void FifteenthNumberIsFizzBuzz()
        {
            Assert.That(GetFizzBuzzResultAtPosition(15), Is.EqualTo("FizzBuzz"));

        }

        [Test]
        public void ThirtiethhNumberIsFizzBuzz()
        {
            Assert.That(GetFizzBuzzResultAtPosition(30), Is.EqualTo("FizzBuzz"));

        }

        [Test]
        public void GenerateASequenceWith100Numbers()
        {
            Assert.That(GetFizzBuzzWithLength(100), Has.Length.EqualTo(100));    
        }

        [Test]
        public void GenerateASequenceFollowsMultipleOf3Rule()
        {
            Assert.That(GetFizzBuzzWithLength(100).GetValue(3), Is.EqualTo("Fizz"));
        }

        [Test]
        public void GenerateASequenceFollowsMultipleOf5Rule()
        {
            Assert.That(GetFizzBuzzWithLength(100).GetValue(5), Is.EqualTo("Buzz"));
        }

        [Test]
        public void GenerateASequenceFollowsMultipleOf3and5Rule()
        {
            Assert.That(GetFizzBuzzWithLength(100).GetValue(15), Is.EqualTo("FizzBuzz"));
        }

        //----- Helper Methods -----
        private static string GetFizzBuzzResultAtPosition(int position)
        {
            return new FizzBuzzGenerator().GetNumberAtPosition(position);
        }

        private string[] GetFizzBuzzWithLength(int length)
        {
            return new FizzBuzzGenerator().GetFizzBuzzSequenceWithLength(length);
        }
    }
}