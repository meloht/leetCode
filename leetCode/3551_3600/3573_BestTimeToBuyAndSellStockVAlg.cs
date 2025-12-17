using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3551_3600
{
    public class _3573_BestTimeToBuyAndSellStockVAlg
    {
        public long MaximumProfit(int[] prices, int k)
        {
            long[][] f = new long[k + 2][];
            for (int i = 0; i < k + 2; i++)
            {
                f[i] = new long[3];
            }
            for (int j = 1; j <= k + 1; j++)
            {
                f[j][1] = long.MinValue / 2; // 防止溢出
            }
            f[0][0] = long.MinValue / 2;
            foreach (int p in prices)
            {
                for (int j = k + 1; j > 0; j--)
                {
                    f[j][0] = Math.Max(f[j][0], Math.Max(f[j][1] + p, f[j][2] - p));
                    f[j][1] = Math.Max(f[j][1], f[j - 1][0] - p);
                    f[j][2] = Math.Max(f[j][2], f[j - 1][0] + p);
                }
            }
            return f[k + 1][0];

        }
    }
}
