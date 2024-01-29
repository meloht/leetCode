using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0401_0450
{
    public class _416_PartitionEqualSubsetSumAlg
    {

        public bool CanPartition(int[] nums)
        {
            if (nums.Length < 2)
                return false;

            int t = 0;
            int max = 0;
            foreach (var item in nums)
            {
                t += item;
                max = Math.Max(max, item);
            }

            if (t % 2 > 0)
                return false;
            int target = t / 2;

            if (max > target)
                return false;
            if (nums.Any(p => p == target))
                return true;

            bool[] dp = new bool[target + 1];
            dp[0] = true;
            if (nums[0] <= target)
            {
                dp[nums[0]] = true;
            }
            for (int i = 1; i < nums.Length; i++)
            {
                int num = nums[i];
                for (int j = target; j >= num; j--)
                {
                    dp[j] = dp[j] || dp[j - num];
                    if (dp[target])
                        return true;
                }
            }
            return dp[target];
        }




        public bool CanPartition2(int[] nums)
        {
            if (nums.Length < 2)
                return false;

            int t = 0;
            int max = 0;
            foreach (var item in nums)
            {
                t += item;
                max = Math.Max(max, item);
            }

            if (t % 2 > 0)
                return false;
            int target = t / 2;

            if (max > target)
                return false;

            bool[,] dp = new bool[nums.Length, target + 1];
            for (int i = 0; i < nums.Length; i++)
            {
                dp[i, 0] = true;
            }
            dp[0, nums[0]] = true;
            for (int i = 1; i < nums.Length; i++)
            {
                int num = nums[i];
                for (int j = 1; j <= target; j++)
                {
                    if (j >= num)
                    {
                        dp[i, j] = dp[i - 1, j] || dp[i - 1, j - num];
                    }
                    else
                    {
                        dp[i, j] = dp[i - 1, j];
                    }
                }
            }

            return dp[nums.Length - 1, target];
        }
    }
}
