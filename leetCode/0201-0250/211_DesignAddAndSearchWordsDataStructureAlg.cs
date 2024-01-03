﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0201_0250
{
    public class _211_DesignAddAndSearchWordsDataStructureAlg
    {
        public class WordDictionary
        {

            TrieNode root;
            public WordDictionary()
            {
                root = new TrieNode();
            }

            public void AddWord(string word)
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
            int len = 0;
            public bool Search(string word)
            {
                if (word.Length == 0)
                    return false;
                len = word.Length - 1;
                TrieNode node = root;
                var res = Dfs(word, 0, node);
                return res;
            }
            private bool Dfs(string word, int index, TrieNode node)
            {
                char ch = word[index];
                if (ch == '.')
                {
                    var nexts = node.NextNode;
                    foreach (var next in nexts)
                    {
                        if (next != null)
                        {
                            if (index == len)
                            {
                                if (next.Count > 0)
                                    return true;

                            }
                            else
                            {
                                var res = Dfs(word, index + 1, next);
                                if (res)
                                    return true;
                            }

                        }
                    }
                }
                else
                {
                    int i = ch - 'a';
                    if (node.NextNode[i] == null)
                        return false;
                    var next = node.NextNode[i];
                    if (index == len)
                    {
                        if (next.Count > 0)
                            return true;
                        return false;
                    }
                    else
                    {
                        var res = Dfs(word, index + 1, next);
                        if (res)
                            return true;
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
