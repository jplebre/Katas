using System;

namespace FizzBuzzTests
{
    public class FizzBuzzGenerator
    {
        public string[] GetFizzBuzzSequenceWithLength(int length)
        {
            return new string[length];
        }

        public string GetNumberAtPosition(int position)
        {
            if (position % 3 == 0 && position % 5 == 0) return "FizzBuzz";
            else if (position % 3 == 0) return "Fizz";
            else if (position % 5 == 0) return "Buzz";
            return position.ToString();
        }
    }
}