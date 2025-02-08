using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0751_0800
{
    public class _791_CustomSortStringAlg
    {
        public string CustomSortString(string S, string T)
        {
            int[] count = new int[26];
            foreach (char c in T)
            {
                count[c - 'a']++;
            }
            StringBuilder sb = new StringBuilder();
            foreach (char c in S)
            {
                if (count[c - 'a']-- > 0)
                {
                    sb.Append(c);
                }
            }
            for (char c = 'a'; c <= 'z'; c++)
            {
                while (count[c - 'a']-- > 0)
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }
    }
}
