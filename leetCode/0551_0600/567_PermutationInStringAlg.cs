using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._0551_0600
{
    public class _567_PermutationInStringAlg
    {
        public bool CheckInclusion(string s1, string s2)
        {
            int[] dict = new int[26];
            foreach (var item in s1)
            {
                dict[item - 'a']++;
            }
            int[] dict2 = new int[26];
            int j = 0;
            for (int i = 0; i < s2.Length; i++)
            {
                int idx = s2[i] - 'a';
                dict2[idx]++;
                if (i > s1.Length - 1)
                {
                    dict2[s2[j] - 'a']--;
                    j++;
                }
                if (i >= s1.Length - 1)
                {
                    if (dict2.SequenceEqual(dict))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool CheckInclusion1(string s1, string s2)
        {
            int n = s1.Length, m = s2.Length;
            if (n > m)
            {
                return false;
            }
            int[] cnt = new int[26];
            for (int i = 0; i < n; ++i)
            {
                --cnt[s1[i] - 'a'];
                ++cnt[s2[i] - 'a'];
            }
            int diff = 0;
            foreach (int c in cnt)
            {
                if (c != 0)
                {
                    ++diff;
                }
            }
            if (diff == 0)
            {
                return true;
            }
            for (int i = n; i < m; ++i)
            {
                int x = s2[i] - 'a', y = s2[i - n] - 'a';
                if (x == y)
                {
                    continue;
                }
                if (cnt[x] == 0)
                {
                    ++diff;
                }
                ++cnt[x];
                if (cnt[x] == 0)
                {
                    --diff;
                }
                if (cnt[y] == 0)
                {
                    ++diff;
                }
                --cnt[y];
                if (cnt[y] == 0)
                {
                    --diff;
                }
                if (diff == 0)
                {
                    return true;
                }
            }
            return false;
        }


    }
}
