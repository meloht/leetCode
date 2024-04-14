using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0651_0700
{
    public class _696_CountBinarySubstringsAlg
    {
        public int CountBinarySubstrings(string s)
        {
            List<int> list = new List<int>();
            int ptr = 0, n = s.Length;
            while (ptr < n)
            {
                char c = s[ptr];
                int count = 0;
                while (ptr < n && s[ptr] == c)
                {
                    ++ptr;
                    ++count;
                }
                list.Add(count);
            }
            int ans = 0;
            for (int i = 1; i < list.Count; ++i)
            {
                ans += Math.Min(list[i], list[i - 1]);
            }
            return ans;

        }
    }
}
