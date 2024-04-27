using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2601_2650
{
    public class _2639_FindTheWidthOfColumnsOfAGridAlg
    {
        public int[] FindColumnWidth(int[][] grid)
        {
            int m = grid.Length;
            int n = grid[0].Length;
            int[] ans = new int[n];
            for (int i = 0; i < n; i++)
            {
                int len = 0;
                for (int j = 0; j < m; j++)
                {
                    len = Math.Max(len, grid[j][i].ToString().Length);
                }
                ans[i] = len;
            }

            return ans;
        }
    }
}
