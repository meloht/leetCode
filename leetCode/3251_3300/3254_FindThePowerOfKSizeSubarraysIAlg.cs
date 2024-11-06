using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3251_3300
{
    public class _3254_FindThePowerOfKSizeSubarraysIAlg
    {
        public int[] ResultsArray(int[] nums, int k)
        {
            int n = nums.Length;
            int[] ans = new int[n - k + 1];
            Array.Fill(ans, -1);
            int cnt = 0;
            for (int i = 0; i < n; i++)
            {
                cnt = (i == 0 || nums[i] - nums[i - 1] != 1) ? 1 : cnt + 1;
                if (cnt >= k)
                {
                    ans[i - k + 1] = nums[i];
                }
            }
            return ans;

        }
    }
}
