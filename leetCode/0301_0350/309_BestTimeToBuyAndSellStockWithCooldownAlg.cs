using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0301_0350
{
    public class _309_BestTimeToBuyAndSellStockWithCooldownAlg
    {
        public int MaxProfit1(int[] prices)
        {
            int n = prices.Length;
            int[,] f = new int[n + 2, 2];
            f[1, 1] = int.MinValue;
            for (int i = 0; i < n; ++i)
            {
                f[i + 2, 0] = Math.Max(f[i + 1, 0], f[i + 1, 1] + prices[i]);
                f[i + 2, 1] = Math.Max(f[i + 1, 1], f[i, 0] - prices[i]);
            }
            return f[n + 1, 0];
        }

        public int MaxProfit(int[] prices)
        {
            int pre0 = 0, f0 = 0, f1 = int.MinValue;
            foreach (int p in prices)
            {
                int newF0 = Math.Max(f0, f1 + p); // f[i+2][0]
                f1 = Math.Max(f1, pre0 - p); // f[i+2][1]
                pre0 = f0;
                f0 = newF0;
            }
            return f0;
        }

    }
}
