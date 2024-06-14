using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2751_2800
{
    public class _2786_VisitArrayPositionsToMaximizeScoreAlg
    {
        public long MaxScore(int[] nums, int x)
        {
            long res = nums[0];
            long[] dp = [int.MinValue, int.MinValue];
            dp[nums[0] % 2] = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                int p = nums[i] % 2;
                long curr = Math.Max(dp[p] + nums[i], dp[1 - p] - x + nums[i]);
                res = Math.Max(res, curr);
                dp[p] = Math.Max(dp[p], curr);
            }
            return res;
        }
    }
}
