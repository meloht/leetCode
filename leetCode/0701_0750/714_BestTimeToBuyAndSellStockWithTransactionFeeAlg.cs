using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0701_0750
{
    public class _714_BestTimeToBuyAndSellStockWithTransactionFeeAlg
    {
        public int MaxProfit1(int[] prices, int fee)
        {
            int n = prices.Length;
            int[,] dp = new int[n, 2];
            dp[0, 0] = 0;
            dp[0, 1] = -prices[0];
            for (int i = 1; i < n; ++i)
            {
                dp[i, 0] = Math.Max(dp[i - 1, 0], dp[i - 1, 1] + prices[i] - fee);
                dp[i, 1] = Math.Max(dp[i - 1, 1], dp[i - 1, 0] - prices[i]);
            }
            return dp[n - 1, 0];

        }

        public int MaxProfit(int[] prices, int fee)
        {
            int n = prices.Length;
            int sell0 = 0;
            int buy0 = -prices[0];

            for (int i = 1; i < n; ++i)
            {
                int sell = Math.Max(sell0, buy0 + prices[i] - fee);
                buy0 = Math.Max(buy0, sell0 - prices[i]);
                sell0 = sell;
            }
            return sell0;

        }
    }
}
