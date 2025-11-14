using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1101_1150
{
    public class _1140_StoneGameIIAlg
    {
        public int StoneGameII(int[] piles)
        {
            int s = 0, n = piles.Length;
            int[,] f = new int[n, n + 1];
            for (int i = n - 1; i >= 0; --i)
            {
                s += piles[i];
                for (int m = 1; m <= i / 2 + 1; ++m)
                {
                    if (i + m * 2 >= n)
                        f[i, m] = s; // 全拿
                    else
                    {
                        int mn = int.MaxValue;
                        for (int x = 1; x <= m * 2; ++x)
                            mn = Math.Min(mn, f[i + x, Math.Max(m, x)]);
                        f[i, m] = s - mn;
                    }
                }
            }
            return f[0, 1];

        }
    }
}
