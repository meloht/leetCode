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
        int maxLcs = 0;
        public int MinimumDeleteSum(string s1, string s2)
        {
            int n = s1.Length;
            int m = s2.Length;

            int ss1 = s1.ToCharArray().Sum(p => p);
            int ss2 = s2.ToCharArray().Sum(p => p);
            int[,] dp = LCS(s1, s2);

            GetAllLCSUtil(dp, s1, s2, n, m, "");
            int res = ss1 - maxLcs + ss2 - maxLcs;

            return res;
        }

        private int[,] LCS(string str1, string str2)
        {
            int m = str1.Length;
            int n = str2.Length;

            int[,] dp = new int[m + 1, n + 1];

            for (int i = 0; i <= m; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    if (i == 0 || j == 0)
                        dp[i, j] = 0;
                    else if (str1[i - 1] == str2[j - 1])
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                    else
                        dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                }
            }

            return dp;
        }

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

        private void GetAllLCSUtil(int[,] dp, string str1, string str2, int m, int n, string current)
        {
            if (m == 0 || n == 0)
            {
                int sum = current.Sum(p => p);
                maxLcs = Math.Max(maxLcs, sum);

                return;
            }

            if (str1[m - 1] == str2[n - 1])
            {
                GetAllLCSUtil(dp, str1, str2, m - 1, n - 1, str1[m - 1] + current);
            }
            else
            {
                if (dp[m - 1, n] >= dp[m, n - 1])
                {
                    GetAllLCSUtil(dp, str1, str2, m - 1, n, current);
                }

                if (dp[m, n - 1] >= dp[m - 1, n])
                {
                    GetAllLCSUtil(dp, str1, str2, m, n - 1, current);
                }
            }
        }
    }
}
