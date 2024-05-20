using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1501_1550
{
    public class _1542_FindLongestAwesomeSubstringAlg
    {
        public int LongestAwesome(string s)
        {
            Dictionary<int, int> prefix = new Dictionary<int, int>();
            prefix.Add(0, -1);
            int seq = 0;
            int ans = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int digit = s[i] - '0';
                seq ^= (1 << digit);
                if (prefix.ContainsKey(seq))
                {
                    ans = Math.Max(ans, i - prefix[seq]);
                }
                else
                {
                    prefix.Add(seq, i);
                }
                for (int k = 0; k < 10; ++k)
                {
                    if (prefix.ContainsKey(seq ^ (1 << k)))
                    {
                        ans = Math.Max(ans, i - prefix[seq ^ (1 << k)]);
                    }
                }


            }
           
           
            return ans;
        }
    }
}
