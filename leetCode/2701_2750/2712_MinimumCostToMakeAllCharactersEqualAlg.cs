using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2701_2750
{
    public class _2712_MinimumCostToMakeAllCharactersEqualAlg
    {
        public long MinimumCost(string s)
        {
            long ans = 0;
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i - 1] != s[i])
                {
                    ans += Math.Min(i, s.Length - i);
                }
            }
            return ans;
        }
    }
}
