using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0151_0200
{
    public class _198_HouseRobberAlg
    {
        public int Rob(int[] nums)
        {

            if (nums.Length < 2)
            {
                return nums[0];
            }
            if (nums.Length == 2)
            {
                return Math.Max(nums[0], nums[1]);
            }
            int[,] dp = new int[nums.Length, 2];
            dp[0, 1] = nums[0];
            dp[1, 1] = nums[1];

            for (int i = 2; i < nums.Length; i++)
            {
                dp[i, 0] = Math.Max(dp[i - 2, 1], dp[i - 1, 1]);
                dp[i, 1] = Math.Max(dp[i - 2, 1] + nums[i], dp[i - 1, 0] + nums[i]);

            }

            return Math.Max(dp[nums.Length - 1, 0], dp[nums.Length - 1, 1]);
        }
    }
}
