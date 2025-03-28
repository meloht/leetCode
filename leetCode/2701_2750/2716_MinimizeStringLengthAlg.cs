using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2701_2750
{
    public class _2716_MinimizeStringLengthAlg
    {
        public int MinimizedStringLength(string s)
        {
            int[] map = new int[26];
            foreach (var item in s)
            {
                map[item - 'a'] = 1;
            }
            return map.Count(p => p == 1);
        }

    }
}
