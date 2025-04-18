using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2351_2400
{
    public class _2364_CountNumberOfBadPairsAlg
    {
        public long CountBadPairs(int[] nums)
        {
            int n = nums.Length;
            long ans = (long)n * (n - 1) / 2;
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int val=nums[i]-i;
                if (dict.ContainsKey(val))
                {
                    ans -= dict[val];
                    dict[val]++;
                }
                else
                {
                    dict.Add(val, 1);
                }
            }

            return ans;
        }
    }
}
