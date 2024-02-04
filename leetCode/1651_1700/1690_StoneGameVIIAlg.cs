using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1651_1700
{
    public class _1690_StoneGameVIIAlg
    {
        public int StoneGameVII(int[] stones)
        {
            int n = stones.Length;
            int[] prefix = new int[n + 1];
            for (int i = 0; i < n; i++)
            {
                prefix[i + 1] = prefix[i + 1] + prefix[i] + stones[i];
            }
            int[,] dp = new int[n, n];
            int ans = Dfs(prefix, 0, n - 1, dp);
            return ans;
        }

        private int Dfs(int[] prefix, int i, int j, int[,] dp)
        {
            if (i == j)
                return 0;
            if (dp[i, j] > 0)
                return dp[i, j];
            int res1 = prefix[j + 1] - prefix[i + 1] - Dfs(prefix, i + 1, j, dp);
            int res2 = prefix[j] - prefix[i] - Dfs(prefix, i, j - 1, dp);
            dp[i, j] = Math.Max(res1, res2);
            return dp[i, j];

        }
    }
}
