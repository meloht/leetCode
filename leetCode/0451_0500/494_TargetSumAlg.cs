using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0451_0500
{
    public class _494_TargetSumAlg
    {
        public int FindTargetSumWays(int[] nums, int target)
        {
            target += nums.Sum();
            if (target < 0 || target % 2 > 0)
                return 0;

            target /= 2;
            int n = nums.Length;
            int[,] dp = new int[n + 1, target + 1];
            dp[0, 0] = 1;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= target; j++)
                {
                    if (j < nums[i])
                    {
                        dp[i + 1, j] = dp[i, j];
                    }
                    else
                    {
                        dp[i + 1, j] = dp[i, j] + dp[i, j - nums[i]];
                    }
                }
            }

            return dp[n, target];
        }
    }
}
