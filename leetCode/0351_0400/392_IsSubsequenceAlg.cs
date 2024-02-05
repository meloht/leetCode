using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0351_0400
{
    public class _392_IsSubsequenceAlg
    {
        public bool IsSubsequence1(string s, string t)
        {
            int j = 0;
            int count = 0;
            foreach (char item in s)
            {
                while (j < t.Length)
                {
                    if (item == t[j])
                    {
                        count++;
                        j++;
                        break;
                    }
                    j++;
                }
            }
            return count == s.Length;
        }

        public bool IsSubsequence(string s, string t)
        {
            int n = s.Length;
            int m = t.Length;
            int[,] dp = new int[m + 1, 26];
            for (int i = 0; i < 26; i++)
            {
                dp[m, i] = m;
            }
            for (int i = m - 1; i >= 0; i--)
            {
                for (int j = 0; j < 26; j++)
                {
                    if (t[i] == j + 'a')
                    {
                        dp[i, j] = i;
                    }
                    else
                    {
                        dp[i, j] = dp[i + 1, j];
                    }
                }
            }
            int add = 0;
            for (int i = 0; i < n; i++)
            {
                if (dp[add, s[i] - 'a'] == m)
                {
                    return false;
                }
                add = dp[add, s[i] - 'a'] + 1;
            }
            return true;
        }
    }
}
