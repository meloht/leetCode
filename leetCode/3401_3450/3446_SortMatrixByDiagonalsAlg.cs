using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3401_3450
{
    public class _3446_SortMatrixByDiagonalsAlg
    {
        public int[][] SortMatrix(int[][] grid)
        {
            int m = grid.Length;
            int n = grid[0].Length;

            for (int i = 0; i < m; i++)
            {
                List<int> ls = new List<int>();
                for (int r = i, c = 0; r < m && c < n; r++, c++)
                {
                    ls.Add(grid[r][c]);
                }
                ls.Sort((x, y) => y - x);
                for (int r = i, c = 0, k = 0; r < m && c < n; r++, c++)
                {
                    grid[r][c] = ls[k++];
                }
            }

            for (int i = 1; i < n; i++)
            {
                List<int> ls = new List<int>();
                for (int r = 0, c = i; r < m && c < n; r++, c++)
                {
                    ls.Add(grid[r][c]);
                }
                ls.Sort();
                for (int r = 0, c = i, k = 0; r < m && c < n; r++, c++)
                {
                    grid[r][c] = ls[k++];
                }
            }
            return grid;
        }
    }
}
