using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3651_3700
{
    public class _3652_BestTimeToBuyAndSellStockUsingStrategyAlg
    {
        public long MaxProfit(int[] prices, int[] strategy, int k)
        {
            int n = prices.Length;
            long[] sum = new long[n + 1];
            long[] sumSell = new long[n + 1];

            for (int i = 0; i < n; i++)
            {
                sum[i + 1] = sum[i] + prices[i] * strategy[i];
                sumSell[i + 1] = sumSell[i] + prices[i];
            }
            long ans = sum[n];

            for (int i = k; i <= n; i++)
            {
                long res = sum[i - k] + sum[n] - sum[i] + sumSell[i] - sumSell[i - k / 2];
                ans = Math.Max(ans, res);
            }

            return ans;
        }
    }
}
