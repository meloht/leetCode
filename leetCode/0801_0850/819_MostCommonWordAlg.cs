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
    }
}
