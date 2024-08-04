using leetCode._0301_0350;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._0451_0500
{
    public class _472_ConcatenatedWordsAlg
    {
        Trie trie = null;
        HashSet<string> set = null;
        public IList<string> FindAllConcatenatedWordsInADict(string[] words)
        {
            trie = new Trie();

            set = new HashSet<string>(words);
            int min = int.MaxValue;
            foreach (var w in words)
            {
                trie.Insert(w);
                min = Math.Min(min, w.Length);
            }

            List<string> result = new List<string>();
            foreach (var w in words)
            {
                int[,] dp = new int[w.Length + 2, w.Length + 2];
                for (int i = min; i < w.Length; i++)
                {
                    string sub = w.Substring(0, i);
                    if (!set.Contains(sub))
                        continue;
                    if (Dfs(w, i, 1, dp))
                    {
                        result.Add(w);
                        break;
                    }
                }
            }

            return result;
        }


        private bool Dfs(string s, int idx, int len, int[,] dp)
        {
            if (len + idx > s.Length)
                return false;
            if (dp[idx, len] != 0)
                return dp[idx, len] == 1;
            string sub = s.Substring(idx, len);
            var node = trie.StartsWith(sub);

            if (node == null || node.Prefix == 0)
            {
                dp[idx, len] = 2;
                return false;
            }

            if (set.Contains(sub) && node.Count > 0)
            {
                if (len + idx == s.Length)
                    return true;
                bool bl = Dfs(s, idx + len, 1, dp);
                if (bl)
                {
                    dp[idx, len] = 1;
                    return true;
                }
                bl = Dfs(s, idx, len + 1, dp);
                dp[idx, len] = bl ? 1 : 2;
                return bl;
            }
            bool res = Dfs(s, idx, len + 1, dp);
            dp[idx, len] = res ? 1 : 2;
            return res;

        }

        public class Trie
        {
            TrieNode root;
            public Trie()
            {
                root = new TrieNode();
            }

            public void Insert(string word)
            {
                TrieNode node = root;
                if (word.Length == 0)
                    return;

                char[] ch = word.ToCharArray();
                for (int i = 0; i < ch.Length; i++)
                {
                    int index = ch[i] - 'a';
                    if (node.NextNode[index] == null)
                    {
                        node.NextNode[index] = new TrieNode();
                    }
                    node = node.NextNode[index];
                    node.Prefix++;
                }
                node.Count++;

            }

            public bool Search(string word)
            {
                if (word.Length == 0)
                    return false;
                TrieNode node = root;
                char[] ch = word.ToCharArray();
                for (int i = 0; i < ch.Length; i++)
                {
                    int index = ch[i] - 'a';
                    if (node.NextNode[index] == null)
                        return false;
                    node = node.NextNode[index];
                }

                if (node.Count > 0)
                    return true;
                return false;
            }

            public TrieNode StartsWith(string prefix)
            {
                if (prefix.Length == 0)
                    return null;

                TrieNode node = root;
                char[] ch = prefix.ToCharArray();
                for (int i = 0; i < ch.Length; i++)
                {
                    int index = ch[i] - 'a';
                    if (node.NextNode[index] == null)
                        return null;
                    node = node.NextNode[index];
                }

                return node;
            }
        }

        public class TrieNode
        {
            public int Count;
            public int Prefix;
            public TrieNode[] NextNode = new TrieNode[26];

            public override string ToString()
            {
                return $"{Count},{Prefix}";
            }
        }


    }
}
