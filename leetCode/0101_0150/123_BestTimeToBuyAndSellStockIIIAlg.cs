using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0101_0150
{
    public class _123_BestTimeToBuyAndSellStockIIIAlg
    {
        public int MaxProfit(int[] prices)
        {
            int[,] dp = new int[prices.Length, prices.Length];

            for (int i = 0; i < prices.Length; i++)
            {
                for (int j = i + 1; j < prices.Length; j++)
                {
                    dp[i, j] = Math.Max(prices[j] - prices[i], dp[i, j - 1]);
                    dp[0, j] = Math.Max(dp[i, j], dp[0, j]);
                }

            }
            int max = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                max = Math.Max(max, dp[0, i] + dp[i, prices.Length - 1]);
            }

            return max;
        }
    }
}
