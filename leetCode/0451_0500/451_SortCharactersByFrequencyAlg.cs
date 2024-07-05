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
            var res = string.Join("", s.GroupBy(p => p).OrderByDescending(p => p.Count()).Select(p => "".PadLeft(p.Count(), p.Key)));

            return res;
        }
    }
}
