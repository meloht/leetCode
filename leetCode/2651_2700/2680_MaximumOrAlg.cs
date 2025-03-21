using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2651_2700
{
    public class _2680_MaximumOrAlg
    {
        public long MaximumOr(int[] nums, int k)
        {
            int n = nums.Length;
            int[] suf = new int[n];

            for (int i = n - 2; i >= 0; i--)
            {
                suf[i] = suf[i + 1] | nums[i + 1];
            }

            long ans = 0;
            int pre = 0;
            for (int i = 0; i < n; i++)
            {
                ans = Math.Max(ans, pre | ((long)nums[i] << k) | suf[i]);
                pre |= nums[i];
            }

            return ans;
        }
    }
}
