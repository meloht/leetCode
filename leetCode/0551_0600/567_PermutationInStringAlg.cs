using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
