using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0201_0250
{
    public class _233_NumberOfDigitOneAlg
    {
        int Mod = 1_000_000_007;
        int[,] dp;
        public int CountDigitOne(int n)
        {
            string ss = n.ToString();
            int nn = ss.Length;
            dp = new int[nn, nn];
            for (int i = 0; i < nn; i++)
            {
                for (int j = 0; j < nn; j++)
                {
                    dp[i, j] = -1;
                }
            }
            int ans = Dfs(0, 0, ss, true);
            return ans;
        }

        private int Dfs(int i, int num, string s, bool isLimit)
        {
            if (i == s.Length)
            {
                return num;
            }
            if (!isLimit && dp[i, num] >= 0)
            {
                return dp[i, num];
            }
            int up = isLimit ? s[i] - '0' : 9;
            int res = 0;
            for (int j = 0; j <= up; j++)
            {
                int cnt = num;
                if (j == 1)
                {
                    cnt++;
                }
                res = res + Dfs(i + 1, cnt, s, isLimit && (j == up));


            }
            if (!isLimit)
            {
                dp[i, num] = res;
            }
            return res;
        }

        public int CountDigitOne1(int n)
        {
            // mulk 表示 10^k
            // 在下面的代码中，可以发现 k 并没有被直接使用到（都是使用 10^k）
            // 但为了让代码看起来更加直观，这里保留了 k
            long mulk = 1;
            int ans = 0;
            for (int k = 0; n >= mulk; ++k)
            {
                ans += (int)(n / (mulk * 10) * mulk) + (int)Math.Min(Math.Max(n % (mulk * 10) - mulk + 1, 0), mulk);
                mulk *= 10;
            }
            return ans;
        }



    }
}
