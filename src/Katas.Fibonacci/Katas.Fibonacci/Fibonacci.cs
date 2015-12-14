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
            if (position > 2)
                return FibonacciNumberAtPosition(position-2) + FibonacciNumberAtPosition(position - 1); 
            return position - 1;
        }

        public int[] GenerateFibonacciSequenceWithLength(int length)
        {
            int[] sequence = new int[length];
            for (int i = 0; i < sequence.Length; i++)
            {
                sequence[i] = FibonacciNumberAtPosition(i + 1);
            }
            return sequence;
        }
    }
}
