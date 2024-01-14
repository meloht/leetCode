using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1101_1150
{
    public class _1143_LongestCommonSubsequenceAlg
    {
        public int LongestCommonSubsequence(string text1, string text2)
        {
            int n = text1.Length;
            int m = text2.Length;

            int[,] dp = new int[n + 1, m + 1];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (text1[i] == text2[j])
                    {
                        dp[i + 1, j + 1] = dp[i, j] + 1;
                    }
                    else
                    {
                        dp[i + 1, j + 1] = Math.Max(dp[i, j + 1], dp[i + 1, j]);
                    }
                }
            }
            return dp[n, m];
        }
    }
}
