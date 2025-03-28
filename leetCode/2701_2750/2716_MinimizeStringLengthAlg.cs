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
            HashSet<char> set = new HashSet<char>();
            foreach (var item in s)
            {
                set.Add(item);
            }
            return set.Count;
        }

    }
}
