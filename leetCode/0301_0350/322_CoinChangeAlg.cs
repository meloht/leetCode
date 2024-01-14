using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0301_0350
{
    public class _322_CoinChangeAlg
    {
        public int CoinChange(int[] coins, int amount)
        {
            int n = coins.Length;
            int nn = n + 1;
            int mm = amount + 1;
            int[,] dp = new int[nn, mm];
            for (int i = 0; i < mm; i++)
            {
                dp[0, i] = int.MaxValue / 2;
            }
            dp[0, 0] = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= amount; j++)
                {
                    if (j < coins[i])
                    {
                        dp[i + 1, j] = dp[i, j];
                    }
                    else
                    {
                        dp[i + 1, j] = Math.Min(dp[i, j], dp[i + 1, j - coins[i]] + 1);
                    }
                }
            }
            int ans = dp[n, amount];
            if (ans < int.MaxValue/2)
                return ans;
            return -1;
        }
    }
}
