using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0501_0550
{
    public class _516_LongestPalindromicSubsequenceAlg
    {
        private char[] arr;
        private int[,] memo;
        public int LongestPalindromeSubseq1(string s)
        {
            arr = s.ToCharArray();
            int n = s.Length;
            memo = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    memo[i, j] = -1;
                }
            }

            return Dfs(0, n - 1);
        }


        private int Dfs(int i, int j)
        {
            if (i > j)
            {
                return 0;
            }
            if (i == j)
            {
                return 1;
            }
            if (memo[i, j] != -1)
            {
                return memo[i, j];
            }
            if (arr[i] == arr[j])
            {
                memo[i, j] = Dfs(i + 1, j - 1) + 2;
                return memo[i, j];
            }

            memo[i, j] = Math.Max(Dfs(i + 1, j), Dfs(i, j - 1));
            return memo[i, j];
        }


        public int LongestPalindromeSubseq(string s)
        {

            int n = s.Length;
            int[,] dp = new int[n, n];
            for (int i = n - 1; i >= 0; i--)
            {
                dp[i, i] = 1;
                for (int j = i + 1; j < n; j++)
                {

                    dp[i, j] = s[i] == s[j] ? dp[i + 1, j - 1] + 2 : Math.Max(dp[i + 1, j], dp[i, j - 1]);
                }
            }
            return dp[0, n - 1];
        }

    }
}
