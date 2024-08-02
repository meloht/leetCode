using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0451_0500
{
    public class _467_UniqueSubstringsInWraparoundStringAlg
    {
        public int FindSubstringInWraproundString(string s)
        {
            int[] dp = new int[26];
            int k = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (i > 0 && (s[i] - s[i - 1] + 26) % 26 == 1)
                {
                    k++;
                }
                else
                {
                    k = 1;
                }
                dp[s[i] - 'a'] = Math.Max(k, dp[s[i] - 'a']);
            }
            return dp.Sum();
        }
    }
}
