using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._0601_0650
{
    public class _648_ReplaceWordsAlg
    {

        public string ReplaceWords1(IList<string> dictionary, string sentence)
        {
            HashSet<string> words = new HashSet<string>(dictionary);

            var ls = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            StringBuilder sb = new StringBuilder();
            foreach (var item in ls)
            {
                StringBuilder sbb = new StringBuilder();
                for (int i = 0; i < item.Length; i++)
                {
                    sbb.Append(item[i]);
                    var prefix = sbb.ToString();
                    if (words.Contains(prefix))
                    {
                        break;
                    }
                }
                sb.Append(sbb.ToString()).Append(" ");
            }

            return sb.ToString().Trim();
        }



        public string ReplaceWords(IList<string> dictionary, string sentence)
        {
            Trie trie = new Trie();
            foreach (string word in dictionary)
            {
                Trie cur = trie;
                for (int i = 0; i < word.Length; i++)
                {
                    char c = word[i];
                    if (!cur.Children.ContainsKey(c))
                    {
                        cur.Children.Add(c, new Trie());
                    }
                    cur = cur.Children[c];
                }
                cur.Children.Add('#', new Trie());
            }
            string[] words = sentence.Split(" ");
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = FindRoot(words[i], trie);
            }
            return string.Join(" ", words);
        }

        public string FindRoot(string word, Trie trie)
        {
            StringBuilder root = new StringBuilder();
            Trie cur = trie;
            for (int i = 0; i < word.Length; i++)
            {
                char c = word[i];
                if (cur.Children.ContainsKey('#'))
                {
                    return root.ToString();
                }
                if (!cur.Children.ContainsKey(c))
                {
                    return word;
                }
                root.Append(c);
                cur = cur.Children[c];
            }
            return root.ToString();
        }
    }

    public class Trie
    {
        public Dictionary<char, Trie> Children;

        public Trie()
        {
            Children = new Dictionary<char, Trie>();
        }
    }





}
