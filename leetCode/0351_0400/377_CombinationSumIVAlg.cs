using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0351_0400
{
    public class _377_CombinationSumIVAlg
    {
        public int CombinationSum4(int[] nums, int target)
        {
            int[] dp = new int[target + 1];
            dp[0] = 1;
            for (int i = 0; i <= target; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i >= nums[j])
                    {
                        dp[i] += dp[i - nums[j]];
                    }
                   
                }
            }

            return dp[target];
        }

        public int CombinationSum41(int[] nums, int target)
        {
            int[] dp = new int[target + 1];
            Array.Fill(dp, -1);
            int ans = Dfs(target, nums, dp);
            return ans;
        }

        public int Dfs(int sum, int[] nums, int[] dp)
        {
            if (sum == 0)
                return 1;
            if (sum < 0)
                return 0;
            if (dp[sum] != -1)
                return dp[sum];

            int ans = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                ans += Dfs(sum - nums[i], nums, dp);
            }
            if (dp[sum] == -1)
            {
                dp[sum] = ans;
            }
            return ans;
        }

    }
}
