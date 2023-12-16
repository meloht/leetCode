using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0101_0150
{
    public class _121_BestTimeToBuyAndSellStockAlg
    {
        public int MaxProfit(int[] prices)
        {
            int n = prices[0];
            int max = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (n > prices[i])
                {
                    n = prices[i];
                }
                else if (n < prices[i])
                {
                    max = Math.Max(max, prices[i] - n);
                }
            }

            return max;
        }
    }
}
