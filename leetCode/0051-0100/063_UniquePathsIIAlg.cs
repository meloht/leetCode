using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._51_100
{
    public class _63_UniquePathsIIAlg
    {
        public int UniquePathsWithObstacles(int[][] obstacleGrid)
        {
            int m = obstacleGrid.Length;
            int n = obstacleGrid[0].Length;
            int[,] f = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                if (obstacleGrid[i][0] == 0)
                {
                    if (i > 0)
                    {
                        f[i, 0] = f[i - 1, 0];
                    }
                    else
                    {
                        f[i, 0] = 1;
                    }

                }

            }
            for (int j = 0; j < n; j++)
            {
                if (obstacleGrid[0][j] == 0)
                {
                    if (j > 0)
                    {
                        f[0, j] = f[0, j - 1];
                    }
                    else
                    {
                        f[0, j] = 1;
                    }

                }

            }
            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    if (obstacleGrid[i][j] == 0)
                    {
                        f[i, j] = f[i - 1, j] + f[i, j - 1];
                    }
                    else
                    {
                        f[i, j] = 0;
                    }

                }
            }
            return f[m - 1, n - 1];
        }
    }
}
