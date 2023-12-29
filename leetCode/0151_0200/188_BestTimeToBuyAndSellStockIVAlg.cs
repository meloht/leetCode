using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0151_0200
{
    public class _188_BestTimeToBuyAndSellStockIVAlg
    {
        public int MaxProfit(int k, int[] prices)
        {
            int len = prices.Length;
            int[,] arr = new int[len, len];
            Dictionary<int, int> dictMax = new Dictionary<int, int>();
            for (int i = 0; i < len; i++)
            {
                int max = 0;
                int index = 0;
                for (int j = 1; j < len; j++)
                {
                    int nn = prices[j] - prices[i];
                    if (nn > 0)
                    {
                        max = nn;
                        index = j;
                        arr[i, j] = nn;
                    }
                }
                if (index > i)
                {
                    dictMax.Add(i, max);
                }
                arr[i, index] = max;

            }
            return 0;
        }


    }
}
