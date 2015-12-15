using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.Fibonacci
{
    public class Fibonacci
    {
        public int FibonacciNumberAtPosition(int position)
        {
            return GenerateFibonacciSequenceWithLength(position)[position - 1];
        }

        public int[] GenerateFibonacciSequenceWithLength(int length)
        {
            int[] sequence = new int[length];

            for (int i = 0; i < sequence.Length; i++)
            {
                if (i < 2) sequence[i] = i;
                else sequence[i] = sequence[i - 1] + sequence[i - 2];
            }

            return sequence;
        }
    }
}
