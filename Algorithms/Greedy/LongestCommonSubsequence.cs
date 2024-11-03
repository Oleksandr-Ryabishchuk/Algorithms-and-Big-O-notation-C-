using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greedy
{
    public class LongestCommonSubsequence
    {
        public static int FindLCS(string X, string Y)
        {
            int m = X.Length;
            int n = Y.Length;

            // Create a 2D array to store lengths of LCS
            int[,] dp = new int[m + 1, n + 1];

            // Build the dp array from the bottom up
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (X[i - 1] == Y[j - 1]) // If characters match
                    {
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                    }
                    else // If characters don't match
                    {
                        dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                    }
                }
            }

            // The value at dp[m][n] contains the length of the LCS
            return dp[m, n];
        }

        // Function to print the LCS itself
        public static string GetLCS(string X, string Y)
        {
            int m = X.Length;
            int n = Y.Length;
            int[,] dp = new int[m + 1, n + 1];

            // Fill the dp table as before
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (X[i - 1] == Y[j - 1])
                    {
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                    }
                }
            }

            // Reconstruct the LCS from the dp array
            int index = dp[m, n];
            char[] lcs = new char[index]; // Create a char array to store the LCS characters
            int iPointer = m, jPointer = n;

            while (iPointer > 0 && jPointer > 0)
            {
                if (X[iPointer - 1] == Y[jPointer - 1])
                {
                    lcs[index - 1] = X[iPointer - 1];
                    iPointer--;
                    jPointer--;
                    index--;
                }
                else if (dp[iPointer - 1, jPointer] > dp[iPointer, jPointer - 1])
                {
                    iPointer--;
                }
                else
                {
                    jPointer--;
                }
            }

            return new string(lcs); // Convert char array to string
        }
    }
}
