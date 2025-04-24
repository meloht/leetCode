using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2751_2800
{
    public class _2799_CountCompleteSubarraysInAnArrayAlg
    {
        public int CountCompleteSubarrays(int[] nums)
        {
            int cnt = nums.Distinct().Count();
            int ans = 0;

            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0, j = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]]++;
                }
                else
                {
                    dict.Add(nums[i], 1);
                }
                while (dict.Count == cnt)
                {
                    ans += (nums.Length - i);
                    dict[nums[j]]--;
                    if (dict[nums[j]] <= 0)
                    {
                        dict.Remove(nums[j]);
                    }
                    j++;
                }
            }

            return ans;
        }
    }
}
