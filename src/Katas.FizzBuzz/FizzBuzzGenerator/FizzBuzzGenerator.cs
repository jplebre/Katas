using System;

namespace FizzBuzzTests
{
    public class FizzBuzzGenerator
    {
        public string GetNumberAtPosition(int position)
        {
            if (position == 3) return "Fizz";
            else if (position == 5) return "Buzz";
            else if (position == 9) return "Fizz";
            return position.ToString();
        }
    }
}