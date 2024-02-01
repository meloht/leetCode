using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2551_2600
{
    public class _2586_CountTheNumberOfVowelStringsInRangeAlg
    {
        public int VowelStrings(string[] words, int left, int right)
        {
            int ans = 0;
            for (int i = left; i < words.Length && i <= right; i++)
            {
                var word = words[i];
                if (IsVowel(word[0]) && IsVowel(word[word.Length - 1]))
                {
                    ans++;
                }
            }
            return ans;
        }
        private bool IsVowel(char ch)
        {
            switch (ch)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    return true;
                default:
                    return false;
            }

        }
    }
}
