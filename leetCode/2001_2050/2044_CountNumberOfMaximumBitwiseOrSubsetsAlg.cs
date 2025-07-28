using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2001_2050
{
    public class _2044_CountNumberOfMaximumBitwiseOrSubsetsAlg
    {
        private int ans = 0;
        public int CountMaxOrSubsets(int[] nums)
        {
            int totalOr = 0;
            foreach (int num in nums) 
            {
                totalOr |= num;
            }
            dfs(0, 0, nums, totalOr);
            return ans;
        }
        private void dfs(int i, int subsetOr, int[] nums, int totalOr)
        {
            if (subsetOr == totalOr)
            {
                ans += 1 << (nums.Length - i);
                return;
            }
            if (i == nums.Length)
            {
                return;
            }
            dfs(i + 1, subsetOr, nums, totalOr); // 不选 nums[i]
            dfs(i + 1, subsetOr | nums[i], nums, totalOr); // 选 nums[i]
        }


    }
}
