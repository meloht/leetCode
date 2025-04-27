using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3351_3400
{
    public class _3392_CountSubarraysOfLengthThreeWithAConditionAlg
    {
        public int CountSubarrays(int[] nums)
        {
            int ans = 0;
            for (int i = 1; i < nums.Length - 1; i++)
            {
                if ((nums[i - 1] + nums[i + 1]) * 2 == nums[i])
                {
                    ans++;
                }
            }

            return ans;
        }
    }
}
