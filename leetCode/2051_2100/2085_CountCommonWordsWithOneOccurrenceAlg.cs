using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2051_2100
{
    public class _2085_CountCommonWordsWithOneOccurrenceAlg
    {
        public int CountWords(string[] words1, string[] words2)
        {
            Dictionary<string, int> dict1 = new Dictionary<string, int>();
            Dictionary<string, int> dict2 = new Dictionary<string, int>();

            AddDict(dict1, words1);
            AddDict(dict2, words2);

            int count = 0;
            foreach (var item in dict1)
            {
                if (item.Value == 1 && dict2.ContainsKey(item.Key) && dict2[item.Key]==1)
                {
                    count++;
                }
            }
            return count;
        }
        private void AddDict(Dictionary<string, int> dict, string[] words)
        {
            foreach (string word in words) 
            {
                if (dict.ContainsKey(word))
                {
                    dict[word] += 1;
                }
                else
                {
                    dict.Add(word, 1);
                }
            }
        }
    }
}

