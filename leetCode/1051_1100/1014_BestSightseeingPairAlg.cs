using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1051_1100
{
    public class _1014_BestSightseeingPairAlg
    {
        public int MaxScoreSightseeingPair(int[] values)
        {
            int ans = 0, mx = values[0] + 0;
            for (int j = 1; j < values.Length; ++j)
            {
                ans = Math.Max(ans, mx + values[j] - j);
                // 边遍历边维护
                mx = Math.Max(mx, values[j] + j);
            }
            return ans;

        }
    }
}
