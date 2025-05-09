using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3301_3350
{
    public class _3343_CountNumberOfBalancedPermutationsAlg
    {
        private const long MOD = 1_000_000_007;

        public int CountBalancedPermutations(string num)
        {
            int tot = 0, n = num.Length;
            int[] cnt = new int[10];
            foreach (char ch in num)
            {
                int d = ch - '0';
                cnt[d]++;
                tot += d;
            }
            if (tot % 2 != 0)
            {
                return 0;
            }

            int target = tot / 2;
            int maxOdd = (n + 1) / 2;
            long[,] comb = new long[maxOdd + 1, maxOdd + 1];
            long[,] f = new long[target + 1, maxOdd + 1];

            for (int i = 0; i <= maxOdd; i++)
            {
                comb[i, i] = comb[i, 0] = 1;
                for (int j = 1; j < i; j++)
                {
                    comb[i, j] = (comb[i - 1, j] + comb[i - 1, j - 1]) % MOD;
                }
            }

            f[0, 0] = 1;
            int psum = 0, totSum = 0;
            for (int i = 0; i <= 9; i++)
            {
                /* 前 i 个数字的数目之和 */
                psum += cnt[i];
                /* 前 i 个数字的元素之和 */
                totSum += i * cnt[i];
                for (int oddCnt = Math.Min(psum, maxOdd); oddCnt >= Math.Max(0, psum - (n - maxOdd)); oddCnt--)
                {
                    /* 偶数位需要填充的位数 */
                    int evenCnt = psum - oddCnt;
                    for (int curr = Math.Min(totSum, target); curr >= Math.Max(0, totSum - target); curr--)
                    {
                        long res = 0;
                        for (int j = Math.Max(0, cnt[i] - evenCnt); j <= Math.Min(cnt[i], oddCnt) && i * j <= curr; j++)
                        {
                            /* 当前数字在奇数位填充 j 位，偶数位填充 cnt[i] - j 位 */
                            long ways = comb[oddCnt, j] * comb[evenCnt, cnt[i] - j] % MOD;
                            res = (res + ways * f[curr - i * j, oddCnt - j] % MOD) % MOD;
                        }
                        f[curr, oddCnt] = res % MOD;
                    }
                }
            }

            return (int)f[target, maxOdd];
        }

    }
}
