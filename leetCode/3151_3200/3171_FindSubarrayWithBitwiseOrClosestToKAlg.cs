using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3151_4000
{
    public class _3171_FindSubarrayWithBitwiseOrClosestToKAlg
    {
        public int MinimumDifference(int[] nums, int k)
        {
            int ans = int.MaxValue;
            for (int i = 0; i < nums.Length; i++)
            {
                int x = nums[i];
                ans = Math.Min(ans, Math.Abs(x - k));
                // 如果 x 是 nums[j] 的子集，就退出循环
                for (int j = i - 1; j >= 0 && (nums[j] | x) != nums[j]; j--)
                {
                    nums[j] |= x;
                    ans = Math.Min(ans, Math.Abs(nums[j] - k));
                }
            }
            return ans;

        }
    }
}
