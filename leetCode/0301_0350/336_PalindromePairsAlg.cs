using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0301_0350
{
    public class _336_PalindromePairsAlg
    {
        public IList<IList<int>> PalindromePairs(string[] words)
        {
            Node root = new Node();
            int n = words.Length;
            for (int i = 0; i < n; i++)
            {
                var ss = words[i].ToCharArray().Reverse().ToArray();
                var sss = new string(ss);
                Node curr = root;
                if (IsPalindrome(sss))
                {
                    curr.Suffixs.Add(i);
                }

                for (int j = 0; j < ss.Length; j++)
                {
                    char ch = ss[j];
                    if (curr.Children[ch - 'a'] == null)
                    {
                        curr.Children[ch - 'a'] = new Node();
                    }
                    curr= curr.Children[ch - 'a'];
                    if (IsPalindrome(sss.Substring(j + 1)))
                    { 
                        curr.Suffixs.Add(i);
                    }
                }

                curr.Words.Add(i);
            }
            List<IList<int>> ans = new List<IList<int>>();

            for (int i = 0; i < n; i++)
            {
                string word = words[i];
                Node curr= root;
                int j = 0;
                for (; j  < word.Length; j++)
                {
                    if (IsPalindrome(word.Substring(j)))
                    {
                        foreach (var item in curr.Words)
                        {
                            if (item != i)
                            {
                                ans.Add([i, item]);
                            }
                        }
                    }
                    char ch = word[j];
                    if (curr.Children[ch - 'a'] == null)
                    {
                        break;
                    }
                    curr = curr.Children[ch - 'a'];
                }
                if (j == word.Length)
                {
                    foreach (var item in curr.Suffixs)
                    {
                        if (item != i)
                        {
                            ans.Add([i, item]);
                        }
                    }
                }
            }
          
            return ans;
        }

        private bool IsPalindrome(string s)
        {
            for (int i = 0, j = s.Length - 1; i < j; i++, j--)
            {
                if (s[i] != s[j])
                    return false;
            }
            return true;
        }

        class Node
        {
            public Node[] Children = new Node[26];
            public List<int> Words = new List<int>();
            public List<int> Suffixs = new List<int>();

        }
    }
}
