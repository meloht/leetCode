using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._0151_0200
{
    public class _188_BestTimeToBuyAndSellStockIVAlg
    {
        public int MaxProfit2(int k, int[] prices)
        {
            int n = prices.Length;
            int[,,] f = new int[n + 1, k + 2, 2];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= k + 1; j++)
                {
                    for (int m = 0; m < 2; m++)
                    {
                        f[i, j, m] = int.MinValue / 2;
                    }
                }
            }
            for (int j = 1; j <= k + 1; j++)
            {
                f[0, j, 0] = 0;
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j <= k + 1; j++)
                {
                    f[i + 1, j, 0] = Math.Max(f[i, j, 0], f[i, j, 1] + prices[i]);
                    f[i + 1, j, 1] = Math.Max(f[i, j, 1], f[i, j - 1, 0] - prices[i]);
                }
            }
            return f[n, k + 1, 0];
        }


        public int MaxProfit3(int k, int[] prices)
        {
            int n = prices.Length;
            int[,] f = new int[k + 2, 2];
            for (int j = 1; j <= k + 1; j++)
            {
                f[j, 1] = int.MinValue / 2;
            }
            f[0, 0] = int.MinValue / 2;
            foreach (var item in prices)
            {
                for (int j = 1; j <= k + 1; j++)
                {
                    f[j, 0] = Math.Max(f[j, 0], f[j, 1] + item);
                    f[j, 1] = Math.Max(f[j, 1], f[j - 1, 0] - item);
                }
            }

            return f[k + 1, 0];
        }

        public int MaxProfit(int k, int[] prices)
        {
            if (prices.Length == 0)
                return 0;
            int n = prices.Length;
            int left = 1;
            int right = prices.Max();
            int ans = -1;
            while (left <= right)
            {
                int c = (left + right) / 2;
                int buyCount = 0, sellCount = 0;
                int buy = -prices[0], sell = 0;

                for (int i = 1; i < n; ++i)
                {
                    if (sell - prices[i] >= buy)
                    {
                        buy = sell - prices[i];
                        buyCount = sellCount;
                    }
                    if (buy + prices[i] - c >= sell)
                    {
                        sell = buy + prices[i] - c;
                        sellCount = buyCount + 1;
                    }
                }

                // 如果交易次数大于等于 k，那么可以更新答案
                // 这里即使交易次数严格大于 k，更新答案也没有关系，因为总能二分到等于 k 的
                if (sellCount >= k)
                {
                    // 别忘了加上 kc
                    ans = sell + k * c;
                    left = c + 1;
                }
                else
                {
                    right = c - 1;
                }


            }

            // 如果二分查找失败，说明交易次数的限制不是瓶颈
            // 可以看作交易次数无限，直接使用贪心方法得到答案
            if (ans == -1)
            {
                ans = 0;
                for (int i = 1; i < n; ++i)
                {
                    ans += Math.Max(prices[i] - prices[i - 1], 0);
                }
            }



            return ans;
        }


    }




}
