using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0351_0400
{
    public class _357_CountNumbersWithUniqueDigitsAlg
    {
        int[,] dp;
        public int CountNumbersWithUniqueDigits(int n)
        {
            int num = (int)Math.Pow(10, n) - 1;
            string s = num.ToString();
            int m = 1 << 10;
            dp = new int[s.Length, m];

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    dp[i, j] = -1;
                }
            }
            return Dfs(0, 0, s, true, false) + 1;
        }

        private int Dfs(int i, int mask, string s, bool isLimit, bool isNum)
        {
            if (i == s.Length)
            {
                return isNum ? 1 : 0;
            }
            if (!isLimit && isNum && dp[i, mask] >= 0)
            {
                return dp[i, mask];
            }

            int res = 0;
            if (!isNum)
            {
                res = Dfs(i + 1, mask, s, false, false);
            }
            int up = isLimit ? s[i] - '0' : 9;

            for (int j = isNum ? 0 : 1; j <= up; j++)
            {
                if (((mask >> j) & 1) == 0)
                {
                    res += Dfs(i + 1, mask | (1 << j), s, isLimit && j == up, true);
                }
            }

            if (!isLimit && isNum)
            {
                dp[i, mask] = res;
            }
            return res;
        }

        public int CountNumbersWithUniqueDigits1(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            if (n == 1)
            {
                return 10;
            }
            int res = 10, cur = 9;
            for (int i = 0; i < n - 1; i++)
            {
                cur *= 9 - i;
                res += cur;
            }
            return res;
        }

    }
}
