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

        public int MinPathSum2(int[][] grid)
        {
            if (grid == null || grid.Length == 0 || grid[0].Length == 0)
            {
                return 0;
            }
            int rows = grid.Length, columns = grid[0].Length;
            int[,] dp = new int[rows,columns];
            dp[0,0] = grid[0][0];
            for (int i = 1; i < rows; i++)
            {
                dp[i,0] = dp[i - 1,0] + grid[i][0];
            }
            for (int j = 1; j < columns; j++)
            {
                dp[0,j] = dp[0,j - 1] + grid[0][j];
            }
            for (int i = 1; i < rows; i++)
            {
                for (int j = 1; j < columns; j++)
                {
                    dp[i,j] = Math.Min(dp[i - 1,j], dp[i,j - 1]) + grid[i][j];
                }
            }
            return dp[rows - 1,columns - 1];
        }

    }
}
