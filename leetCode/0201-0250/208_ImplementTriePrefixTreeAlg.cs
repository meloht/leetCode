using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0201_0250
{
    public class _208_ImplementTriePrefixTreeAlg
    {
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

            public bool StartsWith(string prefix)
            {
                if (prefix.Length == 0)
                    return false;

                TrieNode node = root;
                char[] ch = prefix.ToCharArray();
                for (int i = 0; i < ch.Length; i++)
                {
                    int index = ch[i] - 'a';
                    if (node.NextNode[index] == null)
                        return false;
                    node = node.NextNode[index];
                }

                return node.Prefix > 0;
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
