using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0151_0200
{
    public class _200_NumberOfIslandsAlg
    {

        int m = 0;
        int n = 0;
        public int NumIslands(char[][] grid)
        {
            m = grid.Length - 1;
            n = grid[0].Length - 1;

            int count = 0;


            for (int i = 0; i <= m; i++)
            {
                for (int j = 0; j <= n; j++)
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

            if (i >= 0 && i <= m && j >= 0 && j <= n && grid[i][j] == '1')
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
