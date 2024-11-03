using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public class FibonacciMemoImplementation
    {
        private Dictionary<int, long> memo;

        public FibonacciMemoImplementation()
        {
            memo = new Dictionary<int, long>();
        }

        public long Fibonacci(int input, Dictionary<int, long> newMemo = null)
        {
            if (newMemo != null && newMemo.Count > 0)
            {
                memo = newMemo;
            }
            if(memo.ContainsKey(input))
            {
                return memo[input];
            }
            if (input <= 2)
            {
                return 1;
            }

            memo[input] = Fibonacci(input - 1, memo) + Fibonacci(input - 2, memo);

            return memo[input];
        }
    }
}
