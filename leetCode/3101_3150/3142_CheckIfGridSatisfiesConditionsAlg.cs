using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3101_3150
{
    public class _3142_CheckIfGridSatisfiesConditionsAlg
    {
        public bool SatisfiesConditions(int[][] grid)
        {

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (i + 1 < grid.Length)
                    {
                        if (grid[i][j] != grid[i + 1][j])
                            return false;
                    }
                    if (j + 1 < grid[0].Length)
                    {
                        if (grid[i][j] == grid[i][j + 1])
                            return false;
                    }
                }
            }


            return true;
        }
    }
}
