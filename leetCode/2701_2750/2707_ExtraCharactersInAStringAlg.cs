using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2701_2750
{
    public class _2707_ExtraCharactersInAStringAlg
    {
        int min = int.MaxValue;
        HashSet<int> dict = new HashSet<int>();
        public int MinExtraChar1(string s, string[] dictionary)
        {
            HashSet<string> keys = new HashSet<string>(dictionary);

            Dfs(s.Length, s, 0, keys);

            return min;
        }

        private void Dfs(int len, string word, int index, HashSet<string> keys)
        {
            int hashcode = HashCode.Combine(len, index);
            if (dict.Contains(hashcode))
            {
                return;
            }
            else
            {
                dict.Add(hashcode);
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

        public int MinExtraChar2(string s, string[] dictionary)
        {
            int n = s.Length;

            int[] dp = new int[n + 1];
            Array.Fill(dp, int.MaxValue);
            HashSet<string> dict = new HashSet<string>(dictionary);
            dp[0] = 0;
            for (int i = 1; i <= n; i++)
            {
                dp[i] = dp[i - 1] + 1;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (dict.Contains(s.Substring(j, i - j)))
                    {
                        dp[i] = Math.Min(dp[i], dp[j]);
                    }
                }
            }
            return dp[n];
        }

        public int MinExtraChar(string s, string[] dictionary)
        {
            int n = s.Length;

            int[] dp = new int[n + 1];
            Array.Fill(dp, int.MaxValue);

            dp[0] = 0;
            WordDictionary dict = new WordDictionary();
            foreach (var item in dictionary)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = item.Length - 1; i >= 0; i--)
                {
                    sb.Append(item[i]);
                }
                dict.Insert(sb.ToString());
            }
            for (int i = 1; i <= n; i++)
            {
                dp[i] = dp[i - 1] + 1;
                WordDictionary node = dict;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (node != null)
                    {
                        node = node[s[j]];
                        if (node != null && node.IsEnd)
                        {
                            dp[i] = Math.Min(dp[i], dp[j]);
                        }
                    }

                }
            }
            return dp[n];
        }

        private class WordDictionary
        {
            public WordDictionary[] next = new WordDictionary[26];
            public bool IsEnd = false;
            public WordDictionary this[char c]
            {
                get
                {
                    return next[c - 'a'];
                }
                set
                {
                    next[c - 'a'] = value;
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
                    node = node[c];
                }
                node.IsEnd = true;
            }
        }
    }
}
