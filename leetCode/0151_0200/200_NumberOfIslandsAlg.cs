using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0151_0200
{
    public class _200_NumberOfIslandsAlg
    {

        int imax = 0;
        int jmax = 0;
        public int NumIslands(char[][] grid)
        {
            int m = grid.Length;
            int n = grid[0].Length;
            imax = m - 1;
            jmax = n - 1;
            int count = 0;


            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (grid[i][j] == '1')
                    {

                        Dfs(grid, i, j);

                        count++;
                    }
                }
            }

            return count;
        }


        private void Dfs(char[][] grid, int i, int j)
        {

            if (i >= 0 && i <= imax && j >= 0 && j <= jmax && grid[i][j] == '1')
            {
                grid[i][j] = '2';

                Dfs(grid, i + 1, j);
                Dfs(grid, i - 1, j);
                Dfs(grid, i, j - 1);
                Dfs(grid, i, j + 1);

            }
        }
    }
}
