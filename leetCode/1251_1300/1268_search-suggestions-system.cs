using System;
using System.Collections.Generic;
using System.Text;

namespace leetCode._1251_1300
{
    public class _1268_search_suggestions_system
    {
        public IList<IList<string>> SuggestedProducts1(string[] products, string searchWord)
        {
            Array.Sort(products);
            int n = products.Length;
            IList<IList<string>> ans = new List<IList<string>>();
            for (int i = 0; i < searchWord.Length; i++)
            {
                string cur = searchWord.Substring(0, i + 1);
                int left = 0;
                int right = n - 1;
                while (left < right)
                {
                    int mid = (left + right) >> 1;
                    if (products[mid].CompareTo(cur) >= 0)
                    {
                        right = mid;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }
                List<string> ls = new List<string>();
                if (products[right].CompareTo(cur) >= 0)
                {
                    for (int j = right; j <= Math.Min(n - 1, right + 2); j++)
                    {
                        if (products[j].Length < cur.Length)
                            break;
                        if (!products[j].StartsWith(cur))
                            break;
                        ls.Add(products[j]);
                    }
                }
                ans.Add(ls);
            }

            return ans;
        }
        public IList<IList<string>> SuggestedProducts(string[] products, string searchWord)
        {
            Trie trie = new Trie();
            Array.Sort(products);
            foreach (var item in products)
            {
                trie.Insert(item);
            }
            IList<IList<string>> ans = new List<IList<string>>();
            for (int i = 0; i < searchWord.Length; i++)
            {
                string cur = searchWord.Substring(0, i + 1);
                var res = trie.StartsWith(cur);
                ans.Add(res);
            }
            return ans;
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
                    if (node.CountArr.Count < 3)
                    {
                        node.CountArr.Add(word);
                    }
                }

            }


            public string[] StartsWith(string prefix)
            {
                if (prefix.Length == 0)
                    return [];

                TrieNode node = root;
                char[] ch = prefix.ToCharArray();
                for (int i = 0; i < ch.Length; i++)
                {
                    int index = ch[i] - 'a';
                    if (node.NextNode[index] == null)
                        return [];
                    node = node.NextNode[index];
                }

                return node.CountArr.ToArray();
            }
        }

        public class TrieNode
        {
            public List<string> CountArr = new List<string>();

            public TrieNode[] NextNode = new TrieNode[26];

            public override string ToString()
            {
                return $"{CountArr.Count}";
            }
        }
    }
}
