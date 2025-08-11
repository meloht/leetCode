using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2401_2450
{
    public class _2438_RangeProductQueriesOfPowersAlg
    {
        public int[] ProductQueries(int n, int[][] queries)
        {
            int MOD = 1_000_000_007;
            // 例如二进制 1100 分解为 100 + 1000
            // 第一轮循环 lowbit(1100) = 100，然后 1100 ^ 100 = 1000
            // 第二轮循环 lowbit(1000) = 1000，然后 1000 ^ 1000 = 0，循环结束
            List<int> powers = new List<int>();
            while (n > 0)
            {
                int lowbit = n & -n;
                powers.Add(lowbit);
                n ^= lowbit;
            }

            int[] ans = new int[queries.Length];
            for (int i = 0; i < queries.Length; i++)
            {
                int[] q = queries[i];
                long mul = 1;
                for (int j = q[0]; j <= q[1]; j++)
                {
                    mul = mul * powers[j] % MOD;
                }
                ans[i] = (int)mul;
            }
            return ans;
        }

        
    }
}
