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
                return 1; 
            return position - 1;
        }
    }
}
