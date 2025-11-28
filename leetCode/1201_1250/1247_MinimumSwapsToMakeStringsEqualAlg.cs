using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1201_1250
{
    public class _1247_MinimumSwapsToMakeStringsEqualAlg
    {
        public int MinimumSwap(string s1, string s2)
        {
            int[] cnt = new int[2];
            for (int i = 0, n = s1.Length; i < n; i++)
                if (s1[i] != s2[i])
                    cnt[s1[i] % 2]++; // x 和 y ASCII 值的二进制最低位不同
            int d = cnt[0] + cnt[1];
            return d % 2 != 0 ? -1 : d / 2 + cnt[0] % 2;

        }
    }
}
