using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0351_0400
{
    public class _395_LongestSubstringWithAtLeastKRepeatingCharactersAlg
    {
        public int LongestSubstring(string s, int k)
        {
            int[] charNum = new int[26];
            foreach (char item in s)
            {
                int ch = item - 'a';
                charNum[ch]++;
            }
            List<int> ls = new List<int>();
            for (int i = 0; i < s.Length; i++)
            {
                int ch = s[i] - 'a';
                if (charNum[ch] < k)
                {
                    ls.Add(i);
                }
            }
            if (ls.Count == 0)
            {
                return s.Length;
            }
            if (ls.Count == s.Length)
            {
                return 0;
            }
            int max = 0;
            for (int i = 0; i < ls.Count; i++)
            {
                if (i == 0)
                {
                    string ss = s.Substring(0, ls[i]);
                    if (ss.Length >= k)
                    {
                        int len = LongestSubstring(ss, k);
                        max = Math.Max(max, len);
                    }
                  
                }
                else
                {
                    int begin = ls[i - 1];
                    int end = ls[i];
                    if (end - begin - 1 > 0) 
                    {
                        string ss = s.Substring(begin + 1, end - begin - 1);
                        int len = LongestSubstring(ss, k);
                        max = Math.Max(max, len);
                    }
                }

                if (i == ls.Count - 1)
                {
                    string ss = s.Substring(ls[i] + 1);
                    if (ss.Length >= k)
                    {
                        int len = LongestSubstring(ss, k);
                        max = Math.Max(max, len);
                    }
                }
            }

            return max;
        }

    }
}
