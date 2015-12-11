using System;

namespace FizzBuzzTests
{
    public class FizzBuzzGenerator
    {
        public string[] GetFizzBuzzSequenceWithLength(int length)
        {
            string[] sequence = new string[length];
            for (int i = 0; i < sequence.Length; i++)
            {
                sequence[i] = GetNumberAtPosition(i);
            }
            return sequence;
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