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
        public IList<string> FindAllConcatenatedWordsInADict(string[] words)
        {
            Dictionary<int, List<string>> dict = new Dictionary<int, List<string>>();
            foreach (string word in words)
            {
                if (dict.ContainsKey(word.Length))
                {
                    dict[word.Length].Add(word);
                }
                else
                {
                    dict.Add(word.Length, [word]);
                }
            }

            var list = dict.Keys.ToList();
            list.Sort();





            return null;
        }

        class Trie
        {
            private Trie[] children;
            private bool isEnd;

            public Trie()
            {
                children = new Trie[26];
                isEnd = false;
            }

            public void Insert(string word)
            {
                Trie node = this;
                for (int i = 0; i < word.Length; i++)
                {
                    char ch = word[i];
                    int index = ch - 'a';
                    if (node.children[index] == null)
                    {
                        node.children[index] = new Trie();
                    }
                    node = node.children[index];
                }
                node.isEnd = true;
            }

            public bool Search(string word)
            {
                Trie node = SearchPrefix(word);
                return node != null && node.isEnd;
            }

            public bool StartsWith(string prefix)
            {
                return SearchPrefix(prefix) != null;
            }

            private Trie SearchPrefix(string prefix)
            {
                Trie node = this;
                for (int i = 0; i < prefix.Length; i++)
                {
                    char ch = prefix[i];
                    int index = ch - 'a';
                    if (node.children[index] == null)
                    {
                        return null;
                    }
                    node = node.children[index];
                }
                return node;
            }
        }


    }
}
