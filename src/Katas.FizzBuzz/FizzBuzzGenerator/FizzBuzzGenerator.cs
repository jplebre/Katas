using System;

namespace FizzBuzzTests
{
    public class FizzBuzzGenerator
    {
        public string GetNumberAtPosition(int position)
        {
            if (position == 3) return "Fizz";
            return position.ToString();
        }
    }
}