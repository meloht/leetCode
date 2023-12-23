using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0101_0150
{
    public class _132_PalindromePartitioningIIAlg
    {
        public int MinCut(string s)
        {
            bool[][] dp = new bool[s.Length][];
            for (int i = 0; i < s.Length; i++)
            {
                dp[i] = new bool[s.Length];
                Array.Fill(dp[i], true);

            }

            for (int i = s.Length - 1; i >= 0; --i)
            {
                for (int j = i + 1; j < s.Length; ++j)
                {
                    dp[i][j] = (s[i] == s[j]) && dp[i + 1][j - 1];
                }
            }

            int[] res = new int[s.Length];
            Array.Fill(res, int.MaxValue);
            for (int i = 0; i < s.Length; i++)
            {
                if (dp[0][i])
                {
                    res[i] = 0;
                }
                else
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (dp[j + 1][i])
                        {
                            res[i] = Math.Min(res[i], res[j] + 1);
                        }
                    }
                }
            }


            return res[s.Length - 1];
        }

    }
}
