using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public static class FibonacciIterativeImplementation
    {
        public static long Fibonacci(long input)
        {
            long a = 0, b = 1, temp;

            for (long i = 0; i < input; i++)
            {
                temp = a;
                a = b;
                b = temp + b;
            }

            return a;
        }
    }
}
