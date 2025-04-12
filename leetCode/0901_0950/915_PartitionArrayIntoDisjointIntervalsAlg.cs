using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0901_0950
{
    public class _915_PartitionArrayIntoDisjointIntervalsAlg
    {
        public int PartitionDisjoint(int[] nums)
        {
            int[] right = new int[nums.Length];
            right[nums.Length - 1] = nums[nums.Length - 1];
            for (int i = nums.Length - 2; i >= 0; i--)
            {
                right[i] = Math.Min(right[i + 1], nums[i]);
            }
            int max = nums[0];
            int ans = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                max = Math.Max(nums[i], max);
                if (max <= right[i + 1])
                {
                    return i + 1;
                }
            }

            return ans;
        }
    }
}
