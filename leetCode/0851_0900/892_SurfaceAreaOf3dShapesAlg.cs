using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0851_0900
{
    public class _892_SurfaceAreaOf3dShapesAlg
    {
        public int SurfaceArea(int[][] grid)
        {
            int m = grid.Length;
            int n = grid[0].Length;
            int ans = m * n * 2;

            int[][] dir = [[-1, 0], [1, 0], [0, 1], [0, -1]];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (grid[i][j] > 0)
                    {
                        foreach (int[] item in dir)
                        {
                            int x = item[0] + i;
                            int y = item[1] + j;
                            if (InRange(m, n, x, y))
                            {

                                if (grid[x][y] < grid[i][j])
                                {
                                    ans += (grid[i][j] - grid[x][y]);
                                }
                            }
                            else
                            {
                                ans += grid[i][j];
                            }
                        }
                    }
                    else
                    {
                        ans -= 2;
                    }
                }
            }
            return ans;
        }
        private bool InRange(int m, int n, int x, int y)
        {
            if (x >= 0 && x < m && y >= 0 && y < n)
            {
                return true;
            }
            return false;
        }
    }
}
