using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2601_2650
{
    public class _2645_MinimumAdditionsToMakeValidStringAlg
    {
        public int AddMinimum(string word)
        {
            if (word.Length == 1)
                return 2;

            int[] dp = new int[word.Length + 1];
            dp[1] = 2;
            string a = word.Substring(0, 2);
            if (a == "ab" || a == "bc" || a == "ac")
            {
                dp[2] = 1;
            }
            else
            {
                dp[2] = 4;
            }

            for (int i = 3; i <= word.Length; i++)
            {
                string s = word.Substring(i - 3, 3);
                if (s == "abc")
                {
                    dp[i] = dp[i - 3];
                }
                else if (s.EndsWith("ab") || s.EndsWith("ac") || s.EndsWith("bc"))
                {
                    dp[i] = dp[i - 2] + 1;
                }
                else
                {
                    dp[i] = dp[i - 1] + 2;
                }

            }

            return dp[word.Length];

        }
    }
}
