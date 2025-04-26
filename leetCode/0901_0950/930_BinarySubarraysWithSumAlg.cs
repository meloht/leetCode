using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0901_0950
{
    public class _930_BinarySubarraysWithSumAlg
    {
        public int NumSubarraysWithSum1(int[] nums, int goal)
        {
            int left1 = 0;
            int sum1 = 0;
            int left2 = 0;
            int sum2 = 0;
            int ans = 0;

            for (int right = 0; right < nums.Length; right++)
            {
                sum1 += nums[right];
                sum2 += nums[right];

                while (sum1 > goal && left1 <= right)
                {
                    sum1 -= nums[left1];
                    left1++;
                }

                while (sum2 >= goal && left2 <= right)
                {
                    sum2 -= nums[left2];
                    left2++;
                }
                ans += left1 - left2;
            }
            return ans;
        }

        public int NumSubarraysWithSum(int[] nums, int goal)
        {
            int sum = 0;
            Dictionary<int, int> cnt = new Dictionary<int, int>();
            int ret = 0;
            foreach (int num in nums)
            {
                if (cnt.ContainsKey(sum))
                {
                    cnt[sum]++;
                }
                else
                {
                    cnt.Add(sum, 1);
                }
                sum += num;
                int val = 0;
                cnt.TryGetValue(sum - goal, out val);
                ret += val;
            }
            return ret;
        }

    }
}
