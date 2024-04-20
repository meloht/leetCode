using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0851_0900
{
    public class _883_ProjectionAreaOf3dShapesAlg
    {
        public int ProjectionArea(int[][] grid)
        {
            int m = grid.Length;
            int n = grid[0].Length;
            int xy0 = 0;
            int yz = 0;
            int xz = 0;
            for (int i = 0; i < m; i++)
            {
                int max = 0;
                int max1 = 0;
                for (int j = 0; j < n; j++)
                {
                    if (grid[i][j] == 0)
                    {
                        xy0++;
                    }
                    else
                    {
                        max = Math.Max(max, grid[i][j]);
                    }
                    max1 = Math.Max(max1, grid[j][i]);
                }
                yz += max;
                xz += max1;

            }

            int ans = m * n - xy0 + yz + xz;

            return ans;
        }
    }
}
