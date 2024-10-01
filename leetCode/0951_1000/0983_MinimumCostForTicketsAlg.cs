using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace leetCode._0951_1000
{
    public class _0983_MinimumCostForTicketsAlg
    {
        public int MincostTickets(int[] days, int[] costs)
        {
            int lastDay = days[days.Length - 1];
            bool[] isTraval = new bool[lastDay + 1];
            foreach (int d in days)
            {
                isTraval[d] = true;
            }
            int[] memo = new int[lastDay + 1];
            return Dfs(lastDay,isTraval,costs,memo);
        }
        private int Dfs(int i, bool[] isTravel, int[] costs, int[] memo)
        {
            if (i <= 0)
            {
                return 0;
            }
            if (memo[i] > 0)
            { // 之前计算过
                return memo[i];
            }
            if (!isTravel[i])
            {
                return memo[i] = Dfs(i - 1, isTravel, costs, memo);
            }
            return memo[i] = Math.Min(Dfs(i - 1, isTravel, costs, memo) + costs[0],
                             Math.Min(Dfs(i - 7, isTravel, costs, memo) + costs[1],
                                      Dfs(i - 30, isTravel, costs, memo) + costs[2]));
        }

        public int MincostTickets1(int[] days, int[] costs)
        {
            int lastDay = days[days.Length - 1];
            bool[] isTravel = new bool[lastDay + 1];
            foreach (int d in days)
            {
                isTravel[d] = true;
            }
            int[] f = new int[lastDay + 1];
            for (int i = 1; i <= lastDay; i++)
            {
                if (!isTravel[i])
                {
                    f[i] = f[i - 1];
                }
                else
                {
                    f[i] = Math.Min(f[i - 1] + costs[0],
                           Math.Min(f[Math.Max(i - 7, 0)] + costs[1],
                                    f[Math.Max(i - 30, 0)] + costs[2]));
                }
            }
            return f[lastDay];
        }



    }
}
