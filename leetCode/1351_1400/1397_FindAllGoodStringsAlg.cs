using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1351_1400
{
    public class _1397_FindAllGoodStringsAlg
    {
        int Mod = 1_000_000_007;
        string Evil;
        string begin;
        string end;
        int[,] dp;
        int[] next;
        public int FindGoodStrings(int n, string s1, string s2, string evil)
        {
            begin = s1;
            end = s2;
            Evil = evil;
            int m = evil.Length;
            dp = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    dp[i, j] = -1;
                }
            }

            next = ComputeLPSArray(evil);
            int ans = Dfs(0, 0, true, true);
            return ans;
        }

        private int Dfs(int i, int subIndex, bool limitLow, bool limitHigh)
        {
            if (subIndex == Evil.Length)
            {
                return 0;
            }
            if (i == end.Length)
            {
                return 1;
            }
            if (!limitLow && !limitHigh && dp[i, subIndex] != -1)
            {
                return dp[i, subIndex];
            }

            int res = 0;

            char low = limitLow ? begin[i] : 'a';
            char high = limitHigh ? end[i] : 'z';


            for (char j = low; j <= high; j++)
            {
                int k = subIndex;

                while (k > 0 && Evil[k] != j)
                {
                    k = next[k - 1];
                }
                if (k == 0 && j != Evil[k])
                {
                    k = -1;
                }

                res = (res + Dfs(i + 1, k + 1, limitLow && j == low, limitHigh && j == high)) % Mod;
            }

            if (!limitHigh && !limitLow)
            {
                dp[i, subIndex] = res;
            }
            return res;
        }
        private int[] ComputeLPSArray(string pattern)
        {
            int m = pattern.Length;
            int[] lps = new int[m];
            int len = 0;
            int i = 1;

            while (i < m)
            {
                if (pattern[i] == pattern[len])
                {
                    len++;
                    lps[i] = len;
                    i++;
                }
                else
                {
                    if (len != 0)
                    {
                        len = lps[len - 1];
                    }
                    else
                    {
                        lps[i] = 0;
                        i++;
                    }
                }
            }

            return lps;
        }
    }
}
