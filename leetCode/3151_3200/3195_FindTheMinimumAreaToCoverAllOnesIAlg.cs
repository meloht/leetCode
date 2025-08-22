using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3151_3200
{
    public class _3195_FindTheMinimumAreaToCoverAllOnesIAlg
    {
        public int MinimumArea(int[][] grid)
        {
            int m = grid.Length;
            int n = grid[0].Length;
            int top = m;
            int bottom = 0;
            int left = n;
            int right = 0;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        top = Math.Min(top, i);
                        bottom = Math.Max(bottom, i);
                        left = Math.Min(left, j);
                        right = Math.Max(right, j);
                    }
                }
            }


            return (bottom - top + 1) * (right - left + 1);
        }
    }
}
