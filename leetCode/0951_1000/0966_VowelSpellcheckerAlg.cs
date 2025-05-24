using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0951_1000
{
    public class _0966_VowelSpellcheckerAlg
    {
        public string[] Spellchecker(string[] wordlist, string[] queries)
        {
            Dictionary<string, List<int>> dict1 = new Dictionary<string, List<int>>();
            Dictionary<string, List<int>> dict2 = new Dictionary<string, List<int>>();
            Dictionary<string, List<int>> dict3 = new Dictionary<string, List<int>>();

            for (int i = 0; i < wordlist.Length; i++)
            {
               
                if (dict1.ContainsKey(wordlist[i]))
                {
                    dict1[wordlist[i]].Add(i);
                }
                else
                {
                    dict1.Add(wordlist[i], [i]);
                }
                string word = wordlist[i].ToLower();
                if (dict2.ContainsKey(word))
                {
                    dict2[word].Add(i);
                }
                else
                {
                    dict2.Add(word, [i]);
                }
                string wordNo = GetWord(word);
                if (dict3.ContainsKey(wordNo))
                {
                    dict3[wordNo].Add(i);
                }
                else
                {
                    dict3.Add(wordNo, [i]);
                }
            }
            string[] ans = new string[queries.Length];


            for (int i = 0; i < queries.Length; i++)
            {
                string item = queries[i];
                if (dict1.ContainsKey(item))
                {
                    ans[i] = wordlist[dict1[item][0]];

                    continue;
                }
                string word = item.ToLower();
                if (dict2.ContainsKey(word))
                {
                    ans[i] = wordlist[dict2[word][0]];

                    continue;
                }

                string wordNo = GetWord(word);
                if (dict3.ContainsKey(wordNo))
                {
                    ans[i] = wordlist[dict3[wordNo][0]];
                    continue;
                }

                ans[i] = "";
            }
           

            return ans;
        }

        private string GetWord(string word)
        {
            var chs = word.ToCharArray();
            for (int i = 0; i < word.Length; i++)
            {
                if (chs[i] == 'a' || chs[i] == 'e' || chs[i] == 'i' || chs[i] == 'o' || chs[i] == 'u')
                {
                    chs[i] = '-';
                }
            }
            return new string(chs);
        }
    }
}
