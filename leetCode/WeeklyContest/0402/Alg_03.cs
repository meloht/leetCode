using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode.WeeklyContest._0402
{
    public class Alg_03
    {
        public long MaximumTotalDamage(int[] nums)
        {
            var dict = nums.GroupBy(p => p).ToDictionary(p => p.Key, p => p.Count());
            var list = dict.Keys.ToList();
            list.Sort();

            long[] dp = new long[list.Count + 1];
            int j = 0;
            for (int i = 0; i < list.Count; i++)
            {
                int x = list[i];
                while (list[j] < x - 2)
                {
                    j++;
                }
                dp[i + 1] = Math.Max(dp[i], dp[j] + (long)x * dict[x]);
            }

            return dp[list.Count];
        }





    }
}
