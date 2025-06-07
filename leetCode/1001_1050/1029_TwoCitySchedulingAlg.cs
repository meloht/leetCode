using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1001_1050
{
    public class _1029_TwoCitySchedulingAlg
    {
        public int TwoCitySchedCost(int[][] costs)
        {

            Array.Sort(costs, (x, y) => x[0] - y[0] - (x[1] - y[1]));

            int ans = 0;
            int n = costs.Length / 2;
            for (int i = 0, j = n; i < n ;i++,j++)
            {
                ans += costs[i][0];
                ans += costs[j][1];
            }

            return ans;
        }
    }
}
