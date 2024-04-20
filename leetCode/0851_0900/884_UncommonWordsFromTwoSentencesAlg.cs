using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0851_0900
{
    public class _884_UncommonWordsFromTwoSentencesAlg
    {
        public string[] UncommonFromSentences(string s1, string s2)
        {
            Dictionary<string, int> dict1 = GetDict(s1);
            Dictionary<string, int> dict2 = GetDict(s2);

            HashSet<string> list = new HashSet<string>();

            foreach (var item in dict1)
            {
                if (item.Value == 1&&!dict2.ContainsKey(item.Key))
                {
                    list.Add(item.Key);
                }
            }
            foreach (var item in dict2)
            {
                if (item.Value == 1 && !dict1.ContainsKey(item.Key))
                {
                    list.Add(item.Key);
                }
            }

            return list.ToArray();
        }

        private Dictionary<string, int> GetDict(string s1)
        {
            Dictionary<string, int> dict1 = new Dictionary<string, int>();
            string[] str1 = s1.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in str1)
            {
                if (dict1.ContainsKey(item))
                {
                    dict1[item]++;
                }
                else
                {
                    dict1.Add(item, 1);
                }
            }
            return dict1;
        }
    }
}
