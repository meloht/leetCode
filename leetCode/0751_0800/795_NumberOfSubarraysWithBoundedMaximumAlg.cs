using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0751_0800
{
    public class _795_NumberOfSubarraysWithBoundedMaximumAlg
    {
        public int NumSubarrayBoundedMax(int[] nums, int left, int right)
        {
            int ans = 0;
            int n = nums.Length, i0 = -1, i1 = -1;
            for (int i = 0; i < n; ++i)
            {
                if (nums[i] > right)
                    i0 = i;
                if (nums[i] >= left) 
                    i1 = i;
                ans += i1 - i0;
            }
            return ans;

        }
    }
}
