using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2551_2600
{
    public class _2588_CountTheNumberOfBeautifulSubarraysAlg
    {
        public long BeautifulSubarrays(int[] nums)
        {
            long ans = 0;
            int s = 0;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            dict.Add(0, 1);
            foreach (var x in nums)
            {
                s ^= x;
                int c = dict.GetValueOrDefault(s, 0);
                ans += c;
                if (dict.ContainsKey(s))
                {
                    dict[s] = c + 1;
                }
                else
                {
                    dict.Add(s, c + 1);
                }

            }
            return ans;
        }
    }
}
