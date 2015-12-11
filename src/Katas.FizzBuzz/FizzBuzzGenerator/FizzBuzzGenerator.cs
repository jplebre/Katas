using System;

namespace FizzBuzzTests
{
    public class FizzBuzzGenerator
    {
        public string GetNumberAtPosition(int position)
        {
            if (position % 3 == 0) return "Fizz";
            else if (position == 5) return "Buzz";
            return position.ToString();
        }
    }
}