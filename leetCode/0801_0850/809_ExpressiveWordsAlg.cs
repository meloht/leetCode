using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0801_0850
{
    public class _809_ExpressiveWordsAlg
    {
        public int ExpressiveWords(string S, string[] words)
        {
            int res = 0;
            foreach (var word in words)
            {
                if (IsExpressive(S, word))
                {
                    res++;
                }
            }
            return res;
        }
        private bool IsExpressive(string S, string word)
        {
            int i = 0;
            int j = 0;
            while (i < S.Length && j < word.Length)
            {
                if (S[i] == word[j])
                {
                    int len1 = GetLen(S, i);
                    int len2 = GetLen(word, j);
                    if (len1 < 3 && len1 != len2 || len1 >= 3 && len1 < len2)
                    {
                        return false;
                    }
                    i += len1;
                    j += len2;
                }
                else
                {
                    return false;
                }
            }
            return i == S.Length && j == word.Length;
        }
        private int GetLen(string s, int i)
        {
            int j = i;
            while (j < s.Length && s[j] == s[i])
            {
                j++;
            }
            return j - i;
        }
    }
}
