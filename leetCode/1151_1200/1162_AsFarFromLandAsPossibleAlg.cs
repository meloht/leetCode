using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1151_1200
{
    public class _1162_AsFarFromLandAsPossibleAlg
    {

        public int MaxDistance(int[][] grid)
        {
            int INF = 1000000;
            int[] dx = { -1, 0, 1, 0 };
            int[] dy = { 0, 1, 0, -1 };
            int n = grid.Length;
            int[,] d = new int[n,n];
            Queue<int[]> queue = new Queue<int[]>();

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    d[i,j] = INF;
                }
            }

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    if (grid[i][j] == 1)
                    {
                        d[i,j] = 0;
                        queue.Enqueue(new int[] { i, j });
                    }
                }
            }

            while (queue.Count>0)
            {
                int[] f = queue.Dequeue();
                for (int i = 0; i < 4; ++i)
                {
                    int nx = f[0] + dx[i], ny = f[1] + dy[i];
                    if (!(nx >= 0 && nx < n && ny >= 0 && ny < n))
                    {
                        continue;
                    }
                    if (d[nx,ny] > d[f[0],f[1]] + 1)
                    {
                        d[nx,ny] = d[f[0],f[1]] + 1;
                        queue.Enqueue(new int[] { nx, ny });
                    }
                }
            }

            int ans = -1;
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    if (grid[i][j] == 0)
                    {
                        ans = Math.Max(ans, d[i,j]);
                    }
                }
            }

            return ans == INF ? -1 : ans;
        }
    }
}
