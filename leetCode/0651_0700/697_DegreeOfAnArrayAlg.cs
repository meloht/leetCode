using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0651_0700
{
    public class _697_DegreeOfAnArrayAlg
    {
        public int FindShortestSubArray(int[] nums)
        {
            Dictionary<int, int[]> dict = new Dictionary<int, int[]>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]][0]++;
                    dict[nums[i]][2] = i;
                }
                else
                {
                    dict.Add(nums[i], [1, i, i]);
                }
            }
            int deg = dict.Values.Max(p => p[0]);

            int ans = int.MaxValue;

            foreach (var item in dict)
            {
                if (item.Value[0] == deg)
                {
                    ans = Math.Min(ans, item.Value[2] - item.Value[1] + 1);
                }
            }

            return ans;
        }
    }
}
