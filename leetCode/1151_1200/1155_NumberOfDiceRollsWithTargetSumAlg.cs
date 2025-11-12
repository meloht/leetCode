using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1151_1200
{
    public class _1155_NumberOfDiceRollsWithTargetSumAlg
    {
        public int NumRollsToTarget(int n, int k, int target)
        {
            if (target < n || target > n * k)
            {
                return 0; // 无法组成 target
            }
            int MOD = 1_000_000_007;
            long[] f = new long[target - n + 1];
            f[0] = 1;
            for (int i = 1; i <= n; i++)
            {
                int maxJ = Math.Min(i * (k - 1), target - n); // i 个骰子至多掷出 i*(k-1)
                for (int j = 1; j <= maxJ; j++)
                {
                    f[j] += f[j - 1]; // 原地计算 f 的前缀和
                }
                for (int j = maxJ; j >= k; j--)
                {
                    f[j] = (f[j] - f[j - k]) % MOD; // f[j] 是两个前缀和的差
                }
            }
            return (int)f[target - n];

        }
    }
}
