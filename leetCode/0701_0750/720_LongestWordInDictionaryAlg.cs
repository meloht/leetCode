using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0701_0750
{
    public class _720_LongestWordInDictionaryAlg
    {
        public string LongestWord(string[] words)
        {
            HashSet<string> set = new HashSet<string>(words);

            Array.Sort(words, (x, y) =>
            {
                if (x.Length == y.Length)
                {
                    return x.CompareTo(y);
                }
                return y.Length - x.Length;
            });

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];

                string ans = null;
                var ss = word.AsSpan();
                for (int j = 0; j < word.Length; j++)
                {
                    string s = ss.Slice(0, j + 1).ToString();
                    if (!set.Contains(s))
                    {
                        ans = null;
                        break;
                    }
                    ans = s;
                }

                if (ans != null)
                    return ans;
            }
            return "";
        }
    }
}
