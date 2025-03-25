using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2701_2750
{
    public class _2711_DifferenceOfNumberOfDistinctValuesOnDiagonalsAlg
    {
        public int[][] DifferenceOfDistinctValues(int[][] grid)
        {
            int[][] ans = new int[grid.Length][];
            for (int i = 0; i < grid.Length; i++)
            {
                ans[i] = new int[grid[i].Length];
                for (int j = 0; j < grid[i].Length; j++)
                {
                    ans[i][j] = Math.Abs(GetTop(grid, i, j) - GetBottom(grid, i, j));
                }
            }

            return ans;
        }

        private int GetTop(int[][] grid, int n, int m)
        {
            HashSet<int> result = new HashSet<int>();
            for (int i = n - 1, j = m - 1; i >= 0 && j >= 0; i--, j--)
            {
                result.Add(grid[i][j]);
            }

            return result.Count;
        }
        private int GetBottom(int[][] grid, int n, int m)
        {
            HashSet<int> result = new HashSet<int>();
            for (int i = n + 1, j = m + 1; i < grid.Length && j < grid[0].Length; i++, j++)
            {
                result.Add(grid[i][j]);
            }

            return result.Count;
        }
    }
}
