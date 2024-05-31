using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2951_3000
{
    public class _2965_FindMissingAndRepeatedValuesAlg
    {
        public int[] FindMissingAndRepeatedValues(int[][] grid)
        {
            int n = grid.Length;
            HashSet<int> dict = new HashSet<int>();
            int a = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid.Length; j++)
                {
                    if (dict.Contains(grid[i][j]))
                    {
                        a = grid[i][j];
                    }
                    else
                    {
                        dict.Add(grid[i][j]);
                    }
                }
            }
            int total = (1 + n * n) * (n * n) / 2;
            int b = total - dict.Sum();
            return [a, b];
        }
    }
}
