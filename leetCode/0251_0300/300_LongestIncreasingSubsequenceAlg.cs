using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0251_0300
{
    public class _300_LongestIncreasingSubsequenceAlg
    {
        public int LengthOfLIS(int[] nums)
        {
            int n = nums.Length;
            int[] dp = new int[n];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (nums[j] < nums[i])
                    {
                        dp[i] = Math.Max(dp[i], dp[j]);
                    }
                }
                dp[i] = dp[i] + 1;


            }

            return dp.Max(); 
        }
    } 
}
