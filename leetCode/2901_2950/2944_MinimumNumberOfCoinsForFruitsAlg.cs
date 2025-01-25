using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2901_2950
{
    public class _2944_MinimumNumberOfCoinsForFruitsAlg
    {
        public int MinimumCoins1(int[] prices)
        {
            int n = prices.Length;
            int[] dp = new int[(n + 1) / 2];

            return Dfs(1, prices, dp);
        }
        private int Dfs(int i, int[] prices, int[] dp)
        {
            if (i * 2 >= prices.Length)
                return prices[i - 1];

            if (dp[i] != 0)
                return dp[i];

            int res = int.MaxValue;
            for (int j = i + 1; j <= i * 2 + 1; j++)
            {
                res = Math.Min(res, Dfs(j, prices, dp));
            }
            dp[i] = res + prices[i - 1];
            return dp[i];
        }

        public int MinimumCoins2(int[] prices)
        {
            int n = prices.Length;
            for (int i = (n + 1) / 2 - 1; i > 0; i--)
            {
                int mn = int.MaxValue;
                for (int j = i; j <= i * 2; j++)
                {
                    mn = Math.Min(mn, prices[j]);
                }
                prices[i - 1] += mn;
            }
            return prices[0];
        }

        public int MinimumCoins(int[] prices)
        {
            int n = prices.Length;
            LinkedList<int[]> q = new LinkedList<int[]>();
            q.AddLast([n + 1, 0]); // 哨兵
            for (int i = n; i > 0; i--)
            {
                while (q.Count > 0 && q.Last.Value[0] > i * 2 + 1)
                { // 右边离开窗口
                    q.RemoveLast();
                }
                int f = prices[i - 1] + q.Last.Value[1];
                while (q.Count > 0 && f <= q.First.Value[1])
                {
                    q.RemoveFirst();
                }
                q.AddFirst([i, f]); // 左边进入窗口
            }
            return q.First.Value[1];
        }

    }
}
