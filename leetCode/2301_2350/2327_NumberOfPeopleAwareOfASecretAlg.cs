using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2301_2350
{
    public class _2327_NumberOfPeopleAwareOfASecretAlg
    {
        public int PeopleAwareOfSecret(int n, int delay, int forget)
        {
            int MOD = 1_000_000_007;
            // known[i] 表示恰好在第 i 天得知秘密的人数
            int[] known = new int[n + 1];
            known[1] = 1;
            long ans = 0;

            for (int i = 1; i <= n; i++)
            {
                // 统计在第 n 天没有忘记秘密的人数
                // 这要求 i+forget-1 >= n，解得 i >= n-forget+1
                if (i >= n - forget + 1)
                {
                    ans += known[i];
                }
                // 恰好在第 i 天得知秘密的人，会在第 [i+delay, i+forget-1] 天分享秘密
                for (int j = i + delay; j <= Math.Min(i + forget - 1, n); j++)
                {
                    known[j] = (known[j] + known[i]) % MOD; // known[j] += known[i]
                }
            }

            return (int)(ans % MOD);

        }

        public int PeopleAwareOfSecret1(int n, int delay, int forget)
        {
            int MOD = 1_000_000_007;
            int[] diff = new int[n + 1];
            diff[1] = 1;
            diff[2] = -1;
            int known = 0;
            long ans = 0;

            for (int i = 1; i <= n; i++)
            {
                // 加上 diff[i] 后，known 表示恰好在第 i 天得知秘密的人数
                known = (known + diff[i]) % MOD;
                // 统计在第 n 天没有忘记秘密的人数
                if (i >= n - forget + 1)
                {
                    ans += known;
                }
                // 恰好在第 i 天得知秘密的人，会在第 [i+delay, i+forget-1] 天分享秘密
                if (i + delay <= n)
                {
                    diff[i + delay] = (diff[i + delay] + known) % MOD;
                }
                if (i + forget <= n)
                {
                    diff[i + forget] = (diff[i + forget] - known + MOD) % MOD; // +MOD 保证结果非负
                }
            }

            return (int)(ans % MOD);

        }

    }
}
