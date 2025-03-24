using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2251_2300
{
    public class _2255_CountPrefixesOfAGivenStringAlg
    {
        public int CountPrefixes(string[] words, string s)
        {
            int ans = 0;
            foreach (var item in words)
            {
                if (s.StartsWith(item))
                {
                    ans++;
                }
            }

            return ans;
        }
    }
}
