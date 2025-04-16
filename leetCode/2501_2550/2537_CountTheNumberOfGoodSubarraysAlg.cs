using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2501_2550
{
    public class _2537_CountTheNumberOfGoodSubarraysAlg
    {
        public long CountGood(int[] nums, int k)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            long ans = 0;
            long cnt = 0;
            for (int i = 0, j = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    cnt += dict[nums[i]];
                    dict[nums[i]]++;
                }
                else
                {
                    dict.Add(nums[i], 1);
                }
                if (cnt >= k)
                {
                    ans += (nums.Length - i);
                }

                while (cnt >= k)
                {
                    if (dict[nums[j]] > 1)
                    {
                        cnt = cnt - (dict[nums[j]] - 1);
                    }
                    dict[nums[j]]--;
                    if (dict[nums[j]] == 0)
                    {
                        dict.Remove(nums[j]);
                    }
                    j++;
                    if (cnt >= k)
                    {
                        ans += (nums.Length - i);
                    }
                }

            }

            return ans;
        }
    }
}
