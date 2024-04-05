using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0601_0650
{
    public class _647_PalindromicSubstringsAlg
    {
        public int CountSubstrings1(string s)
        {
            int len = s.Length;
            if (len < 2)
            {
                return 1;
            }
            int ans = 0;
            bool[,] dp = new bool[len, len];
            for (int i = 0; i < len; i++)
            {
                dp[i, i] = true;
                ans++;
            }

            for (int L = 2; L <= len; L++)
            {
                for (int i = 0; i < len; i++)
                {
                    int j = L + i - 1;
                    if (j >= len)
                        break;

                    if (s[i] != s[j])
                    {
                        dp[i, j] = false;
                    }
                    else
                    {
                        if (j - i < 3)
                        {
                            dp[i, j] = true;
                            ans++;
                        }
                        else
                        {
                            dp[i, j] = dp[i + 1, j - 1];
                            if (dp[i, j])
                            {
                                ans++;
                            }
                        }
                    }
                }
            }

            return ans;
        }

        public int CountSubstrings(string s)
        {
            int n = s.Length, ans = 0;
            int len = 2 * n - 1;
            for (int i = 0; i < len; ++i)
            {
                int l = i / 2, r = i / 2 + i % 2;
                while (l >= 0 && r < n && s[l] == s[r])
                {
                    --l;
                    ++r;
                    ++ans;
                }
            }
            return ans;
        }

    }
}
