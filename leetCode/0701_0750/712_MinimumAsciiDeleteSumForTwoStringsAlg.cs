using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0701_0750
{
    public class _712_MinimumAsciiDeleteSumForTwoStringsAlg
    {

        public int MinimumDeleteSum(string s1, string s2)
        {
            int n = s1.Length;
            int m = s2.Length;

            int[,] dp = new int[n + 1, m + 1];

            for (int i = 1; i <= n; i++)
            {
                dp[i, 0] = dp[i - 1, 0] + s1[i - 1];

            }
            for (int i = 1; i <= m; i++)
            {
                dp[0, i] = dp[0, i - 1] + s2[i - 1];

            }

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    if (s1[i - 1] == s2[j - 1])
                    {
                        dp[i, j] = dp[i - 1, j - 1];

                    }
                    else
                    {

                        dp[i, j] = Math.Min(dp[i - 1, j] + s1[i - 1], dp[i, j - 1] + s2[j - 1]);

                    }
                }
            }
            return dp[n, m];

        }

      
    }
}
