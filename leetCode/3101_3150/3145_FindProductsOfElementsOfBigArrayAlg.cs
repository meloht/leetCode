using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3101_3150
{
    public class _3145_FindProductsOfElementsOfBigArrayAlg
    {
        public int[] FindProductsOfElements(long[][] queries)
        {
            int[] ans = new int[queries.Length];
            for (int i = 0; i < queries.Length; i++)
            {
                long[] q = queries[i];
                long er = SumE(q[1] + 1);
                long el = SumE(q[0]);
                ans[i] = Pow(2, er - el, q[2]);

            }
            return ans;
        }

        private long SumE(long k)
        {
            long res = 0;
            long n = 0;
            long cnt1 = 0; // 之前填的 1 的个数
            long sumI = 0; // 之前填的 1 的幂次之和
            for (long i = 63 - long.LeadingZeroCount(k + 1); i > 0; i--)
            {
                long c = (cnt1 << (int)i) + (i << (int)(i - 1)); // 新增的幂次个数
                if (c <= k)
                {
                    k -= c;
                    res += (sumI << (int)i) + ((i * (i - 1) / 2) << (int)(i - 1));
                    sumI += i;
                    cnt1++;
                    n |= 1L << (int)i; // 填 1
                }
            }
            // 最低位单独计算
            if (cnt1 <= k)
            {
                k -= cnt1;
                res += sumI;
                n |= 1; // 最低位填 1
            }
            // 剩余的 k 个幂次，由 n 的低 k 个 1 补充
            while (k-- > 0)
            {
                res += long.TrailingZeroCount(n);
                n &= n - 1; // 去掉最低位的 1（置为 0）
            }
            return res;
        }

        private int Pow(long x, long n, long mod)
        {
            long res = 1 % mod;
            for (; n > 0; n /= 2)
            {
                if (n % 2 == 1)
                {
                    res = res * x % mod;
                }
                x = x * x % mod;
            }
            return (int)res;
        }

    }
}
