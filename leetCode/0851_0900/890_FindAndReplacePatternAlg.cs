using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0851_0900
{
    public class _890_FindAndReplacePatternAlg
    {
        public IList<string> FindAndReplacePattern(string[] words, string pattern)
        {
            List<string> result = new List<string>();
            Dictionary<char, char> dict = new Dictionary<char, char>();
            int cnt = pattern.ToCharArray().Distinct().Count();
            foreach (var item in words)
            {
                dict.Clear();
                bool bl = true;
                for (int i = 0; i < pattern.Length; i++)
                {
                    if (dict.ContainsKey(item[i]))
                    {
                        if (dict[item[i]] != pattern[i])
                        {
                            bl = false;
                            break;
                        }

                    }
                    else
                    {
                        dict.Add(item[i], pattern[i]);
                    }
                }

                if (bl && dict.Count == cnt)
                {
                    result.Add(item);
                }
            }

            return result;
        }

        public IList<string> FindAndReplacePattern1(string[] words, string pattern)
        {
            List<string> ans = new List<string>();
            bool Match(string s, string t)
            {
                int[] m1 = new int[26];
                int[] m2 = new int[26];
                for (int i = 0; i < s.Length; ++i)
                {
                    if (m1[s[i] - 'a'] != m2[t[i] - 'a']) return false;
                    m1[s[i] - 'a'] = i + 1;
                    m2[t[i] - 'a'] = i + 1;
                }
                return true;
            }
            foreach (var word in words)
            {
                if (Match(word, pattern)) ans.Add(word);
            }
            return ans;
        }
    }
}
