using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2701_2750
{
    public class _2717_SemiOrderedPermutationAlg
    {
        public int SemiOrderedPermutation(int[] nums)
        {
            int minIdx = 0;
            int maxIdx = nums.Length - 1;
            int min = int.MaxValue;
            int max = int.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < min)
                {
                    min = nums[i];
                    minIdx = i;
                }
                if (nums[i] > max)
                {
                    max = nums[i];
                    maxIdx = i;
                }
            }
            int ans = minIdx + nums.Length - 1 - maxIdx;
            if (maxIdx < minIdx)
            {
                ans--;
            }
            return ans;
        }
    }
}
