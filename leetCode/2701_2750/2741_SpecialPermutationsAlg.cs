using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace leetCode._2701_2750
{
    public class _2741_SpecialPermutationsAlg
    {
        int Mod = 1_000_000_007;
        public int SpecialPerm(int[] nums)
        {
            int n = nums.Length;
            int u = (1 << n) - 1;
            long[][] memo = new long[u][];
            for (long i = 0; i < u; i++)
            {
                memo[i] = new long[n];
                Array.Fill(memo[i], -1);
            }


            long ans = 0;
            for (int i = 0; i < n; i++)
            {
                ans += Dfs(u ^ (1 << i), i, nums, memo);
            }
            return (int)(ans % 1_000_000_007);

        }
        private long Dfs(int s, int i, int[] nums, long[][] memo)
        {
            if (s == 0)
                return 1;

            if (memo[s][i] != -1)
                return memo[s][i];

            long res = 0;
            for (int j = 0; j < nums.Length; j++)
            {
                if ((s >> j & 1) > 0 && (nums[i] % nums[j] == 0 || nums[j] % nums[i] == 0))
                {
                    res += Dfs(s ^ (1 << j), j, nums, memo);
                }


            }
            memo[s][i] = res;
            return res;
        }
    }
}
