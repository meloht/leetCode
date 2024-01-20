using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0551_0600
{
    public class _600_NonNegativeIntegersWithoutConsecutiveOnesAlg
    {
        int[,] dp;
        public int FindIntegers(int n)
        {
            string ss = Convert.ToString(n, 2);
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
        private int Dfs(int i, int prev, string s, bool isLimit)
        {
            if (i == s.Length)
            {
                return 1;
            }
            if (!isLimit  && dp[i, prev] >= 0)
            {
                return dp[i, prev];
            }

            int res = 0;
          

            int up = isLimit ? s[i] - '0' : 1;

            for (int j = 0; j <= up; j++)
            {
                if (j > up || (j == 1 && prev == 1))
                    break;
                res += Dfs(i + 1, j, s, isLimit && j == up);
            }

            if (!isLimit)
            {
                dp[i, prev] = res;
            }
            return res;
        }


    }
}
