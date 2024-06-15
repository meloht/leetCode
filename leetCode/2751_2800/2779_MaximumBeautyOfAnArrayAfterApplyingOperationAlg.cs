using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2751_2800
{
    public class _2779_MaximumBeautyOfAnArrayAfterApplyingOperationAlg
    {
        public int MaximumBeauty(int[] nums, int k)
        {
            if (nums.Length == 1)
                return 1;
            Array.Sort(nums);
            int ans = 0;
            int k2 = k * 2;

            for (int i = 0, j = 1; i < nums.Length && j < nums.Length;)
            {
                while (j < nums.Length && nums[j] - nums[i] <= k2)
                {
                    ans = Math.Max(ans, j - i + 1);
                    j++;

                }
                i++;

            }
            return ans;
        }

        public int MaximumBeauty1(int[] nums, int k)
        {
            int res = 0, n = nums.Length;
            Array.Sort(nums);
            for (int i = 0, j = 0; i < n; i++)
            {
                while (nums[i] - 2 * k > nums[j])
                {
                    j++;
                }
                res = Math.Max(res, i - j + 1);
            }
            return res;
        }


    }
}
