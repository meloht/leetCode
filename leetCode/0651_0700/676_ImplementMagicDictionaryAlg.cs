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
            HashSet<int> set = new HashSet<int>();
            Trie trie = new Trie();
            public MagicDictionary()
            {

            }

            public void BuildDict(string[] dictionary)
            {
                foreach (var item in dictionary)
                {
                    this.trie.Insert(item);
                    set.Add(item.Length);
                }
            }

            public bool Search(string searchWord)
            {
                if (!set.Contains(searchWord.Length))
                    return false;
                bool bl = this.trie.Search(searchWord);
                if (bl)
                    return false;

                return false;
            }
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

            public bool Dfs(string word, TrieNode perent)
            {
                if (word.Length == 0)
                    return false;
                TrieNode node = perent;
                char[] ch = word.ToCharArray();
                for (int i = 0; i < ch.Length; i++)
                {
                    int index = ch[i] - 'a';
                    for (int j = 0; j < node.Count; j++)
                    {
                        if (j == index)
                            continue;
                        if (node.NextNode[index] == null)
                            continue;
                        if (i != ch.Length - 1 && Search(word.Substring(i + 1)))
                        {
                            return true;
                        }
                        if (i == ch.Length - 1)
                            return true;

                    }
                    if (node.NextNode[index] == null)
                        return false;
                    node = node.NextNode[index];
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
