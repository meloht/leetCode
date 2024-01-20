using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1001_1050
{
    public class _1012_NumbersWithRepeatedDigitsAlg
    {
        int[,] dp;
        public int NumDupDigitsAtMostN(int n)
        {
            string s = n.ToString();
            int m = 1 << 10;
            dp = new int[s.Length, m];

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    dp[i, j] = -1;

                }
            }
            return n-Dfs(0, 0, s, true, false);
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
                int mask1 = mask;
                if (((mask >> j) & 1) == 0)
                {
                    mask1 = mask1 | (1 << j);
                    res += Dfs(i + 1, mask1, s, isLimit && j == up, true);
                }

            }

            if (!isLimit && isNum)
            {
                dp[i, mask] = res;
            }
            return res;
        }
    }
}
