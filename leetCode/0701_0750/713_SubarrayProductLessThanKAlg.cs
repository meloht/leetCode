using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0701_0750
{
    public class _713_SubarrayProductLessThanKAlg
    {
        public int NumSubarrayProductLessThanK(int[] nums, int k)
        {
            if (k <= 1)
                return 0;
            int ans = 0;
            int res = 1;
            int left = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                res *= nums[i];
                while (res >= k)
                {
                    res /= nums[left];
                    left++;
                }
                ans += i - left + 1;
            }
            return ans;
        }
    }
}
