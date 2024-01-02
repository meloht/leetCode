using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0201_0250
{
    public class _205_IsomorphicStringsAlg
    {
        public bool IsIsomorphic(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            var ss = s.ToArray().Distinct().Count();
            var tt = t.ToArray().Distinct().Count();
            if (ss != tt)
            {
                return false;
            }
            char[] dict = new char[256];

            for (int i = 0; i < s.Length; i++)
            {
                int ch1 = s[i];
                var ch2 = t[i];
                if (dict[ch1] != 0)
                {
                    if (ch2 != dict[ch1])
                    {
                        return false;
                    }
                }
                else
                {
                    dict[ch1] = ch2;
                }

            }

            return true; ;
        }
    }
}
