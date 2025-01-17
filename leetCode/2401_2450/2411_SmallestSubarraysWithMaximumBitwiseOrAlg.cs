using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2401_2450
{
    public class _2411_SmallestSubarraysWithMaximumBitwiseOrAlg
    {
        public int[] SmallestSubarrays(int[] nums)
        {

            int[] ans = new int[nums.Length];
           
            for (int i = 0; i < nums.Length; i++)
            {
                int x = nums[i];
                ans[i] = 1;
                for (int j = i - 1; j >= 0 && (nums[j] | x) != nums[j]; j--)
                {
                    nums[j] |= x;
                    ans[j] = i - j + 1;
                }

            }
            return ans;
        }
    }
}
