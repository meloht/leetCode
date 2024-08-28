using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3101_3150
{
    public class _3144_MinimumSubstringPartitionOfEqualCharacterFrequencyAlg
    {
        public int MinimumSubstringsInPartition(string s)
        {
            char[] chars = s.ToCharArray();
            int n = chars.Length;
            int[] memo = new int[n];

            return Dfs(n - 1, chars, memo);
        }

        private int Dfs(int i, char[] chars, int[] memo)
        {
            if (i < 0)
                return 0;
            if (memo[i] > 0)
                return memo[i];

            int res = int.MaxValue;
            int[] cnt = new int[26];
            int k = 0;
            int maxcnt = 0;
            for (int j = i; j >= 0; j--)
            {
                k += cnt[chars[j] - 'a']++ == 0 ? 1 : 0;
                maxcnt = Math.Max(maxcnt, cnt[chars[j] - 'a']);
                if (i - j + 1 == k * maxcnt)
                {
                    res = Math.Min(res, Dfs(j - 1, chars, memo) + 1);
                }
            }

            memo[i] = res;
            return res;
        }
    }
}
