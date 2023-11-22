using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._51_100
{
    public class _64_MinimumPathSumAlg
    {
        public int MinPathSum(int[][] grid)
        {
            int m = grid.Length;
            int n = grid[0].Length;
            int[,] f = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                if (i == 0)
                {
                    f[i, 0] = grid[0][0];
                }
                else
                {
                    f[i, 0] = grid[i][0] + f[i - 1, 0];
                }


            }
            for (int j = 0; j < n; j++)
            {
                if (j == 0)
                {
                    f[0, j] = grid[0][0];
                }
                else
                {
                    f[0, j] = grid[0][j] + f[0, j - 1];
                }

            }
            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    f[i, j] = grid[i][j] + Math.Min(f[i - 1, j], f[i, j - 1]);
                }
            }
            return f[m - 1, n - 1];

        }
    }
}
