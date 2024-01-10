using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2701_2750
{
    public class _2707_ExtraCharactersInAStringAlg
    {
        int min = int.MaxValue;
        HashSet<string> dict = new HashSet<string>();
        public int MinExtraChar(string s, string[] dictionary)
        {
            HashSet<string> keys = new HashSet<string>(dictionary);


            Dfs(s.Length, s, 0, keys);

            return min;
        }

        private void Dfs(int len, string word, int index, HashSet<string> keys)
        {
            string key = $"{len},{index}";
            if (dict.Contains(key))
            {
                return;
            }
            else
            {
                dict.Add(key);
            }
            if (index >= word.Length)
            {
                min = Math.Min(min, len);
                return;
            }
            StringBuilder sb = new StringBuilder();
            for (int i = index; i < word.Length; i++)
            {
                sb.Append(word[i]);
                if (keys.Contains(sb.ToString()))
                {
                    int n = len - sb.Length;

                    Dfs(n, word, i + 1, keys);
                }
                else
                {
                    Dfs(len, word, i + 1, keys);
                }
            }
        }

        public int MinExtraChar1(string s, string[] dictionary)
        {
            WordDictionary dic = new WordDictionary();
            foreach (var word in dictionary)
            {
                dic.Insert(word);
            }
            return 0;
        }

        private class WordDictionary
        {
            public WordDictionary[] next = new WordDictionary[26];
            public string word;
            public bool hashNext = false;
            public WordDictionary this[char c]
            {
                get
                {
                    return next[c - 'a'];
                }
                set
                {
                    next[c - 'a'] = value;
                    hashNext = true;
                }
            }

            public void Insert(string word)
            {
                WordDictionary node = this;
                foreach (char c in word)
                {
                    if (node[c] == null)
                    {
                        node[c] = new WordDictionary();
                    }
                    node.word = word;
                }
            }
        }
    }
}
