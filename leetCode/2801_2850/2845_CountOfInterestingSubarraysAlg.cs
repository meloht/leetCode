using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2801_2850
{
    public class _2845_CountOfInterestingSubarraysAlg
    {
        public long CountInterestingSubarrays1(IList<int> nums, int modulo, int k)
        {
            int n = nums.Count;
            int[] sum = new int[n + 1];
            for (int i = 0; i < n; i++)
            {
                sum[i + 1] = sum[i] + (nums[i] % modulo == k ? 1 : 0);
            }

            int[] cnt = new int[Math.Min(n + 1, modulo)];
            long ans = 0;
            foreach (int s in sum)
            {
                if (s >= k)
                {
                    ans += cnt[(s - k) % modulo];
                }
                cnt[s % modulo]++;
            }
            return ans;


        }

        public long CountInterestingSubarrays(IList<int> nums, int modulo, int k)
        {
            int n = nums.Count;

            int[] cnt = new int[Math.Min(n + 1, modulo)];
            cnt[0] = 1;
            long ans = 0;
            int sum = 0;
            foreach (int s in nums)
            {
                if (s % modulo == k)
                {
                    sum++;
                }

                if (sum >= k)
                {
                    ans += cnt[(sum - k) % modulo];
                }
                cnt[sum % modulo]++;
            }
            return ans;


        }
    }
}
