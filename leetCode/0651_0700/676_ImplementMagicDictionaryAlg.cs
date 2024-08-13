using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0651_0700
{
    public class _676_ImplementMagicDictionaryAlg
    {
        public class MagicDictionary
        {

            TrieNode root = new TrieNode();
            HashSet<int> keys = new HashSet<int>();
            public MagicDictionary()
            {

            }

            public void BuildDict(string[] dictionary)
            {
                foreach (var item in dictionary)
                {
                    Insert(item);
                    keys.Add(item.Length);
                }
            }
            public bool Search(string searchWord)
            {
                if(keys.Contains(searchWord.Length)==false)
                    return false;
                return DFS(searchWord, root, 0, false);
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
            private bool DFS(string searchWord, TrieNode node, int pos, bool modified)
            {
                if (pos == searchWord.Length)
                {
                    return modified && node.Count>0;
                }
                int idx = searchWord[pos] - 'a';
                if (node.NextNode[idx] != null)
                {
                    if (DFS(searchWord, node.NextNode[idx], pos + 1, modified))
                    {
                        return true;
                    }
                }
                if (!modified)
                {
                    for (int i = 0; i < 26; ++i)
                    {
                        if (i != idx && node.NextNode[i] != null)
                        {
                            if (DFS(searchWord, node.NextNode[i], pos + 1, true))
                            {
                                return true;
                            }
                        }
                    }
                }
                return false;
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
