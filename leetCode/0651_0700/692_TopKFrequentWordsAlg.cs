using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0651_0700
{
    public class _692_TopKFrequentWordsAlg
    {
        public IList<string> TopKFrequent(string[] words, int k)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach (var item in words)
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
            List<(string, int)> list = new List<(string, int)>();
            foreach (var item in dict)
            {
                list.Add((item.Key, item.Value));
            }
            list.Sort((x, y) =>
            {
                if (x.Item2 == y.Item2)
                {
                    return x.Item1.CompareTo(y.Item1);
                }
                return y.Item2 - x.Item2;

            });

            List<string> ls = new List<string>();
            for (int i = 0; i < k; i++)
            {
                ls.Add(list[i].Item1);
            }
            return ls;
        }
    }
}
