using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1001_1050
{
    public class _1002_FindCommonCharactersAlg
    {
        public IList<string> CommonChars(string[] words)
        {
            if (words.Length == 1)
                return words;
            Dictionary<char, int> dict = GetDict(words[0]);

            for (int i = 1; i < words.Length; i++)
            {

                Dictionary<char, int> set = new Dictionary<char, int>();
                string s = words[i];
                foreach (var item in s)
                {
                    if (dict.ContainsKey(item) && dict[item] > 0)
                    {
                        if (set.ContainsKey(item))
                        {
                            set[item]++;
                        }
                        else
                        {
                            set.Add(item, 1);
                        }
                        dict[item]--;
                    }
                }

                dict = set;

            }
            List<string> ans = new List<string>();
            foreach (var item in dict)
            {
                for (int i = 0; i < item.Value; i++)
                {
                    ans.Add(item.Key.ToString());
                }
            }
            return ans;
        }
        private Dictionary<char, int> GetDict(string s)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (var item in s)
            {
                if (dict.ContainsKey(item))
                {
                    dict[item]++;
                }
                else
                {
                    dict.Add(item, 1);
                }
            }
            return dict;

        }
    }
}
