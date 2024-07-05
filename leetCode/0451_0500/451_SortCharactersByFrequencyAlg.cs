using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0451_0500
{
    public class _451_SortCharactersByFrequencyAlg
    {
        public string FrequencySort(string s)
        {
            char[] chars = s.ToCharArray();
            var dict = chars.GroupBy(p => p).OrderByDescending(p => p.Count()).Select(p => new Tuple<char, int>(p.Key, p.Count()));

            StringBuilder sb = new StringBuilder();

            foreach (var item in dict)
            {
                for (int i = 0; i < item.Item2; i++)
                {
                    sb.Append(item.Item1);
                }
            }

            return sb.ToString();
        }
    }
}
