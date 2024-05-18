using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2601_2650
{
    public class _2644_FindTheMaximumDivisibilityScoreAlg
    {
        public int MaxDivScore(int[] nums, int[] divisors)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int max = 0;
            foreach (var item in divisors)
            {
                if (dict.ContainsKey(item))
                {
                    continue;
                }
                int count = 0;
                foreach (var number in nums)
                {
                    if (number % item == 0)
                    {
                        count++;
                    }
                }
                dict.Add(item, count);
                max = Math.Max(max, count);
            }

            int ans = dict.Where(p => p.Value == max).Min(p => p.Key);

            return ans;
        }
    }
}
