using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0751_0800
{
    public class _788_RotatedDigitsAlg
    {
        int[,] dp;
        public int RotatedDigits(int n)
        {
            string ss = n.ToString();
            int nn = ss.Length;
            dp = new int[nn, 2];
            for (int i = 0; i < nn; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    dp[i, j] = -1;
                }
            }

            int ans = Dfs(0, 0, ss, true);
            return ans;
        }

        private int Dfs(int i, int isDiff, string s, bool isLimit)
        {
            if (i == s.Length)
            {
                return isDiff == 1 ? 1 : 0;
            }
            if (!isLimit && dp[i, isDiff] >= 0)
            {
                return dp[i, isDiff];
            }
            int up = isLimit ? s[i] - '0' : 9;
            int res = 0;
            for (int j = 0; j <= up; j++)
            {

                if (j == 0 || j == 1 || j == 8 || j == 2 || j == 5 || j == 6 || j == 9)
                {
                    int diff = isDiff;
                    if (diff == 0 && (j == 2 || j == 5 || j == 6 || j == 9))
                    {
                        diff = 1;
                    }
                    res = res + Dfs(i + 1, diff, s, isLimit && (j == up));
                }
            }
            if (!isLimit)
            {
                dp[i, isDiff] = res;
            }
            return res;
        }
    }
}
