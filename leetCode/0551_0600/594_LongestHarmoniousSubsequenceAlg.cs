using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0551_0600
{
    public class _594_LongestHarmoniousSubsequenceAlg
    {
        public int FindLHS(int[] nums)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (var item in nums)
            {
                if (dict.ContainsKey(item))
                {
                    dict[item]++;
                }
                else
                {
                    dict.Add(item, 1);
                }
            }
            int ans = 0;
            foreach (var item in dict)
            {
                int num = item.Value;
                if (dict.ContainsKey(item.Key + 1))
                {
                    num += dict[item.Key + 1];
                    ans = Math.Max(ans, num);
                }
            }
            return ans;
        }
    }
}
