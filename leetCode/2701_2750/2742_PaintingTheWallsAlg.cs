using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2701_2750
{
    public class _2742_PaintingTheWallsAlg
    {
        public int PaintWalls(int[] cost, int[] time)
        {
            int n = cost.Length;
            int[] f = new int[n + 1];
            Array.Fill(f, int.MaxValue / 2);
            f[0] = 0;
            for (int i = 0; i < n; i++)
            {
                int c = cost[i];
                int t = time[i] + 1;
                for (int j = n; j > 0; j--)
                {
                    f[j] = Math.Min(f[j], f[Math.Max(j - t, 0)] + c);
                }
            }
            return f[n];
        }
    }
}
