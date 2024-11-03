using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public static class FibonacciBinetsImplementation
    {
        public static long Fibonacci(int input)
        {
            double phi = (1 + Math.Sqrt(5)) / 2;
            double psi = (1 - Math.Sqrt(5)) / 2;

            return (long)Math.Floor((Math.Pow(phi, input) - Math.Pow(psi, input)) / Math.Sqrt(5));
        }
    }
}
