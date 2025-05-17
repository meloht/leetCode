using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3301_3350
{
    public class _3335_TotalCharactersInStringAfterTransformationsIAlg
    {
        private const int MOD = 1000000007;
        public int LengthAfterTransformations(string s, int t)
        {
            int[] cnt = new int[26];

            foreach (var item in s)
            {
                cnt[item - 'a']++;
            }

            for (int i = 0; i < t; i++)
            {
                int[] next = new int[26];
                next[0] = cnt[25];
                next[1] = (cnt[25] + cnt[0]) % MOD;
                for (int j = 2; j < 26; j++)
                {
                    next[j] = cnt[j - 1];
                }
                cnt = next;
            }

            int ans = 0;
            for (int i = 0; i < 26; i++)
            {
                ans = (cnt[i] + ans) % MOD;
            }

            return ans;
        }
    }
}
