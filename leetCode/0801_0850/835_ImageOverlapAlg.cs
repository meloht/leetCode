using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0801_0850
{
    public class _835_ImageOverlapAlg
    {
        public int LargestOverlap(int[][] img1, int[][] img2)
        {
            int N = img1.Length;
            int[,] count = new int[2 * N + 1, 2 * N + 1];
            for (int i = 0; i < N; ++i)
                for (int j = 0; j < N; ++j)
                    if (img1[i][j] == 1)
                        for (int i2 = 0; i2 < N; ++i2)
                            for (int j2 = 0; j2 < N; ++j2)
                                if (img2[i2][j2] == 1)
                                    count[i - i2 + N, j - j2 + N] += 1;

            int ans = 0;
            int nn = 2 * N + 1;
            for (int i = 0; i < nn; i++)
            {
                for (int j = 0; j < nn; j++)
                {
                    ans = Math.Max(ans, count[i, j]);
                }
            }

            return ans;

        }
    }
}
