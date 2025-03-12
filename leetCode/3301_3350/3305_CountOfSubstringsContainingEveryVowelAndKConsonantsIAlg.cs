using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3301_3350
{
    public class _3305_CountOfSubstringsContainingEveryVowelAndKConsonantsIAlg
    {

        public long CountOfSubstrings1(string word, int k)
        {
            HashSet<char> vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
            long Count(int m)
            {
                int n = word.Length, consonants = 0;
                long res = 0;
                Dictionary<char, int> occur = new Dictionary<char, int>();
                for (int i = 0, j = 0; i < n; i++)
                {
                    while (j < n && (consonants < m || occur.Count < 5))
                    {
                        char ch = word[j];
                        if (vowels.Contains(ch))
                        {
                            if (!occur.ContainsKey(ch)) occur[ch] = 0;
                            occur[ch]++;
                        }
                        else
                        {
                            consonants++;
                        }
                        j++;
                    }
                    if (consonants >= m && occur.Count == 5)
                    {
                        res += n - j + 1;
                    }
                    char left = word[i];
                    if (vowels.Contains(left))
                    {
                        occur[left]--;
                        if (occur[left] == 0)
                        {
                            occur.Remove(left);
                        }
                    }
                    else
                    {
                        consonants--;
                    }
                }
                return res;
            }
            return Count(k) - Count(k + 1);
        }


        public long CountOfSubstrings(string word, int k)
        {
            var n1 = GetCount(word, k);
            var n2 = GetCount(word, k + 1);
            return n1 - n2;
        }
        private long GetCount(string word, int k)
        {
            long ans = 0;
            int[] map = new int[26];
            int n = word.Length;

            for (int i = 0, j = 0; i < n; i++)
            {
                while (j < n && !GetVowelCount(map, k))
                {
                    map[word[j] - 'a']++;
                    j++;
                }
                if (GetVowelCount(map, k))
                {
                    ans += n - j + 1;
                }

                map[word[i] - 'a']--;

            }
            return ans;
        }


        private bool GetVowelCount(int[] map, int k)
        {
            int cnt = 0;
            int num = 0;
            for (int i = 0; i < map.Length; i++)
            {
                if (i == 0 || i == 'e' - 'a' || i == 'i' - 'a' || i == 'o' - 'a' || i == 'u' - 'a')
                {
                    if (map[i] > 0)
                    {
                        num++;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    cnt += map[i];
                }
            }
            if (num == 5 && cnt >= k)
            {
                return true;
            }
            return false;
        }
    }
}
