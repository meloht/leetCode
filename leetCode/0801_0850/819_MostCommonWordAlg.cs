using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0801_0850
{
    public class _819_MostCommonWordAlg
    {
        public string MostCommonWord(string paragraph, string[] banned)
        {
            HashSet<string> set = new HashSet<string>(banned.Length);
            foreach (var item in banned)
            {
                set.Add(item.ToLower());
            }
            Dictionary<string, int> dict = new Dictionary<string, int>();
            var arr = paragraph.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            int max = 0;
            string word = "";
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i].EndsWith('!') || arr[i].EndsWith('?')
                    || arr[i].EndsWith(',') || arr[i].EndsWith(';') 
                    || arr[i].EndsWith('.')|| arr[i].EndsWith("'"))
                {
                    arr[i] = arr[i].Substring(0, arr[i].Length - 1);
                }
                if (arr[i].Contains('!') || arr[i].Contains('?')
                   || arr[i].Contains(',') || arr[i].Contains(';')
                   || arr[i].Contains('.'))
                {
                    var arrAdd = arr[i].Split(new char[] { ',', '!', '?','.',';','\'' },StringSplitOptions.RemoveEmptyEntries);
                    if (arrAdd.Length > 0)
                    {
                        arr[i] = arrAdd[0];
                    }
                    for (int j = 1; j < arrAdd.Length; j++)
                    {
                        arr.Add(arrAdd[j]);
                    }
                  
                }
                string item = arr[i].ToLower();
                if (!set.Contains(item))
                {
                    if (dict.ContainsKey(item))
                    {
                        dict[item]++;
                    }
                    else
                    {
                        dict.Add(item, 1);
                    }
                    if (dict[item] > max) 
                    {
                        max = dict[item];
                        word = item;
                    }
                }
            }
            return word;
        }

        public string MostCommonWord2(string paragraph, string[] banned)
        {
            ISet<string> bannedSet = new HashSet<string>();
            foreach (string word in banned)
            {
                bannedSet.Add(word);
            }
            int maxFrequency = 0;
            Dictionary<string, int> frequencies = new Dictionary<string, int>();
            StringBuilder sb = new StringBuilder();
            int length = paragraph.Length;
            for (int i = 0; i <= length; i++)
            {
                if (i < length && char.IsLetter(paragraph[i]))
                {
                    sb.Append(char.ToLower(paragraph[i]));
                }
                else if (sb.Length > 0)
                {
                    string word = sb.ToString();
                    if (!bannedSet.Contains(word))
                    {
                        if (!frequencies.ContainsKey(word))
                        {
                            frequencies.Add(word, 1);
                        }
                        else
                        {
                            frequencies[word]++;
                        }
                        maxFrequency = Math.Max(maxFrequency, frequencies[word]);
                    }
                    sb.Length = 0;
                }
            }
            string mostCommon = "";
            foreach (KeyValuePair<string, int> pair in frequencies)
            {
                string word = pair.Key;
                int frequency = pair.Value;
                if (frequency == maxFrequency)
                {
                    mostCommon = word;
                    break;
                }
            }
            return mostCommon;
        }


    }
}
