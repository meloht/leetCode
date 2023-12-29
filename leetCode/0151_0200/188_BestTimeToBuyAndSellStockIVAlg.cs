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


        public int MaxProfit(int k, int[] prices)
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



    }




}
