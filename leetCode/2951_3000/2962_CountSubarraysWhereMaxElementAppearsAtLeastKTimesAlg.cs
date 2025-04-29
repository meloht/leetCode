using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2951_3000
{
    public class _2962_CountSubarraysWhereMaxElementAppearsAtLeastKTimesAlg
    {
        public long CountSubarrays(int[] nums, int k)
        {
            int cnt = 0;
            int max = 0;
            foreach (var item in nums)
            {
                if (item > max)
                {
                    max = item;
                    cnt = 1;
                }
                else if (max == item)
                {
                    cnt++;
                }
            }

            if (cnt < k)
                return 0;
            cnt = 0;

            long ans = 0;
            for (int i = 0, j = 0; i < nums.Length; i++)
            {
                if (nums[i] == max)
                {
                    cnt++;
                }
                if (cnt >= k)
                {
                    while (cnt >= k && j <= i)
                    {
                        ans += nums.Length - i;
                        if (nums[j] == max)
                        {
                           cnt--;
                        }
                        j++;
                    }
                }
            }

            return ans;
        }
    }
}
