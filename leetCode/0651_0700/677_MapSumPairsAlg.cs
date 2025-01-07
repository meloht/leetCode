using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0651_0700
{
    public class _677_MapSumPairsAlg
    {
        public class MapSum
        {
            Trie root;
            Dictionary<string, int> dict;
            public MapSum()
            {
                root = new Trie();
                dict=new Dictionary<string, int>();
            }

            public void Insert(string key, int val)
            {
                int num = val;
                if (dict.ContainsKey(key))
                {
                    num = val - dict[key];
                    dict[key] = val;
                }
                else
                {
                    dict.Add(key, val);
                }

                root.Insert(key, num);
              
            }

            public int Sum(string prefix)
            {
                return root.StartsWith(prefix);
            }
        }
        public class Trie
        {
            TrieNode root;
            public Trie()
            {
                root = new TrieNode();
            }

            public void Insert(string word, int val)
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
                    node.Sum += val;
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

            public int StartsWith(string prefix)
            {
                if (prefix.Length == 0)
                    return 0;

                TrieNode node = root;
                char[] ch = prefix.ToCharArray();
                for (int i = 0; i < ch.Length; i++)
                {
                    int index = ch[i] - 'a';
                    if (node.NextNode[index] == null)
                        return 0;
                    node = node.NextNode[index];
                }

                return node.Sum;
            }
        }
        public class TrieNode
        {
            public int Count;
            public int Prefix;
            public int Sum;
            public TrieNode[] NextNode = new TrieNode[26];
        }
    }
}
