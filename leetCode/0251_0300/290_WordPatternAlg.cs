using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0251_0300
{
    public class _290_WordPatternAlg
    {
        public bool WordPattern(string pattern, string s)
        {
            string[] words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (words.Length != pattern.Length)
                return false;

            string[] map = new string[26];

            Dictionary<string, char> dict = new Dictionary<string, char>();
            for (int i = 0; i < pattern.Length; i++)
            {
                int j = pattern[i] - 'a';
                if (!dict.ContainsKey(words[i]) && string.IsNullOrEmpty(map[j]))
                {
                    map[j] = words[i];
                    dict[words[i]] = pattern[i];
                }
                else
                {
                    if (map[j] != words[i])
                        return false;
                }

            }
            return true;
        }
    }
}
