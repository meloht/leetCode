using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0601_0650
{
    public class _628_MaximumProductOfThreeNumbersAlg
    {
        public int MaximumProduct(int[] nums)
        {
            Array.Sort(nums);
            int max = nums[nums.Length - 1] * nums[nums.Length - 2] * nums[nums.Length - 3];

            if (nums[0] < 0 && nums[1] < 0 && nums[0] * nums[1] * nums[nums.Length - 1] > max)
            {
                max = nums[0] * nums[1] * nums[nums.Length - 1];
            }
            return max;
        }
    }
}
