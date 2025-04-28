using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2301_2350
{
    public class _2302_CountSubarraysWithScoreLessThanKAlg
    {
        public long CountSubarrays(int[] nums, long k)
        {
            long sum = 0;
            long ans = 0;
            for (int i = 0, j = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                while (sum * (i - j + 1) >= k)
                {
                    sum -= nums[j];
                    j++;
                }
                ans += i - j + 1;
            }
            return ans;
        }
    }
}
