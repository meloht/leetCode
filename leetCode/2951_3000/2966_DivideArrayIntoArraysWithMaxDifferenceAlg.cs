using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2951_3000
{
    public class _2966_DivideArrayIntoArraysWithMaxDifferenceAlg
    {
        public int[][] DivideArray(int[] nums, int k)
        {
            Array.Sort(nums);
            int n = nums.Length / 3;
            int[][] ans = new int[n][];
            for (int i = 0, j = 0; i < nums.Length; i += 3)
            {
                if (Math.Abs(nums[i] - nums[i + 2]) <= k)
                {
                    ans[j++] = [nums[i], nums[i + 1], nums[i + 2]];

                }
                else
                {
                    return [];
                }
            }

            return ans;
        }
    }
}
