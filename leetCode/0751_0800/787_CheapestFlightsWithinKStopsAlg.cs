using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0751_0800
{
    public class _787_CheapestFlightsWithinKStopsAlg
    {
        public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k)
        {
            int[][] dp = new int[n][];
            List<int[]>[] vist = new List<int[]>[n];
            for (int i = 0; i < n; i++)
            {
                dp[i] = new int[k + 2];
                vist[i] = new List<int[]>();
            }

            foreach (var item in flights)
            {
                vist[item[0]].Add(item);
            }


            return Dfs(vist, src, dst, k + 1, dp);
        }

        private int Dfs(List<int[]>[] flights, int src, int dst, int k, int[][] dp)
        {
            if (k < 0)
            {
                return -1;
            }
            if (src == dst)
            {
                return 0;
            }
            if (dp[src][k] != 0)
            {
                return dp[src][k];
            }
            int min = int.MaxValue;
            var list = flights[src];
            foreach (var flight in list)
            {
                int price = Dfs(flights, flight[1], dst, k - 1, dp);
                if (price != -1)
                {
                    min = Math.Min(min, price + flight[2]);
                }
            }
            dp[src][k] = min == int.MaxValue ? -1 : min;
            return dp[src][k];
        }
    }
}
