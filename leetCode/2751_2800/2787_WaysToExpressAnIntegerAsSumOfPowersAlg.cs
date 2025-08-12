using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2751_2800
{
    public class _2787_WaysToExpressAnIntegerAsSumOfPowersAlg
    {
        public int NumberOfWays(int n, int x)
        {
            long[] f = new long[n + 1];
            f[0] = 1;
            // 本题数据范围小，Math.pow 的计算结果一定准确
            for (int i = 1; Math.Pow(i, x) <= n; i++)
            {
                int v = (int)Math.Pow(i, x);
                for (int s = n; s >= v; s--)
                {
                    f[s] += f[s - v];
                }
            }
            return (int)(f[n] % 1_000_000_007);
        }
    }
}
