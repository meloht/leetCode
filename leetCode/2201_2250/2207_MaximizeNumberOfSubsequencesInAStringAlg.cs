using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2201_2250
{
    public class _2207_MaximizeNumberOfSubsequencesInAStringAlg
    {
        public long MaximumSubsequenceCount(string text, string pattern)
        {
            long res = 0, cnt1 = 0, cnt2 = 0;
            foreach (char c in text)
            {
                if (c == pattern[1])
                {
                    res += cnt1;
                    cnt2++;
                }
                if (c == pattern[0])
                {
                    cnt1++;
                }
            }
            return res + Math.Max(cnt1, cnt2);
        }
    }
}
