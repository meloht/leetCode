using leetCode.Model.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0801_0850
{
    public class _820_ShortEncodingOfWordsAlg
    {
        public int MinimumLengthEncoding(string[] words)
        {
            Dictionary<TrieNode, int> dict = new Dictionary<TrieNode, int>();
            TrieNode root = new TrieNode();
            for (int i = 0; i < words.Length; i++)
            {
                TrieNode cur = root;
                for (int j = words[i].Length - 1; j >= 0; j--)
                {
                    cur = cur.GetNode(words[i][j]);
                }
                if (!dict.ContainsKey(cur))
                {
                    dict.Add(cur, i);
                }
               
            }


            int ans = 0;
            foreach (var item in dict)
            {
                if (item.Key.Count == 0)
                {
                    ans += words[item.Value].Length + 1;
                }
            }
           
            return ans;
        }
        public class TrieNode
        {

            public int Count;
            public TrieNode[] NextNode = new TrieNode[26];

            public TrieNode GetNode(char c)
            {
                if (NextNode[c - 'a'] == null)
                {
                    NextNode[c - 'a'] = new TrieNode();
                    Count++;
                }
                return NextNode[c - 'a'];
            }

        }
    }
}
