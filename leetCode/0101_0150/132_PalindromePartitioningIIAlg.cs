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
            int[] arrLen = new int[s.Length];
            Array.Fill(arrLen, 1);
            for (int i = s.Length - 1; i >= 0; --i)
            {
                for (int j = i + 1; j < s.Length; ++j)
                {
                    dp[i][j] = (s[i] == s[j]) && dp[i + 1][j - 1];

                    if (dp[i][j])
                    {
                        int n = j - i + 1;
                        arrLen[i] = Math.Max(n, arrLen[i]);
                    }

                }


            }

            int[] res = new int[s.Length];
            Array.Fill(res, int.MaxValue);

            int nn = arrLen[0];
            int preIndex = nn - 1;

            for (int i = 0; i < nn; i++)
            {
                res[i] = 1;
            }

            for (int i = 1; i < s.Length; i++)
            {
                nn = arrLen[i];
                int len = nn + i - 1;
                if (i == 42)
                {

                }
                for (int j = i; j <= len; j++)
                {
                    if (preIndex >= i)
                    {
                        res[j] = Math.Min(res[j], 1 + res[i - 1]);
                    }
                    else
                    {
                        res[j] = 1 + res[i - 1];
                    }

                }
                preIndex = Math.Max(len, preIndex); ;


            }

            if (res[s.Length - 1] > 0)
            {
                return res[s.Length - 1] - 1;
            }
            return 0;
        }
    }
}
